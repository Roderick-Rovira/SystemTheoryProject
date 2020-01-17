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
    public partial class Frm_PermisosXModulo : Form
    {
        int id;
        int id2;
        int privilegio;
        BussinesLayer bl;

        public Frm_PermisosXModulo()
        {
            InitializeComponent();
        }

        public Frm_PermisosXModulo(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Frm_PermisosXModulo_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarData();
        }

        private void Dgv_ListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_ListaUsuarios.SelectedRows.Count > 0)
            {
                try
                {

                    id = int.Parse(Dgv_ListaUsuarios.CurrentRow.Cells["Id_usuario"].Value.ToString());
                    Txt_Identificiacion.Text = Dgv_ListaUsuarios.CurrentRow.Cells["Identificacion"].Value.ToString();
                    Txt_NombreUsuario.Text = Dgv_ListaUsuarios.CurrentRow.Cells["Nombre"].Value.ToString() + " " + Dgv_ListaUsuarios.CurrentRow.Cells["Apellido1"].Value.ToString() + " " + Dgv_ListaUsuarios.CurrentRow.Cells["Apellido1"].Value.ToString();
                    Cmb_Rol.Text = bl.TipoUsuario2(id);


                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cmb_Rol.Text == "Administrador")
            {
                privilegio = 1;
            }

            if (Cmb_Rol.Text == "Contabilidad")
            {
                privilegio = 2;

            }
            if (Cmb_Rol.Text == "Inventario")
            {
                privilegio = 3;
            }

            if (Cmb_Rol.Text == "Vendedor")
            {
                privilegio = 4;

            }
            if (Cmb_Rol.Text == "Sin Privilegios")
            {
                privilegio = 5;

            }

            bl.SetPrivilegio(id, privilegio);
            CargarData();
        }

        public void CargarData()
        {
            try
            {
                Dgv_ListaUsuarios.DataSource = bl.MostrarUsuariosStoreProcedure().ToList();

            }
            catch (Exception e)
            {
                Console.Write(e);
            }

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Seguridad fms = new Form_Menu_Seguridad(bl);
            fms.Show();
        }

        private void Frm_PermisosXModulo_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.ExitThread();   
        }

    }
}
