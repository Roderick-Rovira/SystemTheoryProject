using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_Venta_BeerLab.BL;

namespace Punto_de_Venta_BeerLab.UI
{

    public partial class Form_IniciarSession : Form
    {
        int intentos;
        BussinesLayer bl = new BussinesLayer();
        public Form_IniciarSession()
        {
            InitializeComponent();
        }

        public Form_IniciarSession(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }


        private void Form_IniciarSession_Load(object sender, EventArgs e)
        {

        }

        public void ValidarSession()
        {
            try
            {

                if (bl.IniciarSession(textBox1.Text, maskedTextBoxUsuario.Text) == true)
                {
                    this.Hide();
                    Form_Mensaje_de_Bienvenida fmb = new Form_Mensaje_de_Bienvenida(bl);
                    fmb.Show();

                    
                }

            }
            catch (Exception)
            {
                intentos++;
                DialogResult opcion;
                opcion = MessageBox.Show("El usuario o contraseña es incorrecto,asegúrese de ingresar correctamente la información de inicio de sesion", "Inicio de session erróneo", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }


        }

        public void SesionNoValida() 
        {

            if (intentos == 3)
            {

                DialogResult opcion;
                opcion = MessageBox.Show("Se ha alcanzado el número máximo de intentos para iniciar sesion.", "Cerrar Session", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                this.Close();

            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ValidarSession();
            SesionNoValida();
         
        }

        private void Form_IniciarSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
