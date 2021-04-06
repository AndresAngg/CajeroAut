using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ATM_Proof;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.testutils;
using iTextSharp;

namespace CajeroBeta
{
    public partial class Form1 : Form

    {
        //VERSION 4.0

        public transaccional tran = new transaccional();
        public cliente cli = new cliente();
        //  public formINICIAL frI = new formINICIAL();
        public finalTrans frt = new finalTrans();
        public retiroDin ret = new retiroDin();
       
        string NoCuentaDES, Nidenti_DES, nombre_DES, claveDES;
        double saldo_DES, VR;

        public Form1()
        {
            InitializeComponent();
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            //  PIN.Text += "4";

        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            // PIN.Text += "6";
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            // PIN.Text += "0";
        }

        private void Num_1_Click(object sender, EventArgs e)
        {
            //  PIN.Text += "1";
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            // PIN.Text += "2"; 
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            //PIN.Text += "3"; 
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            //  PIN.Text += "5";
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            // PIN.Text += "7";
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            //  PIN.Text += "8";
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            //   PIN.Text += "9";
        }

        private void BotBorrar_Click(object sender, EventArgs e)
        {
            /*
                 string ultCarac = PIN.Text.Substring(0, PIN.Text.Length - 1);

                 PIN.Text = ultCarac;
                 */

        }

        private void BotCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            frt.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotEnter_Click(object sender, EventArgs e)
        {
            if (TAP_1.SelectedTab == tabPage1) {
                if (NuevaClaveI.Text == ConfirmarClaveII.Text)
                {
                    cambiarClave(NuevaClaveI.Text);

                    TAP_1.SelectTab(0);
                    NuevaClaveI.Text = "";
                    ConfirmarClaveII.Text = "";
                }
                else
                {
                    MessageBox.Show("La clave no coinciden. Por favor, intente de nuevo.",
                        "Cambio De Clave", MessageBoxButtons.OK);
                    NuevaClaveI.Text = "";
                    ConfirmarClaveII.Text = "";
                }

            } else
            {
                MessageBox.Show("¡ACCIÓN INVÁLIDA!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                NuevaClaveI.Text = "";
                ConfirmarClaveII.Text = "";
            }
         
        }

        private void BttConsultaSaldo_Click(object sender, EventArgs e)
        {
            BOXSaldo.Text = Convert.ToString(cli.Saldo);
            TAP_1.SelectTab(1);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TAP_1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        //-------------------{metodos cajero}---------------------------------------------------------------------------------------------------------------
        public void consultar()
        {

            foreach (cliente clienteItem in tran.Cli) {
                BOXSaldo.Text = Convert.ToString(clienteItem.Saldo);
            }

        }

        public void pdfReporte() {
            DateTime fecha = DateTime.Now;

            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(cli.NIdentificacion1+".pdf",
                                        FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("PRUEBA REPORTE No.XXX-XXX");
            doc.AddCreator("JUAN JARABA & ANDRÉS ANGULO");

            // Abrimos el archivo
            doc.Open();
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"LOGO.png");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_LEFT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);
            // Insertamos la imagen en el documento
            doc.Add(imagen);

         
           

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, 
                BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("\n"+""
                +"\nTRANSACCIÓN RETIRO CUENTA No."+cli.Nºcuenta1+"                     -                   "+fecha));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla 
            PdfPTable tblMovimiento = new PdfPTable(4);
            tblMovimiento.WidthPercentage = 90;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("NOMBRE", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.50f;

            PdfPCell clCuenta = new PdfPCell(new Phrase("N° Cuenta", _standardFont));
            clCuenta.BorderWidth = 0;
            clCuenta.BorderWidthBottom = 0.50f;

            PdfPCell clMonto = new PdfPCell(new Phrase("MONTO RET.", _standardFont));
            clCuenta.BorderWidth = 0;
            clCuenta.BorderWidthBottom = 0.50f;

            PdfPCell clSald = new PdfPCell(new Phrase("SALDO", _standardFont));
            clSald.BorderWidth = 0;
            clSald.BorderWidthBottom = 0.50f;

            // Añadimos las celdas a la tabla
            tblMovimiento.AddCell(clNombre);
            tblMovimiento.AddCell(clCuenta);
            tblMovimiento.AddCell(clMonto);
            tblMovimiento.AddCell(clSald);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase(cli.Nombre, _standardFont));
            clNombre.BorderWidth = 0;

            clCuenta = new PdfPCell(new Phrase(cli.Nºcuenta1.Substring(0, 4), _standardFont));
            clCuenta.BorderWidth = 0;

            clMonto = new PdfPCell(new Phrase("$"+VR, _standardFont));
            clMonto.BorderWidth = 0;

            clSald = new PdfPCell(new Phrase("$"+cli.Saldo, _standardFont));
            clSald.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblMovimiento.AddCell(clNombre);
            tblMovimiento.AddCell(clCuenta);
            tblMovimiento.AddCell(clMonto);
            tblMovimiento.AddCell(clSald);

            doc.Add(tblMovimiento);

            doc.Close();
            writer.Close();
        }
                  
    public void retirar(double cant)
        {
            
             double saldo = cli.Saldo;
            double t;
            if (cant <= saldo)
            {
                VR = cant;
                 t = saldo - cant;
                cli.Saldo = t;
                BOXSaldo.Text = Convert.ToString(cli.Saldo);
                //DESDE AQUI ---PDF
                
                  if (TAP_1.SelectedTab == tabPage4) {

                    ret.ShowDialog();



                    if (MessageBox.Show("¿Desea generar comprobante?","AVISO",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MODIf_Saldo(cli.Saldo);

                        pdfReporte();
                    }
                    else
                    {
                         
                        
                        MessageBox.Show("ID cajero: " + tran.Caj.IdCajero + "\nNo. Documento: " + cli.NIdentificacion1 +
                       "\nNombre Completo: " + cli.Nombre + "\nNo. Cuenta: **** **** **** " + cli.Nºcuenta1.Substring(0, 4) + " " +
                       "\nSaldo actual: $ " + cli.Saldo, "Retiro de Dinero", MessageBoxButtons.OK);

                        MODIf_Saldo(cli.Saldo);


                        
                        
                        
                    }
                }
                else if(TAP_1.SelectedTab == tabPage7)
                {
                    MessageBox.Show("PAGO DE SERVICIO\n" + "\nID cajero: " + tran.Caj.IdCajero + "\nNo. Documento: " + cli.NIdentificacion1 +
                                           "\nNombre Completo: " + cli.Nombre + "\nNo. Cuenta: **** **** **** " + cli.Nºcuenta1.Substring(0, 4) +
                                           " " +"\nServicio: "+NameSERVI+ "\nNo. Referencia: " +NUMReferencia.Text+ "\nValor Pagado: "+VALORSERVI.Text + 
                                           "\nSaldo actual: $ " + cli.Saldo);
                    MODIf_Saldo(cli.Saldo);
                    TAP_1.SelectTab(0);
                }
            
            }
            else
            {
                MessageBox.Show("Fondos Insuficientes", "Advertencia", MessageBoxButtons.OK);
                TAP_1.SelectTab(0);
            }
            
        }
        public void depositar(double cant)
        {

            double saldo = cli.Saldo;
            double t;
            t = saldo + cant;
            cli.Saldo = t;
            BOXSaldo.Text = Convert.ToString(cli.Saldo);
            TAP_1.SelectTab(0);
            MODIf_Saldo(cli.Saldo);
            MessageBox.Show("Transacción exitosa.", "Depositar Dinero", MessageBoxButtons.OK);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------

        public void Btn20000_Click(object sender, EventArgs e)
        {
            retirar(20000);
           
            TAP_1.SelectTab(0);
        }

        private void Btn100000_Click(object sender, EventArgs e)
        {
            retirar(100000);
           
            TAP_1.SelectTab(0);
        }

        private void Btn300000_Click(object sender, EventArgs e)
        {
            retirar(300000);
            
            TAP_1.SelectTab(0);
        }

        private void Btn600000_Click(object sender, EventArgs e)
        {
            retirar(600000);
          
            TAP_1.SelectTab(0);
        }

        private void Btn50000_Click(object sender, EventArgs e)
        {
            retirar(50000);
            
            TAP_1.SelectTab(0);
        }

        private void Btn200000_Click(object sender, EventArgs e)
        {
           
            retirar(200000);
            TAP_1.SelectTab(0);

        }

        private void Btn400000_Click(object sender, EventArgs e)
        {
            retirar(400000);
          
            TAP_1.SelectTab(0);
        }

        public void OtraCant_Click(object sender, EventArgs e)
        {
            
            try
           {
                string OtherValue = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad que desea retirar",
                    "Retirar Dinero", "0");
               double VALUE = Double.Parse(OtherValue);
             
                if (VALUE % 10000   == 0)
                {
                    retirar(VALUE);
                    TAP_1.SelectTab(0);
                }else
                {
                    MessageBox.Show("¡VALOR INVÁLIDO!");
                }
            }
           catch (Exception)
            {
                 MessageBox.Show("¡VALOR INVÁLIDO!");
            }
        }

        private void BttRetirar_Click(object sender, EventArgs e)
        {
            TAP_1.SelectTab(2);
        }
       

        private void regresar_Click(object sender, EventArgs e)
        {
            TAP_1.SelectTab(1);
        }

        private void atras1_Click(object sender, EventArgs e)
        {
            TAP_1.SelectTab(0);
        }

        private void NumCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BOXSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consignar_Click(object sender, EventArgs e)
        {
            try
            {
                string OtherValue = Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad que desea depositar", "Depositar Dinero", "0");
                double VALUE = Double.Parse(OtherValue);
                depositar(VALUE);
            }
            catch (Exception)
            {
                MessageBox.Show("¡VALOR INVÁLIDO!");
            }
        }
       

        private void buttCambioClave_Click(object sender, EventArgs e)
        {
            TAP_1.SelectTab(3);
        }

     
        public void cambiarClave(string n)
        {
            string[] campo = new string[5];
            StreamWriter escri;
            StreamReader leer;
            escri = File.CreateText("temp.txt");
            leer = File.OpenText("clientes.txt");
            string linea = leer.ReadLine();
          


            while (linea != null)
            {

                campo = linea.Split(',');

                if (cli.Clave == campo[1])
                {

                    escri.WriteLine(cli.Nºcuenta1 + "," + n + "," + cli.NIdentificacion1 + "," + cli.Nombre + "," + cli.Saldo);
                }
                else
                {
                    escri.WriteLine(linea);
                }
                linea = leer.ReadLine();
            }


            escri.Close();
            leer.Close();

            File.Delete("clientes.txt");
            File.Move("temp.txt", "clientes.txt");
            MessageBox.Show("¡Su clave se cambió con éxito!");
        }

        public void MODIf_Saldo(double cant) {

            string[] campo = new string[5];
            StreamWriter escri;
            StreamReader leer;
            escri = File.CreateText("temp.txt");
            leer = File.OpenText("clientes.txt");
            string linea = leer.ReadLine();

        
           

                while (linea != null)
                {

                    campo = linea.Split(',');

                    if (cli.Clave == campo[1])
                    {

                        escri.WriteLine(cli.Nºcuenta1 + "," + cli.Clave + "," + cli.NIdentificacion1 + "," + cli.Nombre + "," + cant);
                    }
                    else
                    {
                        escri.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                
            }

            escri.Close();
            leer.Close();

            File.Delete("clientes.txt");
            File.Move("temp.txt", "clientes.txt");
           

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void buttPagoServicios_Click(object sender, EventArgs e)
        {
            TAP_1.SelectTab(4);

        }
        string NameSERVI="";
        private void buttonAGUA_GAS_Click(object sender, EventArgs e)
        {
            NameSERVI ="01-AGUA-GAS-LUZ";
            TAP_1.SelectTab(5);
        }

        private void buttonTELEFONIA_Click(object sender, EventArgs e)
        {
            NameSERVI = "02-TELEFONIA";
            TAP_1.SelectTab(5);
        }

        private void buttonOPERADORTV_Click(object sender, EventArgs e)
        {
            NameSERVI = "03-OPERADOR-TV";
            TAP_1.SelectTab(5);
        }

        private void buttonINTERNET_Click(object sender, EventArgs e)
        {
            NameSERVI = "04-INTERNET";
            TAP_1.SelectTab(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NUMReferencia.Text != "")
            {
                TAP_1.SelectTab(6);
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "WARNING!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Valor = Convert.ToDouble(VALORSERVI.Text);

            if (Convert.ToDouble(VALORSERVI.Text) >= 1000 && Convert.ToDouble(VALORSERVI.Text) <= 2999000)
            {
                if (Valor <= cli.Saldo)
                {
                    retirar(Valor);


                    NUMReferencia.Text = "";
                    VALORSERVI.Text = "";
                }
                else
                {
                    MessageBox.Show("FONDOS INSUFICIENTES", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("VALOR NO VALIDO", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void regre_Click(object sender, EventArgs e)
        {
            TAP_1.SelectTab(0);
        }

     
        private void button4_Click(object sender, EventArgs e)
        {

            if (Valor_TRAsDES.Text != "" && Convert.ToDouble(Valor_TRAsDES.Text) <= 2999000 && Convert.ToDouble(Valor_TRAsDES.Text) >= 1000)
            {


                double valordes = Convert.ToDouble(Valor_TRAsDES.Text);
                double n;
                n = saldo_DES + valordes;
                saldo_DES = n;
                updateCli2(saldo_DES);


                double t;
                t = cli.Saldo - valordes;
                cli.Saldo = t;
                BOXSaldo.Text = Convert.ToString(cli.Saldo);
                MODIf_Saldo(t);



                MessageBox.Show("Transferenia Completada", "Transferencia", MessageBoxButtons.OK);

                TAP_1.SelectTab(0);
            }else
            {
                

                
                MessageBox.Show("Valor No valido", "Transferencia", MessageBoxButtons.OK);
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (No_CUentaDES.Text != "")
            {
                VERIfdato();
            }
        }

        private void NuevaClaveI_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaClaveI_Enter(object sender, EventArgs e)
        {
            if (NuevaClaveI.Text == "Ingrese nuevo PIN")
            {
                NuevaClaveI.Text = "";              
                NuevaClaveI.UseSystemPasswordChar = true;

            }
        }

        private void NuevaClaveI_Leave(object sender, EventArgs e)
        {
            if (NuevaClaveI.Text == "")
            {
                NuevaClaveI.Text = "Ingrese nuevo PIN";
                NuevaClaveI.UseSystemPasswordChar = false;

            }
        }

        private void ConfirmarClaveII_Enter(object sender, EventArgs e)
        {
            if (ConfirmarClaveII.Text == "Confirme PIN")
            {
                ConfirmarClaveII.Text = "";
                ConfirmarClaveII.UseSystemPasswordChar = true;

            }
        }

        private void ConfirmarClaveII_Leave(object sender, EventArgs e)
        {
            if (ConfirmarClaveII.Text == "")
            {
                ConfirmarClaveII.Text = "Confirme PIN";
                ConfirmarClaveII.UseSystemPasswordChar = false;

            }


        }

        private void BOTON_1_Click(object sender, EventArgs e)
        {
    
            retirar(20000);

            TAP_1.SelectTab(0);
        }

        private void BOTON_5_Click(object sender, EventArgs e)
        {
            retirar(50000);

            TAP_1.SelectTab(0);
        }

        private void BOTON_2_Click(object sender, EventArgs e)
        {
            retirar(100000);

            TAP_1.SelectTab(0);
        }

        private void BOTON_6_Click(object sender, EventArgs e)
        {
            retirar(200000);

            TAP_1.SelectTab(0);
        }

        private void BOTON_3_Click(object sender, EventArgs e)
        {
            retirar(300000);

            TAP_1.SelectTab(0);
        }

        private void BOTON_7_Click(object sender, EventArgs e)
        {
            retirar(400000);

            TAP_1.SelectTab(0);
        }

        private void BOTON_4_Click(object sender, EventArgs e)
        {
            retirar(600000);

            TAP_1.SelectTab(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cajero ATM - Banco de Bogotá "+"\nVersión 4.0.1"+"\nANDRÉS ANGULO -- JUAN JARABA"+
                "\nP.C.A  2020");
        }

        private void BOTON_8_Click(object sender, EventArgs e)
        {
            try
            {
                string OtherValue = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad que desea retirar",
                    "Retirar Dinero", "0");
                double VALUE = Double.Parse(OtherValue);
                retirar(VALUE);
                TAP_1.SelectTab(0);
            }
            catch (Exception)
            {
                MessageBox.Show("¡VALOR INVÁLIDO!");
            }
        
    }

        private void buttTransferencia_Click(object sender, EventArgs e)
        {
            TAP_1.SelectTab(7);
        }

        public void VERIfdato()
        {
           StreamReader leer = File.OpenText("clientes.txt");
            string linea = leer.ReadLine();
            Boolean dato = false;

            try
            {
               
                    while (dato == false && linea != null)
                    {


                        string[] campo = new string[5];
                        campo = linea.Split(',');
                        NoCuentaDES = campo[0];
                        claveDES = campo[1];
                        Nidenti_DES = campo[2];
                        nombre_DES = campo[3];
                        saldo_DES = double.Parse(campo[4]);



                        if (NoCuentaDES == No_CUentaDES.Text)
                        {

                            dato = true;
                            TAP_1.SelectTab(8);
                        }


                        linea = leer.ReadLine();

                    }
                if (dato == false)
                {
                    MessageBox.Show("Cuenta No Encontrada, Intente De Nuevo", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {

            }
            leer.Close();
        }

        public void updateCli2(double newsal)
        {
           
            
            StreamWriter escri;
            StreamReader leer;
            escri = File.CreateText("temp.txt");
            leer = File.OpenText("clientes.txt");
            string linea = leer.ReadLine();




            while (linea != null)
            {
                string[] campo = new string[5];
                campo = linea.Split(',');
              
              
              

                if (No_CUentaDES.Text == campo[0])
                {
                    
                    escri.WriteLine(NoCuentaDES + "," + claveDES + "," + Nidenti_DES + "," + nombre_DES + "," + newsal);
                }
                else
                {
                    escri.WriteLine(linea);
                }
                linea = leer.ReadLine();
            }
            escri.Close();
            leer.Close();

            File.Delete("clientes.txt");
            File.Move("temp.txt", "clientes.txt");
        }
    }

}
