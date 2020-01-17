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
    public partial class Form_Mantenimiento_DescuentosVIP : Form
    {

        #region Header:

        int id;
        BussinesLayer bl;
        public Form_Mantenimiento_DescuentosVIP()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_DescuentosVIP(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        #endregion

        #region Events: 

        private void Form_Mantenimiento_DescuentosVIP_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Dgv_Listar_Descuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_Lista_Descuentos.SelectedRows.Count > 0)
            {
                try
                {

                    id = int.Parse(Dgv_Lista_Descuentos.CurrentRow.Cells["Id_DescVIP"].Value.ToString());

                    Txt_Valor_Descuentos.Text = Dgv_Lista_Descuentos.CurrentRow.Cells["Descuento"].Value.ToString();
                    Txt_Equivalencia_Puntos.Text = Dgv_Lista_Descuentos.CurrentRow.Cells["Puntos"].Value.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Equivalencia_Puntos.Text) || String.IsNullOrEmpty(Txt_Valor_Descuentos.Text))
            {
                MessageBox.Show("Algunos campos se encuentra vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!String.IsNullOrEmpty(Convert.ToString(bl.VIPDiscountExists(Convert.ToInt32(Txt_Valor_Descuentos.Text), Convert.ToInt32(Txt_Equivalencia_Puntos.Text)))))
            {
                MessageBox.Show("Ya existe un descuento con estos parámetros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Desea agregar el descuento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha agregado el descuento exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.AgregarDescuentosVIP(int.Parse(Txt_Valor_Descuentos.Text), int.Parse(Txt_Equivalencia_Puntos.Text));
                CargarDatos();
                id = 0;
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Equivalencia_Puntos.Text) || String.IsNullOrEmpty(Txt_Valor_Descuentos.Text))
            {
                MessageBox.Show("Algunos campos se encuentra vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (id == 0)
            {
                MessageBox.Show("Debe seleccionar un descuento antes de poder modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Desea modifcar el descuento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha modificado el descuento exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.ModificarDescuentosVIP(id, int.Parse(Txt_Valor_Descuentos.Text), int.Parse(Txt_Equivalencia_Puntos.Text));
                CargarDatos();
            }
        }

        //Modify this later.

        private void Btn_Activar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Equivalencia_Puntos.Text) || String.IsNullOrEmpty(Txt_Valor_Descuentos.Text))
            {
                MessageBox.Show("Algunos campos se encuentra vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (id == 0)
            {
                MessageBox.Show("Debe seleccionar un descuento antes de poder modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Desea activar el descuento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha activado el descuento exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.ChangeVIPDiscountState(id, "1");
                CargarDatos();
            }
        }

        private void Btn_Desactivar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Equivalencia_Puntos.Text) || String.IsNullOrEmpty(Txt_Valor_Descuentos.Text))
            {
                MessageBox.Show("Algunos campos se encuentra vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (id == 0)
            {
                MessageBox.Show("Debe seleccionar un descuento antes de poder modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Desea desactivar el descuento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha desactivado el descuento exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.ChangeVIPDiscountState(id, "2");
                CargarDatos();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        private void Form_Mantenimiento_DescuentosVIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void OnlyNumberAllow_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Methods:

        public void CargarDatos()
        {
            Dgv_Lista_Descuentos.DataSource = bl.MostrarDescuentosVIP();
        }


        #endregion

    }
}
