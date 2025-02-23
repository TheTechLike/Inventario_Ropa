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

namespace Inventario_Base
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private async void Agregar_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, se obtiene el último ID de inventario y se establece en el TextBox
            Consultar consultar = new Consultar();
            dateTimePicker1.Value = DateTime.Now; // Establece la fecha actual en el DateTimePicker
            var id = await consultar.GetLastInventario();
            textBox1.Text = (id[0].ObjetoID + 1).ToString(); // Muestra el siguiente ID disponible
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Marca
            Marca marca = new Marca();
            marca.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón de agregar, se confirma la acción y se inserta el nuevo inventario
            var function = new Insertar();
            DialogResult result = MessageBox.Show("Seguro que quieres agregarlo?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.OK)
                {
                    // Crea un nuevo objeto de inventario con los datos ingresados
                    var minventario = new MInventario
                    {
                        ObjetoID = Convert.ToInt32(textBox1.Text),
                        Nombre = textBox5.Text,
                        MarcaID = Convert.ToInt32(comboBox1.SelectedValue),
                        TipoID = Convert.ToInt32(comboBox2.SelectedValue),
                        SizeID = Convert.ToInt32(comboBox3.SelectedValue),
                        Color = textBox4.Text,
                        Cantidad = Convert.ToInt32(numericUpDown1.Value),
                        Precio = Convert.ToDecimal(textBox2.Text),
                        FechaAquisicion = dateTimePicker1.Value,
                        UbicacionID = Convert.ToInt32(comboBox4.SelectedValue)
                    };

                    try
                    {
                        // Envía el objeto de inventario al servidor y procesa la respuesta
                        var response = await function.PostInv(minventario);
                        var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response);

                        bool isSuccess = jsonResponse.GetProperty("response").GetBoolean();
                        string message = jsonResponse.GetProperty("message").GetString();

                        if (isSuccess)
                        {
                            MessageBox.Show("Agregado con éxito");
                            LimpiarControles(); // Limpia los controles del formulario
                        }
                        else
                        {
                            MessageBox.Show($"Error al agregar: {message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al agregar: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento vacío para manejar clics en el DataGridView
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento vacío para manejar cambios en la selección del ComboBox1
        }

        private async void comboBox1_DropDown(object sender, EventArgs e)
        {
            // Al desplegar el ComboBox1, se obtienen las marcas desde la base de datos
            Consultar consultar = new Consultar();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "MarcaID";
            comboBox1.DataSource = await consultar.GetMarcas();
        }

        private async void comboBox2_DropDown(object sender, EventArgs e)
        {
            // Al desplegar el ComboBox2, se obtienen los tipos desde la base de datos
            Consultar consultar = new Consultar();
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "TipoID";
            comboBox2.DataSource = await consultar.GetTipo();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento vacío para manejar cambios en la selección del ComboBox4
        }

        private async void comboBox4_DropDown(object sender, EventArgs e)
        {
            // Al desplegar el ComboBox4, se obtienen las ubicaciones desde la base de datos
            Consultar consultar = new Consultar();
            comboBox4.DisplayMember = "Pasillo";
            comboBox4.ValueMember = "UbicacionID";
            comboBox4.DataSource = await consultar.GetUbi();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que solo se ingresen números y un punto decimal en el TextBox2
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Bloquea la tecla no permitida
                ShowWarning("Solo se permiten números y un punto decimal.");
            }

            // Evitar más de un punto decimal
            if (e.KeyChar == '.' && textBox2.Text.Contains("."))
            {
                e.Handled = true;
                ShowWarning("Solo se permite un punto decimal.");
            }
        }

        private void ShowWarning(string message)
        {
            // Muestra el mensaje de advertencia utilizando un ToolTip
            toolTip1.Show(message, textBox2, 0, -20, 2000);  // Muestra el mensaje 20 píxeles arriba del TextBox durante 2 segundos
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento vacío para manejar cambios en la selección del ComboBox3
        }

        private void LimpiarControles()
        {
            // Limpia todos los controles del formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
            comboBox3.Enabled = false;
        }

        private async void comboBox3Resfrech()
        {
            // Refresca los datos del ComboBox3 basado en la selección del ComboBox2
            Consultar consultar = new Consultar();

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
    }
}


