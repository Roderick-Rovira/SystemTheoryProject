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
        #region Header and Variables:

        int ID_Devolucion;

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

        #endregion

        #region Events:

        private void Dgv_Devoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_Devoluciones.SelectedRows.Count > 0)
            {
                try
                {
                    ID_Devolucion = Convert.ToInt32(Dgv_Devoluciones.CurrentRow.Cells["Id_Devolucion"].Value);
                    Txt_Razon.Text = Dgv_Devoluciones.CurrentRow.Cells["Razon_Devolucion"].Value.ToString();
                    Txt_Estado_Fisico.Text = Dgv_Devoluciones.CurrentRow.Cells["Estado_Fisico"].Value.ToString();
                    rtxt_Descripcion.Text = Dgv_Devoluciones.CurrentRow.Cells["Descripcion"].Value.ToString();
                    Txt_Estado_Inventario.Text = Dgv_Devoluciones.CurrentRow.Cells["Estado_Inventario"].Value.ToString();

                    if (Dgv_Devoluciones.CurrentRow.Cells["Id_Estado"].Value.ToString() == "1")
                    {
                        Txt_Estado.Text = "Activo";
                    }
                    else 
                    {
                        Txt_Estado.Text = "Inactivo";
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }

                Btn_Activar.Enabled = true;
                Btn_Desactivar.Enabled = false;

            }
        }
        private void Form_Mantenimientos_Devoluciones_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();

            Dgv_Devoluciones.DataSource = bl.Mostrar_Devoluciones();
        }
        private void Btn_Activar_Click(object sender, EventArgs e)
        {
            if (ID_Devolucion != 0)
            {
                bl.Activar_Devolución(ID_Devolucion);
                MessageBox.Show("Se ha activado la devolución", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("No se pudo activar este descuento","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Btn_Desactivar_Click(object sender, EventArgs e)
        {
            if (ID_Devolucion != 0)
            {
                bl.Desactivar_Devolución(ID_Devolucion);
                MessageBox.Show("Se ha desactivado la devolución", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo desactivar este descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos WindowView = new Form_Mantenimientos(bl);
            WindowView.Show();
        }
        private void Form_Mantenimientos_Devoluciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        #endregion
    }
}
