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
    public partial class Buscar : Form
    {
        Consultar consultar = new Consultar();
        public Buscar()
        {
            InitializeComponent();

            // Deshabilitar botones de minimizar y maximizar
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            // Asegurarse de que el botón de cerrar (X) esté presente
            this.ControlBox = true;

            // Cambiar el estilo del borde si es necesario (opcional)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Buscar_Load(object sender, EventArgs e)

        {
            label2.Text = Conexion.conectionstringlocal;
            dataGridView1.DataSource = await consultar.GetInventariou(string.Empty);
            dataGridView1.Refresh();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await consultar.GetInventariou(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar_Load(sender, e);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Buscar_ResizeEnd(object sender, EventArgs e)
        {

        }
    }
}
