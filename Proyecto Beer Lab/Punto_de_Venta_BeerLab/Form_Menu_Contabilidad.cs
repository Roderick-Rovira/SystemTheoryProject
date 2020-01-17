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
        //comentario

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
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Administrador fma = new Form_Menu_Administrador();
            fma.Show();
        }

        private void Btn_Cierre_Click(object sender, EventArgs e)
        {
            Frm_CierreCaja View = new Frm_CierreCaja();
            View.Show();
        }

        private void Btn_Ctascobrar_Click(object sender, EventArgs e)
        {
            Frm_CtasxCobrar View = new Frm_CtasxCobrar();
            View.Show();
        }

        private void Btn_Ctaspagar_Click(object sender, EventArgs e)
        {
            Frm_CtasxPagar View = new Frm_CtasxPagar();
            View.Show();
        }
    }
}
