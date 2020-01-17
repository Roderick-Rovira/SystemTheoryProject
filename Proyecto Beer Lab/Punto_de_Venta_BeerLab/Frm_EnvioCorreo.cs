using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta_BeerLab.UI
{
    public partial class Frm_EnvioCorreo : Form
    {
        public Frm_EnvioCorreo()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Contabilidad WindowsViewer = new Form_Menu_Contabilidad();
            WindowsViewer.Show();
        }

        private void Btn_AdjuntarArchivo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EnviarCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
