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
    public partial class Frm_ReporteCierreCajas : Form
    {

        BussinesLayer bl;

        public Frm_ReporteCierreCajas()
        {
            InitializeComponent();
        }

        public Frm_ReporteCierreCajas(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Frm_ReporteCierreCajas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void Btn_EnviarReporte_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_EnvioCorreo WindowViewer = new Frm_EnvioCorreo(bl);
            WindowViewer.Show();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_CierreCaja WindowsViwer = new Frm_CierreCaja(bl);
            WindowsViwer.Show();

        }

        
    }
}
