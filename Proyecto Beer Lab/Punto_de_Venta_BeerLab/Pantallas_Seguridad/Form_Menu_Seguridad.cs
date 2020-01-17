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
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Pantallas_Seguridad.Frm_Login WindowViewer = new Pantallas_Seguridad.Frm_Login(bl);
            WindowViewer.Show();
        }

        private void Btn_PermisosXModulo_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Pantallas_Seguridad.Frm_PermisosXModulo WindowViewer = new Pantallas_Seguridad.Frm_PermisosXModulo(bl);
            WindowViewer.Show();
        }

        private void Btn_AdministracionTiempo_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Pantallas_Seguridad.Frm_AdministracionTiempos WindowViewer = new Pantallas_Seguridad.Frm_AdministracionTiempos(bl);
            WindowViewer.Show();
        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
            fma.Show();
        }

        private void Form_Menu_Seguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
