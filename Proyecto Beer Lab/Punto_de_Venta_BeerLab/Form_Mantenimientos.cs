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
    public partial class Form_Mantenimientos : Form
    {
        BussinesLayer bl;
        public Form_Mantenimientos()
        {
            InitializeComponent();
        }

        public Form_Mantenimientos(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Mantenimientos_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void Form_Mantenimientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimiento_Clientes fmc = new Form_Mantenimiento_Clientes(bl);
            fmc.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
            fma.Show();
        }

        // ------------------------------------------------------------------------------------------------------------

        private void AccUsuarios_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimiento_Usuarios fmu = new Form_Mantenimiento_Usuarios(bl);
            fmu.Show();
        }

        private void AccProductos_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimiento_Productos fmp = new Form_Mantenimiento_Productos(bl);
            fmp.Show();
        }

        private void AccDescEst_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimiento_Descuentos_Estandar fmde = new Form_Mantenimiento_Descuentos_Estandar(bl);
            fmde.Show();
        }

        private void AccClientes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimiento_Clientes fmc = new Form_Mantenimiento_Clientes(bl);
            fmc.Show();
        }

        private void AccDevoluciones_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos_Devoluciones fmd = new Form_Mantenimientos_Devoluciones(bl);
            fmd.Show();
        }

        private void AccDescVIP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimiento_DescuentosVIP fmdvip = new Form_Mantenimiento_DescuentosVIP(bl);
            fmdvip.Show();
        }
    }
}
