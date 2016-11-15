using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_HClinica
{
    class Consulta
    {
        public void RellenarDataGridConsulta()
        {
            SqlConnection conn;
            SqlCommand cmd;
            string strComandoSQL;
            string strCadenaConexion = @"Data Source=TAMARA\SQLEXPRESS;Initial Catalog=Hospital_Ginecologia;Integrated Security=True";
            //strComandoSQL = "Select * from Consulta;";
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
                //idPacienteTextBoxConsulta.Text = this.dataGridConsulta.CurrentRow.Cells[1].Value.ToString();
                //idMedicoTextBoxConsulta.Text = this.dataGridConsulta.CurrentRow.Cells[2].Value.ToString();
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
    }
}
