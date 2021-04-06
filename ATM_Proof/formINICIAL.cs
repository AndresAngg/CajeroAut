using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CajeroBeta;
using System.IO;

namespace ATM_Proof
{
    public partial class formINICIAL : Form
    {
        //VERSION 4.0

        cliente cli = new cliente();
        Form1 fr =new Form1();
        finalTrans frt = new finalTrans();
        errorLog err = new errorLog();
       
        StreamReader leer;
        public formINICIAL()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam,
            int lparam);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textPIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textCUENTA_Enter(object sender, EventArgs e)
        {
            if (textCUENTA.Text== "Últimos 4 dígitos de tarjeta")
            {
                textCUENTA.Text = "";
                //textCUENTA.ForeColor == Color.Blue;
            }
        }

        private void textCUENTA_Leave(object sender, EventArgs e)
        {
            if (textCUENTA.Text=="")
            {
                textCUENTA.Text = "Últimos 4 dígitos de tarjeta";
                //textCUENTA.ForeColor == Color.Blue;


            }
        }

        private void textPIN_Enter(object sender, EventArgs e)
        {
            if (textPIN.Text == "PIN")
            {
                textPIN.Text = "";
                //textCUENTA.ForeColor == Color.Blue;
                textPIN.UseSystemPasswordChar = true;
            }
        }

        private void textPIN_Leave(object sender, EventArgs e)
        {
            if (textPIN.Text == "")
            {
                textPIN.Text = "PIN";
                //textCUENTA.ForeColor == Color.Blue;
                textPIN.UseSystemPasswordChar = false;

            }
        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            
            //pr.Show();
            verificacionDatos();
            textPIN.Text = "";
            textCUENTA.Text = "";
          //  this.Hide();
        }

        public void verificacionDatos()
        {

          
            
           leer = File.OpenText("clientes.txt");
            string linea = leer.ReadLine();
            Boolean dato = false;

            try {

                while (dato == false)
                {


                    string[] campo = new string[5];
                    campo = linea.Split(',');
                    fr.cli.Nºcuenta1 = campo[0];
                    fr.cli.Clave = campo[1];
                    fr.cli.NIdentificacion1 = campo[2];
                    fr.cli.Nombre = campo[3];
                    fr.cli.Saldo = double.Parse(campo[4]);
                    


                    if (textPIN.Text == fr.cli.Clave && textCUENTA.Text == fr.cli.Nºcuenta1)
                    {

                       
                        fr.tran.Cli.Add(fr.cli);
                        dato = true;                  
                        fr.Show();
                        fr.TAP_1.SelectTab(0);


                    }

                    linea = leer.ReadLine();

                }


            }
            catch (Exception ){
                err.Show();
                
            }
            leer.Close();
        }

      
        

        private void buttonLOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            verificacionDatos();
            textPIN.Text = "";
            textCUENTA.Text = "";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formINICIAL_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formINICIAL_Load(object sender, EventArgs e)
        {

        }
    }
}
