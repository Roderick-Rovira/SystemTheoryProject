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
    public partial class Form_Mantenimiento_DescuentosVIP : Form
    {
        int id;
        BussinesLayer bl;
        public Form_Mantenimiento_DescuentosVIP()
        {
            InitializeComponent();
        }

        public Form_Mantenimiento_DescuentosVIP(BussinesLayer bl)
        {
            this.bl = bl;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Mantenimiento_DescuentosVIP_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        public void CargarDatos()
        {

            dataGridView1.DataSource = bl.MostrarDescuentosVIP();


        }

        private void Form_Mantenimiento_DescuentosVIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Mantenimientos fm = new Form_Mantenimientos(bl);
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.AgregarDescuentosVIP(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bl.ModificarDescuentosVIP(id,int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            CargarDatos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {

                     id = int.Parse(dataGridView1.CurrentRow.Cells["Id_DescVIP"].Value.ToString());
                 
                    textBox1.Text = dataGridView1.CurrentRow.Cells["Descuento"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["Puntos"].Value.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Esta columna no tiene información");

                }
            }
        }
    }
}
