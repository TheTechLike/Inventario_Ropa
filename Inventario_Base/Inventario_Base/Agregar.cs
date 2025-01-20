using Inventario_Base.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_Base
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Agregar_Load(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            dateTimePicker1.Value = DateTime.Now;
            var id = await consultar.GetLastInventario();
            textBox1.Text = (id[0].ObjetoID + 1).ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void comboBox1_DropDown(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();


            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "MarcaID";
            comboBox1.DataSource = await consultar.GetMarcas();
        }

        private async void comboBox2_DropDown(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();


            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "TipoID";
            comboBox2.DataSource = await consultar.GetTipo();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async void comboBox4_DropDown(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();


            comboBox4.DisplayMember = "Pasillo";
            comboBox4.ValueMember = "UbicacionID";
            comboBox4.DataSource = await consultar.GetUbi();
        }
    }
}
