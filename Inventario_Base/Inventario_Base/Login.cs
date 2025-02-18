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
    public partial class Login : Form
    {
        private Main main;
        Inicio iniciar = new Inicio();
        public Login(Main principal)
        {
            

            InitializeComponent();
            this.main = principal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MLogin mLogin = new MLogin();
            mLogin.User = textBox1.Text;
            mLogin.Password = textBox2.Text;

            if (mLogin.User == "admin" && mLogin.Password == "1234")
            {
                iniciar.inicio = true;
                this.Close();
                
                main.Enabled = true;
                main.Show();

            }
            else if (mLogin.User != "admin")
            {
                var function = new DLogin();
                if (await function.GetLogin(mLogin) != "0")
                {
                    iniciar.inicio = true;
                    this.Close();
                   
                    main.Enabled = true;
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrecta");
                }

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            main.Hide();
            this.Enabled = false;
            new Carga(this).Show();
            
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
                    if(iniciar.inicio == false)
            {
                Application.Exit();
            }
        }
    }
}
