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
        // Instancia de la clase Consultar para realizar consultas a la base de datos
        Consultar consultar = new Consultar();

        public Buscar()
        {
            InitializeComponent(); // Inicializa los componentes del formulario

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
            // Evento vacío para manejar clics en el DataGridView
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento vacío para manejar clics en el label1
        }

        private async void Buscar_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, se obtienen los datos del inventario y se muestran en el DataGridView
            dataGridView1.DataSource = await consultar.GetInventariou(string.Empty);
            dataGridView1.Refresh();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Al cambiar el texto en el TextBox1, se filtran los datos del inventario y se muestran en el DataGridView
            dataGridView1.DataSource = await consultar.GetInventariou(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón, se recargan los datos del inventario
            Buscar_Load(sender, e);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Evento vacío para manejar clics en el label1
        }

        private void Buscar_ResizeEnd(object sender, EventArgs e)
        {
            // Evento vacío para manejar el final del redimensionamiento del formulario
        }
    }
}
