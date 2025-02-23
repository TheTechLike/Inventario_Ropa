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
        public string password="";
        public UserPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == textBox2.Text)
            {
                var result = MessageBox.Show("Seguro de la contraseña?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    password = textBox1.Text;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
