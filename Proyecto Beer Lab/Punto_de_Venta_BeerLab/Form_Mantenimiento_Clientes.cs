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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Mantenimiento_Clientes_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarDatos();
        }


        public void CargarDatos() 
        {
            dataGridView1.DataSource = bl.MostrarClientes();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TipoID = comboBox1.SelectedItem.ToString();
            bl.AgregarCliente(TipoID,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,DateTime.Parse(dateTimePicker1.Text),DateTime.Now, textBox5.Text, int.Parse(textBox6.Text));
            CargarDatos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {

                    string id = dataGridView1.CurrentRow.Cells["Identificacion"].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells["Tipo_identificacion"].Value.ToString();
                    textBox1.Text = dataGridView1.CurrentRow.Cells["Identificacion"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells["Apellido1"].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells["Apellido2"].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Fecha_nacimiento"].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();




                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TipoID = comboBox1.SelectedItem.ToString();
            bl.ModificarCliente(TipoID, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, DateTime.Parse(dateTimePicker1.Text), DateTime.Now, textBox5.Text, int.Parse(textBox6.Text));
            CargarDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        private void Form_Mantenimiento_Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
    
}
