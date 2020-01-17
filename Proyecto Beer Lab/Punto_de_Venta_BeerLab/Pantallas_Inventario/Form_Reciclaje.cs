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

namespace Punto_de_Venta_BeerLab.UI.Pantallas_Inventario
{
    public partial class Form_Reciclaje : Form
    {
        BussinesLayer bl;
        public Form_Reciclaje()
        {
            InitializeComponent();
        }

        public Form_Reciclaje(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Reciclaje_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Administrador")
            {
                this.Dispose();
                Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
                fma.Show();
            }
            if (label1.Text == "Vendedor")
            {
                this.Dispose();
                Form_Menu_Ventas fmv = new Form_Menu_Ventas(bl);
                fmv.Show();
            }
        }
    }
}
