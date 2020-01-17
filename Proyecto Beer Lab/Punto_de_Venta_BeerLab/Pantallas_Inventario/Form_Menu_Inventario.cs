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
using Punto_de_Venta_BeerLab.UI.Pantallas_Inventario;

namespace Punto_de_Venta_BeerLab.UI
{
    public partial class Form_Menu_Inventario : Form
    {
        BussinesLayer bl;
        public Form_Menu_Inventario()
        {
            InitializeComponent();
        }

        public Form_Menu_Inventario(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Ordenes_Fabricacion Form_Ordenes = new Frm_Ordenes_Fabricacion(bl);
            Form_Ordenes.Show();
        }

        private void Form_Menu_Inventario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Ubicacciones form_Ubicacciones = new Form_Ubicacciones(bl);
            form_Ubicacciones.Show();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Reciclaje form_Reciclaje = new Form_Reciclaje(bl);
            form_Reciclaje.Show();
        }
    }
}
