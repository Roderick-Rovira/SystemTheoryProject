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
    public partial class Form_Mantenimiento_Descuentos_Estandar : Form
    {
        #region Header:

        int id;
        BussinesLayer bl;
        public Form_Mantenimiento_Descuentos_Estandar()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_Descuentos_Estandar(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        #endregion

        #region Events:

        private void Form_Mantenimiento_Descuentos_Estandar_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarDatos();
        }

        private void Form_Mantenimiento_Descuentos_Estandar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Monto.Text) || String.IsNullOrEmpty(Txt_Min.Text) || String.IsNullOrEmpty(Txt_Max.Text) || String.IsNullOrEmpty(Cmb_DiaDescuento.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!String.IsNullOrEmpty(Convert.ToString(bl.StandarDiscountExists(Convert.ToInt32(Txt_Min.Text), Convert.ToInt32(Txt_Max.Text), Cmb_DiaDescuento.SelectedItem.ToString()))))
            {
                MessageBox.Show("Ya existe un descuento con estos parámetros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Desea agregar el descuento estándar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha agredado el descuento estándar exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.AgregarDescuentos_Estandar(int.Parse(Txt_Min.Text), Convert.ToInt32(Txt_Max.Text), int.Parse(Txt_Monto.Text), Cmb_DiaDescuento.SelectedItem.ToString());
                CargarDatos();
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Monto.Text) || String.IsNullOrEmpty(Txt_Min.Text) || String.IsNullOrEmpty(Txt_Max.Text) || String.IsNullOrEmpty(Cmb_DiaDescuento.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (id == 0)
            {
                MessageBox.Show("Debe seleccionar un descuentos estándar antes de poder continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Desea agregar el descuento estándar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha agredado el descuento estándar exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.ModificarDescuentos_Estandar(id, int.Parse(Txt_Min.Text), Convert.ToInt32(Txt_Max.Text), int.Parse(Txt_Monto.Text), Cmb_DiaDescuento.SelectedItem.ToString());
                CargarDatos();
            }
        }

        private void Dgv_Listar_Descuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {

                    id = int.Parse(dataGridView1.CurrentRow.Cells["Id_DescEstandar"].Value.ToString());

                    Txt_Min.Text = dataGridView1.CurrentRow.Cells["Cant_unidades"].Value.ToString();
                    Txt_Monto.Text = dataGridView1.CurrentRow.Cells["Descuento"].Value.ToString();
                    Cmb_DiaDescuento.Text = dataGridView1.CurrentRow.Cells["Dia"].Value.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        #endregion

        #region Methods:
        public void CargarDatos()
        {
            dataGridView1.DataSource = bl.MostrarDescuentos_Estandar();
        }

        #endregion

    }
}
