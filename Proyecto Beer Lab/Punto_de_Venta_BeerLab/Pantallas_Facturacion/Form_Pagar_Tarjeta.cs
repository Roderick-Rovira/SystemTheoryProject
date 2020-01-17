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
    
    public partial class Form_Pagar_Tarjeta : Form
    {

        #region Header and Variables

        BussinesLayer bl;
        string Bill_Type, Payment_Type;
        decimal Subtotal, Subtotal_Discount, Total_Taxes, Total;
        int ID_Client, ID_Discount;

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir? La factura se anulará", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Form_Facturación WindowsView = new Form_Facturación(bl);
                WindowsView.Show();
            }       
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Monto_Pagar.Text) || String.IsNullOrEmpty(Txt_Nombre_Tarjeta.Text) || String.IsNullOrEmpty(Txt_Numero_Tarjeta.Text) || String.IsNullOrEmpty(Txt_Codigo_Seguridad.Text))
            {
                MessageBox.Show("Algunos campos aún se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Dtp_Fecha_Expiraciom.Value.Date.Day == DateTime.Today.Date.Day)
            {
                MessageBox.Show("La tarjeta que está tratando de ingresar ya expiró","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;   
            }
            else if (MessageBox.Show("¿Desea continuar con el proceso de facturació?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bl.FacturarPago(Bill_Type, Payment_Type, Subtotal, Subtotal_Discount, Total_Taxes, Total, ID_Client, ID_Discount);
                bl.Ligar_DetalleFactura_Factura(bl.ObtenerUltimoNumero() - 1);
                bl.Insertar_CierreCajas_Facturacion(DateTime.Today, Bill_Type, Payment_Type, Total, bl.ObtenerUltimoNumero() - 1);

                MessageBox.Show("Se han facturado los productos de manera exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se cierra la pantalla apenas de concrete el pago.

                this.Dispose();
                Form_Facturación WindowsView = new Form_Facturación(bl);
                WindowsView.Show();
            }
        }

        public Form_Pagar_Tarjeta()
        {
            InitializeComponent();
        }
        public Form_Pagar_Tarjeta(BussinesLayer bl, string Bill_Type, string Payment_Type, decimal Subtotal, decimal Subtotal_Discount, decimal Total_Taxes, decimal Total, int ID_Client, int ID_Discount)
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


        private void Form_Pagar_Tarjeta_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Txt_Monto_Pagar.Enabled = false;
            Btn_Pagar.Enabled = true;
            Txt_Monto_Pagar.Text = bl.SetTotal().ToString();
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

        private void OnlyLettersAllowed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
