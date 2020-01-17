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

namespace Punto_de_Venta_BeerLab.UI.Pantallas_Mantenimiento
{
    public partial class Frm_Mantenimiento_Direcciones : Form
    {
        #region Header and Variables:

        BussinesLayer bl;
        String ID_Provincia = "1", ID_Canton = "01", ID_Distrito = "01";

        public Frm_Mantenimiento_Direcciones()
        {
            InitializeComponent();
        }

        public Frm_Mantenimiento_Direcciones(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        #endregion

        #region Events:

        private void Frm_Mantenimiento_Direcciones_Load(object sender, EventArgs e)
        {
            Dgv_Lista_Direcciones.DataSource = bl.Mostrar_Direcciones_Cliente();
            Cmb_Provincia.DataSource = bl.Cargar_Provincias();
            Cmb_Canton.DataSource = bl.Cargar_Cantones(ID_Provincia);
            Cmb_Distrito.DataSource = bl.Cargar_Distritos(ID_Provincia, ID_Canton);
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Numero_Identificacion.Text))
            {
                MessageBox.Show("Algunos campos aún se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!String.IsNullOrEmpty(Convert.ToString(bl.AdressExist(Convert.ToInt32(Txt_Numero_Identificacion.Text)))))
            {
                MessageBox.Show("Ya existe un cliente con esta dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Está seguro que desea agregar esta dirección?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Description = Cmb_Distrito.SelectedItem.ToString() + "," + Cmb_Canton.SelectedItem.ToString() + "," + Cmb_Provincia.SelectedItem.ToString();
                bl.Agregar_DireccionCliente(Convert.ToInt32(Txt_Numero_Identificacion.Text), Description, ID_Provincia, ID_Canton, ID_Distrito);
                MessageBox.Show("La dirección fue agregada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Numero_Identificacion.Text))
            {
                MessageBox.Show("Algunos campos aún se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(Convert.ToString(bl.AdressExist(Convert.ToInt32(Txt_Numero_Identificacion.Text)))))
            {
                MessageBox.Show("No existe ninguna dirección para ese cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Está seguro que desea modificar esta dirección?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Description = Cmb_Distrito.SelectedItem.ToString() + "," + Cmb_Canton.SelectedItem.ToString() + "," + Cmb_Provincia.SelectedItem.ToString();
                bl.Modificar_DireccionCliente(Convert.ToInt32(Txt_Numero_Identificacion.Text), Description, ID_Provincia, ID_Canton, ID_Distrito);
                MessageBox.Show("La dirección fue modificada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Numero_Identificacion.Text))
            {
                MessageBox.Show("Algunos campos aún se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(Convert.ToString(bl.AdressExist(Convert.ToInt32(Txt_Numero_Identificacion.Text)))))
            {
                MessageBox.Show("No existe ninguna dirección para ese cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                Txt_Numero_Identificacion.Text = Convert.ToString(bl.AdressExist(Convert.ToInt32(Txt_Numero_Identificacion.Text)).Id_cliente);

                byte Temp_Counter = 0;
            }
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos WindowView = new Form_Mantenimientos(bl);
            WindowView.Show();
        }
        private void Dgv_Lista_Direcciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Cmb_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_Provincia = bl.Obtener_Codigo_Provincia(Cmb_Provincia.SelectedItem.ToString()).Id_provincia;
            Cmb_Canton.DataSource = bl.Cargar_Cantones(ID_Provincia);
        }
        private void Cmb_Canton_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_Canton = bl.Obtener_Codigo_Canton(Cmb_Canton.SelectedItem.ToString()).Id_canton;
            Cmb_Distrito.DataSource = bl.Cargar_Distritos(ID_Provincia, ID_Canton);
        }
        private void Cmb_Distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_Distrito = bl.Obtener_Codigo_Distrito(Cmb_Distrito.SelectedItem.ToString()).Id_canton;
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

        private void Frm_Mantenimiento_Direcciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        // I probably wont use this.

        public void CargarDatos()
        {
            
        }



        #endregion

        
    }
}
