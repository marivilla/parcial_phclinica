namespace Parcial_HClinica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label apellidoSolteraLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label nacionalidadLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ocupacionLabel;
            System.Windows.Forms.Label obraSocialLabel;
            System.Windows.Forms.Label alfabetaLabel;
            System.Windows.Forms.Label estudiosLabel;
            System.Windows.Forms.Label estadoCivilLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label apellidoMedLabel;
            System.Windows.Forms.Label nombresMedLabel;
            System.Windows.Forms.Label idConsultaLabel;
            System.Windows.Forms.Label idPacienteLabel1;
            System.Windows.Forms.Label idMedicoLabel1;
            System.Windows.Forms.Label fechaConsultaLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label fechaUltPeriodoLabel;
            System.Windows.Forms.Label motivoConsultaLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label tallaLabel;
            System.Windows.Forms.Label taLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_pacienteBlanco = new System.Windows.Forms.ToolStripButton();
            this.btn_modificarPaciente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.estadoCivilTextBox = new System.Windows.Forms.TextBox();
            this.estudiosTextBox = new System.Windows.Forms.TextBox();
            this.alfabetaCheckBox = new System.Windows.Forms.CheckBox();
            this.obraSocialTextBox = new System.Windows.Forms.TextBox();
            this.ocupacionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidoSolteraTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_llenarDataGridMedico = new System.Windows.Forms.Button();
            this.dataGridMedico = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_medicoBlanco = new System.Windows.Forms.ToolStripButton();
            this.btn_altaMedico = new System.Windows.Forms.ToolStripButton();
            this.btn_modificarMedico = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminarMedico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nombresMedTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMedTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.IDMedicoComboBoxConsulta = new System.Windows.Forms.ComboBox();
            this.IDPacienteComboBoxConsulta = new System.Windows.Forms.ComboBox();
            this.btn_llenarDataGridConsulta = new System.Windows.Forms.Button();
            this.dataGridConsulta = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btn_consultaBlanco = new System.Windows.Forms.ToolStripButton();
            this.btn_altaConsulta = new System.Windows.Forms.ToolStripButton();
            this.btn_modificarConsulta = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminarConsulta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.taTextBox = new System.Windows.Forms.TextBox();
            this.tallaTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.motivoConsultaTextBox = new System.Windows.Forms.TextBox();
            this.fechaUltPeriodoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.fechaConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listViewListado = new System.Windows.Forms.ListView();
            this.btn_listConsulta = new System.Windows.Forms.Button();
            this.btn_listMedico = new System.Windows.Forms.Button();
            this.btn_listPaciente = new System.Windows.Forms.Button();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_altaPaciente = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminarPaciente = new System.Windows.Forms.ToolStripButton();
            this.btn_llenarDataGridPaciente = new System.Windows.Forms.Button();
            this.dataGridPaciente = new System.Windows.Forms.DataGridView();
            dniLabel = new System.Windows.Forms.Label();
            apellidoSolteraLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            nacionalidadLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ocupacionLabel = new System.Windows.Forms.Label();
            obraSocialLabel = new System.Windows.Forms.Label();
            alfabetaLabel = new System.Windows.Forms.Label();
            estudiosLabel = new System.Windows.Forms.Label();
            estadoCivilLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            apellidoMedLabel = new System.Windows.Forms.Label();
            nombresMedLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            idPacienteLabel1 = new System.Windows.Forms.Label();
            idMedicoLabel1 = new System.Windows.Forms.Label();
            fechaConsultaLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            fechaUltPeriodoLabel = new System.Windows.Forms.Label();
            motivoConsultaLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            tallaLabel = new System.Windows.Forms.Label();
            taLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(229, 54);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(29, 13);
            dniLabel.TabIndex = 2;
            dniLabel.Text = "DNI:";
            // 
            // apellidoSolteraLabel
            // 
            apellidoSolteraLabel.AutoSize = true;
            apellidoSolteraLabel.Location = new System.Drawing.Point(23, 83);
            apellidoSolteraLabel.Name = "apellidoSolteraLabel";
            apellidoSolteraLabel.Size = new System.Drawing.Size(98, 13);
            apellidoSolteraLabel.TabIndex = 4;
            apellidoSolteraLabel.Text = "Apellido de Soltera:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(25, 114);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 6;
            nombresLabel.Text = "Nombres:";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.Location = new System.Drawing.Point(25, 143);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(72, 13);
            nacionalidadLabel.TabIndex = 8;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(23, 176);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 10;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(26, 214);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(52, 13);
            domicilioLabel.TabIndex = 12;
            domicilioLabel.Text = "Domicilio:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(25, 246);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(56, 13);
            localidadLabel.TabIndex = 14;
            localidadLabel.Text = "Localidad:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(27, 281);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 16;
            telefonoLabel.Text = "Teléfono:";
            // 
            // ocupacionLabel
            // 
            ocupacionLabel.AutoSize = true;
            ocupacionLabel.Location = new System.Drawing.Point(19, 322);
            ocupacionLabel.Name = "ocupacionLabel";
            ocupacionLabel.Size = new System.Drawing.Size(62, 13);
            ocupacionLabel.TabIndex = 18;
            ocupacionLabel.Text = "Ocupación:";
            // 
            // obraSocialLabel
            // 
            obraSocialLabel.AutoSize = true;
            obraSocialLabel.Location = new System.Drawing.Point(15, 357);
            obraSocialLabel.Name = "obraSocialLabel";
            obraSocialLabel.Size = new System.Drawing.Size(65, 13);
            obraSocialLabel.TabIndex = 20;
            obraSocialLabel.Text = "Obra Social:";
            // 
            // alfabetaLabel
            // 
            alfabetaLabel.AutoSize = true;
            alfabetaLabel.Location = new System.Drawing.Point(192, 321);
            alfabetaLabel.Name = "alfabetaLabel";
            alfabetaLabel.Size = new System.Drawing.Size(49, 13);
            alfabetaLabel.TabIndex = 22;
            alfabetaLabel.Text = "Alfabeta:";
            // 
            // estudiosLabel
            // 
            estudiosLabel.AutoSize = true;
            estudiosLabel.Location = new System.Drawing.Point(198, 356);
            estudiosLabel.Name = "estudiosLabel";
            estudiosLabel.Size = new System.Drawing.Size(50, 13);
            estudiosLabel.TabIndex = 24;
            estudiosLabel.Text = "Estudios:";
            // 
            // estadoCivilLabel
            // 
            estadoCivilLabel.AutoSize = true;
            estadoCivilLabel.Location = new System.Drawing.Point(15, 391);
            estadoCivilLabel.Name = "estadoCivilLabel";
            estadoCivilLabel.Size = new System.Drawing.Size(65, 13);
            estadoCivilLabel.TabIndex = 26;
            estadoCivilLabel.Text = "Estado Civil:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(32, 55);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(66, 13);
            idPacienteLabel.TabIndex = 28;
            idPacienteLabel.Text = "ID Paciente:";
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(29, 49);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(59, 13);
            idMedicoLabel.TabIndex = 0;
            idMedicoLabel.Text = "ID Médico:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(28, 93);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(55, 13);
            matriculaLabel.TabIndex = 2;
            matriculaLabel.Text = "Matrícula:";
            // 
            // apellidoMedLabel
            // 
            apellidoMedLabel.AutoSize = true;
            apellidoMedLabel.Location = new System.Drawing.Point(29, 135);
            apellidoMedLabel.Name = "apellidoMedLabel";
            apellidoMedLabel.Size = new System.Drawing.Size(85, 13);
            apellidoMedLabel.TabIndex = 4;
            apellidoMedLabel.Text = "Apellido Médico:";
            // 
            // nombresMedLabel
            // 
            nombresMedLabel.AutoSize = true;
            nombresMedLabel.Location = new System.Drawing.Point(32, 176);
            nombresMedLabel.Name = "nombresMedLabel";
            nombresMedLabel.Size = new System.Drawing.Size(90, 13);
            nombresMedLabel.TabIndex = 6;
            nombresMedLabel.Text = "Nombres Médico:";
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Location = new System.Drawing.Point(19, 64);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(65, 13);
            idConsultaLabel.TabIndex = 0;
            idConsultaLabel.Text = "ID Consulta:";
            // 
            // idPacienteLabel1
            // 
            idPacienteLabel1.AutoSize = true;
            idPacienteLabel1.Location = new System.Drawing.Point(18, 98);
            idPacienteLabel1.Name = "idPacienteLabel1";
            idPacienteLabel1.Size = new System.Drawing.Size(66, 13);
            idPacienteLabel1.TabIndex = 2;
            idPacienteLabel1.Text = "ID Paciente:";
            // 
            // idMedicoLabel1
            // 
            idMedicoLabel1.AutoSize = true;
            idMedicoLabel1.Location = new System.Drawing.Point(18, 132);
            idMedicoLabel1.Name = "idMedicoLabel1";
            idMedicoLabel1.Size = new System.Drawing.Size(59, 13);
            idMedicoLabel1.TabIndex = 4;
            idMedicoLabel1.Text = "ID Médico:";
            // 
            // fechaConsultaLabel
            // 
            fechaConsultaLabel.AutoSize = true;
            fechaConsultaLabel.Location = new System.Drawing.Point(19, 170);
            fechaConsultaLabel.Name = "fechaConsultaLabel";
            fechaConsultaLabel.Size = new System.Drawing.Size(84, 13);
            fechaConsultaLabel.TabIndex = 6;
            fechaConsultaLabel.Text = "Fecha Consulta:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(19, 207);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(62, 13);
            referenciaLabel.TabIndex = 8;
            referenciaLabel.Text = "Referencia:";
            // 
            // fechaUltPeriodoLabel
            // 
            fechaUltPeriodoLabel.AutoSize = true;
            fechaUltPeriodoLabel.Location = new System.Drawing.Point(17, 241);
            fechaUltPeriodoLabel.Name = "fechaUltPeriodoLabel";
            fechaUltPeriodoLabel.Size = new System.Drawing.Size(97, 13);
            fechaUltPeriodoLabel.TabIndex = 10;
            fechaUltPeriodoLabel.Text = "Fecha Últ Período:";
            // 
            // motivoConsultaLabel
            // 
            motivoConsultaLabel.AutoSize = true;
            motivoConsultaLabel.Location = new System.Drawing.Point(20, 272);
            motivoConsultaLabel.Name = "motivoConsultaLabel";
            motivoConsultaLabel.Size = new System.Drawing.Size(86, 13);
            motivoConsultaLabel.TabIndex = 12;
            motivoConsultaLabel.Text = "Motivo Consulta:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(22, 312);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(34, 13);
            pesoLabel.TabIndex = 14;
            pesoLabel.Text = "Peso:";
            // 
            // tallaLabel
            // 
            tallaLabel.AutoSize = true;
            tallaLabel.Location = new System.Drawing.Point(190, 309);
            tallaLabel.Name = "tallaLabel";
            tallaLabel.Size = new System.Drawing.Size(33, 13);
            tallaLabel.TabIndex = 16;
            tallaLabel.Text = "Talla:";
            // 
            // taLabel
            // 
            taLabel.AutoSize = true;
            taLabel.Location = new System.Drawing.Point(23, 348);
            taLabel.Name = "taLabel";
            taLabel.Size = new System.Drawing.Size(24, 13);
            taLabel.TabIndex = 18;
            taLabel.Text = "TA:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 475);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dataGridPaciente);
            this.tabPage1.Controls.Add(this.btn_llenarDataGridPaciente);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(idPacienteLabel);
            this.tabPage1.Controls.Add(this.idPacienteTextBox);
            this.tabPage1.Controls.Add(estadoCivilLabel);
            this.tabPage1.Controls.Add(this.estadoCivilTextBox);
            this.tabPage1.Controls.Add(estudiosLabel);
            this.tabPage1.Controls.Add(this.estudiosTextBox);
            this.tabPage1.Controls.Add(alfabetaLabel);
            this.tabPage1.Controls.Add(this.alfabetaCheckBox);
            this.tabPage1.Controls.Add(obraSocialLabel);
            this.tabPage1.Controls.Add(this.obraSocialTextBox);
            this.tabPage1.Controls.Add(ocupacionLabel);
            this.tabPage1.Controls.Add(this.ocupacionTextBox);
            this.tabPage1.Controls.Add(telefonoLabel);
            this.tabPage1.Controls.Add(this.telefonoTextBox);
            this.tabPage1.Controls.Add(localidadLabel);
            this.tabPage1.Controls.Add(this.localidadTextBox);
            this.tabPage1.Controls.Add(domicilioLabel);
            this.tabPage1.Controls.Add(this.domicilioTextBox);
            this.tabPage1.Controls.Add(fechaNacimientoLabel);
            this.tabPage1.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.tabPage1.Controls.Add(nacionalidadLabel);
            this.tabPage1.Controls.Add(this.nacionalidadTextBox);
            this.tabPage1.Controls.Add(nombresLabel);
            this.tabPage1.Controls.Add(this.nombresTextBox);
            this.tabPage1.Controls.Add(apellidoSolteraLabel);
            this.tabPage1.Controls.Add(this.apellidoSolteraTextBox);
            this.tabPage1.Controls.Add(dniLabel);
            this.tabPage1.Controls.Add(this.dniTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_pacienteBlanco,
            this.btn_altaPaciente,
            this.btn_modificarPaciente,
            this.btn_eliminarPaciente,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1027, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_pacienteBlanco
            // 
            this.btn_pacienteBlanco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_pacienteBlanco.Image = ((System.Drawing.Image)(resources.GetObject("btn_pacienteBlanco.Image")));
            this.btn_pacienteBlanco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pacienteBlanco.Name = "btn_pacienteBlanco";
            this.btn_pacienteBlanco.Size = new System.Drawing.Size(23, 22);
            this.btn_pacienteBlanco.Text = "&New";
            this.btn_pacienteBlanco.Click += new System.EventHandler(this.btn_pacienteBlanco_Click);
            // 
            // btn_modificarPaciente
            // 
            this.btn_modificarPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_modificarPaciente.Enabled = false;
            this.btn_modificarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificarPaciente.Image")));
            this.btn_modificarPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificarPaciente.Name = "btn_modificarPaciente";
            this.btn_modificarPaciente.Size = new System.Drawing.Size(23, 22);
            this.btn_modificarPaciente.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.Enabled = false;
            this.idPacienteTextBox.Location = new System.Drawing.Point(98, 49);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPacienteTextBox.TabIndex = 29;
            // 
            // estadoCivilTextBox
            // 
            this.estadoCivilTextBox.Location = new System.Drawing.Point(82, 385);
            this.estadoCivilTextBox.Name = "estadoCivilTextBox";
            this.estadoCivilTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoCivilTextBox.TabIndex = 27;
            // 
            // estudiosTextBox
            // 
            this.estudiosTextBox.Location = new System.Drawing.Point(250, 350);
            this.estudiosTextBox.Name = "estudiosTextBox";
            this.estudiosTextBox.Size = new System.Drawing.Size(100, 20);
            this.estudiosTextBox.TabIndex = 25;
            // 
            // alfabetaCheckBox
            // 
            this.alfabetaCheckBox.Location = new System.Drawing.Point(243, 316);
            this.alfabetaCheckBox.Name = "alfabetaCheckBox";
            this.alfabetaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.alfabetaCheckBox.TabIndex = 23;
            this.alfabetaCheckBox.UseVisualStyleBackColor = true;
            // 
            // obraSocialTextBox
            // 
            this.obraSocialTextBox.Location = new System.Drawing.Point(81, 351);
            this.obraSocialTextBox.Name = "obraSocialTextBox";
            this.obraSocialTextBox.Size = new System.Drawing.Size(100, 20);
            this.obraSocialTextBox.TabIndex = 21;
            // 
            // ocupacionTextBox
            // 
            this.ocupacionTextBox.Location = new System.Drawing.Point(82, 316);
            this.ocupacionTextBox.Name = "ocupacionTextBox";
            this.ocupacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ocupacionTextBox.TabIndex = 19;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(81, 277);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 17;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.Location = new System.Drawing.Point(83, 240);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.localidadTextBox.TabIndex = 15;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.Location = new System.Drawing.Point(80, 208);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(100, 20);
            this.domicilioTextBox.TabIndex = 13;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(119, 172);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 11;
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.Location = new System.Drawing.Point(98, 137);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.nacionalidadTextBox.TabIndex = 9;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(78, 109);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 7;
            // 
            // apellidoSolteraTextBox
            // 
            this.apellidoSolteraTextBox.Location = new System.Drawing.Point(121, 79);
            this.apellidoSolteraTextBox.Name = "apellidoSolteraTextBox";
            this.apellidoSolteraTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoSolteraTextBox.TabIndex = 5;
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(261, 48);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_llenarDataGridMedico);
            this.tabPage2.Controls.Add(this.dataGridMedico);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(nombresMedLabel);
            this.tabPage2.Controls.Add(this.nombresMedTextBox);
            this.tabPage2.Controls.Add(apellidoMedLabel);
            this.tabPage2.Controls.Add(this.apellidoMedTextBox);
            this.tabPage2.Controls.Add(matriculaLabel);
            this.tabPage2.Controls.Add(this.matriculaTextBox);
            this.tabPage2.Controls.Add(idMedicoLabel);
            this.tabPage2.Controls.Add(this.idMedicoTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Médicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_llenarDataGridMedico
            // 
            this.btn_llenarDataGridMedico.Location = new System.Drawing.Point(648, 40);
            this.btn_llenarDataGridMedico.Name = "btn_llenarDataGridMedico";
            this.btn_llenarDataGridMedico.Size = new System.Drawing.Size(75, 23);
            this.btn_llenarDataGridMedico.TabIndex = 36;
            this.btn_llenarDataGridMedico.Text = "Llenar lista";
            this.btn_llenarDataGridMedico.UseVisualStyleBackColor = true;
            this.btn_llenarDataGridMedico.Click += new System.EventHandler(this.btn_llenarDataGridMedico_Click);
            // 
            // dataGridMedico
            // 
            this.dataGridMedico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedico.Location = new System.Drawing.Point(368, 67);
            this.dataGridMedico.Name = "dataGridMedico";
            this.dataGridMedico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridMedico.Size = new System.Drawing.Size(635, 360);
            this.dataGridMedico.TabIndex = 35;
            this.dataGridMedico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedico_CellClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_medicoBlanco,
            this.btn_altaMedico,
            this.btn_modificarMedico,
            this.btn_eliminarMedico,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1027, 25);
            this.toolStrip2.TabIndex = 31;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_medicoBlanco
            // 
            this.btn_medicoBlanco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_medicoBlanco.Image = ((System.Drawing.Image)(resources.GetObject("btn_medicoBlanco.Image")));
            this.btn_medicoBlanco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_medicoBlanco.Name = "btn_medicoBlanco";
            this.btn_medicoBlanco.Size = new System.Drawing.Size(23, 22);
            this.btn_medicoBlanco.Text = "&New";
            this.btn_medicoBlanco.Click += new System.EventHandler(this.btn_medicoBlanco_Click);
            // 
            // btn_altaMedico
            // 
            this.btn_altaMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_altaMedico.Enabled = false;
            this.btn_altaMedico.Image = ((System.Drawing.Image)(resources.GetObject("btn_altaMedico.Image")));
            this.btn_altaMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_altaMedico.Name = "btn_altaMedico";
            this.btn_altaMedico.Size = new System.Drawing.Size(23, 22);
            this.btn_altaMedico.Text = "Agregar nuevo";
            this.btn_altaMedico.Click += new System.EventHandler(this.btn_altaMedico_Click);
            // 
            // btn_modificarMedico
            // 
            this.btn_modificarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_modificarMedico.Enabled = false;
            this.btn_modificarMedico.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificarMedico.Image")));
            this.btn_modificarMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificarMedico.Name = "btn_modificarMedico";
            this.btn_modificarMedico.Size = new System.Drawing.Size(23, 22);
            this.btn_modificarMedico.Text = "&Save";
            this.btn_modificarMedico.Click += new System.EventHandler(this.btn_modificarMedico_Click);
            // 
            // btn_eliminarMedico
            // 
            this.btn_eliminarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminarMedico.Enabled = false;
            this.btn_eliminarMedico.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarMedico.Image")));
            this.btn_eliminarMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminarMedico.Name = "btn_eliminarMedico";
            this.btn_eliminarMedico.Size = new System.Drawing.Size(23, 22);
            this.btn_eliminarMedico.Text = "Eliminar Registro";
            this.btn_eliminarMedico.Click += new System.EventHandler(this.btn_eliminarMedico_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nombresMedTextBox
            // 
            this.nombresMedTextBox.Location = new System.Drawing.Point(124, 170);
            this.nombresMedTextBox.Name = "nombresMedTextBox";
            this.nombresMedTextBox.Size = new System.Drawing.Size(171, 20);
            this.nombresMedTextBox.TabIndex = 7;
            // 
            // apellidoMedTextBox
            // 
            this.apellidoMedTextBox.Location = new System.Drawing.Point(116, 129);
            this.apellidoMedTextBox.Name = "apellidoMedTextBox";
            this.apellidoMedTextBox.Size = new System.Drawing.Size(179, 20);
            this.apellidoMedTextBox.TabIndex = 5;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.Location = new System.Drawing.Point(83, 87);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 3;
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.Enabled = false;
            this.idMedicoTextBox.Location = new System.Drawing.Point(88, 45);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(52, 20);
            this.idMedicoTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.IDMedicoComboBoxConsulta);
            this.tabPage3.Controls.Add(this.IDPacienteComboBoxConsulta);
            this.tabPage3.Controls.Add(this.btn_llenarDataGridConsulta);
            this.tabPage3.Controls.Add(this.dataGridConsulta);
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Controls.Add(taLabel);
            this.tabPage3.Controls.Add(this.taTextBox);
            this.tabPage3.Controls.Add(tallaLabel);
            this.tabPage3.Controls.Add(this.tallaTextBox);
            this.tabPage3.Controls.Add(pesoLabel);
            this.tabPage3.Controls.Add(this.pesoTextBox);
            this.tabPage3.Controls.Add(motivoConsultaLabel);
            this.tabPage3.Controls.Add(this.motivoConsultaTextBox);
            this.tabPage3.Controls.Add(fechaUltPeriodoLabel);
            this.tabPage3.Controls.Add(this.fechaUltPeriodoDateTimePicker);
            this.tabPage3.Controls.Add(referenciaLabel);
            this.tabPage3.Controls.Add(this.referenciaTextBox);
            this.tabPage3.Controls.Add(fechaConsultaLabel);
            this.tabPage3.Controls.Add(this.fechaConsultaDateTimePicker);
            this.tabPage3.Controls.Add(idMedicoLabel1);
            this.tabPage3.Controls.Add(idPacienteLabel1);
            this.tabPage3.Controls.Add(idConsultaLabel);
            this.tabPage3.Controls.Add(this.idConsultaTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1033, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // IDMedicoComboBoxConsulta
            // 
            this.IDMedicoComboBoxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDMedicoComboBoxConsulta.Enabled = false;
            this.IDMedicoComboBoxConsulta.FormattingEnabled = true;
            this.IDMedicoComboBoxConsulta.Location = new System.Drawing.Point(82, 129);
            this.IDMedicoComboBoxConsulta.Name = "IDMedicoComboBoxConsulta";
            this.IDMedicoComboBoxConsulta.Size = new System.Drawing.Size(94, 21);
            this.IDMedicoComboBoxConsulta.TabIndex = 36;
            // 
            // IDPacienteComboBoxConsulta
            // 
            this.IDPacienteComboBoxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDPacienteComboBoxConsulta.Enabled = false;
            this.IDPacienteComboBoxConsulta.FormattingEnabled = true;
            this.IDPacienteComboBoxConsulta.Location = new System.Drawing.Point(84, 95);
            this.IDPacienteComboBoxConsulta.Name = "IDPacienteComboBoxConsulta";
            this.IDPacienteComboBoxConsulta.Size = new System.Drawing.Size(94, 21);
            this.IDPacienteComboBoxConsulta.TabIndex = 35;
            // 
            // btn_llenarDataGridConsulta
            // 
            this.btn_llenarDataGridConsulta.Location = new System.Drawing.Point(675, 31);
            this.btn_llenarDataGridConsulta.Name = "btn_llenarDataGridConsulta";
            this.btn_llenarDataGridConsulta.Size = new System.Drawing.Size(75, 23);
            this.btn_llenarDataGridConsulta.TabIndex = 34;
            this.btn_llenarDataGridConsulta.Text = "Llenar lista";
            this.btn_llenarDataGridConsulta.UseVisualStyleBackColor = true;
            this.btn_llenarDataGridConsulta.Click += new System.EventHandler(this.btn_llenarDataGridConsulta_Click);
            // 
            // dataGridConsulta
            // 
            this.dataGridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsulta.Location = new System.Drawing.Point(377, 58);
            this.dataGridConsulta.Name = "dataGridConsulta";
            this.dataGridConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridConsulta.Size = new System.Drawing.Size(635, 360);
            this.dataGridConsulta.TabIndex = 33;
            this.dataGridConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConsulta_CellClick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_consultaBlanco,
            this.btn_altaConsulta,
            this.btn_modificarConsulta,
            this.btn_eliminarConsulta,
            this.toolStripSeparator2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1027, 25);
            this.toolStrip3.TabIndex = 31;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btn_consultaBlanco
            // 
            this.btn_consultaBlanco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_consultaBlanco.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultaBlanco.Image")));
            this.btn_consultaBlanco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultaBlanco.Name = "btn_consultaBlanco";
            this.btn_consultaBlanco.Size = new System.Drawing.Size(23, 22);
            this.btn_consultaBlanco.Text = "Nuevo";
            this.btn_consultaBlanco.Click += new System.EventHandler(this.btn_consultaBlanco_Click);
            // 
            // btn_altaConsulta
            // 
            this.btn_altaConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_altaConsulta.Enabled = false;
            this.btn_altaConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_altaConsulta.Image")));
            this.btn_altaConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_altaConsulta.Name = "btn_altaConsulta";
            this.btn_altaConsulta.Size = new System.Drawing.Size(23, 22);
            this.btn_altaConsulta.Text = "Agregar nuevo";
            this.btn_altaConsulta.Click += new System.EventHandler(this.btn_altaConsulta_Click);
            // 
            // btn_modificarConsulta
            // 
            this.btn_modificarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_modificarConsulta.Enabled = false;
            this.btn_modificarConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificarConsulta.Image")));
            this.btn_modificarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificarConsulta.Name = "btn_modificarConsulta";
            this.btn_modificarConsulta.Size = new System.Drawing.Size(23, 22);
            this.btn_modificarConsulta.Text = "Guardar modificación";
            this.btn_modificarConsulta.Click += new System.EventHandler(this.btn_modificarConsulta_Click);
            // 
            // btn_eliminarConsulta
            // 
            this.btn_eliminarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminarConsulta.Enabled = false;
            this.btn_eliminarConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarConsulta.Image")));
            this.btn_eliminarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminarConsulta.Name = "btn_eliminarConsulta";
            this.btn_eliminarConsulta.Size = new System.Drawing.Size(23, 22);
            this.btn_eliminarConsulta.Text = "Eliminar Registro";
            this.btn_eliminarConsulta.Click += new System.EventHandler(this.btn_eliminarConsulta_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // taTextBox
            // 
            this.taTextBox.Enabled = false;
            this.taTextBox.Location = new System.Drawing.Point(50, 343);
            this.taTextBox.Name = "taTextBox";
            this.taTextBox.Size = new System.Drawing.Size(100, 20);
            this.taTextBox.TabIndex = 19;
            // 
            // tallaTextBox
            // 
            this.tallaTextBox.Enabled = false;
            this.tallaTextBox.Location = new System.Drawing.Point(224, 307);
            this.tallaTextBox.Name = "tallaTextBox";
            this.tallaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tallaTextBox.TabIndex = 17;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.Enabled = false;
            this.pesoTextBox.Location = new System.Drawing.Point(58, 306);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pesoTextBox.TabIndex = 15;
            // 
            // motivoConsultaTextBox
            // 
            this.motivoConsultaTextBox.Enabled = false;
            this.motivoConsultaTextBox.Location = new System.Drawing.Point(108, 266);
            this.motivoConsultaTextBox.Name = "motivoConsultaTextBox";
            this.motivoConsultaTextBox.Size = new System.Drawing.Size(200, 20);
            this.motivoConsultaTextBox.TabIndex = 13;
            // 
            // fechaUltPeriodoDateTimePicker
            // 
            this.fechaUltPeriodoDateTimePicker.Enabled = false;
            this.fechaUltPeriodoDateTimePicker.Location = new System.Drawing.Point(118, 236);
            this.fechaUltPeriodoDateTimePicker.Name = "fechaUltPeriodoDateTimePicker";
            this.fechaUltPeriodoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaUltPeriodoDateTimePicker.TabIndex = 11;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.Enabled = false;
            this.referenciaTextBox.Location = new System.Drawing.Point(82, 202);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.referenciaTextBox.TabIndex = 9;
            // 
            // fechaConsultaDateTimePicker
            // 
            this.fechaConsultaDateTimePicker.Enabled = false;
            this.fechaConsultaDateTimePicker.Location = new System.Drawing.Point(104, 166);
            this.fechaConsultaDateTimePicker.Name = "fechaConsultaDateTimePicker";
            this.fechaConsultaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaConsultaDateTimePicker.TabIndex = 7;
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.Enabled = false;
            this.idConsultaTextBox.Location = new System.Drawing.Point(84, 58);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(53, 20);
            this.idConsultaTextBox.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listViewListado);
            this.tabPage4.Controls.Add(this.btn_listConsulta);
            this.tabPage4.Controls.Add(this.btn_listMedico);
            this.tabPage4.Controls.Add(this.btn_listPaciente);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1033, 449);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listados";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listViewListado
            // 
            this.listViewListado.FullRowSelect = true;
            this.listViewListado.Location = new System.Drawing.Point(9, 62);
            this.listViewListado.Name = "listViewListado";
            this.listViewListado.Size = new System.Drawing.Size(1016, 379);
            this.listViewListado.TabIndex = 3;
            this.listViewListado.UseCompatibleStateImageBehavior = false;
            // 
            // btn_listConsulta
            // 
            this.btn_listConsulta.Location = new System.Drawing.Point(610, 15);
            this.btn_listConsulta.Name = "btn_listConsulta";
            this.btn_listConsulta.Size = new System.Drawing.Size(118, 29);
            this.btn_listConsulta.TabIndex = 2;
            this.btn_listConsulta.Text = "Consultas";
            this.btn_listConsulta.UseVisualStyleBackColor = true;
            this.btn_listConsulta.Click += new System.EventHandler(this.btn_listConsulta_Click);
            // 
            // btn_listMedico
            // 
            this.btn_listMedico.Location = new System.Drawing.Point(468, 15);
            this.btn_listMedico.Name = "btn_listMedico";
            this.btn_listMedico.Size = new System.Drawing.Size(118, 29);
            this.btn_listMedico.TabIndex = 1;
            this.btn_listMedico.Text = "Médicos";
            this.btn_listMedico.UseVisualStyleBackColor = true;
            this.btn_listMedico.Click += new System.EventHandler(this.btn_listMedico_Click);
            // 
            // btn_listPaciente
            // 
            this.btn_listPaciente.Location = new System.Drawing.Point(330, 15);
            this.btn_listPaciente.Name = "btn_listPaciente";
            this.btn_listPaciente.Size = new System.Drawing.Size(118, 29);
            this.btn_listPaciente.TabIndex = 0;
            this.btn_listPaciente.Text = "Pacientes";
            this.btn_listPaciente.UseVisualStyleBackColor = true;
            this.btn_listPaciente.Click += new System.EventHandler(this.btn_listPaciente_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "&New";
            // 
            // btn_altaPaciente
            // 
            this.btn_altaPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_altaPaciente.Enabled = false;
            this.btn_altaPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_altaPaciente.Image")));
            this.btn_altaPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_altaPaciente.Name = "btn_altaPaciente";
            this.btn_altaPaciente.Size = new System.Drawing.Size(23, 22);
            this.btn_altaPaciente.Text = "Agregar nuevo";
            this.btn_altaPaciente.Click += new System.EventHandler(this.btn_altaPaciente_Click);
            // 
            // btn_eliminarPaciente
            // 
            this.btn_eliminarPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminarPaciente.Enabled = false;
            this.btn_eliminarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarPaciente.Image")));
            this.btn_eliminarPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminarPaciente.Name = "btn_eliminarPaciente";
            this.btn_eliminarPaciente.Size = new System.Drawing.Size(23, 22);
            this.btn_eliminarPaciente.Text = "Eliminar Registro";
            // 
            // btn_llenarDataGridPaciente
            // 
            this.btn_llenarDataGridPaciente.Location = new System.Drawing.Point(664, 34);
            this.btn_llenarDataGridPaciente.Name = "btn_llenarDataGridPaciente";
            this.btn_llenarDataGridPaciente.Size = new System.Drawing.Size(75, 23);
            this.btn_llenarDataGridPaciente.TabIndex = 37;
            this.btn_llenarDataGridPaciente.Text = "Llenar lista";
            this.btn_llenarDataGridPaciente.UseVisualStyleBackColor = true;
            this.btn_llenarDataGridPaciente.Click += new System.EventHandler(this.btn_llenarDataGridPaciente_Click);
            // 
            // dataGridPaciente
            // 
            this.dataGridPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPaciente.Location = new System.Drawing.Point(384, 67);
            this.dataGridPaciente.Name = "dataGridPaciente";
            this.dataGridPaciente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridPaciente.Size = new System.Drawing.Size(635, 360);
            this.dataGridPaciente.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Historias Clínicas - Ginecología";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;       
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.TextBox estadoCivilTextBox;
        private System.Windows.Forms.TextBox estudiosTextBox;
        private System.Windows.Forms.CheckBox alfabetaCheckBox;
        private System.Windows.Forms.TextBox obraSocialTextBox;
        private System.Windows.Forms.TextBox ocupacionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidoSolteraTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox nombresMedTextBox;
        private System.Windows.Forms.TextBox apellidoMedTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox taTextBox;
        private System.Windows.Forms.TextBox tallaTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox motivoConsultaTextBox;
        private System.Windows.Forms.DateTimePicker fechaUltPeriodoDateTimePicker;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.DateTimePicker fechaConsultaDateTimePicker;
        private System.Windows.Forms.TextBox idConsultaTextBox;
        private object bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_pacienteBlanco;
        private System.Windows.Forms.ToolStripButton btn_modificarPaciente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_listConsulta;
        private System.Windows.Forms.Button btn_listMedico;
        private System.Windows.Forms.Button btn_listPaciente;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_medicoBlanco;
        private System.Windows.Forms.ToolStripButton btn_modificarMedico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btn_consultaBlanco;
        private System.Windows.Forms.ToolStripButton btn_modificarConsulta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_altaConsulta;
        private System.Windows.Forms.ToolStripButton btn_eliminarConsulta;
        private System.Windows.Forms.ListView listViewListado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridConsulta;
        private System.Windows.Forms.Button btn_llenarDataGridConsulta;
        private System.Windows.Forms.ComboBox IDMedicoComboBoxConsulta;
        private System.Windows.Forms.ComboBox IDPacienteComboBoxConsulta;
        private System.Windows.Forms.Button btn_llenarDataGridMedico;
        private System.Windows.Forms.DataGridView dataGridMedico;
        private System.Windows.Forms.ToolStripButton btn_altaMedico;
        private System.Windows.Forms.ToolStripButton btn_eliminarMedico;
        private System.Windows.Forms.DataGridView dataGridPaciente;
        private System.Windows.Forms.Button btn_llenarDataGridPaciente;
        private System.Windows.Forms.ToolStripButton btn_altaPaciente;
        private System.Windows.Forms.ToolStripButton btn_eliminarPaciente;
    }
}

