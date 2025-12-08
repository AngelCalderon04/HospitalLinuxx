using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Microsoft.Data.SqlClient;
using Personas;
using Doctor;

namespace CapaPresentacion
{

    public partial class GestionCitas : Form


    {

        // Variables para controlar la edición
        private bool Editar = false;
        private int IDCitaSeleccionada = 0;
        public GestionCitas()
        {
            InitializeComponent();
        }

        private void CargarComboPacientes()
        {
            // Usamos la clase de conexión "CapaDatos"
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                // El  SQL DEBE TRAER LA COLUMNA IDPaciente EXPLICITAMENTE
                string sql = @"SELECT P.IDPaciente, Per.Nombre 
                       FROM Paciente P 
                       INNER JOIN Personas Per ON P.IDPersona = Per.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //el orden correcto 
                cboPaciente.DisplayMember = "Nombre";
                cboPaciente.ValueMember = "IDPaciente";
                cboPaciente.DataSource = dt;

                cboPaciente.SelectedIndex = -1; // Limpiar selección inicial
            }
        }

        private void CargarComboDoctores()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                // SQL con IDDoctor
                string sql = @"SELECT D.IDDoctor, Per.Nombre 
                       FROM Doctor D 
                       INNER JOIN Personas Per ON D.IDPersona = Per.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // ORDEN CORRECTO
                cboDoctor.DisplayMember = "Nombre";
                cboDoctor.ValueMember = "IDDoctor";
                cboDoctor.DataSource = dt;

                cboDoctor.SelectedIndex = -1;
            }
        }

        private void FormGestionCitas_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            // Configurar ComboBoxes con autocompletado
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDown;
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cboDoctor.DropDownStyle = ComboBoxStyle.DropDown;
            cboDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Llenar ComboBoxes
            CargarComboPacientes();
            CargarComboDoctores();

            // Cargar grid de citas para mostrar las existentes
            CargarGridCitas();



        }



        private void btnAgendar_Click(object sender, EventArgs e)
        {
            // Validar que haya selección, capturaores 
            if (cboPaciente.SelectedItem == null || cboDoctor.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Paciente y un Doctor.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                CapaDatos.CD_Citas objetoCD = new CapaDatos.CD_Citas();

                // Recogemos datos
                int idPac = Convert.ToInt32(cboPaciente.SelectedValue);
                int idDoc = Convert.ToInt32(cboDoctor.SelectedValue);
                DateTime fecha = dtpFecha.Value;
                TimeSpan hora = dtpHora.Value.TimeOfDay;

                if (Editar == false)
                {
                    // --- MODO GUARDAR NUEVO ---
                    // Como quitaste motivo, enviamos string vacío ""
                    objetoCD.AgendarCita(idPac, idDoc, fecha, hora, "");
                    MessageBox.Show("Cita agendada correctamente.");
                }
                else
                {
                    // --- MODO EDITAR ---
                    objetoCD.EditarCita(IDCitaSeleccionada, idPac, idDoc, fecha, hora);
                    MessageBox.Show("Cita editada correctamente.");

                    // Volvemos al estado original
                    Editar = false;
                    IDCitaSeleccionada = 0;
                    btnAgendar.Text = "AGENDAR"; // Regresamos el texto original
                }

                // LIMPIEZA FINAL
                CargarGridCitas(); // Refrescar tabla
                LimpiarFormulario(); // Método para borrar textos (si tienes)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // MÉTODO PARA LIMPIAR CAMPOS
        private void LimpiarFormulario()
        {
            // 1. Reseteamos los ComboBox para que no tengan nada seleccionado
            cboPaciente.SelectedIndex = -1;
            cboDoctor.SelectedIndex = -1;

            // 2. Reseteamos las fechas al día de hoy
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            // 3. Limpiamos cajas de texto (si tienes la de costo o motivo)
            // txtMotivo.Clear(); // Descomenta si usas motivo
            if (Controls.Find("txtCosto", true).Length > 0)
                Controls.Find("txtCosto", true)[0].Text = ""; // Limpia costo si existe

            // 4. IMPORTANTE: Reseteamos las variables de Edición
            Editar = false;
            IDCitaSeleccionada = 0;

            // 5. Regresamos el botón a su estado original
            btnAgendar.Text = "AGENDAR";
        }

        private void CargarGridCitas()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                // 1. TU SQL CORREGIDO (Con los IDs ocultos)
                string sql = @"SELECT 
                    c.IDCita,
                    c.IDPaciente,
                    c.IDDoctor,
                    pe.Nombre AS Paciente,
                    dpe.Nombre AS Doctor,
                    c.FechaCita,
                    c.HoraCita,
                    d.TarifaConsulta AS Costo
                FROM Citas c
                INNER JOIN Paciente p ON c.IDPaciente = p.IDPaciente
                INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona
                INNER JOIN Doctor d ON c.IDDoctor = d.IDDoctor
                INNER JOIN Personas dpe ON d.IDPersona = dpe.IDPersona
                ORDER BY c.FechaCita, c.HoraCita";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // --- INICIO DE LA SOLUCIÓN ---

                // A. Limpiamos cualquier "memoria" vieja de la tabla
                dgvCitas.DataSource = null;
                dgvCitas.Columns.Clear();

                // B. Le decimos que genere todo nuevo automáticamente
                dgvCitas.AutoGenerateColumns = true;

                // C. Le damos los datos frescos
                dgvCitas.DataSource = dt;

                // --- FIN DE LA SOLUCIÓN ---

                // Ajustes visuales
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;

                // Ocultar los IDs (Usamos 'Contains' para que no explote si no existen)
                if (dgvCitas.Columns.Contains("IDPaciente")) dgvCitas.Columns["IDPaciente"].Visible = false;
                if (dgvCitas.Columns.Contains("IDDoctor")) dgvCitas.Columns["IDDoctor"].Visible = false;
                if (dgvCitas.Columns.Contains("IDCita")) dgvCitas.Columns["IDCita"].Visible = false;

                // Formato Moneda
                if (dgvCitas.Columns.Contains("Costo")) dgvCitas.Columns["Costo"].DefaultCellStyle.Format = "C2";
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            cboPaciente.Text = "";
            cboDoctor.Text = "";
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            //txtMotivo.Clear();
            cboPaciente.Focus();
        }


        private void dvgCitas()
        {

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ObtenerIDPacientePorNombre(string nombre, out int idPaciente)
        {
            idPaciente = 0;
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = "SELECT IDPaciente FROM Paciente p INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona WHERE pe.Nombre=@Nombre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idPaciente = Convert.ToInt32(result);
                    return true;
                }
            }
            return false;
        }

        private bool ObtenerIDDoctorPorNombre(string nombre, out int idDoctor)
        {
            idDoctor = 0;
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = "SELECT IDDoctor FROM Doctor d INNER JOIN Personas pe ON d.IDPersona = pe.IDPersona WHERE pe.Nombre=@Nombre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idDoctor = Convert.ToInt32(result);
                    return true;
                }
            }
            return false;
        }

        private void CargarGridCitasData()
        {
            try
            {
                using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
                {
                    // SQL LIMPIO (Sin comentarios para evitar errores)
                    string sql = @"SELECT 
                        c.IDCita,
                        c.IDPaciente,
                        c.IDDoctor,
                        pe.Nombre AS Paciente,
                        dpe.Nombre AS Doctor,
                        c.FechaCita,
                        c.HoraCita,
                        d.TarifaConsulta AS Costo
                    FROM Citas c
                    INNER JOIN Paciente p ON c.IDPaciente = p.IDPaciente
                    INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona
                    INNER JOIN Doctor d ON c.IDDoctor = d.IDDoctor
                    INNER JOIN Personas dpe ON d.IDPersona = dpe.IDPersona
                    ORDER BY c.FechaCita DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // PRUEBA: Si no ves este mensaje, es que este código NO se está ejecutando
                    // MessageBox.Show("Filas encontradas: " + dt.Rows.Count); 

                    // 1. Limpiamos todo
                    dgvCitas.DataSource = null;
                    dgvCitas.Columns.Clear();

                    // 2. Activamos la magia automática
                    dgvCitas.AutoGenerateColumns = true;

                    // 3. Ponemos los datos
                    dgvCitas.DataSource = dt;

                    // 4. Ajustes Visuales
                    dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvCitas.ReadOnly = true;

                    // 5. Ocultar columnas técnicas (IDs)
                    if (dgvCitas.Columns.Contains("IDPaciente")) dgvCitas.Columns["IDPaciente"].Visible = false;
                    if (dgvCitas.Columns.Contains("IDDoctor")) dgvCitas.Columns["IDDoctor"].Visible = false;
                    if (dgvCitas.Columns.Contains("IDCita")) dgvCitas.Columns["IDCita"].Visible = false;

                    // 6. Formato de Dinero
                    if (dgvCitas.Columns.Contains("Costo"))
                        dgvCitas.Columns["Costo"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificamos si seleccionó una fila
            if (dgvCitas.SelectedRows.Count > 0)
            {
                // 1. Cambiamos el modo a "EDITAR"
                Editar = true;

                // 2. Desbloqueamos controles (si usaste el método de bloqueo)
                // HabilitarControles(true); 

                // 3. Obtenemos el ID de la cita seleccionada
                IDCitaSeleccionada = Convert.ToInt32(dgvCitas.CurrentRow.Cells["IDCita"].Value);

                // 4. Rellenamos los campos con los datos de la tabla
                // NOTA: Asegúrate de que los nombres "IDPaciente" coincidan con tu SQL del Paso 2
                cboPaciente.SelectedValue = Convert.ToInt32(dgvCitas.CurrentRow.Cells["IDPaciente"].Value);
                cboDoctor.SelectedValue = Convert.ToInt32(dgvCitas.CurrentRow.Cells["IDDoctor"].Value);

                dtpFecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells["FechaCita"].Value);
                // Para la hora, convertimos el string o TimeSpan
                dtpHora.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells["FechaCita"].Value).Date +
                                (TimeSpan)dgvCitas.CurrentRow.Cells["HoraCita"].Value;

                // Cambiamos el texto del botón Guardar para dar feedback visual
                btnAgendar.Text = "ACTUALIZAR";
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }
    }

}
