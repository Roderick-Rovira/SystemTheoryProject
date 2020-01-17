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
    public partial class Form_Menu_Contabilidad : Form
    {

        BussinesLayer bl;
        public Form_Menu_Contabilidad()
        {
            InitializeComponent();
        }
        public Form_Menu_Contabilidad(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Menu_Contabilidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Form_Menu_Contabilidad_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void Btn_Cierre_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_CierreCaja View = new Frm_CierreCaja(bl);
            View.Show();
        }

        private void Btn_Ctascobrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_CtasxCobrar View = new Frm_CtasxCobrar(bl);
            View.Show();
        }

        private void Btn_Ctaspagar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_CtasxPagar View = new Frm_CtasxPagar(bl);
            View.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (bl.TipoUsuario().Equals("Administrador"))
            {
                this.Dispose();
                Form_Menu_Administrador WindowView = new Form_Menu_Administrador(bl);
                WindowView.Show();
            }
            else
            {
                this.Dispose();
                Form_IniciarSession WindowView = new Form_IniciarSession();
                WindowView.Show();
            }
        }
    }
}
