using Inventario_Base.Datos;
using Microsoft.IdentityModel.Protocols.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Inventario_Base
{
    public partial class Login : Form
    {
        private Main main;
        Inicio iniciar = new Inicio();
        Consultar consultar = new Consultar();
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
                var login = await function.GetLogin(mLogin);

                if (login[0] != "0")
                {
                    string userid = login[0].ToString();
                    string rolid = login[1].ToString();
                    var id = await consultar.GetUserid(Convert.ToInt32(userid));
                    this.main.nombreuser = id.Select(x => x.Nombre + " " + x.Apellido).FirstOrDefault();
                    this.main.rol = Convert.ToInt32(rolid);
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
            Carga carga = new Carga(this);
            carga.Show();



        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {


            if (iniciar.inicio == false)
            {
                Application.Exit();
            }
        }
    }
}
