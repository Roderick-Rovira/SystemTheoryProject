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
    
    public partial class Form_Menu_Administrador : Form
    {
        BussinesLayer bl;
        public Form_Menu_Administrador()
        {
            InitializeComponent();
        }

        public Form_Menu_Administrador(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }


        private void Form_Menu_Administrador_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Ventas fmv = new Form_Menu_Ventas(bl);
            fmv.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void Form_Menu_Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Seguridad fms = new Form_Menu_Seguridad(bl);
            fms.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Inventario Form_Menu_Inventario = new Form_Menu_Inventario(bl); 
            Form_Menu_Inventario.Show();

        }
    }
}
