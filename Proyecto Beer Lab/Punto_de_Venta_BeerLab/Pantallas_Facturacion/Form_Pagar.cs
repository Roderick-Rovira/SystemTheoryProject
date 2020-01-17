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
    
    public partial class Form_Pagar : Form
    {
        #region Header and Variables:

        BussinesLayer bl;
        string Bill_Type, Payment_Type;
        decimal Subtotal, Subtotal_Discount, Total_Taxes, Total;
        int ID_Client, ID_Discount;

        

        public Form_Pagar()
        {
            InitializeComponent();
        }

        private void Txt_Monto_Cliente_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Monto_Cliente.Text == "" || String.IsNullOrEmpty(Txt_Monto_Cliente.Text))
            {
                Txt_Vuelto.Text = "0";
                return;
            }
            if (Convert.ToDecimal(Txt_Monto_Cliente.Text) < Convert.ToDecimal(Txt_Monto_Pagar.Text))
            {
                Btn_Pagar.Enabled = false;
                Txt_Vuelto.Text = "0";
                return;
            }
            else
            {
                Txt_Vuelto.Text = Convert.ToString(Convert.ToDecimal(Txt_Monto_Cliente.Text) - Convert.ToDecimal(Txt_Monto_Pagar.Text));
                Btn_Pagar.Enabled = true;
            }
        }

        public Form_Pagar(BussinesLayer bl, string Bill_Type, string Payment_Type, decimal Subtotal, decimal Subtotal_Discount, decimal Total_Taxes, decimal Total, int ID_Client, int ID_Discount)
        {
            this.bl = bl;
            this.Bill_Type = Bill_Type;
            this.Payment_Type = Payment_Type;
            this.Subtotal = Subtotal;
            this.Subtotal_Discount = Subtotal_Discount;
            this.Total_Taxes = Total_Taxes;
            this.Total = Total;
            this.ID_Client = ID_Client;
            this.ID_Discount = ID_Discount;
            InitializeComponent();
        }

        #endregion

        #region Events:

        private void Form_Pagar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Txt_Monto_Pagar.Enabled = false;
            Btn_Pagar.Enabled = true;
            Txt_Monto_Pagar.Text = bl.SetTotal().ToString();
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea procesar la factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Creación de la factura y ligado de esta a la orden de fabricación.

                
                bl.FacturarPago(Bill_Type, Payment_Type, Subtotal, Subtotal_Discount, Total_Taxes, Total, ID_Client, ID_Discount);
                bl.Ligar_DetalleFactura_Factura(bl.ObtenerUltimoNumero()-1);
                bl.Insertar_CierreCajas_Facturacion(DateTime.Today, Bill_Type, Payment_Type, Total, bl.ObtenerUltimoNumero()-1);
                MessageBox.Show("El proceso de facturación se ha concretado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se deshabilitan los controles para evitar que el usuario vuelva a realizar la misma factura. 

                Txt_Monto_Pagar.Enabled = false;
                Btn_Pagar.Enabled = false;
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Monto_Cliente.Text) || String.IsNullOrEmpty(Txt_Vuelto.Text))
            {
                if (MessageBox.Show("¿Está seguro que desea salir? No se guardarán los cambios y se anulará el detalle de factura" , "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Aquí se debe anular el detalle de factura.

                    this.Close();
                    Form_Facturación WindowView = new Form_Facturación(bl);
                    WindowView.Show();
                }
            }
            else
            {
                this.Close();
                Form_Facturación WindowView = new Form_Facturación(bl);
                WindowView.Show();
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

        #endregion

    }
}
