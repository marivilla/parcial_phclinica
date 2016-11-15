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
    class Llenado
    {
        public int RellenarLista(string strConn, ListView Lista, string strComandoSQL)
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader lector;
            ListViewItem registro;
            string[] strColumnas;
            object[] objColumnas;
            int nRegs = 0;
            int nColumnas = 0;
            int n = 0;

            conn = new SqlConnection(strConn);

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
                return nRegs;
            }
            cmd = new SqlCommand(strComandoSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                lector = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en cosulta SQL");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                conn.Close();
                return nRegs;
            }

            nColumnas = lector.FieldCount;
            objColumnas = new object[nColumnas];

            Lista.Items.Clear();
            Lista.Columns.Clear();
            Lista.FullRowSelect = true;
            Lista.View = View.Details;

            //Colocar nombres de columnas;
            for (n = 0; n < nColumnas; n++)
            {
                Lista.Columns.Add(lector.GetName(n));
            }

            //Mostrar datos
            if (lector.HasRows)
            {
                strColumnas = new string[lector.FieldCount];
                nRegs = 0;

                while (lector.Read())
                {
                    nRegs++;
                    for (n = 0; n < nColumnas; n++)
                    {
                        if (!lector.IsDBNull(n))
                        {
                            strColumnas[n] = lector.GetValue(n).ToString();
                        }
                    }
                    registro = new ListViewItem(strColumnas);
                    Lista.Items.Insert(nRegs - 1, registro);
                }
            }

            //Ajustar anchos de columna automaticamente
            for (n = 0; n < Lista.Columns.Count; n++)
            {
                Lista.Columns[n].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            conn.Close();

            //No hace falta liberar variables, el colector de basura lo hace por nosotros
            return nRegs;
        }


        public void LlenarCombo(ComboBox cb, string strComandoSQL, string campo)
        {

            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader dr;

            //conn = new SqlConnection(@"Data Source = TAMARA\SQLEXPRESS; Initial Catalog = Hospital_Ginecologia; Integrated Security = True");
            conn = new SqlConnection(@"Data Source = BGH\SQLEXPRESS; Initial Catalog = Hospital_Ginecologia; Integrated Security = True");
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

            try
            {
                cmd = new SqlCommand(strComandoSQL, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[campo].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llena el ComboBox: ", ex.ToString());
            }
        }
    }
}
