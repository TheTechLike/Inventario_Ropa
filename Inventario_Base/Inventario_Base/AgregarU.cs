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
    public partial class AgregarU : Form
    {
        // Instancia de la clase Insertar para realizar operaciones de inserción
        Insertar function = new Insertar();
        Consultar cn = new Consultar();

        public AgregarU()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento vacío para manejar clics en el label1
        }

        private async void AgregarU_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, se configuran los datos del ComboBox1
            comboBox1.ValueMember = "RolID";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = await cn.GetRol();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón de agregar, se solicita al usuario que ingrese su contraseña

            // Crea un nuevo objeto de usuario con los datos ingresados
            var usuario = new MUsuario
            {
                Nombre = textBox1.Text,
                Apellido = textBox2.Text,
                Numero = maskedTextBox1.Text,
                Correo = textBox3.Text,
                Usuario = textBox4.Text,
                Contraseña = "Prueba",
                RolID = Convert.ToInt32(comboBox1.SelectedValue)
            };
            if (await InsertUsuario(usuario))
            {

                MessageBox.Show("Usuario Agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close(); // Cierra el formulario actual
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario\n" + "Error: " + function.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task<bool> InsertUsuario(MUsuario usuario)
        {
            // Inserta el usuario en la base de datos
            var result = await function.PostUser(usuario);
            bool result2 = true;
            if (checkBox1.Checked)
            {
                // Si el usuario es local
                result2 = await function.PostUserlcl(usuario);
            }
            if (result && result2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            Close();
        }
    }
}
