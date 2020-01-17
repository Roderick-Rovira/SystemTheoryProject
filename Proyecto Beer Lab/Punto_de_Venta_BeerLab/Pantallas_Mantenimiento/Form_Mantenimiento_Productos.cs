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
    public partial class Form_Mantenimiento_Productos : Form
    {
        #region Header

        BussinesLayer bl;
        public Form_Mantenimiento_Productos()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_Productos(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        #endregion

        #region Events:

        private void Form_Mantenimiento_Productos_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarDatos();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Cod_Producto.Text) || String.IsNullOrEmpty(Txt_Nombre_Producto.Text) || String.IsNullOrEmpty(Txt_Cantidad_Litros.Text) || String.IsNullOrEmpty(Txt_Stock_Ini.Text) || String.IsNullOrEmpty(Txt_Stock_Act.Text) || String.IsNullOrEmpty(Txt_Precio.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!String.IsNullOrEmpty(Convert.ToString(bl.ProductExists(Txt_Cod_Producto.Text))))
            {
                MessageBox.Show("El producto que está tratando de ingresar ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Dtp_Caducidad.Value.Date.CompareTo(Dtp_Emision.Value.Date.AddDays(15)) < 0)
            {
                MessageBox.Show("No se puede ingresar un producto que esté a quince días de su fecha de vencimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Desea agregar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("El producto fue agregado existosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DateTime FechaIngreso = DateTime.Now;
                int Estado = 1;
                string Descripcion = Txt_Nombre_Producto.Text + " " + Cmb_Tipo.SelectedItem.ToString();
                bl.AgregarProducto(Txt_Cod_Producto.Text, Txt_Nombre_Producto.Text, Cmb_Tipo.Text, Cmd_Fragilidad.Text, int.Parse(Txt_Cantidad_Litros.Text), int.Parse(Txt_Nivel_Alcohol.Text), decimal.Parse(Txt_Precio.Text), DateTime.Parse(Dtp_Emision.Text), DateTime.Parse(Dtp_Caducidad.Text), int.Parse(Txt_Stock_Ini.Text), int.Parse(Txt_Stock_Act.Text), FechaIngreso, Estado, Descripcion);
                CargarDatos();
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Cod_Producto.Text) || String.IsNullOrEmpty(Txt_Nombre_Producto.Text) || String.IsNullOrEmpty(Txt_Cantidad_Litros.Text) || String.IsNullOrEmpty(Txt_Stock_Ini.Text) || String.IsNullOrEmpty(Txt_Stock_Act.Text) || String.IsNullOrEmpty(Txt_Precio.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(Convert.ToString(bl.ProductExists(Txt_Cod_Producto.Text))))
            {
                MessageBox.Show("El producto que está tratando de modifciar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Desea modificar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("El producto fue modificado existosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DateTime FechaModificacion = DateTime.Now;
                string Descripcion;

                Descripcion = Txt_Nombre_Producto.Text + " " + Cmb_Tipo.SelectedItem.ToString();
                bl.ModificarProducto(Txt_Cod_Producto.Text, Txt_Nombre_Producto.Text, Cmb_Tipo.SelectedItem.ToString(), Cmd_Fragilidad.SelectedItem.ToString(), int.Parse(Txt_Cantidad_Litros.Text), int.Parse(Txt_Nivel_Alcohol.SelectedItem.ToString()), decimal.Parse(Txt_Precio.Text), DateTime.Parse(Dtp_Emision.Text), DateTime.Parse(Dtp_Caducidad.Text), int.Parse(Txt_Stock_Ini.Text), int.Parse(Txt_Stock_Act.Text), Descripcion, FechaModificacion);
                CargarDatos();
            }
        }

        private void Btn_Activar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Cod_Producto.Text) || String.IsNullOrEmpty(Txt_Nombre_Producto.Text) || String.IsNullOrEmpty(Txt_Cantidad_Litros.Text) || String.IsNullOrEmpty(Txt_Stock_Ini.Text) || String.IsNullOrEmpty(Txt_Stock_Act.Text) || String.IsNullOrEmpty(Txt_Precio.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(Convert.ToString(bl.ProductExists(Txt_Cod_Producto.Text))))
            {
                MessageBox.Show("El producto que está trantando de activar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Desea activar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("El producto fue activado existosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.ChangeProductState(Txt_Cod_Producto.Text, "1");
                CargarDatos();
            }
        }

        private void Btn_Desactivar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Cod_Producto.Text) || String.IsNullOrEmpty(Txt_Nombre_Producto.Text) || String.IsNullOrEmpty(Txt_Cantidad_Litros.Text) || String.IsNullOrEmpty(Txt_Stock_Ini.Text) || String.IsNullOrEmpty(Txt_Stock_Act.Text) || String.IsNullOrEmpty(Txt_Precio.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(Convert.ToString(bl.ProductExists(Txt_Cod_Producto.Text))))
            {
                MessageBox.Show("El producto que está trantando de desactivar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Desea desactivar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("El producto fue desactivado existosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bl.ChangeProductState(Txt_Cod_Producto.Text, "2");
                CargarDatos();
            }
        }

        private void Dtp_Emision_ValueChanged(object sender, EventArgs e)
        {
            Dtp_Caducidad.Value = Dtp_Emision.Value.Date.AddDays(15);
        }

        private void Dgv_Lista_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_Lista_Productos.SelectedRows.Count > 0)
            {
                try
                {

                    string id = Dgv_Lista_Productos.CurrentRow.Cells["Codigo"].Value.ToString();
                    Txt_Cod_Producto.Text = Dgv_Lista_Productos.CurrentRow.Cells["Codigo"].Value.ToString();
                    Txt_Nombre_Producto.Text = Dgv_Lista_Productos.CurrentRow.Cells["Nombre_producto"].Value.ToString();
                    Cmb_Tipo.Text = Dgv_Lista_Productos.CurrentRow.Cells["Tipo_envasado"].Value.ToString();
                    Cmd_Fragilidad.Text = Dgv_Lista_Productos.CurrentRow.Cells["Nivel_fragilidad"].Value.ToString();
                    Txt_Cantidad_Litros.Text = Dgv_Lista_Productos.CurrentRow.Cells["Cantidad_mililitros"].Value.ToString();
                    Txt_Nivel_Alcohol.Text = Dgv_Lista_Productos.CurrentRow.Cells["Nivel_Alcohol"].Value.ToString();
                    Txt_Precio.Text = Dgv_Lista_Productos.CurrentRow.Cells["Precio_producto"].Value.ToString();
                    Dtp_Emision.Text = Dgv_Lista_Productos.CurrentRow.Cells["Fecha_emision"].Value.ToString();
                    Dtp_Caducidad.Text = Dgv_Lista_Productos.CurrentRow.Cells["Fecha_caducidad"].Value.ToString();
                    Txt_Stock_Ini.Text = Dgv_Lista_Productos.CurrentRow.Cells["Stock_Inicial"].Value.ToString();
                    Txt_Stock_Act.Text = Dgv_Lista_Productos.CurrentRow.Cells["Stock_Actual"].Value.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información" + "Error: " + error);

                }
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        private void Form_Mantenimiento_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void OnlyNumbersAllowed_Click(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void OnlyLettersAllowed_Click(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        #endregion

        #region Methods:

        public void CargarDatos()
        {
            Dgv_Lista_Productos.DataSource = bl.MostrarProductos();
        }

        #endregion

    }
}
