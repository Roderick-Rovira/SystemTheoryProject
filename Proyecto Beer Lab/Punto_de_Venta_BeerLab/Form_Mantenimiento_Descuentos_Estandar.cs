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
    public partial class Form_Mantenimiento_Descuentos_Estandar : Form
    {
        int id;
        BussinesLayer bl;
        public Form_Mantenimiento_Descuentos_Estandar()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_Descuentos_Estandar(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }


        private void Form_Mantenimiento_Descuentos_Estandar_Load(object sender, EventArgs e)
        {
            label1.Text = bl.TipoUsuario();
            label2.Text = bl.Nombre_Usuario();
            CargarDatos();

        }

        public void CargarDatos() 
        {

            dataGridView1.DataSource = bl.MostrarDescuentos_Estandar();
        }

        private void Form_Mantenimiento_Descuentos_Estandar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.AgregarDescuentos_Estandar(int.Parse(textBox1.Text),int.Parse(textBox2.Text),comboBox1.SelectedItem.ToString());
            CargarDatos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {

                    id = int.Parse(dataGridView1.CurrentRow.Cells["Id_DescEstandar"].Value.ToString());

                    textBox1.Text = dataGridView1.CurrentRow.Cells["Cant_unidades"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["Descuento"].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells["Dia"].Value.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bl.ModificarDescuentos_Estandar(id,int.Parse(textBox1.Text), int.Parse(textBox2.Text), comboBox1.SelectedItem.ToString());
            CargarDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }
    }
}
