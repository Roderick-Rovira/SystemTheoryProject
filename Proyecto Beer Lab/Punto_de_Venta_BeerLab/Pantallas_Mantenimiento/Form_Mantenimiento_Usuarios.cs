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

    public partial class Form_Mantenimiento_Usuarios : Form
    {
        int id;
        BussinesLayer bl;
        public Form_Mantenimiento_Usuarios()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_Usuarios(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void Form_Mantenimiento_Usuarios_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarData();

        }

        public void CargarData()
        {
            try
            {
                Dgv_Lista_Usuarios.DataSource = bl.MostrarUsuariosStoreProcedure();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

        }

        private void Form_Mantenimiento_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }


        private void ClearSpaces()
        {
            Txt_NumeroIdentificacion.Text = "";
            Txt_Nombre.Text = "";
            Txt_ApellidoI.Text = "";
            Txt_ApellidoII.Text = "";
            Txt_Correo.Text = "";
            Txt_Estado.Text = "";
        }

        public void CC()
        {

            if (Dgv_Lista_Usuarios.SelectedRows.Count > 0)
            {
                try
                {
                    string estado;
                    id = int.Parse(Dgv_Lista_Usuarios.CurrentRow.Cells["Id_usuario"].Value.ToString());
                    Txt_NumeroIdentificacion.Text = Dgv_Lista_Usuarios.CurrentRow.Cells["Identificacion"].Value.ToString();
                    Txt_Nombre.Text = Dgv_Lista_Usuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                    Txt_ApellidoI.Text = Dgv_Lista_Usuarios.CurrentRow.Cells["Apellido1"].Value.ToString();
                    Txt_ApellidoII.Text = Dgv_Lista_Usuarios.CurrentRow.Cells["Apellido2"].Value.ToString();
                    Txt_Correo.Text = Dgv_Lista_Usuarios.CurrentRow.Cells["Correo"].Value.ToString();
                    estado = Dgv_Lista_Usuarios.CurrentRow.Cells["Id_estado"].Value.ToString();

                    if (estado == "1")
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

        private void Dgv_Lista_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CC();
        }


        private void Btn_Activar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_NumeroIdentificacion.Text))
            {
                bl.ActivarUsuario(id);
                CargarData();
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de identificación para poder cambiarle el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Btn_Desactivar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_NumeroIdentificacion.Text))
            {
                bl.DesactivarUsuario(id);
                CargarData();
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de identificación para poder cambiarle el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_NumeroIdentificacion.Text) || String.IsNullOrEmpty(Txt_Nombre.Text) || String.IsNullOrEmpty(Txt_ApellidoI.Text) ||
                String.IsNullOrEmpty(Txt_ApellidoII.Text) || String.IsNullOrEmpty(Txt_Correo.Text))
            {
                MessageBox.Show("Algunos campos aún se encuentra vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bl.AgregarUsuario(Txt_NumeroIdentificacion.Text, Txt_Nombre.Text, Txt_ApellidoI.Text, Txt_ApellidoII.Text, Txt_Correo.Text);
                MessageBox.Show("El usuario se ha agredado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_NumeroIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(bl.IdNumberExist(Txt_NumeroIdentificacion.Text))))
            {
                Txt_Nombre.Text = "";
                Txt_ApellidoI.Text = "";
                Txt_ApellidoII.Text = "";
                Txt_Correo.Text = "";
                Txt_Estado.Text = "";
            }
            else
            {
                id = bl.IdNumberExist(Txt_NumeroIdentificacion.Text).Id_usuario;
                Txt_Nombre.Text = bl.IdNumberExist(Txt_NumeroIdentificacion.Text).Nombre;
                Txt_ApellidoI.Text = bl.IdNumberExist(Txt_NumeroIdentificacion.Text).Apellido1;
                Txt_ApellidoII.Text = bl.IdNumberExist(Txt_NumeroIdentificacion.Text).Apellido2; 
                Txt_Correo.Text = bl.IdNumberExist(Txt_NumeroIdentificacion.Text).Correo;

                if (bl.IdNumberExist(Txt_NumeroIdentificacion.Text).Id_estado == 1)
                {
                    Txt_Estado.Text = "Activo";
                }
                else
                {
                    Txt_Estado.Text = "Inactivo";
                }

                
            }
            
        }

        private void Btn_Modifcar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_NumeroIdentificacion.Text) || String.IsNullOrEmpty(Txt_Nombre.Text) || String.IsNullOrEmpty(Txt_ApellidoI.Text) ||
                String.IsNullOrEmpty(Txt_ApellidoII.Text) || String.IsNullOrEmpty(Txt_Correo.Text))
            {
                MessageBox.Show("Algunos campos aún se encuentra vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bl.ModificarUsuario(Txt_NumeroIdentificacion.Text, Txt_Nombre.Text, Txt_ApellidoI.Text, Txt_ApellidoII.Text, Txt_Correo.Text, "N/A");
                MessageBox.Show("El usuario se ha modificado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
