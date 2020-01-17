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
    public partial class Form_Menu_Ventas : Form
    {
        BussinesLayer bl;
        public Form_Menu_Ventas()
        {
            InitializeComponent();
        }

        public Form_Menu_Ventas(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Menu_Ventas_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Facturación fm = new Form_Facturación(bl);
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (bl.TipoUsuario() == "Vendedor")
            {

                DialogResult opcion;
                opcion = MessageBox.Show("¿Esta seguro de que desea cerrar sesion?.", "¡Cerrar session!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {

                    this.Dispose();
                    Form_IniciarSession fi = new Form_IniciarSession(bl);
                    fi.Show();

                }
                else { }
            }

            if (bl.TipoUsuario() == "Administrador")
            {
                this.Dispose();
                Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
                fma.Show();
            }
        }

        private void Btn_Devoluciones_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Pantallas_Facturacion.Frm_Devoluciones WindowsView = new Pantallas_Facturacion.Frm_Devoluciones(bl);
            WindowsView.Show();
        }

        private void Form_Menu_Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        
    }
}
