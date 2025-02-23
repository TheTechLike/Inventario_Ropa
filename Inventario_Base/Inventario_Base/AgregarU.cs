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
       Insertar function = new Insertar();
        public AgregarU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarU_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "RolID";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = new List<MRol>
            {
                new MRol { RolID = 1, Nombre = "Administrador" },
                new MRol { RolID = 2, Nombre = "Supervisor" },
                new MRol { RolID = 3, Nombre = "Empleado" }
            };
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ahora el Usuario debe ingresar su contraseña, por favor deje que el usuario coloque su contraseña", "Contraseña", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                UserPassword userPassword = new UserPassword();
                userPassword.Show();
                while (userPassword.Visible == true)
                {
                    await Task.Delay(1000);

                }

                if (userPassword.password != "" && userPassword.Visible == false)
                {

                    var usuario = new MUsuario
                    {
                        Nombre = textBox1.Text,
                        Apellido = textBox2.Text,
                        Numero = maskedTextBox1.Text,
                        Correo = textBox3.Text,
                        Usuario = textBox4.Text,
                        Contraseña = userPassword.password,
                        RolID = Convert.ToInt32(comboBox1.SelectedValue)
                    };
                    if (await InsertUsuario(usuario))
                    {
                        MessageBox.Show("Usuario Agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userPassword.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el usuario\n" + "Error: "+function.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        private async Task<bool> InsertUsuario(MUsuario usuario)
        {
         
            var result = await function.PostUser(usuario);
            return result;
        }
    }
}
