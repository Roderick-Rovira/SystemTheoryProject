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
    public partial class Form_Mantenimientos_Devoluciones : Form
    {
        BussinesLayer bl;
        public Form_Mantenimientos_Devoluciones()
        {
            InitializeComponent();
        }

        public Form_Mantenimientos_Devoluciones(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Mantenimientos_Devoluciones_Load(object sender, EventArgs e)
        {

        }

        private void Form_Mantenimientos_Devoluciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
