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

namespace Punto_de_Venta_BeerLab.UI.Pantallas_Facturacion
{

    public partial class Frm_Devoluciones : Form
    {
        #region Header and Variables:
        BussinesLayer bl;
        int ID_Product;
        int Numero_Detalle;
        int ID_Detalle;

        public Frm_Devoluciones()
        {
            InitializeComponent();
        }
        public Frm_Devoluciones(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }
        #endregion

        #region Events:

        private void Frm_Devoluciones_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();

            Cmb_Estado_Fisico.SelectedIndex = 0;
            Cmb_Estado_Inventario.SelectedIndex = 0;
            Cmb_Razon_Devolucion.SelectedIndex = 0;
        }
        private void Txt_Numero_Factura_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Numero_Factura.Text) || Txt_Numero_Factura.Text == "0")
            { return; }
            else
            {
                Txt_Numero_Identificacion.Text = bl.Mostrar_ClienteXNumero(bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Id_factura).Identificacion;
                Txt_Nombre_Cliente.Text = bl.Mostrar_ClienteXNumero(bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Id_factura).Nombre;
                Txt_Fecha_Emision.Text = (bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Fecha_venta.ToShortDateString().ToString());
                Dgv_Detalle_Factura.DataSource = bl.Mostrar_DetalleFacturaXNumero(bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Id_factura);
            }
        }
        private void Dgv_Detalle_Factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Product = 0;
            ID_Detalle = 0;

            if (Dgv_Detalle_Factura.SelectedRows.Count > 0)
            {
                try
                {
                    ID_Detalle = Convert.ToInt32(Dgv_Detalle_Factura.CurrentRow.Cells["Id_detalle_factura"].Value);
                    Txt_Numero_Factura.Text = Dgv_Detalle_Factura.CurrentRow.Cells["Id_factura"].Value.ToString();

                    Txt_Numero_Identificacion.Text = bl.Mostrar_ClienteXNumero(bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Id_factura).Identificacion;
                    Txt_Nombre_Cliente.Text = bl.Mostrar_ClienteXNumero(bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Id_factura).Nombre;
                    Txt_Fecha_Emision.Text = (bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Fecha_venta.Date.ToString());

                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
                Btn_Agregar.Enabled = true;
            }
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cmb_Razon_Devolucion.SelectedItem.ToString() == null || Cmb_Estado_Fisico.SelectedItem.ToString() == null || Cmb_Estado_Inventario.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Cmb_Estado_Fisico.SelectedItem.ToString().Equals("Producto en mal estado") && Cmb_Estado_Fisico.SelectedItem.ToString().Equals("Devolución de Efectivo"))
            {
                MessageBox.Show("No aplica para una devolución de efectivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Cmb_Estado_Fisico.SelectedItem.ToString().Equals("Producto en mal estado") && Cmb_Estado_Inventario.SelectedItem.ToString().Equals("Reintegrar en Inventario"))
            {
                MessageBox.Show("El producto no tiene las condiciones para ser incluido en el inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(Txt_Numero_Factura.Text) || String.IsNullOrEmpty(Txt_Numero_Identificacion.Text) || String.IsNullOrEmpty(Txt_Nombre_Cliente.Text) || String.IsNullOrEmpty(Txt_Fecha_Emision.Text) || String.IsNullOrEmpty(rtxt_Descripcion.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Desea ejecutar esta devolución", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bl.Insertar_Devolucion(Cmb_Razon_Devolucion.SelectedItem.ToString(), Cmb_Estado_Fisico.SelectedItem.ToString(), 0,Cmb_Estado_Inventario.SelectedItem.ToString(), rtxt_Descripcion.Text, Convert.ToInt32(Txt_Numero_Factura.Text), bl.Mostrar_ClienteXNumero(bl.Mostrar_FacturaXNumero(Convert.ToInt32(Txt_Numero_Factura.Text)).Id_factura).Id_cliente);
                
                MessageBox.Show("Se ha insertado la devolución exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (ID_Detalle == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para hacer la devolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Dgv_Articulos_Devolver.Rows[0].Cells[0].Value == null)
            {
                Numero_Detalle = Dgv_Articulos_Devolver.Rows.Count - 1;
            }
            else
            {
                Numero_Detalle = Numero_Detalle + 1;
            }

            Dgv_Articulos_Devolver.Rows.Add();
            Dgv_Articulos_Devolver.Rows[Numero_Detalle].Cells[0].Value = Numero_Detalle + 1;
            Dgv_Articulos_Devolver.Rows[Numero_Detalle].Cells[1].Value = bl.Obtener_Datos_DetalleFactura(Convert.ToInt32(ID_Detalle)).Descripcion_Producto;
            Dgv_Articulos_Devolver.Rows[Numero_Detalle].Cells[2].Value = bl.Obtener_Datos_DetalleFactura(Convert.ToInt32(ID_Detalle)).Codigo;
            Dgv_Articulos_Devolver.Rows[Numero_Detalle].Cells[3].Value = bl.Obtener_Datos_DetalleFactura(Convert.ToInt32(ID_Detalle)).Precio_unitario;
            Dgv_Articulos_Devolver.Rows[Numero_Detalle].Cells[4].Value = bl.Obtener_Datos_DetalleFactura(Convert.ToInt32(ID_Detalle)).Cantidad;

            Btn_Remover.Enabled = true;
            Btn_Guardar.Enabled = true;
        }
        private void Btn_Desactivar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.Dgv_Articulos_Devolver.SelectedRows)
                {
                    Dgv_Articulos_Devolver.Rows.RemoveAt(item.Index);

                    for (int i = Dgv_Articulos_Devolver.Rows.Count - 1; i > -1; i--)
                    {
                        DataGridViewRow row = Dgv_Detalle_Factura.Rows[i];
                        if (!row.IsNewRow && row.Cells[0].Value == null)
                        {
                            Dgv_Articulos_Devolver.Rows.RemoveAt(i);
                        }
                    }
                }

                if (Dgv_Articulos_Devolver.Rows.Count - 1 == 0)
                {
                    Btn_Guardar.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione la fila que desea remover haciendo click en la parte izquierda junto a el id");
            }
        }
        private void Txt_Numero_Factura_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Ventas WindowView = new Form_Menu_Ventas(bl);
            WindowView.Show();
        }
        #endregion

    }
}
