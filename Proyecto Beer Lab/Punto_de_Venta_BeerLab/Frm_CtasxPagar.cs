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
    public partial class Frm_CtasxPagar : Form
    {
        BussinesLayer bl;

        public Frm_CtasxPagar()
        {
            InitializeComponent();
        }

        public Frm_CtasxPagar(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Frm_CtasxPagar_Load(object sender, EventArgs e)
        {
           // Dgv_CuentaPagar.DataSource = bl.MostrarCuentasPagar();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Contabilidad WindowsViewer = new Form_Menu_Contabilidad();
            WindowsViewer.Show();
        }
    }

}
