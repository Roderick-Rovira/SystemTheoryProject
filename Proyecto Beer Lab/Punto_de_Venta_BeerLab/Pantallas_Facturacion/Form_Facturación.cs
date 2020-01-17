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
    public partial class Form_Facturación : Form
    {
        #region Header and Variables:
        string tipoId;
        int NumeroFactura;
        decimal Precio;
        string Codigo;
        string DescProducto;
        string Tipo_Envase;


        // Variables para el detalle de factura.

        int Numero_Detalle;
        String Descripcion_Producto;
        String Codigo_Producto;
        String Precio_Unitario;
        String Cantidad;

        BussinesLayer bl;

        public Form_Facturación()
        {
            InitializeComponent();
        }

        public Form_Facturación(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        #endregion

        #region Events:
        private void Form_Facturación_Load(object sender, EventArgs e)
        {
            DeshabilitarComponentes();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            Cmb_Productos.DataSource = bl.InfoProductos();
            Cmb_Tipo_Pago.SelectedIndex = 0;
            Cmb_Tipo_Venta.SelectedIndex = 0;
            Cmb_Tipo_Envasado.SelectedIndex = 0;

            string Nombre_Producto = Cmb_Productos.SelectedItem.ToString();
            var Producto = bl.BuscarProductos_PorNombre(Nombre_Producto, Cmb_Tipo_Envasado.SelectedItem.ToString());
            Txt_Precio.Text = "₡" + Producto.Precio_producto.ToString();
        }
        private void Btn_Nueva_Factura_Click(object sender, EventArgs e)
        {

            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea generar una nueva factura?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (opcion == DialogResult.Yes)
            {
                NumeroFactura = bl.ObtenerUltimoNumero();
                Lbl_NumeroFactura.Text = NumeroFactura.ToString();
                DeshabilitarComponentes();
                HabilitarBusquedaCliente();
                Rdb_Cedula.Checked = true;
            }
        }
        private void Btn_Buscar_Cliente_Click(object sender, EventArgs e)
        {

            if (Rdb_Cedula.Checked)
            {
                tipoId = "Cédula";
            }
            if (Rdb_Dimex.Checked)
            {
                tipoId = "DIMEX";
            }
            if (Rdb_Pasaporte.Checked)
            {
                tipoId = "Pasaporte";
            }

            try
            {
                var Cliente = bl.BuscarCliente(Txt_Identificacion.Text, tipoId);
                lbl_Tipo_Cliente.Text = Cliente.Tipo_cliente;
                lbl_Nombre_Cliente.Text = Cliente.Nombre + " " + Cliente.Apellido1 + " " + Cliente.Apellido2;
                lbl_Numero_ID.Text = Cliente.Identificacion;
                lbl_Telefono.Text = Cliente.Telefono.ToString();
                lbl_Correo.Text = Cliente.Correo;

                if (!String.IsNullOrEmpty(Convert.ToString(bl.AdressExist(Cliente.Id_cliente))))
                {
                    lbl_Direccion.Text = bl.AdressExist(Cliente.Id_cliente).Dsc_direccion;
                }
                else
                {
                    lbl_Direccion.Text = "No tiene un dirección asignada";
                }
                lbl_Puntos_Acumulados.Text = Cliente.Puntos_acumulados.ToString();
                HabilitarBusquedaProductos();
                ValidarTipoUsuario();
                DialogResult opcion;
                opcion = MessageBox.Show("Búsqueda realizada correctamente.", "¡Cliente  encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Cantidad.Enabled = true;

                string Nombre_Producto = Cmb_Productos.SelectedItem.ToString();
                var Producto = bl.BuscarProductos_PorNombre(Nombre_Producto, Cmb_Tipo_Envasado.SelectedItem.ToString());
                Txt_Precio.Text = "₡" + Producto.Precio_producto.ToString();

                Codigo = Producto.Codigo;
                Precio = Producto.Precio_producto;
                DescProducto = Cmb_Productos.SelectedItem.ToString();

            }
            catch (Exception)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Asegúrese de haber seleccionado el tipo correcto de identificación y de haber introducido el número de identificación correctamente.", "¡Cliente no encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
        private void Cmb_Productos_Click(object sender, EventArgs e)
        {
            
            string Nombre_Producto = Cmb_Productos.SelectedItem.ToString();
            var Producto = bl.BuscarProductos_PorNombre(Nombre_Producto, Cmb_Tipo_Envasado.SelectedItem.ToString());
            Txt_Precio.Text = "₡" + Producto.Precio_producto.ToString();
            Txt_Cantidad.Enabled = true;
            Btn_Agregar.Enabled = true;
            Codigo = Producto.Codigo;
            Precio = Producto.Precio_producto;
            DescProducto = Cmb_Productos.SelectedItem.ToString();

        }
        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(Txt_Cantidad.Text) || Convert.ToInt32(Txt_Cantidad.Text) < 1)
                {
                    MessageBox.Show("Debe seleccionar una cantidad antes de poder ingresar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    
                    string Nombre_Producto = Cmb_Productos.SelectedItem.ToString();
                    var Producto = bl.BuscarProductos_PorNombre(Nombre_Producto, Cmb_Tipo_Envasado.SelectedItem.ToString());

                    if (Dgv_Detalle_Factura.Rows[0].Cells[0].Value == null)
                    {
                        NumeroFactura = Dgv_Detalle_Factura.Rows.Count - 1;
                    }
                    else 
                    {
                        NumeroFactura = NumeroFactura + 1;
                    }
                    
                    Dgv_Detalle_Factura.Rows.Add();
                    Dgv_Detalle_Factura.Rows[Numero_Detalle].Cells[0].Value = Numero_Detalle+1;
                    Dgv_Detalle_Factura.Rows[Numero_Detalle].Cells[1].Value = Producto.Descripcion_producto;
                    Dgv_Detalle_Factura.Rows[Numero_Detalle].Cells[2].Value = Producto.Codigo;
                    Dgv_Detalle_Factura.Rows[Numero_Detalle].Cells[3].Value = Producto.Precio_producto;
                    Dgv_Detalle_Factura.Rows[Numero_Detalle].Cells[4].Value = Txt_Cantidad.Text;
                    
                    
                    SumarProductos();   // -- Aquí se está haciendo la sumatoria de la cantidad de productos que van a ser comprados.
                    ActualizarMonto();  // -- Aquí se está calculando el monto a pagar por el cliente (VIP o Estándar)

                    #region Habilitar Componentes

                    Txt_Cantidad.Text = "";
                    Cmb_Tipo_Pago.Enabled = true;
                    Cmb_Tipo_Venta.Enabled = true;
                    Btn_Remover.Enabled = true;
                    Dgv_Detalle_Factura.Enabled = true;
                    Btn_Facturar.Enabled = true;

                    #endregion

                    for (int i = Dgv_Detalle_Factura.Rows.Count - 1; i > -1; i--)
                    {
                        DataGridViewRow row = Dgv_Detalle_Factura.Rows[i];
                        if (!row.IsNewRow && row.Cells[0].Value == null)
                        {
                            Dgv_Detalle_Factura.Rows.RemoveAt(i);
                        }
                    }

                    Numero_Detalle++;
                }
            }
            catch (Exception)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Debe buscar e ingresar una cantidad de producto para agregar el producto a la factura detalle.", "¡No se agregó ningún producto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        private void Btn_Remover_Producto_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow item in this.Dgv_Detalle_Factura.SelectedRows)
                {
                    Dgv_Detalle_Factura.Rows.RemoveAt(item.Index);

                    for (int i = Dgv_Detalle_Factura.Rows.Count - 1; i > -1; i--)
                    {
                        DataGridViewRow row = Dgv_Detalle_Factura.Rows[i];
                        if (!row.IsNewRow && row.Cells[0].Value == null)
                        {
                            Dgv_Detalle_Factura.Rows.RemoveAt(i);
                        }
                    }
                }

                MessageBox.Show("Producto eliminado correctamente");
                ActualizarMonto();


            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione la fila que desea remover haciendo click en la parte izquierda junto a el id");
            }

        }
        private void Btn_Canjear_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Si canjea los puntos ahora no podrá agregar mas productos ", "Facturar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (opcion == DialogResult.OK)
                {
                    int CantidadProductoTotal = SumarProductos();
                    Lbl_Descuento.Text = bl.DescuentosVIP(int.Parse(Txt_Puntos.Text), Txt_Identificacion.Text).ToString();
                    Lbl_SubTotalDescuento.Text = bl.MontoDescuentoTotalVIP(int.Parse(Txt_Puntos.Text), Txt_Identificacion.Text, CantidadProductoTotal, Codigo).ToString();
                    Lbl_Impuestos.Text = bl.TotalImpuestosVIP(int.Parse(Txt_Puntos.Text), Txt_Identificacion.Text, CantidadProductoTotal, Codigo).ToString();
                    Lbl_Total.Text = bl.TotalVIP(int.Parse(Txt_Puntos.Text), Txt_Identificacion.Text, CantidadProductoTotal, Codigo).ToString();
                    lbl_Puntos_Acumulados.Text = bl.BuscarClienteId(Txt_Identificacion.Text).Puntos_acumulados.ToString();
                    Btn_Agregar.Enabled = false;
                    Btn_Remover.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar una cantidad de puntos valida");
            }
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Administrador")
            {
                this.Dispose();
                Form_Menu_Administrador fma = new Form_Menu_Administrador(bl);
                fma.Show();
            }
            if (label1.Text == "Vendedor")
            {
                this.Dispose();
                Form_Menu_Ventas fmv = new Form_Menu_Ventas(bl);
                fmv.Show();
            }

        }
        private void Btn_Facturar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(Lbl_Total.Text) < 0 || Convert.ToDecimal(Lbl_Total.Text) == 0)
            {
                MessageBox.Show("El monto total que está tratando de facturar no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CantidadProductoTotal = SumarProductos();

            if (Cmb_Tipo_Venta.SelectedItem.ToString() == "Contado" && Cmb_Tipo_Pago.SelectedItem.ToString() == "Efectivo")
            {

                
                label7.Text = DateTime.Now.ToString();
                label9.Text = "";
                bl.GetTotal(decimal.Parse(Lbl_Total.Text));

                if (lbl_Tipo_Cliente.Text == "VIP")
                {
                    if (Lbl_Descuento.Text == "N/A")
                    {
                        Lbl_Descuento.Text = "0";
                        Lbl_SubTotalDescuento.Text = "0";
                        Form_Pagar fp = new Form_Pagar(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), 0, Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, 0);
                        this.Dispose();
                        fp.Show();
                    }
                    else
                    {
                        
                        Form_Pagar fp = new Form_Pagar(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, bl.Descuento_Aplicado_VIP(Convert.ToInt32(Txt_Puntos.Text)).Id_DescVIP);
                        this.Dispose();
                        fp.Show();
                    }
                    

                }
                else
                {
                    if (Lbl_Descuento.Text == "N/A")
                    {
                        Lbl_Descuento.Text = "0";
                        Lbl_SubTotalDescuento.Text = "0";
                        Form_Pagar fp = new Form_Pagar(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, 0);
                        this.Dispose();
                        fp.Show();
                    }
                    else
                    {
                        Form_Pagar fp = new Form_Pagar(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, bl.Descuento_Aplicado(CantidadProductoTotal, DateTime.Today.DayOfWeek.ToString()).Id_DescEstandar);
                        this.Dispose();
                        fp.Show();
                    }
                }

                for (int i = Dgv_Detalle_Factura.Rows.Count - 1; i > -1; i--)
                {
                    DataGridViewRow row = Dgv_Detalle_Factura.Rows[i];
                    if (!row.IsNewRow && row.Cells[0].Value == null)
                    {
                        Dgv_Detalle_Factura.Rows.RemoveAt(i);
                    }
                }

                for (int i = 0; i < Dgv_Detalle_Factura.RowCount; i++)
                {
                    if (Dgv_Detalle_Factura.Rows[i].Cells[0].Value != null)
                    {
                        Descripcion_Producto = Dgv_Detalle_Factura.Rows[i].Cells[1].Value.ToString();
                        Codigo_Producto = Dgv_Detalle_Factura.Rows[i].Cells[2].Value.ToString();
                        Precio_Unitario = Dgv_Detalle_Factura.Rows[i].Cells[3].Value.ToString();
                        Cantidad = Dgv_Detalle_Factura.Rows[i].Cells[4].Value.ToString();

                        bl.AgregarProducto_DetalleFactura(Descripcion_Producto, Codigo_Producto, Convert.ToDecimal(Precio_Unitario), Convert.ToInt32(Cantidad));
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (Cmb_Tipo_Venta.SelectedItem.ToString() == "Crédito")
            {
                if (MessageBox.Show("¿Está seguro que desea generar una factura a crédito?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (Lbl_Descuento.Text == "N/A" && lbl_Tipo_Cliente.Text == "VIP")
                    {

                        Lbl_Descuento.Text = "0";
                        Lbl_SubTotalDescuento.Text = "0";

                        label7.Text = DateTime.Now.ToString();
                        label9.Text = DateTime.Now.AddDays(+15).ToString();

                        bl.FacturarPago("Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Descuento.Text), Convert.ToDecimal(Lbl_Total.Text), bl.BuscarCliente(Txt_Identificacion.Text, tipoId).Id_cliente, 0);
                        bl.Insertar_CierreCajas_Facturacion(DateTime.Now, "Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        bl.Ligar_DetalleFactura_Factura(bl.ObtenerUltimoNumero() - 1);
                        bl.Insertar_CuentaCobrar_Facturacion(DateTime.Today.Date, Txt_Identificacion.Text, lbl_Nombre_Cliente.Text, 0, Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        MessageBox.Show("El proceso de facturación se ha concretado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form_Facturación fpt = new Form_Facturación(bl);
                        this.Dispose();
                        fpt.Show();
                    }
                    else if (Convert.ToDecimal(Lbl_Descuento.Text) > 0 && lbl_Tipo_Cliente.Text == "VIP")
                    {
                        label7.Text = DateTime.Now.ToString();
                        label9.Text = DateTime.Now.AddDays(+15).ToString();

                        bl.FacturarPago("Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Descuento.Text), Convert.ToDecimal(Lbl_Total.Text), bl.BuscarCliente(Txt_Identificacion.Text, tipoId).Id_cliente, bl.Descuento_Aplicado_VIP(Convert.ToInt32(Txt_Puntos.Text)).Id_DescVIP);
                        bl.Insertar_CierreCajas_Facturacion(DateTime.Now, "Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        bl.Ligar_DetalleFactura_Factura(bl.ObtenerUltimoNumero() - 1);
                        bl.Insertar_CuentaCobrar_Facturacion(DateTime.Today.Date, Txt_Identificacion.Text, lbl_Nombre_Cliente.Text, 0, Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        MessageBox.Show("El proceso de facturación se ha concretado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form_Facturación fpt = new Form_Facturación(bl);
                        this.Dispose();
                        fpt.Show();
                    }

                    if (Lbl_Descuento.Text == "N/A" && lbl_Tipo_Cliente.Text == "Estandar")
                    {

                        Lbl_Descuento.Text = "0";
                        Lbl_SubTotalDescuento.Text = "0";

                        label7.Text = DateTime.Now.ToString();
                        label9.Text = DateTime.Now.AddDays(+15).ToString();

                        bl.FacturarPago("Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Descuento.Text), Convert.ToDecimal(Lbl_Total.Text), bl.BuscarCliente(Txt_Identificacion.Text, tipoId).Id_cliente, 0);
                        bl.Insertar_CierreCajas_Facturacion(DateTime.Now, "Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        bl.Ligar_DetalleFactura_Factura(bl.ObtenerUltimoNumero() - 1);
                        bl.Insertar_CuentaCobrar_Facturacion(DateTime.Today.Date, Txt_Identificacion.Text, lbl_Nombre_Cliente.Text, 0, Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        MessageBox.Show("El proceso de facturación se ha concretado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form_Facturación fpt = new Form_Facturación(bl);
                        this.Dispose();
                        fpt.Show();
                    }
                    else if (Convert.ToDecimal(Lbl_Descuento.Text) > 0 && lbl_Tipo_Cliente.Text == "Estandar")
                    {
                        label7.Text = DateTime.Now.ToString();
                        label9.Text = DateTime.Now.AddDays(+15).ToString();

                        bl.FacturarPago("Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Descuento.Text), Convert.ToDecimal(Lbl_Total.Text), bl.BuscarCliente(Txt_Identificacion.Text, tipoId).Id_cliente, bl.Descuento_Aplicado(CantidadProductoTotal, DateTime.Today.DayOfWeek.ToString()).Id_DescEstandar);
                        bl.Insertar_CierreCajas_Facturacion(DateTime.Now, "Crédito", Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        bl.Ligar_DetalleFactura_Factura(bl.ObtenerUltimoNumero() - 1);
                        bl.Insertar_CuentaCobrar_Facturacion(DateTime.Today.Date, Txt_Identificacion.Text, lbl_Nombre_Cliente.Text, 0, Convert.ToDecimal(Lbl_Total.Text), Convert.ToInt32(Lbl_NumeroFactura.Text));
                        MessageBox.Show("El proceso de facturación se ha concretado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form_Facturación fpt = new Form_Facturación(bl);
                        this.Dispose();
                        fpt.Show();
                    }
                }
                else
                {
                    return;
                }
            }

            if (Cmb_Tipo_Venta.SelectedItem.ToString() == "Contado" && Cmb_Tipo_Pago.SelectedItem.ToString() == "Tarjeta")
            {
                label7.Text = DateTime.Now.ToString();
                label9.Text = "";

                CantidadProductoTotal = SumarProductos();

                label7.Text = DateTime.Now.ToString();
                label9.Text = "";
                bl.GetTotal(decimal.Parse(Lbl_Total.Text));

                if (lbl_Tipo_Cliente.Text == "VIP")
                {
                    if (Lbl_Descuento.Text == "N/A")
                    {
                        Form_Pagar_Tarjeta fpt = new Form_Pagar_Tarjeta(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, 0);
                        this.Dispose();
                        fpt.Show();
                    }
                    else
                    {
                        Form_Pagar_Tarjeta fpt = new Form_Pagar_Tarjeta(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, bl.Descuento_Aplicado_VIP(Convert.ToInt32(Txt_Puntos.Text)).Id_DescVIP);
                        this.Dispose();
                        fpt.Show();
                    }


                }
                else
                {
                    if (Lbl_Descuento.Text == "N/A")
                    {
                        Form_Pagar_Tarjeta fpt = new Form_Pagar_Tarjeta(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, 0);
                        this.Dispose();
                        fpt.Show();
                    }
                    else
                    {
                        Form_Pagar_Tarjeta fpt = new Form_Pagar_Tarjeta(bl, Cmb_Tipo_Venta.SelectedItem.ToString(), Cmb_Tipo_Pago.SelectedItem.ToString(), Convert.ToDecimal(Lbl_SubTotal.Text), Convert.ToDecimal(Lbl_SubTotalDescuento.Text), Convert.ToDecimal(Lbl_Impuestos.Text), Convert.ToDecimal(Lbl_Total.Text), bl.ClienteExiste(Txt_Identificacion.Text).Id_cliente, bl.Descuento_Aplicado(CantidadProductoTotal, DateTime.Today.DayOfWeek.ToString()).Id_DescEstandar);
                        this.Dispose();
                        fpt.Show();
                    }
                }

                // Not relevant. 

                for (int i = Dgv_Detalle_Factura.Rows.Count - 1; i > -1; i--)
                {
                    DataGridViewRow row = Dgv_Detalle_Factura.Rows[i];
                    if (!row.IsNewRow && row.Cells[0].Value == null)
                    {
                        Dgv_Detalle_Factura.Rows.RemoveAt(i);
                    }
                }
                for (int i = 0; i < Dgv_Detalle_Factura.RowCount; i++)
                {
                    if (Dgv_Detalle_Factura.Rows[i].Cells[0].Value != null)
                    {
                        Descripcion_Producto = Dgv_Detalle_Factura.Rows[i].Cells[1].Value.ToString();
                        Codigo_Producto = Dgv_Detalle_Factura.Rows[i].Cells[2].Value.ToString();
                        Precio_Unitario = Dgv_Detalle_Factura.Rows[i].Cells[3].Value.ToString();
                        Cantidad = Dgv_Detalle_Factura.Rows[i].Cells[4].Value.ToString();

                        bl.AgregarProducto_DetalleFactura(Descripcion_Producto, Codigo_Producto, Convert.ToDecimal(Precio_Unitario), Convert.ToInt32(Cantidad));
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }
        private void OnlyNumbersAndLettersAllowed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rdb_Pasaporte.Checked == true)
            {
                if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else 
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
        }
        private void OnlyNumbersAllowed_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Rdb_Cedula_Click(object sender, EventArgs e)
        {
            Txt_Identificacion.Text = "";
            Txt_Identificacion.MaxLength = 10;
        }
        private void Rdb_DIMEX_Click(object sender, EventArgs e)
        {
            Txt_Identificacion.Text = "";
            Txt_Identificacion.MaxLength = 12;
        }
        private void Rdb_Pasaporte_Click(object sender, EventArgs e)
        {
            Txt_Identificacion.Text = "";
            Txt_Identificacion.MaxLength = 15;
        }
        private void Form_Facturación_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
        #endregion

        #region Methods:

        // Método encargado de modificar la pantalla dependiendo del tipo de cliente. 
        public void ValidarTipoUsuario()
        {

            var Cliente =bl.BuscarClienteId(Txt_Identificacion.Text);

            if (Cliente.Tipo_cliente == "Estandar") 
            {
                Btn_Canjear.Enabled = false;
                Txt_Puntos.Enabled = false;
                label22.Visible = false;
                lbl_Puntos_Acumulados.Visible = false;
                Btn_Canjear.Visible = false;
                Txt_Puntos.Visible = false;
                label39.Visible = false;
            }

            if (Cliente.Tipo_cliente == "VIP")
            {
                Btn_Canjear.Enabled = true;
                Txt_Puntos.Enabled = true;
            }
        }

        // Método encargado de deshabilitar los componentes, para evitar que el usuario no siga el flujo de trabajo.
        public void DeshabilitarComponentes() 
        {
            /*Deshabilita Busqueda Cliente*/
            Rdb_Cedula.Enabled = false;
            Rdb_Dimex.Enabled = false;
            Rdb_Pasaporte.Enabled = false;
            Rdb_Cedula.Checked = false;
            Rdb_Dimex.Checked = false;
            Rdb_Pasaporte.Checked = false;
            Txt_Identificacion.Enabled = false;
            Btn_Buscar_Factura.Enabled = false;
            Txt_Identificacion.Text = "";
            Txt_Cantidad.Enabled = false;
            //Dgv_Detalle_Factura.DataSource = "";
            Lbl_SubTotal.Text = "N/A";
            Lbl_Descuento.Text = "N/A";
            Lbl_SubTotalDescuento.Text = "N/A";
            Lbl_Impuestos.Text = "N/A";
            Lbl_Total.Text = "N/A";

            lbl_Tipo_Cliente.Text = "N/A";
            lbl_Nombre_Cliente.Text = "N/A";
            lbl_Numero_ID.Text = "N/A";
            lbl_Telefono.Text = "N/A";
            lbl_Correo.Text = "N/A";
            lbl_Direccion.Text = "N/A";
            lbl_Puntos_Acumulados.Text = "N/A";

            label7.Text = "N/A";
            label9.Text = "N/A";

            Cmb_Productos.Enabled = false;
            Cmb_Tipo_Pago.Enabled = false;
            Cmb_Tipo_Venta.Enabled = false;
            Btn_Canjear.Enabled = false;
            Txt_Puntos.Enabled = false;




            /*Deshabilita Busqueda Producto*/
            Cmb_Productos.Enabled = false;
            Txt_Precio.Enabled = false;
            Txt_Cantidad.Enabled = false;
            Btn_Agregar.Enabled = false;
            Btn_Remover.Enabled = false;
            Dgv_Detalle_Factura.Enabled = false;
        }

        // Método encargado de habilitar los componentes en la tabla de búsqueda de cliente.
        public void HabilitarBusquedaCliente() 
        {
            /*Habilita Busqueda Cliente*/
            Rdb_Cedula.Enabled = true;
            Rdb_Dimex.Enabled = true;
            Rdb_Pasaporte.Enabled = true;
            Txt_Identificacion.Enabled = true;
            Btn_Buscar_Factura.Enabled = true;

        }

        // Método encargado de habilitar el agregar los producto una vez se haya realizado la búsqueda del cliente.
        public void HabilitarBusquedaProductos() 
        {
            /*Deshabilita Busqueda Producto*/
            Cmb_Productos.Enabled = true;
            Btn_Agregar.Enabled = true;
        }
        
        // Método encargado de sumar la cantidad de productos que van a ser comprados.
        public int SumarProductos() 
        {
            int CantidadProductoTotal = 0;

            foreach (DataGridViewRow row in Dgv_Detalle_Factura.Rows)
            {
                CantidadProductoTotal += Convert.ToInt32(row.Cells[4].Value);
            }
            return CantidadProductoTotal;

        }

        // Método encargado de calcular los montos finales.
        public void ActualizarMonto() 
        {
            try
            {
                int CantidadProductoTotal = SumarProductos();

                if (bl.validarTipoCliente(Txt_Identificacion.Text) == "Estandar")

                {
                    Lbl_SubTotal.Text = bl.SubTotal(Codigo, CantidadProductoTotal).ToString();
                    Lbl_Descuento.Text = bl.DescuentosEstandar(CantidadProductoTotal).ToString();
                    Lbl_SubTotalDescuento.Text = bl.MontoMenosDescuentoTotal(CantidadProductoTotal, Codigo).ToString();
                    Lbl_Impuestos.Text = bl.ImpuestosTotalEstandar(CantidadProductoTotal, Codigo).ToString();
                    Lbl_Total.Text = bl.TotalEstandar(CantidadProductoTotal, Codigo).ToString();

                }
                if (bl.validarTipoCliente(Txt_Identificacion.Text) == "VIP")

                {
                    if (Lbl_Descuento.Text == "N/A")
                    {

                        Lbl_SubTotal.Text = bl.SubTotal(Codigo, CantidadProductoTotal).ToString();
                        Lbl_Impuestos.Text = bl.ImpuestosTotalVIP(CantidadProductoTotal, Codigo).ToString();
                        Lbl_Total.Text = bl.TotalVIPSinDescuento(CantidadProductoTotal, Codigo).ToString();
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Actualizar Monto error" + error);
            }

        }

        #endregion

    }
}
