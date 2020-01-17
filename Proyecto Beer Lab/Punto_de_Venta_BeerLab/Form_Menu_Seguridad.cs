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
    public partial class Form_Menu_Seguridad : Form
    {
        BussinesLayer bl;
        public Form_Menu_Seguridad()
        {
            InitializeComponent();
        }

        public Form_Menu_Seguridad(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Menu_Seguridad_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void Form_Menu_Seguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
            fma.Show();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Form_Mantenimiento_Usuarios WindowViewer = new Form_Mantenimiento_Usuarios();
            WindowViewer.Show();
        }
    }
}
