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
        Insertar function = new Insertar();
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
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();
                maskedTextBox1.Text = dataGridView1.SelectedRows[0].Cells["Numero"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["Correo"].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString();
                //textBox5.Text = dataGridView1.SelectedRows[0].Cells["Contraseña"].Value.ToString();
                var rols = await cn.GetRol();
                var rol = rols.Where(c => c.Nombre == dataGridView1.SelectedRows[0].Cells["Rol"].Value.ToString()).First().RolID;
                comboBox1.SelectedValue = rol;
                bool check = await cn.GetUsuariolclBD(dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString());
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

        private async void button2_Click(object sender, EventArgs e)
        {
            MUsuario user = new MUsuario();
            user.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
            user.Nombre = textBox1.Text;
            user.Apellido = textBox2.Text;
            user.Numero = maskedTextBox1.Text.Replace("-", "");
            user.Correo = textBox3.Text;
            user.Usuario = textBox4.Text;
            if(checkBox2.Checked)
            user.Contraseña = "Prueba";
            user.RolID = Convert.ToInt32(comboBox1.SelectedValue);
            if(await ActualizarUsuario(user,checkBox2.Checked))
            {

                MessageBox.Show("Usuario Actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario\n" + "Error: " + function.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> ActualizarUsuario(MUsuario usuario, bool cambioC)
        {
            bool result = await function.PutUser(usuario, cambioC);
            bool result2 = true;

            if ( result && result2)
            { return true; }
            else
                return false;
        }
    }
}
