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
    public partial class Login : Form
    {
        private Main main;
        public Login(Main principal)
        {
            InitializeComponent();
            this.main = principal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contra = textBox2.Text;

            if (usuario == "admin" && contra == "1234")
            {
                this.Close();
                main.Enabled = true;
                main.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrecta");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            main.Hide();
        }
      
    }
}
