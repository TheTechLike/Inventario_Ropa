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
        Consultar consultar = new Consultar();
        private int ID = 0;

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
            Marca marca = new Marca();
            marca.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void comboBox3Resfrech()
        {
            comboBox3.DisplayMember = "Size";
            comboBox3.ValueMember = "SizeID";
            comboBox3.DataSource = await consultar.GetSize(Convert.ToInt32(comboBox2.SelectedValue));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3Resfrech();
            comboBox3.Enabled = true;
        }

        private async void comboBox1_DropDown(object sender, EventArgs e)
        {

        }

        private async void comboBox2_DropDown(object sender, EventArgs e)
        {

        }

        private async void comboBox4_DropDown(object sender, EventArgs e)
        {


        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
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
            this.Close();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var function = new Insertar();
            DialogResult result = MessageBox.Show("Seguro que quieres atualizarlo?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.OK)
                {
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
                        var response = await function.PutInv(minventario);
                        var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response);

                        bool isSuccess = jsonResponse.GetProperty("response").GetBoolean();
                        string message = jsonResponse.GetProperty("message").GetString();

                        if (isSuccess)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            Actualizar_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show($"Error al Actualizar: {message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message , "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
