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
            //Dgv_CierreCajas.DataSource = bl.MostrarCierreCajas(); -- Se necesita instrucción de Daniel para poder implementar estos procesos.
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GenerarReporte_Click(object sender, EventArgs e)
        {
            Frm_ReporteCierreCajas ViewWindow = new Frm_ReporteCierreCajas();
            ViewWindow.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Contabilidad WindowsViewer = new Form_Menu_Contabilidad();
            WindowsViewer.Show();

        }
    }
}
