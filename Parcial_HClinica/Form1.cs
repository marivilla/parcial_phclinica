using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_HClinica
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                string strComandoMedico = "Select idMedico From Medico;";
                string strComandoPaciente = "Select idPaciente From Paciente;";
                string campoMedico = "idMedico";
                string campoPaciente = "idPaciente";

                IDMedicoComboBoxConsulta.Items.Clear();
                IDPacienteComboBoxConsulta.Items.Clear();
                Llenado llenar = new Llenado();
                llenar.LlenarCombo(IDMedicoComboBoxConsulta, strComandoMedico, campoMedico);
                llenar.LlenarCombo(IDPacienteComboBoxConsulta, strComandoPaciente, campoPaciente);
            }
        }
               
        public void RellenarDataGridPaciente()
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strComandoSQL;
            string strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //string strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";

            strComandoSQL = "sp_pacienteRead";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }

            cmd = new SqlCommand(strComandoSQL, conn);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridPaciente.DataSource = dt;

                idPacienteTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[0].Value.ToString();
                dniTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[1].Value.ToString();
                apellidoSolteraTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[2].Value.ToString();
                nombresTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[3].Value.ToString();
                nacionalidadTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[4].Value.ToString();
                fechaNacimientoDateTimePicker.Text = this.dataGridPaciente.CurrentRow.Cells[5].Value.ToString();
                domicilioTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[6].Value.ToString();
                localidadTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[7].Value.ToString();
                telefonoTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[8].Value.ToString();
                ocupacionTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[9].Value.ToString();
                obraSocialTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[10].Value.ToString();
                alfabetaCheckBox.Text = this.dataGridPaciente.CurrentRow.Cells[11].Value.ToString();
                estudiosTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[12].Value.ToString();
                estadoCivilTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[13].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en cosulta SQL");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }
        }

        public void RellenarDataGridMedico()
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strComandoSQL;
            string strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //string strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            strComandoSQL = "sp_medicoRead";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }

            cmd = new SqlCommand(strComandoSQL, conn);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridMedico.DataSource = dt;

                idMedicoTextBox.Text = this.dataGridMedico.CurrentRow.Cells[0].Value.ToString();
                matriculaTextBox.Text = this.dataGridMedico.CurrentRow.Cells[1].Value.ToString();
                apellidoMedTextBox.Text = this.dataGridMedico.CurrentRow.Cells[2].Value.ToString();
                nombresMedTextBox.Text = this.dataGridMedico.CurrentRow.Cells[3].Value.ToString();                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en cosulta SQL");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }
        }

        public void RellenarDataGridConsulta()
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strComandoSQL;
            string strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //string strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            strComandoSQL = "sp_consultaRead";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con los datos");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }

            cmd = new SqlCommand(strComandoSQL, conn);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridConsulta.DataSource = dt;

                idConsultaTextBox.Text = this.dataGridConsulta.CurrentRow.Cells[0].Value.ToString();                
                IDPacienteComboBoxConsulta.Text = this.dataGridConsulta.CurrentRow.Cells[1].Value.ToString();
                IDMedicoComboBoxConsulta.Text = this.dataGridConsulta.CurrentRow.Cells[2].Value.ToString();
                fechaConsultaDateTimePicker.Text = this.dataGridConsulta.CurrentRow.Cells[3].Value.ToString();
                referenciaTextBox.Text = this.dataGridConsulta.CurrentRow.Cells[4].Value.ToString();
                fechaUltPeriodoDateTimePicker.Text = this.dataGridConsulta.CurrentRow.Cells[5].Value.ToString();
                motivoConsultaTextBox.Text = this.dataGridConsulta.CurrentRow.Cells[6].Value.ToString();
                pesoTextBox.Text = this.dataGridConsulta.CurrentRow.Cells[7].Value.ToString();
                tallaTextBox.Text = this.dataGridConsulta.CurrentRow.Cells[8].Value.ToString();
                taTextBox.Text = this.dataGridConsulta.CurrentRow.Cells[9].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en cosulta SQL");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }            
        }        
        
        private void btn_listPaciente_Click(object sender, EventArgs e)
        {            
            string strConn;
            string strComandoSQL;
            int nRegs;

            Llenado llenar = new Llenado();
            strConn = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strConn = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            strComandoSQL = "sp_pacienteRead";                        
            nRegs = llenar.RellenarLista(strConn, listViewListado, strComandoSQL);
        }

        private void btn_listMedico_Click(object sender, EventArgs e)
        {
            string strConn;
            string strComandoSQL;
            int nRegs;

            Llenado llenar = new Llenado();
            strConn = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strConn = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            strComandoSQL = "sp_medicoRead";
            nRegs = llenar.RellenarLista(strConn, listViewListado, strComandoSQL);
        }

        private void btn_listConsulta_Click(object sender, EventArgs e)
        {            
            string strConn;
            string strComandoSQL;
            int nRegs;

            Llenado llenar = new Llenado();
            strConn = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strConn = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            strComandoSQL = "sp_consultaRead";
            nRegs = llenar.RellenarLista(strConn, listViewListado, strComandoSQL);
        }

        public int nuevoID(string strComandoSQL)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strCadenaConexion;            
            int id = 0;

            strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar");
            }
            
            cmd = new SqlCommand(strComandoSQL, conn);

            try
            {                
                id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }            
        }

        private void btn_pacienteBlanco_Click(object sender, EventArgs e)
        {
            idPacienteTextBox.Clear();
            dniTextBox.Clear();
            apellidoSolteraTextBox.Clear();
            nombresTextBox.Clear();
            nacionalidadTextBox.Clear();
            fechaNacimientoDateTimePicker.ResetText();
            domicilioTextBox.Clear();
            localidadTextBox.Clear();
            telefonoTextBox.Clear();
            ocupacionTextBox.Clear();
            obraSocialTextBox.Clear();
            alfabetaCheckBox.ResetText();
            estudiosTextBox.Clear();
            estadoCivilTextBox.Clear();

            string strComandoSql = "select max(idPaciente)+1 from Paciente;";
            idPacienteTextBox.Text = nuevoID(strComandoSql).ToString();
            btn_modificarPaciente.Enabled = false;
            btn_eliminarPaciente.Enabled = false;
            btn_altaPaciente.Enabled = true;

            dniTextBox.Enabled = true;
            apellidoSolteraTextBox.Enabled = true;
            nombresTextBox.Enabled = true;
            nacionalidadTextBox.Enabled = true;
            fechaNacimientoDateTimePicker.Enabled = true;
            domicilioTextBox.Enabled = true;
            localidadTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            ocupacionTextBox.Enabled = true;
            obraSocialTextBox.Enabled = true;
            alfabetaCheckBox.Enabled = true;
            estudiosTextBox.Enabled = true;
            estadoCivilTextBox.Enabled = true;
        }

        private void btn_medicoBlanco_Click(object sender, EventArgs e)
        {
            idMedicoTextBox.Clear();
            matriculaTextBox.Clear();
            apellidoMedTextBox.Clear();
            nombresMedTextBox.Clear();

            string strComandoSql = "select max(idMedico)+1 from Medico;";
            idMedicoTextBox.Text = nuevoID(strComandoSql).ToString();
            btn_modificarMedico.Enabled = false;
            btn_eliminarMedico.Enabled = false;
            btn_altaMedico.Enabled = true;
                        
            matriculaTextBox.Enabled = true;
            apellidoMedTextBox.Enabled = true;
            nombresMedTextBox.Enabled = true;
        }

        private void btn_consultaBlanco_Click(object sender, EventArgs e)
        {          
            idConsultaTextBox.Clear();
            IDPacienteComboBoxConsulta.ResetText();
            IDMedicoComboBoxConsulta.ResetText();
            fechaConsultaDateTimePicker.ResetText();
            referenciaTextBox.Clear();
            fechaUltPeriodoDateTimePicker.ResetText();
            motivoConsultaTextBox.Clear();
            pesoTextBox.Clear();
            tallaTextBox.Clear();
            taTextBox.Clear();

            string strComandoSQL = "select max(idConsulta)+1 from Consulta;";
            idConsultaTextBox.Text = nuevoID(strComandoSQL).ToString();
            btn_modificarConsulta.Enabled = false;
            btn_eliminarConsulta.Enabled = false;
            btn_altaConsulta.Enabled = true;
            
            IDPacienteComboBoxConsulta.Enabled = true;
            IDMedicoComboBoxConsulta.Enabled = true;
            fechaConsultaDateTimePicker.Enabled = true;
            referenciaTextBox.Enabled = true;
            fechaUltPeriodoDateTimePicker.Enabled = true;
            motivoConsultaTextBox.Enabled = true;
            pesoTextBox.Enabled = true;
            tallaTextBox.Enabled = true;
            taTextBox.Enabled = true;
        }

        private void btn_altaPaciente_Click(object sender, EventArgs e)
        {                          
            if (dniTextBox.Text != "" && apellidoSolteraTextBox.Text != "" && nombresTextBox.Text != "" && nacionalidadTextBox.Text != ""
                && fechaNacimientoDateTimePicker.Text != "" && domicilioTextBox.Text != "" && localidadTextBox.Text != "" && telefonoTextBox.Text != "" 
                && ocupacionTextBox.Text != "" && obraSocialTextBox.Text != "" && estudiosTextBox.Text != "" && estadoCivilTextBox.Text != "")
            {

                SqlConnection conn;
                SqlCommand cmd;
                string strCadenaConexion;
                string strComandoSQL;

                strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                conn = new SqlConnection(strCadenaConexion);

                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al conectar");
                    return;
                }

                strComandoSQL = "sp_pacienteCreate";

                cmd = new SqlCommand(strComandoSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                string strIDSQL = "select max(idPaciente)+1 from Paciente;";

                cmd.Parameters.Add("@idPaciente", SqlDbType.Int).Value = nuevoID(strIDSQL);
                cmd.Parameters.Add("@dni", SqlDbType.VarChar).Value = dniTextBox.Text;
                cmd.Parameters.Add("@apellidoSoltera", SqlDbType.VarChar).Value = apellidoSolteraTextBox.Text;
                cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = nombresTextBox.Text;
                cmd.Parameters.Add("@nacionalidad", SqlDbType.VarChar).Value = nacionalidadTextBox.Text;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = Convert.ToDateTime(fechaNacimientoDateTimePicker.Text);
                cmd.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = domicilioTextBox.Text;
                cmd.Parameters.Add("@localidad", SqlDbType.VarChar).Value = localidadTextBox.Text;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = telefonoTextBox.Text;
                cmd.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = ocupacionTextBox.Text;
                cmd.Parameters.Add("@obraSocial", SqlDbType.VarChar).Value = obraSocialTextBox.Text;
                cmd.Parameters.Add("@alfabeta", SqlDbType.Bit).Value = Convert.ToBoolean(alfabetaCheckBox.Checked);
                cmd.Parameters.Add("@estudios", SqlDbType.VarChar).Value = estudiosTextBox.Text;
                cmd.Parameters.Add("@estadoCivil", SqlDbType.VarChar).Value = estadoCivilTextBox.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado.");
                    if (dataGridPaciente.Rows.Count > 0)
                    {
                        RellenarDataGridPaciente();
                    }                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();

                idPacienteTextBox.Clear();
                dniTextBox.Clear();
                apellidoSolteraTextBox.Clear();
                nombresTextBox.Clear();
                nacionalidadTextBox.Clear();
                fechaNacimientoDateTimePicker.ResetText();
                domicilioTextBox.Clear();
                localidadTextBox.Clear();
                telefonoTextBox.Clear();
                ocupacionTextBox.Clear();
                obraSocialTextBox.Clear();
                alfabetaCheckBox.ResetText();
                estudiosTextBox.Clear();
                estadoCivilTextBox.Clear();

                btn_altaPaciente.Enabled = false;

                dniTextBox.Enabled = false;
                apellidoSolteraTextBox.Enabled = false;
                nombresTextBox.Enabled = false;
                nacionalidadTextBox.Enabled = false;
                fechaNacimientoDateTimePicker.Enabled = false;
                domicilioTextBox.Enabled = false;
                localidadTextBox.Enabled = false;
                telefonoTextBox.Enabled = false;
                ocupacionTextBox.Enabled = false;
                obraSocialTextBox.Enabled = false;
                alfabetaCheckBox.Enabled = false;
                estudiosTextBox.Enabled = false;
                estadoCivilTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos.");
            }
        }

        private void btn_altaMedico_Click(object sender, EventArgs e)
        {
            if (matriculaTextBox.Text != "" && apellidoMedTextBox.Text != "" && nombresMedTextBox.Text != "" )
            {
                SqlConnection conn;
                SqlCommand cmd;
                string strCadenaConexion;
                string strComandoSQL;

                strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                conn = new SqlConnection(strCadenaConexion);

                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al conectar");
                    return;
                }

                strComandoSQL = "sp_medicoInsert";

                cmd = new SqlCommand(strComandoSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                string strIDSQL = "select max(idMedico)+1 from Medico;";

                cmd.Parameters.Add("@idMedico", SqlDbType.Int).Value = nuevoID(strIDSQL);                
                cmd.Parameters.Add("@matricula", SqlDbType.Int).Value = Convert.ToInt32(matriculaTextBox.Text);                
                cmd.Parameters.Add("@apellidoMed", SqlDbType.NVarChar).Value = apellidoMedTextBox.Text;                
                cmd.Parameters.Add("@nombresMed", SqlDbType.NVarChar).Value = nombresMedTextBox.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado.");
                    if (dataGridMedico.Rows.Count > 0)
                    {
                        RellenarDataGridMedico();
                    }                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();

                idMedicoTextBox.Clear();
                matriculaTextBox.Clear();
                apellidoMedTextBox.Clear();
                nombresMedTextBox.Clear();

                btn_altaMedico.Enabled = false;
                matriculaTextBox.Enabled = false;
                apellidoMedTextBox.Enabled = false;
                nombresMedTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos.");
            }
        }

        private void btn_altaConsulta_Click(object sender, EventArgs e)
        {
            //if (idPacienteTextBoxConsulta.Text != "" && idMedicoTextBoxConsulta.Text != "" && fechaConsultaDateTimePicker.Text != "" && referenciaTextBox.Text != "" 
            //    && fechaUltPeriodoDateTimePicker.Text != "" && motivoConsultaTextBox.Text != "" && pesoTextBox.Text != "" && tallaTextBox.Text != "" && taTextBox.Text!= "")                
            if (IDPacienteComboBoxConsulta.Text != "" && IDMedicoComboBoxConsulta.Text != "" && fechaConsultaDateTimePicker.Text != "" && referenciaTextBox.Text != ""
                && fechaUltPeriodoDateTimePicker.Text != "" && motivoConsultaTextBox.Text != "" && pesoTextBox.Text != "" && tallaTextBox.Text != "" && taTextBox.Text!= "")                
            {

                SqlConnection conn;
                SqlCommand cmd;
                string strCadenaConexion;
                string strComandoSQL;

                strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                conn = new SqlConnection(strCadenaConexion);

                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al conectar");
                    return;
                }

                strComandoSQL = "sp_consultaInsert";

                cmd = new SqlCommand(strComandoSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                string strIDSQL = "select max(idConsulta)+1 from Consulta;";                

                cmd.Parameters.Add("@idConsulta", SqlDbType.Int).Value = nuevoID(strIDSQL);
                cmd.Parameters.Add("@idPaciente", SqlDbType.Int).Value = Convert.ToInt16(IDPacienteComboBoxConsulta.Text);
                cmd.Parameters.Add("@idMedico", SqlDbType.Int).Value = Convert.ToInt16(IDMedicoComboBoxConsulta.Text);
                cmd.Parameters.Add("@fechaConsulta", SqlDbType.Date).Value = Convert.ToDateTime(fechaConsultaDateTimePicker.Text);
                cmd.Parameters.Add("@referencia", SqlDbType.NVarChar).Value = referenciaTextBox.Text;
                cmd.Parameters.Add("@fechaUltPeriodo", SqlDbType.Date).Value = Convert.ToDateTime(fechaUltPeriodoDateTimePicker.Text);
                cmd.Parameters.Add("@motivoConsulta", SqlDbType.NVarChar).Value = motivoConsultaTextBox.Text;
                cmd.Parameters.Add("@peso", SqlDbType.Int).Value = Convert.ToInt16(pesoTextBox.Text);
                cmd.Parameters.Add("@talla", SqlDbType.Int).Value = Convert.ToInt16(tallaTextBox.Text);
                cmd.Parameters.Add("@ta", SqlDbType.Int).Value = Convert.ToInt16(taTextBox.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado.");
                    if (dataGridConsulta.Rows.Count > 0)
                    {
                        RellenarDataGridConsulta();
                    }                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                idConsultaTextBox.Clear();
                IDPacienteComboBoxConsulta.ResetText();
                IDMedicoComboBoxConsulta.ResetText();
                fechaConsultaDateTimePicker.ResetText();
                referenciaTextBox.Clear();
                fechaUltPeriodoDateTimePicker.ResetText();
                motivoConsultaTextBox.Clear();
                pesoTextBox.Clear();
                tallaTextBox.Clear();
                taTextBox.Clear();
                btn_altaConsulta.Enabled = false;
                IDPacienteComboBoxConsulta.Enabled = false;
                IDMedicoComboBoxConsulta.Enabled = false;
                fechaConsultaDateTimePicker.Enabled = false;
                referenciaTextBox.Enabled = false;
                fechaUltPeriodoDateTimePicker.Enabled = false;
                motivoConsultaTextBox.Enabled = false;
                pesoTextBox.Enabled = false;
                tallaTextBox.Enabled = false;
                taTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos.");
            }
        }

        private void btn_modificarPaciente_Click(object sender, EventArgs e)
        {
            if (dniTextBox.Text != "" && apellidoSolteraTextBox.Text != "" && nombresTextBox.Text != "" && nacionalidadTextBox.Text != ""
                && fechaNacimientoDateTimePicker.Text != "" && domicilioTextBox.Text != "" && localidadTextBox.Text != "" && telefonoTextBox.Text != ""
                && ocupacionTextBox.Text != "" && obraSocialTextBox.Text != "" && estudiosTextBox.Text != "" && estadoCivilTextBox.Text != "")
            {
                SqlConnection conn;
                SqlCommand cmd;
                string strCadenaConexion;
                string strComandoSQL;

                strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                conn = new SqlConnection(strCadenaConexion);

                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al conectar");
                    return;
                }

                strComandoSQL = "sp_pacienteUpdate";
                cmd = new SqlCommand(strComandoSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idPaciente", SqlDbType.Int).Value = Convert.ToInt32(idPacienteTextBox.Text);
                cmd.Parameters.Add("@dni", SqlDbType.VarChar).Value = dniTextBox.Text;
                cmd.Parameters.Add("@apellidoSoltera", SqlDbType.VarChar).Value = apellidoSolteraTextBox.Text;
                cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = nombresTextBox.Text;
                cmd.Parameters.Add("@nacionalidad", SqlDbType.VarChar).Value = nacionalidadTextBox.Text;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = Convert.ToDateTime(fechaNacimientoDateTimePicker.Text);
                cmd.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = domicilioTextBox.Text;
                cmd.Parameters.Add("@localidad", SqlDbType.VarChar).Value = localidadTextBox.Text;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = telefonoTextBox.Text;
                cmd.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = ocupacionTextBox.Text;
                cmd.Parameters.Add("@obraSocial", SqlDbType.VarChar).Value = obraSocialTextBox.Text;
                cmd.Parameters.Add("@alfabeta", SqlDbType.Bit).Value = Convert.ToBoolean(alfabetaCheckBox.Checked);
                cmd.Parameters.Add("@estudios", SqlDbType.VarChar).Value = estudiosTextBox.Text;
                cmd.Parameters.Add("@estadoCivil", SqlDbType.VarChar).Value = estadoCivilTextBox.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente Modificado.");
                    if (dataGridPaciente.Rows.Count > 0)
                    {
                        RellenarDataGridPaciente();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos.");
            }
        }

        private void btn_modificarMedico_Click(object sender, EventArgs e)
        {
            if (matriculaTextBox.Text != "" && apellidoMedTextBox.Text != "" && nombresMedTextBox.Text != "")
            {
                SqlConnection conn;
                SqlCommand cmd;
                string strCadenaConexion;
                string strComandoSQL;

                strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                conn = new SqlConnection(strCadenaConexion);

                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al conectar");
                    return;
                }

                strComandoSQL = "sp_medicoUpdate";
                cmd = new SqlCommand(strComandoSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idMedico", SqlDbType.Int).Value = Convert.ToInt32(idMedicoTextBox.Text);
                cmd.Parameters.Add("@matricula", SqlDbType.Int).Value = Convert.ToInt32(matriculaTextBox.Text);
                cmd.Parameters.Add("@apellidoMed", SqlDbType.NVarChar).Value = apellidoMedTextBox.Text;
                cmd.Parameters.Add("@nombresMed", SqlDbType.NVarChar).Value = nombresMedTextBox.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro del médico modificado.");
                    if (dataGridMedico.Rows.Count > 0)
                    {
                        RellenarDataGridMedico();
                    }                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos.");
            }
        }

        private void btn_modificarConsulta_Click(object sender, EventArgs e)
        {
            //if (idPacienteTextBoxConsulta.Text != "" && idMedicoTextBoxConsulta.Text != "" && fechaConsultaDateTimePicker.Text != "" && referenciaTextBox.Text != ""
            //   && fechaUltPeriodoDateTimePicker.Text != "" && motivoConsultaTextBox.Text != "" && pesoTextBox.Text != "" && tallaTextBox.Text != "" && taTextBox.Text != "")
            if (IDPacienteComboBoxConsulta.Text != "" && IDMedicoComboBoxConsulta.Text != "" && fechaConsultaDateTimePicker.Text != "" && referenciaTextBox.Text != ""
               && fechaUltPeriodoDateTimePicker.Text != "" && motivoConsultaTextBox.Text != "" && pesoTextBox.Text != "" && tallaTextBox.Text != "" && taTextBox.Text != "")
            {
                SqlConnection conn;
                SqlCommand cmd;
                string strCadenaConexion;
                string strComandoSQL;

                strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
                conn = new SqlConnection(strCadenaConexion);

                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al conectar");
                    return;
                }

                strComandoSQL = "sp_consultaUpdate";
                cmd = new SqlCommand(strComandoSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idConsulta", SqlDbType.Int).Value = Convert.ToInt16(idConsultaTextBox.Text);
                cmd.Parameters.Add("@idPaciente", SqlDbType.Int).Value = Convert.ToInt16(IDPacienteComboBoxConsulta.Text);
                cmd.Parameters.Add("@idMedico", SqlDbType.Int).Value = Convert.ToInt16(IDMedicoComboBoxConsulta.Text);
                cmd.Parameters.Add("@fechaConsulta", SqlDbType.Date).Value = Convert.ToDateTime(fechaConsultaDateTimePicker.Text);
                cmd.Parameters.Add("@referencia", SqlDbType.NVarChar).Value = referenciaTextBox.Text;
                cmd.Parameters.Add("@fechaUltPeriodo", SqlDbType.Date).Value = Convert.ToDateTime(fechaUltPeriodoDateTimePicker.Text);
                cmd.Parameters.Add("@motivoConsulta", SqlDbType.NVarChar).Value = motivoConsultaTextBox.Text;
                cmd.Parameters.Add("@peso", SqlDbType.Int).Value = Convert.ToInt16(pesoTextBox.Text);
                cmd.Parameters.Add("@talla", SqlDbType.Int).Value = Convert.ToInt16(tallaTextBox.Text);
                cmd.Parameters.Add("@ta", SqlDbType.Int).Value = Convert.ToInt16(taTextBox.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consulta Modificada");
                    if (dataGridConsulta.Rows.Count > 0)
                    {
                        RellenarDataGridConsulta();
                    }                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completos.");
            }            
        }

        private void btn_eliminarPaciente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strCadenaConexion;
            string strComandoSQL;

            strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar");
                return;
            }

            strComandoSQL = "sp_pacienteDelete";
            cmd = new SqlCommand(strComandoSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Original_idPaciente", SqlDbType.Int).Value = Convert.ToInt16(idPacienteTextBox.Text);

            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consulta Eliminada");
                    if (dataGridPaciente.Rows.Count > 0)
                    {
                        RellenarDataGridPaciente();
                    }                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            idPacienteTextBox.Clear();
            dniTextBox.Clear();
            apellidoSolteraTextBox.Clear();
            nombresTextBox.Clear();
            nacionalidadTextBox.Clear();
            fechaNacimientoDateTimePicker.ResetText();
            domicilioTextBox.Clear();
            localidadTextBox.Clear();
            telefonoTextBox.Clear();
            ocupacionTextBox.Clear();
            obraSocialTextBox.Clear();
            alfabetaCheckBox.ResetText();
            estudiosTextBox.Clear();
            estadoCivilTextBox.Clear();

            dniTextBox.Enabled = false;
            apellidoSolteraTextBox.Enabled = false;
            nombresTextBox.Enabled = false;
            nacionalidadTextBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;
            domicilioTextBox.Enabled = false;
            localidadTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            ocupacionTextBox.Enabled = false;
            obraSocialTextBox.Enabled = false;
            alfabetaCheckBox.Enabled = false;
            estudiosTextBox.Enabled = false;
            estadoCivilTextBox.Enabled = false;
        }

        private void btn_eliminarMedico_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strCadenaConexion;
            string strComandoSQL;

            strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar");
                return;
            }

            strComandoSQL = "sp_medicoDelete";
            cmd = new SqlCommand(strComandoSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Original_idMedico", SqlDbType.Int).Value = Convert.ToInt16(idMedicoTextBox.Text);

            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Médico Eliminada");
                    if (dataGridMedico.Rows.Count > 0)
                    {
                        RellenarDataGridMedico();
                    }                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            idMedicoTextBox.Clear();
            matriculaTextBox.Clear();
            apellidoMedTextBox.Clear();
            nombresMedTextBox.Clear();

            matriculaTextBox.Enabled = false;
            apellidoMedTextBox.Enabled = false;
            nombresMedTextBox.Enabled = false;            
        }

        private void btn_eliminarConsulta_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strCadenaConexion;
            string strComandoSQL;

            strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar");
                return;
            }

            strComandoSQL = "sp_consultaDelete";
            cmd = new SqlCommand(strComandoSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Original_idConsulta", SqlDbType.Int).Value = Convert.ToInt16(idConsultaTextBox.Text);

            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consulta Eliminada");
                    if (dataGridConsulta.Rows.Count > 0)
                    {
                        RellenarDataGridConsulta();
                    }                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            idConsultaTextBox.Clear();
            IDPacienteComboBoxConsulta.ResetText();
            IDMedicoComboBoxConsulta.ResetText();
            fechaConsultaDateTimePicker.ResetText();
            referenciaTextBox.Clear();
            fechaUltPeriodoDateTimePicker.ResetText();
            motivoConsultaTextBox.Clear();
            pesoTextBox.Clear();
            tallaTextBox.Clear();
            taTextBox.Clear();

            IDPacienteComboBoxConsulta.Enabled = false;
            IDMedicoComboBoxConsulta.Enabled = false;
            fechaConsultaDateTimePicker.Enabled = false;
            referenciaTextBox.Enabled = false;
            fechaUltPeriodoDateTimePicker.Enabled = false;
            motivoConsultaTextBox.Enabled = false;
            pesoTextBox.Enabled = false;
            tallaTextBox.Enabled = false;
            taTextBox.Enabled = false;
            btn_eliminarConsulta.Enabled = false;
            btn_modificarConsulta.Enabled = false;
        }

        private void dataGridPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificarPaciente.Enabled = true;
            btn_eliminarPaciente.Enabled = true;
            btn_altaPaciente.Enabled = false;

            dniTextBox.Enabled = true;
            apellidoSolteraTextBox.Enabled = true;
            nombresTextBox.Enabled = true;
            nacionalidadTextBox.Enabled = true;
            fechaNacimientoDateTimePicker.Enabled = true;
            domicilioTextBox.Enabled = true;
            localidadTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            ocupacionTextBox.Enabled = true;
            obraSocialTextBox.Enabled = true;
            alfabetaCheckBox.Enabled = true;
            estudiosTextBox.Enabled = true;
            estadoCivilTextBox.Enabled = true;

            DataGridViewRow row = (DataGridViewRow)dataGridPaciente.Rows[e.RowIndex];
            if (row.Index != null)
            {
                idPacienteTextBox.Text = Convert.ToString(row.Cells[0].Value);
                dniTextBox.Text = row.Cells[1].Value.ToString();
                apellidoSolteraTextBox.Text = row.Cells[2].Value.ToString();
                nombresTextBox.Text = row.Cells[3].Value.ToString();
                nacionalidadTextBox.Text = row.Cells[4].Value.ToString();
                fechaNacimientoDateTimePicker.Text = row.Cells[5].Value.ToString();
                domicilioTextBox.Text = row.Cells[6].Value.ToString();
                localidadTextBox.Text = row.Cells[7].Value.ToString();
                telefonoTextBox.Text = row.Cells[8].Value.ToString();
                ocupacionTextBox.Text = row.Cells[9].Value.ToString();
                obraSocialTextBox.Text = row.Cells[10].Value.ToString();
                alfabetaCheckBox.Checked = Convert.ToBoolean(row.Cells[11].Value);
                estudiosTextBox.Text = row.Cells[12].Value.ToString();
                estadoCivilTextBox.Text = row.Cells[13].Value.ToString();
            }
        }

        private void dataGridMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificarMedico.Enabled = true;
            btn_eliminarMedico.Enabled = true;
            btn_altaMedico.Enabled = false;

            matriculaTextBox.Enabled = true;
            apellidoMedTextBox.Enabled = true;
            nombresMedTextBox.Enabled = true;
            
            DataGridViewRow row = (DataGridViewRow)dataGridMedico.Rows[e.RowIndex];
            if (row.Index != null)
            {
                idMedicoTextBox.Text = Convert.ToString(row.Cells[0].Value);                
                matriculaTextBox.Text = row.Cells[1].Value.ToString();
                apellidoMedTextBox.Text = row.Cells[2].Value.ToString();
                nombresMedTextBox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dataGridConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificarConsulta.Enabled = true;
            btn_eliminarConsulta.Enabled = true;
            btn_altaConsulta.Enabled = false;
            
            IDPacienteComboBoxConsulta.Enabled = true;
            IDMedicoComboBoxConsulta.Enabled = true;
            fechaConsultaDateTimePicker.Enabled = true;
            referenciaTextBox.Enabled = true;
            fechaUltPeriodoDateTimePicker.Enabled = true;
            motivoConsultaTextBox.Enabled = true;
            pesoTextBox.Enabled = true;
            tallaTextBox.Enabled = true;
            taTextBox.Enabled = true;

            DataGridViewRow row = (DataGridViewRow)dataGridConsulta.Rows[e.RowIndex];
            if (row.Index != null)
            {                                
                idConsultaTextBox.Text = Convert.ToString(row.Cells[0].Value);
                IDPacienteComboBoxConsulta.Text = row.Cells[1].Value.ToString();
                IDMedicoComboBoxConsulta.Text = row.Cells[2].Value.ToString();
                fechaConsultaDateTimePicker.Text = row.Cells[3].Value.ToString();
                referenciaTextBox.Text = row.Cells[4].Value.ToString();
                fechaUltPeriodoDateTimePicker.Text = row.Cells[5].Value.ToString();
                motivoConsultaTextBox.Text = row.Cells[6].Value.ToString();
                pesoTextBox.Text = row.Cells[7].Value.ToString();
                tallaTextBox.Text = row.Cells[8].Value.ToString();
                taTextBox.Text = row.Cells[9].Value.ToString();
                IDPacienteComboBoxConsulta.Enabled = false;
                IDMedicoComboBoxConsulta.Enabled = false;
            }
        }

        private void btn_llenarDataGridPaciente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strComandoSQL;
            string strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //string strCadenaConexion = @"Data Source=BGH\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            strComandoSQL = "sp_pacienteRead";
            conn = new SqlConnection(strCadenaConexion);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con los datos.");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }

            cmd = new SqlCommand(strComandoSQL, conn);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridPaciente.DataSource = dt;

                idPacienteTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[0].Value.ToString();
                dniTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[1].Value.ToString();
                apellidoSolteraTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[2].Value.ToString();
                nombresTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[3].Value.ToString();
                nacionalidadTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[4].Value.ToString();
                fechaNacimientoDateTimePicker.Text = this.dataGridPaciente.CurrentRow.Cells[5].Value.ToString();
                domicilioTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[6].Value.ToString();
                localidadTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[7].Value.ToString();
                telefonoTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[8].Value.ToString();
                ocupacionTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[9].Value.ToString();
                obraSocialTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[10].Value.ToString();
                alfabetaCheckBox.Text = this.dataGridPaciente.CurrentRow.Cells[11].Value.ToString();
                estudiosTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[12].Value.ToString();
                estadoCivilTextBox.Text = this.dataGridPaciente.CurrentRow.Cells[13].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en cosulta SQL");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
            }
        }

        private void btn_llenarDataGridMedico_Click(object sender, EventArgs e)
        {
            RellenarDataGridMedico();
            btn_modificarMedico.Enabled = true;
            btn_eliminarMedico.Enabled = true;
            matriculaTextBox.Enabled = true;
            apellidoMedTextBox.Enabled = true;
            nombresMedTextBox.Enabled = true;
        }

        private void btn_llenarDataGridConsulta_Click(object sender, EventArgs e)
        {
            RellenarDataGridConsulta();
            btn_modificarConsulta.Enabled = true;
            btn_eliminarConsulta.Enabled = true;
            fechaConsultaDateTimePicker.Enabled = true;
            referenciaTextBox.Enabled = true;
            fechaUltPeriodoDateTimePicker.Enabled = true;
            motivoConsultaTextBox.Enabled = true;
            pesoTextBox.Enabled = true;
            tallaTextBox.Enabled = true;
            taTextBox.Enabled = true;
        }

        
    }
}
