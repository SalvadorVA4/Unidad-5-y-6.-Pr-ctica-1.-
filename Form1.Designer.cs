namespace ProyectoFinalHMI_23
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelIntegrantes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIntegrantes = new System.Windows.Forms.Label();
            this.pictureEquipo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBoxCloseBtn = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelComunicacion = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelPortSelection = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPortSelection = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEstadoConexion = new System.Windows.Forms.Label();
            this.labelEstadoArduino = new System.Windows.Forms.Label();
            this.btnActivar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClockRealTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelIntegrantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseBtn)).BeginInit();
            this.panelComunicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTitulo.Controls.Add(this.panelIntegrantes);
            this.panelTitulo.Controls.Add(this.pictureBoxMinimizeBtn);
            this.panelTitulo.Controls.Add(this.pictureBoxCloseBtn);
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1006, 100);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelIntegrantes
            // 
            this.panelIntegrantes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelIntegrantes.Controls.Add(this.label1);
            this.panelIntegrantes.Controls.Add(this.labelIntegrantes);
            this.panelIntegrantes.Controls.Add(this.pictureEquipo);
            this.panelIntegrantes.Location = new System.Drawing.Point(3, 0);
            this.panelIntegrantes.Name = "panelIntegrantes";
            this.panelIntegrantes.Size = new System.Drawing.Size(300, 129);
            this.panelIntegrantes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // labelIntegrantes
            // 
            this.labelIntegrantes.AutoSize = true;
            this.labelIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntegrantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIntegrantes.Location = new System.Drawing.Point(66, 12);
            this.labelIntegrantes.Name = "labelIntegrantes";
            this.labelIntegrantes.Size = new System.Drawing.Size(180, 20);
            this.labelIntegrantes.TabIndex = 1;
            this.labelIntegrantes.Text = "Salvador Villalpando";
            // 
            // pictureEquipo
            // 
            this.pictureEquipo.Image = global::ProyectoFinalHMI_23.Properties.Resources.WhatsApp_Image_2025_12_03_at_6_54_32_PM;
            this.pictureEquipo.Location = new System.Drawing.Point(3, 12);
            this.pictureEquipo.Name = "pictureEquipo";
            this.pictureEquipo.Size = new System.Drawing.Size(57, 50);
            this.pictureEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEquipo.TabIndex = 0;
            this.pictureEquipo.TabStop = false;
            // 
            // pictureBoxMinimizeBtn
            // 
            this.pictureBoxMinimizeBtn.Image = global::ProyectoFinalHMI_23.Properties.Resources.rwq;
            this.pictureBoxMinimizeBtn.Location = new System.Drawing.Point(722, 28);
            this.pictureBoxMinimizeBtn.Name = "pictureBoxMinimizeBtn";
            this.pictureBoxMinimizeBtn.Size = new System.Drawing.Size(44, 34);
            this.pictureBoxMinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizeBtn.TabIndex = 2;
            this.pictureBoxMinimizeBtn.TabStop = false;
            this.pictureBoxMinimizeBtn.Click += new System.EventHandler(this.pictureBoxMinimizeBtn_Click);
            // 
            // pictureBoxCloseBtn
            // 
            this.pictureBoxCloseBtn.Image = global::ProyectoFinalHMI_23.Properties.Resources.www;
            this.pictureBoxCloseBtn.Location = new System.Drawing.Point(802, 28);
            this.pictureBoxCloseBtn.Name = "pictureBoxCloseBtn";
            this.pictureBoxCloseBtn.Size = new System.Drawing.Size(44, 34);
            this.pictureBoxCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseBtn.TabIndex = 1;
            this.pictureBoxCloseBtn.TabStop = false;
            this.pictureBoxCloseBtn.Click += new System.EventHandler(this.pictureBoxCloseBtn_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(323, 16);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(325, 39);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Proyecto Final HMI";
            // 
            // panelComunicacion
            // 
            this.panelComunicacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelComunicacion.Controls.Add(this.label8);
            this.panelComunicacion.Controls.Add(this.label9);
            this.panelComunicacion.Controls.Add(this.pictureBox5);
            this.panelComunicacion.Controls.Add(this.label6);
            this.panelComunicacion.Controls.Add(this.label7);
            this.panelComunicacion.Controls.Add(this.pictureBox4);
            this.panelComunicacion.Controls.Add(this.label4);
            this.panelComunicacion.Controls.Add(this.label5);
            this.panelComunicacion.Controls.Add(this.pictureBox3);
            this.panelComunicacion.Controls.Add(this.label2);
            this.panelComunicacion.Controls.Add(this.pictureBox1);
            this.panelComunicacion.Controls.Add(this.label3);
            this.panelComunicacion.Controls.Add(this.pictureBox2);
            this.panelComunicacion.Controls.Add(this.buttonConnect);
            this.panelComunicacion.Controls.Add(this.buttonRefresh);
            this.panelComunicacion.Controls.Add(this.labelPortSelection);
            this.panelComunicacion.Controls.Add(this.comboBoxBaudRate);
            this.panelComunicacion.Controls.Add(this.comboBoxPortSelection);
            this.panelComunicacion.Location = new System.Drawing.Point(0, 68);
            this.panelComunicacion.Name = "panelComunicacion";
            this.panelComunicacion.Size = new System.Drawing.Size(303, 622);
            this.panelComunicacion.TabIndex = 1;
            this.panelComunicacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelComunicacion_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(78, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Admin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(74, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Victor Bordonave";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoFinalHMI_23.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_19_16_PM;
            this.pictureBox5.Location = new System.Drawing.Point(8, 171);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(78, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(74, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adair Puente";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoFinalHMI_23.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_29_35_PM;
            this.pictureBox4.Location = new System.Drawing.Point(8, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(70, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(66, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Josue Avendaño";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinalHMI_23.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_07_16_PM;
            this.pictureBox3.Location = new System.Drawing.Point(0, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(70, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalHMI_23.Properties.Resources.ChatGPT_Image_29_nov_2025__13_03_23;
            this.pictureBox1.Location = new System.Drawing.Point(8, 458);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(66, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Andrew Contreras";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinalHMI_23.Properties.Resources.WhatsApp_Image_2025_12_03_at_4_11_02_PM;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Green;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConnect.Location = new System.Drawing.Point(8, 411);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(159, 45);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Purple;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefresh.Location = new System.Drawing.Point(4, 346);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(163, 48);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh Ports";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelPortSelection
            // 
            this.labelPortSelection.AutoSize = true;
            this.labelPortSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortSelection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPortSelection.Location = new System.Drawing.Point(4, 235);
            this.labelPortSelection.Name = "labelPortSelection";
            this.labelPortSelection.Size = new System.Drawing.Size(179, 20);
            this.labelPortSelection.TabIndex = 2;
            this.labelPortSelection.Text = "Communication Port";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(4, 310);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(179, 24);
            this.comboBoxBaudRate.TabIndex = 1;
            this.comboBoxBaudRate.Text = "9600";
            // 
            // comboBoxPortSelection
            // 
            this.comboBoxPortSelection.FormattingEnabled = true;
            this.comboBoxPortSelection.Location = new System.Drawing.Point(4, 271);
            this.comboBoxPortSelection.Name = "comboBoxPortSelection";
            this.comboBoxPortSelection.Size = new System.Drawing.Size(179, 24);
            this.comboBoxPortSelection.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.labelEstadoConexion);
            this.panel1.Controls.Add(this.labelEstadoArduino);
            this.panel1.Controls.Add(this.btnActivar);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Location = new System.Drawing.Point(302, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 195);
            this.panel1.TabIndex = 2;
            // 
            // labelEstadoConexion
            // 
            this.labelEstadoConexion.AutoSize = true;
            this.labelEstadoConexion.BackColor = System.Drawing.Color.White;
            this.labelEstadoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoConexion.Location = new System.Drawing.Point(363, 51);
            this.labelEstadoConexion.Name = "labelEstadoConexion";
            this.labelEstadoConexion.Size = new System.Drawing.Size(61, 20);
            this.labelEstadoConexion.TabIndex = 5;
            this.labelEstadoConexion.Text = "Activo";
            // 
            // labelEstadoArduino
            // 
            this.labelEstadoArduino.AutoSize = true;
            this.labelEstadoArduino.BackColor = System.Drawing.Color.White;
            this.labelEstadoArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoArduino.Location = new System.Drawing.Point(363, 9);
            this.labelEstadoArduino.Name = "labelEstadoArduino";
            this.labelEstadoArduino.Size = new System.Drawing.Size(135, 20);
            this.labelEstadoArduino.TabIndex = 3;
            this.labelEstadoArduino.Text = "Buzer sonando";
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.Green;
            this.btnActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivar.Location = new System.Drawing.Point(48, 97);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(231, 74);
            this.btnActivar.TabIndex = 1;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(48, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(211, 53);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "TECNM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.labelClockRealTime);
            this.panel2.Location = new System.Drawing.Point(309, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 202);
            this.panel2.TabIndex = 3;
            // 
            // labelClockRealTime
            // 
            this.labelClockRealTime.AutoSize = true;
            this.labelClockRealTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClockRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockRealTime.ForeColor = System.Drawing.Color.Red;
            this.labelClockRealTime.Location = new System.Drawing.Point(137, 58);
            this.labelClockRealTime.Name = "labelClockRealTime";
            this.labelClockRealTime.Size = new System.Drawing.Size(426, 51);
            this.labelClockRealTime.TabIndex = 0;
            this.labelClockRealTime.Text = "labelClockRealTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(669, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 181);
            this.panel3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(38, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "On amarrillo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(38, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "On rojo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(38, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "On Verde";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelComunicacion);
            this.Controls.Add(this.panelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelIntegrantes.ResumeLayout(false);
            this.panelIntegrantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseBtn)).EndInit();
            this.panelComunicacion.ResumeLayout(false);
            this.panelComunicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBoxMinimizeBtn;
        private System.Windows.Forms.PictureBox pictureBoxCloseBtn;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelIntegrantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIntegrantes;
        private System.Windows.Forms.PictureBox pictureEquipo;
        private System.Windows.Forms.Panel panelComunicacion;
        private System.Windows.Forms.Label labelPortSelection;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxPortSelection;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonRefresh;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEstadoArduino;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClockRealTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelEstadoConexion;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

