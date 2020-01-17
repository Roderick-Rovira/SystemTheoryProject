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
                Tbl_ListaUsuarios.DataSource = bl.MostrarUsuariosStoreProcedure();
            }
            catch (Exception)
            {
            }

        }

        private void Form_Mantenimiento_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int cedula = int.Parse(Txt_NumeroIdentificacion.Text);
                string Nombre = Txt_Nombre.Text;
                string Apellido1 = Txt_ApellidoI.Text;
                string Apellido2 = Txt_ApellidoII.Text;
                string correo = Txt_ApellidoII.Text;

                // Realizar correción de pantalla.


                bl.AgregarUsuario(cedula.ToString(), Nombre, Apellido1, Apellido2, correo);
                CargarData();
                MessageBox.Show("Se ha agragado correctamente");
                ClearSpaces();


            }
            catch (Exception)
            {


                MessageBox.Show("Ingrsese el número de identificación para que el usuario sea agragado correctamente");


            }

        }

        private void ClearSpaces()
        {
            Txt_NumeroIdentificacion.Text = "";
            Txt_Nombre.Text = "";
            Txt_ApellidoI.Text = "";
            Txt_ApellidoII.Text = "";
            Txt_Contrasenna.Text = "";
            Txt_ConfirmarContrasenna.Text = "";
        }

        public void cc() 
        {

            if (Tbl_ListaUsuarios.SelectedRows.Count > 0)
            {
                try
                {
                    string estado;
                    id = int.Parse(Tbl_ListaUsuarios.CurrentRow.Cells["Id_usuario"].Value.ToString());
                    Txt_NumeroIdentificacion.Text = Tbl_ListaUsuarios.CurrentRow.Cells["Identificacion"].Value.ToString();
                    Txt_Nombre.Text = Tbl_ListaUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                    Txt_ApellidoI.Text = Tbl_ListaUsuarios.CurrentRow.Cells["Apellido1"].Value.ToString();
                    Txt_ApellidoII.Text = Tbl_ListaUsuarios.CurrentRow.Cells["Apellido2"].Value.ToString();
                    Txt_Contrasenna.Text = Tbl_ListaUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                    estado = Tbl_ListaUsuarios.CurrentRow.Cells["Id_estado"].Value.ToString();

                    if (estado == "1")
                    {
                        Txt_Contrasenna.Text = "Activo";
                    }
                    else
                    {
                        Txt_Contrasenna.Text = "Inactivo";
                    }



                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string identificacion = Txt_NumeroIdentificacion.Text;
            string Nombre = Txt_Nombre.Text;
            string Apellido1 = Txt_ApellidoI.Text;
            string Apellido2 = Txt_ApellidoII.Text;
            string correo = Txt_Contrasenna.Text;
            bl.ModificarUsuario(identificacion ,Nombre, Apellido1, Apellido2, correo);
            CargarData();
            MessageBox.Show("Se ha agragado actualizado correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bl.ActivarUsuario(id);           
            CargarData();
            cc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bl.DesactivarUsuario(id);           
            CargarData();
            cc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }
    }
}
