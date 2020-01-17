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
    public partial class Frm_ReporteCuentasCobrar : Form
    {
        public Frm_ReporteCuentasCobrar()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EnviarReporte_Click(object sender, EventArgs e)
        {
            Frm_EnvioCorreo WindowViewer = new Frm_EnvioCorreo();
            WindowViewer.Show();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_CtasxCobrar WindowsViwer = new Frm_CtasxCobrar();
            WindowsViwer.Show();
        }
    }
}
