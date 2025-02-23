using Inventario_Base.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario_Base
{
    public partial class Actualizar : Form
    {
        // Instancia de la clase Consultar para realizar consultas a la base de datos
        Consultar consultar = new Consultar();
        private int ID = 0; // Variable para almacenar el ID del objeto seleccionado

        public Actualizar()
        {
            InitializeComponent();
            // Deshabilitar botones de minimizar y maximizar
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            // Asegurarse de que el botón de cerrar (X) esté presente
            this.ControlBox = true;

            // Cambiar el estilo del borde si es necesario (opcional)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            splitContainer1.IsSplitterFixed = true;
        }

        private async void Actualizar_Load(object sender, EventArgs e)
        {
            // Cargar datos en el DataGridView y en los ComboBox al cargar el formulario
            dataGridView1.DataSource = await consultar.GetInventariou(string.Empty);
            dataGridView1.Refresh();

            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "MarcaID";
            comboBox1.DataSource = await consultar.GetMarcas();
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "TipoID";
            comboBox2.DataSource = await consultar.GetTipo();
            comboBox4.DisplayMember = "Pasillo";
            comboBox4.ValueMember = "UbicacionID";
            comboBox4.DataSource = await consultar.GetUbi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Marca
            Marca marca = new Marca();
            marca.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento vacío para manejar cambios en la selección del ComboBox1
        }

        private async void comboBox3Resfrech()
        {
            // Refresca los datos del ComboBox3 basado en la selección del ComboBox2
            comboBox3.DisplayMember = "Size";
            comboBox3.ValueMember = "SizeID";
            comboBox3.DataSource = await consultar.GetSize(Convert.ToInt32(comboBox2.SelectedValue));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al cambiar la selección del ComboBox2, se refresca el ComboBox3 y se habilita
            comboBox3Resfrech();
            comboBox3.Enabled = true;
        }

        private async void comboBox1_DropDown(object sender, EventArgs e)
        {
            // Evento vacío para manejar el despliegue del ComboBox1
        }

        private async void comboBox2_DropDown(object sender, EventArgs e)
        {
            // Evento vacío para manejar el despliegue del ComboBox2
        }

        private async void comboBox4_DropDown(object sender, EventArgs e)
        {
            // Evento vacío para manejar el despliegue del ComboBox4
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            // Evento vacío para manejar el despliegue del ComboBox3
        }

        private async void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Maneja la selección de una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var selectedRow = dataGridView1.SelectedRows[0];

                // Obtener los datos de la fila seleccionada
                ID = Convert.ToInt32(selectedRow.Cells["ObjetoID"].Value);
                var nombre = selectedRow.Cells["Nombre"].Value.ToString();
                var marcaTexto = selectedRow.Cells["Marca"].Value.ToString();
                var tipoTexto = selectedRow.Cells["Tipo"].Value.ToString();
                var sizeTexto = selectedRow.Cells["Size"].Value.ToString();
                var color = selectedRow.Cells["Color"].Value.ToString();
                var cantidad = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);
                var precio = Convert.ToDecimal(selectedRow.Cells["Precio"].Value);
                var pasillo = selectedRow.Cells["Pasillo"].Value.ToString();
                var sector = selectedRow.Cells["Sector"].Value.ToString();
                var fila = selectedRow.Cells["Fila"].Value.ToString();

                // Concatenar los campos de ubicación
                string ubicacionTexto = $"{pasillo}-{sector}-{fila}";

                // Obtener los IDs correspondientes a los textos
                var marcas = await consultar.GetMarcas();
                var tipos = await consultar.GetTipo();
                var ubicaciones = await consultar.GetUbi();

                var marcaID = marcas.Where(m => m.Nombre == marcaTexto)?.First().MarcaID;
                var tipoID = tipos.Where(t => t.Nombre == tipoTexto)?.First().TipoID;
                var ubicacionID = ubicaciones.Where(u => u.Pasillo == ubicacionTexto)?.First().UbicacionID;

                // Asignar los valores a los controles correspondientes
                textBox1.Text = nombre;
                comboBox1.SelectedValue = marcaID;
                comboBox2.SelectedValue = tipoID;
                var sizes = await consultar.GetSize(Convert.ToInt32(tipoID));
                var sizeID = sizes.Where(s => s.Size == sizeTexto)?.First().SizeID;
                comboBox3.SelectedValue = sizeID;
                textBox2.Text = color;
                numericUpDown1.Value = cantidad;
                textBox3.Text = precio.ToString();
                comboBox4.SelectedValue = ubicacionID;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón de actualizar, se confirma la acción y se actualiza el inventario
            var function = new Insertar();
            DialogResult result = MessageBox.Show("Seguro que quieres atualizarlo?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.OK)
                {
                    // Crea un nuevo objeto de inventario con los datos ingresados
                    var minventario = new MInventario
                    {
                        ObjetoID = ID,
                        Nombre = textBox1.Text,
                        MarcaID = Convert.ToInt32(comboBox1.SelectedValue),
                        TipoID = Convert.ToInt32(comboBox2.SelectedValue),
                        SizeID = Convert.ToInt32(comboBox3.SelectedValue),
                        Color = textBox2.Text,
                        Cantidad = Convert.ToInt32(numericUpDown1.Value),
                        Precio = Convert.ToDecimal(textBox3.Text),
                        UbicacionID = Convert.ToInt32(comboBox4.SelectedValue)
                    };

                    try
                    {
                        // Envía el objeto de inventario al servidor y procesa la respuesta
                        var response = await function.PutInv(minventario);
                        var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response);
                        bool isSuccess = jsonResponse.GetProperty("response").GetBoolean();
                        string message = jsonResponse.GetProperty("message").GetString();

                        if (isSuccess)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            Actualizar_Load(sender, e); // Recarga los datos en el formulario
                        }
                        else
                        {
                            MessageBox.Show($"Error al Actualizar: {message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
