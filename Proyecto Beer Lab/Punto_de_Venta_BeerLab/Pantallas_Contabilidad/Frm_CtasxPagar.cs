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
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();

            Lbl_Fecha.Text = DateTime.Now.Date.ToShortDateString().ToString();

            DataLoad();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Cuenta_Pagar.Text))
            {
                Dgv_CuentaPagar.DataSource = bl.FiltrarCuentasCobrar(Convert.ToInt32(Txt_Cuenta_Pagar.Text));
            }
            else
            {
                MessageBox.Show("No se pudo realizar la búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        public void DataLoad()
        {
            Dgv_CuentaPagar.DataSource = bl.MostrarCuentasCobrar();
            Txt_Cuenta_Pagar.Text = "";
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Contabilidad WindowsViewer = new Form_Menu_Contabilidad(bl);
            WindowsViewer.Show();
        }

    }

}
