using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalHMI_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void pictureBoxMinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPortSelection.DataSource = ports;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPortSelection.SelectedItem == null)
            {
                MessageBox.Show("No hay puertos disponibles.");
                return;
            }

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = comboBoxPortSelection.SelectedItem.ToString();
                    serialPort1.BaudRate = int.Parse(comboBoxBaudRate.SelectedItem.ToString());
                    serialPort1.Open();

                    buttonConnect.Text = "Disconnect";
                    labelEstadoConexion.Text = "CONNECTED";
                    labelEstadoConexion.ForeColor = Color.Green;

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
           
        
        private void OpenSerialPort()
        {
            try
            {
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort1.PortName = comboBoxPortSelection.Text;
                serialPort1.Open();
                serialPort1.WriteLine("");
                serialPort1.DiscardInBuffer();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClockRealTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void ProcessDataFromArduino(string data)
        {
            data = data.Trim();
            

            if (data == "PIR:1")
            {
                labelEstadoArduino.Text = "Movimiento detectado";
                labelEstadoArduino.ForeColor = Color.Red;
            }
            else if (data == "PIR:0")
            {
                labelEstadoArduino.Text = "Sin movimiento";
                labelEstadoArduino.ForeColor = Color.Black;
            }
            else if (data == "ALARMA:ON")
            {
                labelEstadoArduino.Text = "Alarma ACTIVADA";
                labelEstadoArduino.ForeColor = Color.Red;
            }
            else if (data == "ALARMA:OFF")
            {
                labelEstadoArduino.Text = "Alarma DESACTIVADA";
                labelEstadoArduino.ForeColor = Color.Green;
            }
            else
            {
                // mostrar cualquier otro texto
                labelEstadoArduino.Text = data;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelComunicacion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
