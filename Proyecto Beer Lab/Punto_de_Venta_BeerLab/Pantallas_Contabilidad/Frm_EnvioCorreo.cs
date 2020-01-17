using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_de_Venta_BeerLab.BL;
using System.Windows.Forms;

namespace Punto_de_Venta_BeerLab.UI
{
    public partial class Frm_EnvioCorreo : Form
    {

        BussinesLayer bl;

        public Frm_EnvioCorreo()
        {
            InitializeComponent();
        }

        public Frm_EnvioCorreo(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Frm_EnvioCorreo_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        

        private void Btn_AdjuntarArchivo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EnviarCorreo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Contabilidad WindowsViewer = new Form_Menu_Contabilidad(bl);
            WindowsViewer.Show();
        }
    }
}
