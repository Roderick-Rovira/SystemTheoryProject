using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_de_Venta_BeerLab.BL;
using System.Windows.Forms;

namespace Punto_de_Venta_BeerLab.UI.Pantallas_Seguridad
{ 
    public partial class Frm_Login : Form
    {
        BussinesLayer bl;

        public Frm_Login()
        {
            InitializeComponent();
        }

        public Frm_Login(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();

            Btn_Actualizar.Enabled = false;
            Btn_CrearContrasenna.Enabled = false;

            Dgv_ListaUsuarios.DataSource = bl.MostrarUsuariosStoreProcedure().ToList();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_NumeroIdentificacion.Text))
            {
                MessageBox.Show("Debe ingresar un número de identificación antes de poder realizar la consulta", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Txt_CrearContrasenna.Text = bl.Contrasenna_Usuario(Txt_NumeroIdentificacion.Text);

                if (Txt_CrearContrasenna.Text == "N/A")
                {
                    MessageBox.Show("Este usuario no tiene una constraseña asignada", "Información",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Txt_CrearContrasenna.Text = "";
                    Txt_ConfirmarContrasenna.Text = "";
                    Btn_CrearContrasenna.Enabled = true;
                    Btn_Actualizar.Enabled = false;
                }
                else
                {

                    MessageBox.Show("Este usuario ya tiene un contraseña asiganda", "Información",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Txt_ConfirmarContrasenna.Text = "";
                    Btn_CrearContrasenna.Enabled = false;
                    Btn_Actualizar.Enabled = true;
                }
            }
        }

        private void Dgv_ListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_ListaUsuarios.SelectedRows.Count > 0)
            {
                try
                {
                    Txt_NumeroIdentificacion.Text = Dgv_ListaUsuarios.CurrentRow.Cells["Identificacion"].Value.ToString();
                    Txt_CrearContrasenna.Text = bl.Contrasenna_Usuario(Txt_NumeroIdentificacion.Text);

                    if (Txt_CrearContrasenna.Text == "N/A")
                    {
                        Txt_CrearContrasenna.Text = "";
                        Txt_ConfirmarContrasenna.Text = "";
                        Btn_Actualizar.Enabled = true;
                        Btn_Actualizar.Enabled = false;
                    }
                    else 
                    {
                        Txt_ConfirmarContrasenna.Text = "";
                        Btn_Actualizar.Enabled = false;
                        Btn_Actualizar.Enabled = true;
                    }


                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }

        private void Btn_CrearContrasenna_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_NumeroIdentificacion.Text) || String.IsNullOrEmpty(Txt_CrearContrasenna.Text) || String.IsNullOrEmpty(Txt_ConfirmarContrasenna.Text))
            {
                MessageBox.Show("Hay campos que se encuentran vacíos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_CrearContrasenna.Text == Txt_ConfirmarContrasenna.Text)
            {
                if (MessageBox.Show("¿Está seguro que desea cambiar la contraseña?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bl.ChangePassword(Txt_NumeroIdentificacion.Text, Txt_CrearContrasenna.Text);
                    MessageBox.Show("La contraseña se ha cambiado de manera exitosa", "Cambio de Contraseña Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                    Form_Menu_Administrador WindowView = new Form_Menu_Administrador(bl);
                    WindowView.Show();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite la confirmación de contraseña correctamente", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_NumeroIdentificacion.Text) || String.IsNullOrEmpty(Txt_CrearContrasenna.Text) || String.IsNullOrEmpty(Txt_ConfirmarContrasenna.Text))
            {
                MessageBox.Show("Hay campos que se encuentran vacíos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_CrearContrasenna.Text == Txt_ConfirmarContrasenna.Text)
            {
                if (MessageBox.Show("¿Está seguro que desea cambiar la contraseña?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bl.ChangePassword(Txt_NumeroIdentificacion.Text, Txt_CrearContrasenna.Text);
                    MessageBox.Show("La contraseña se ha cambiado de manera exitosa", "Cambio de Contraseña Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                    Form_Menu_Administrador WindowView = new Form_Menu_Administrador(bl);
                    WindowView.Show();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite la confirmación de contraseña correctamente", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_NumeroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Contrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar))
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
            Form_Menu_Seguridad WindowView = new Form_Menu_Seguridad(bl);
            WindowView.Show();
        }

    }
}
