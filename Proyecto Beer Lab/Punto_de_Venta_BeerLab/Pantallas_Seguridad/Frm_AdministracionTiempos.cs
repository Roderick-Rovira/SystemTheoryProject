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

namespace Punto_de_Venta_BeerLab.UI.Pantallas_Seguridad
{
    public partial class Frm_AdministracionTiempos : Form
    {
        BussinesLayer bl;

        public Frm_AdministracionTiempos()
        {
            InitializeComponent();
        }

        public Frm_AdministracionTiempos(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Frm_AdministracionTiempos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }



        private void Btn_EstablecerTiempo_Click(object sender, EventArgs e)
        {

        }

        // Método para validar si el usuario existe, y traer los datos en caso de que así sea. 

        private void Txt_IdentificacionUsuario_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(bl.IdNumberExist(Txt_IdentificacionUsuario.Text))))
            {
                Txt_NombreUsuario.Text = "";
                Txt_TiempoSesion.Text = "";
                Cmb_TiempoAsignado.SelectedItem = 0;
            }
            else
            {
                Txt_NombreUsuario.Text = bl.IdNumberExist(Txt_IdentificacionUsuario.Text).Nombre;
                Txt_TiempoSesion.Text = bl.IdNumberExist(Txt_IdentificacionUsuario.Text).Apellido1;
            }

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Seguridad WindowView = new Form_Menu_Seguridad(bl);
            WindowView.Show();
        }

    }
}
