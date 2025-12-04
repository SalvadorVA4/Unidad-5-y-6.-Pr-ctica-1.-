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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelPortSelection = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPortSelection = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEstadoArduino = new System.Windows.Forms.Label();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClockRealTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelEstadoConexion = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelIntegrantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseBtn)).BeginInit();
            this.panelComunicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelTitulo.Size = new System.Drawing.Size(887, 100);
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
            this.panelIntegrantes.Size = new System.Drawing.Size(300, 200);
            this.panelIntegrantes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(110, 36);
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
            this.labelIntegrantes.Location = new System.Drawing.Point(109, 12);
            this.labelIntegrantes.Name = "labelIntegrantes";
            this.labelIntegrantes.Size = new System.Drawing.Size(180, 20);
            this.labelIntegrantes.TabIndex = 1;
            this.labelIntegrantes.Text = "Salvador Villalpando";
            // 
            // pictureEquipo
            // 
            this.pictureEquipo.Image = global::ProyectoFinalHMI_23.Properties.Resources.kk;
            this.pictureEquipo.Location = new System.Drawing.Point(3, 12);
            this.pictureEquipo.Name = "pictureEquipo";
            this.pictureEquipo.Size = new System.Drawing.Size(100, 50);
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
            this.labelTitulo.Size = new System.Drawing.Size(312, 38);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Proyecto Final HMI";
            // 
            // panelComunicacion
            // 
            this.panelComunicacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelComunicacion.Controls.Add(this.pictureBox1);
            this.panelComunicacion.Controls.Add(this.buttonConnect);
            this.panelComunicacion.Controls.Add(this.buttonRefresh);
            this.panelComunicacion.Controls.Add(this.labelPortSelection);
            this.panelComunicacion.Controls.Add(this.comboBoxBaudRate);
            this.panelComunicacion.Controls.Add(this.comboBoxPortSelection);
            this.panelComunicacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelComunicacion.Location = new System.Drawing.Point(0, 100);
            this.panelComunicacion.Name = "panelComunicacion";
            this.panelComunicacion.Size = new System.Drawing.Size(303, 498);
            this.panelComunicacion.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalHMI_23.Properties.Resources.ChatGPT_Image_29_nov_2025__13_03_23;
            this.pictureBox1.Location = new System.Drawing.Point(29, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Green;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConnect.Location = new System.Drawing.Point(29, 225);
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
            this.buttonRefresh.Location = new System.Drawing.Point(25, 160);
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
            this.labelPortSelection.Location = new System.Drawing.Point(25, 7);
            this.labelPortSelection.Name = "labelPortSelection";
            this.labelPortSelection.Size = new System.Drawing.Size(179, 20);
            this.labelPortSelection.TabIndex = 2;
            this.labelPortSelection.Text = "Communication Port";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(25, 106);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(179, 24);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // comboBoxPortSelection
            // 
            this.comboBoxPortSelection.FormattingEnabled = true;
            this.comboBoxPortSelection.Location = new System.Drawing.Point(25, 43);
            this.comboBoxPortSelection.Name = "comboBoxPortSelection";
            this.comboBoxPortSelection.Size = new System.Drawing.Size(179, 24);
            this.comboBoxPortSelection.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.labelEstadoConexion);
            this.panel1.Controls.Add(this.listBoxLog);
            this.panel1.Controls.Add(this.labelEstadoArduino);
            this.panel1.Controls.Add(this.btnDesactivar);
            this.panel1.Controls.Add(this.btnActivar);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Location = new System.Drawing.Point(302, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 195);
            this.panel1.TabIndex = 2;
            // 
            // labelEstadoArduino
            // 
            this.labelEstadoArduino.AutoSize = true;
            this.labelEstadoArduino.BackColor = System.Drawing.Color.White;
            this.labelEstadoArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoArduino.Location = new System.Drawing.Point(363, 9);
            this.labelEstadoArduino.Name = "labelEstadoArduino";
            this.labelEstadoArduino.Size = new System.Drawing.Size(171, 20);
            this.labelEstadoArduino.TabIndex = 3;
            this.labelEstadoArduino.Text = "labelEstadoArduino";
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.Red;
            this.btnDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesactivar.Location = new System.Drawing.Point(117, 92);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(187, 27);
            this.btnDesactivar.TabIndex = 2;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.Green;
            this.btnActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivar.Location = new System.Drawing.Point(117, 43);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(187, 28);
            this.btnActivar.TabIndex = 1;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(125, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(179, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.labelClockRealTime);
            this.panel2.Location = new System.Drawing.Point(610, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 202);
            this.panel2.TabIndex = 3;
            // 
            // labelClockRealTime
            // 
            this.labelClockRealTime.AutoSize = true;
            this.labelClockRealTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClockRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockRealTime.ForeColor = System.Drawing.Color.Red;
            this.labelClockRealTime.Location = new System.Drawing.Point(23, 81);
            this.labelClockRealTime.Name = "labelClockRealTime";
            this.labelClockRealTime.Size = new System.Drawing.Size(251, 29);
            this.labelClockRealTime.TabIndex = 0;
            this.labelClockRealTime.Text = "labelClockRealTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(367, 92);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(120, 84);
            this.listBoxLog.TabIndex = 4;
            // 
            // labelEstadoConexion
            // 
            this.labelEstadoConexion.AutoSize = true;
            this.labelEstadoConexion.BackColor = System.Drawing.Color.White;
            this.labelEstadoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoConexion.Location = new System.Drawing.Point(363, 51);
            this.labelEstadoConexion.Name = "labelEstadoConexion";
            this.labelEstadoConexion.Size = new System.Drawing.Size(184, 20);
            this.labelEstadoConexion.TabIndex = 5;
            this.labelEstadoConexion.Text = "labelEstadoConexion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 598);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEstadoArduino;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClockRealTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label labelEstadoConexion;
    }
}

