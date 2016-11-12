using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void newToolStripButton_Click(object sender, EventArgs e)
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
        }
    }
}
