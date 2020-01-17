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
    public partial class Form_Mantenimiento_Clientes : Form
    {

        #region Header

        BussinesLayer bl;
        public Form_Mantenimiento_Clientes()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_Clientes(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        #endregion

        #region Events

        private void Form_Mantenimiento_Clientes_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarDatos();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Nombre.Text) || String.IsNullOrEmpty(Txt_Num_Identificacion.Text) || String.IsNullOrEmpty(Txt_Apellido_I.Text) || String.IsNullOrEmpty(Txt_Apellido_II.Text) || String.IsNullOrEmpty(Txt_Correo.Text) || String.IsNullOrEmpty(Txt_Telefono.Text) || String.IsNullOrEmpty(Txt_Estado.Text))
            {
                MessageBox.Show("Algunos campos se encuentran vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (!String.IsNullOrEmpty(Convert.ToString(bl.ClienteExiste(Txt_Num_Identificacion.Text))))
            {
                MessageBox.Show("El usuario que está tratando de ingresar, ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Dtp_FechaNacimiento.Value == DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_Estado.Text != "Activo" && Txt_Estado.Text != "Inactivo")
            {
                MessageBox.Show("Ingrese un estado válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("¿Desea añadir este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                string TipoID = Cmb_Tipo_Identificacion.SelectedItem.ToString();
                bl.AgregarCliente(TipoID, Txt_Num_Identificacion.Text, Txt_Nombre.Text, Txt_Apellido_I.Text, Txt_Apellido_II.Text, DateTime.Parse(Dtp_FechaNacimiento.Text), DateTime.Now, Txt_Correo.Text, int.Parse(Txt_Telefono.Text));
                CargarDatos();
            }
        }

        private void Dgv_Lista_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_Lista_Clientes.SelectedRows.Count > 0)
            {
                try
                {
                    string id = Dgv_Lista_Clientes.CurrentRow.Cells["Identificacion"].Value.ToString();
                    Cmb_Tipo_Identificacion.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Tipo_identificacion"].Value.ToString();
                    Txt_Num_Identificacion.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Identificacion"].Value.ToString();
                    Txt_Nombre.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    Txt_Apellido_I.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Apellido1"].Value.ToString();
                    Txt_Apellido_II.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Apellido2"].Value.ToString();
                    Dtp_FechaNacimiento.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Fecha_nacimiento"].Value.ToString();
                    Txt_Correo.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Correo"].Value.ToString();
                    Txt_Telefono.Text = Dgv_Lista_Clientes.CurrentRow.Cells["Telefono"].Value.ToString();

                    if (bl.ClienteExiste(Txt_Num_Identificacion.Text).Id_estado == 1)
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
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string TipoID = Cmb_Tipo_Identificacion.SelectedItem.ToString();
            bl.ModificarCliente(TipoID, Txt_Num_Identificacion.Text, Txt_Nombre.Text, Txt_Apellido_I.Text, Txt_Apellido_II.Text, DateTime.Parse(Dtp_FechaNacimiento.Text), DateTime.Now, Txt_Correo.Text, int.Parse(Txt_Telefono.Text));
            CargarDatos();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }
        
        private void Form_Mantenimiento_Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
        
        private void Btn_Activar_Click(object sender, EventArgs e)
        {
            bl.ActivarCliente(Txt_Num_Identificacion.Text);
            CargarDatos();
        }

        private void Btn_Desactivar_Click(object sender, EventArgs e)
        {
            bl.DesactivarCliente(Txt_Num_Identificacion.Text);
            CargarDatos();
        } 
        
        // Validations

        private void OnlyNumbersAllow_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion

        #region Methods
        public void CargarDatos() 
        {
            Dgv_Lista_Clientes.DataSource = bl.MostrarClientes();
            
        }

        #endregion

       
    }
    
}
