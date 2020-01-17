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
    
    public partial class Form_Menu_Administrador : Form
    {
        BussinesLayer bl;
        public Form_Menu_Administrador()
        {
            InitializeComponent();
        }

        public Form_Menu_Administrador(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        // Se encarga de cargar los datos en las etiquetas que se encuentran en la parte superior. 

        private void Form_Menu_Administrador_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
        }

        // Invoca el menú de Mantenimeintos. 

        private void Btn_Menu_Mantenimientos_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        // Invoca el menú de Seguridad.

        private void Btn_Menu_Seguridad_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Seguridad fms = new Form_Menu_Seguridad(bl);
            fms.Show();
        }

        // Invoca el menú de Punto de Venta. 

        private void Btn_Menu_Punto_Venta_Click (object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Ventas fmv = new Form_Menu_Ventas(bl);
            fmv.Show();
        }

        // Invoca el menú de Inventario.

        private void Btn_Menu_Inventario_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Inventario Form_Menu_Inventario = new Form_Menu_Inventario(bl);
            Form_Menu_Inventario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Ventas fmv = new Form_Menu_Ventas(bl);
            fmv.Show();
        }

        // Invoca el menú de Contabilidad.

        private void Btn_Menu_Contabilidad_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Menu_Contabilidad fmv = new Form_Menu_Contabilidad(bl);
            fmv.Show();
        }

        // Botón para salir.

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Esta seguro de que desea cerrar sesion?.", "¡Cerrar session!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {

                this.Dispose();
                Form_IniciarSession fi = new Form_IniciarSession(bl);
                fi.Show();

            }
            else { }
        }

        // Se encarga de cerrar completamente la aplicación por medio de la eliminación de los threads existentes. 

        private void Form_Menu_Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
