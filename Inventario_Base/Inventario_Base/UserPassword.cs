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
    public partial class UserPassword : Form
    {
        // Variable pública para almacenar la contraseña ingresada por el usuario
        public string password = "";

        public UserPassword()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Maneja el evento de clic en el botón de confirmación de contraseña
            if (textBox1.Text == textBox2.Text)
            {
                // Si las contraseñas ingresadas coinciden, se muestra un mensaje de confirmación
                var result = MessageBox.Show("Seguro de la contraseña?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    // Si el usuario confirma, se almacena la contraseña y se oculta el formulario
                    password = textBox1.Text;
                    this.Hide();
                }
            }
            else
            {
                // Si las contraseñas no coinciden, se muestra un mensaje de error
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
