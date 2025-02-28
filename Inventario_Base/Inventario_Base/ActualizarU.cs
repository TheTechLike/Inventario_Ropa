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
    public partial class ActualizarU : Form
    {
        Consultar cn = new Consultar();
        public ActualizarU()
        {
            InitializeComponent();
        }

        private async void ActualizarU_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            dataGridView1.DataSource = await cn.GetUser("");
            dataGridView1.Refresh();

            comboBox1.ValueMember = "RolID";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = await cn.GetRol();
            pictureBox1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["Nombres"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["Apellidos"].Value.ToString();
                maskedTextBox1.Text = dataGridView1.SelectedRows[0].Cells["Numero"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["Correo"].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells["Contraseña"].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.SelectedRows[0].Cells["RolID"].Value;
            }

            bool  check = await cn.GetUsuariolclBD(dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString());
            if (check)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
    }
}
