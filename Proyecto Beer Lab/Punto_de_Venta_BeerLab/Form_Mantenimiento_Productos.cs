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
    public partial class Form_Mantenimiento_Productos : Form
    {
        BussinesLayer bl;
        public Form_Mantenimiento_Productos()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_Productos(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form_Mantenimiento_Productos_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarDatos();
        }

        public void CargarDatos() 
        {
            dataGridView1.DataSource = bl.MostrarProductos();        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime FechaIngreso = DateTime.Now;
            int Estado = 1;
            string Descripcion = textBox2.Text + " " + comboBox1.SelectedItem.ToString();
            bl.AgregarProducto(textBox1.Text, textBox2.Text,comboBox1.Text,comboBox2.Text, int.Parse(textBox3.Text),int.Parse(comboBox3.Text),decimal.Parse(textBox4.Text),DateTime.Parse(dateTimePicker1.Text),DateTime.Parse(dateTimePicker2.Text) ,int.Parse(textBox5.Text),int.Parse(textBox6.Text),FechaIngreso,Estado,Descripcion);
            CargarDatos();
        }

        private void Form_Mantenimiento_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime FechaModificacion = DateTime.Now;
            string Descripcion;            
            
            Descripcion = textBox2.Text+" "+comboBox1.SelectedItem.ToString();
            bl.ModificarProducto(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), int.Parse(textBox3.Text),int.Parse(comboBox3.SelectedItem.ToString()), decimal.Parse(textBox4.Text), DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text), Descripcion, FechaModificacion);
            

            CargarDatos();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {

                    string  id = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                    textBox1.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["Nombre_producto"].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells["Tipo_envasado"].Value.ToString();
                    comboBox2.Text = dataGridView1.CurrentRow.Cells["Nivel_fragilidad"].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells["Cantidad_mililitros"].Value.ToString();
                    comboBox3.Text = dataGridView1.CurrentRow.Cells["Nivel_Alcohol"].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells["Precio_producto"].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Fecha_emision"].Value.ToString();
                    dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["Fecha_caducidad"].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells["Stock_Inicial"].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells["Stock_Actual"].Value.ToString();




                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }
    }
}
