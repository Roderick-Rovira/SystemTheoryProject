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
    public partial class Form_Mensaje_de_Bienvenida : Form
    {
        BussinesLayer bl;
        public Form_Mensaje_de_Bienvenida()
        {
            InitializeComponent();
        }

        public Form_Mensaje_de_Bienvenida(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Mensaje_de_Bienvenida_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = bl.Nombre_Usuario();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string TipoUsuario = bl.TipoUsuario();

            if (TipoUsuario == "Administrador") 
            {
                this.Hide();
                Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
                fma.Show();
            }

            if (TipoUsuario == "Contabilidad")
            {
                this.Hide();
                Form_Menu_Contabilidad fmc = new Form_Menu_Contabilidad(bl);
                fmc.Show();
            }


            if (TipoUsuario == "Vendedor")
            {
                this.Hide();
                Form_Menu_Ventas fmv = new Form_Menu_Ventas(bl);
                fmv.Show();
            }




        }
    }
}
