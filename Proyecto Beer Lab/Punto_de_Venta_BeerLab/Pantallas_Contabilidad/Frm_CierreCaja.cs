using Punto_de_Venta_BeerLab.BL;
using System;
using System.Windows.Forms;


namespace Punto_de_Venta_BeerLab.UI
{
    public partial class Frm_CierreCaja : Form
    {
        BussinesLayer bl;

        public Frm_CierreCaja()
        {
            InitializeComponent();
        }

        public Frm_CierreCaja(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Frm_CierreCaja_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();

            Dgv_CierreCajas.DataSource = bl.MostrarCierreCajas();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GenerarReporte_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_ReporteCierreCajas ViewWindow = new Frm_ReporteCierreCajas(bl);
            ViewWindow.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Contabilidad WindowsViewer = new Form_Menu_Contabilidad(bl);
            WindowsViewer.Show();

        }
    }
}
