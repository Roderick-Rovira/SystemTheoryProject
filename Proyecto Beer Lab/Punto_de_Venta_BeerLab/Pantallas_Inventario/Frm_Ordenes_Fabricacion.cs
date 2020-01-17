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
    public partial class Frm_Ordenes_Fabricacion : Form
    {
        BussinesLayer bl;
        public Frm_Ordenes_Fabricacion()
        {
            InitializeComponent();
        }
        public Frm_Ordenes_Fabricacion(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Dgv_OrdenesFabricacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ValidarOrden()
        {
            
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Ordenes_Fabricacion_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            Dgv_OrdenesFabricacion.DataSource = bl.MostrarOrdenesFabricacion();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bl.TipoUsuario() == "Vendedor")
            {

                DialogResult opcion;
                opcion = MessageBox.Show("¿Esta seguro de que desea cerrar sesion?.", "¡Cerrar session!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {

                    this.Dispose();
                    Form_IniciarSession fi = new Form_IniciarSession(bl);
                    fi.Show();

                }
                else { }

            }

            if (bl.TipoUsuario() == "Administrador")
            {
                this.Dispose();
                Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
                fma.Show();



            }
        }
    }
}
