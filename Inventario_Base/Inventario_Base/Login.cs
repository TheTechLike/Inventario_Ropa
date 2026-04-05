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
        internal Main main; // Instancia de la clase Main
        Inicio iniciar = new Inicio(); // Instancia de la clase Inicio
        Consultar consultar = new Consultar(); // Instancia de la clase Consultar
        Insertar insertar = new Insertar(); // Instancia de la clase Insertar

        public Login(Main principal)
        {
            InitializeComponent();
            this.main = principal; // Asigna la instancia principal de Main
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento vacío para manejar clics en el label1
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true; // Muestra el pictureBox2
            // Maneja el evento de clic en el botón de inicio de sesión
            MLogin mLogin = new MLogin();
            mLogin.User = textBox1.Text;
            mLogin.Password = textBox2.Text;

            if (mLogin.User == "admin" && mLogin.Password == "1234")
            {
                // Si el usuario y la contraseña son "admin" y "1234", se inicia la sesión como administrador
                iniciar.inicio = true;
                this.Close();

                main.Enabled = true;
                main.Show();
            }
            else if (mLogin.User != "admin")
            {
                // Si el usuario no es "admin", se verifica la autenticación con la base de datos
                var function = new DLogin();
                var login = await function.GetLogin(mLogin);

                if (login[0] != "0")
                {
                    // Si la autenticación es exitosa, se obtienen los datos del usuario y se inicia la sesión
                    string userid = login[0].ToString();
                    string rolid = login[1].ToString();
                    string changeid = login[2].ToString();
                    if (login[0] != "local")
                    {
                        var id = await consultar.GetUserid(Convert.ToInt32(userid));
                        this.main.nombreuser = id.Select(x => x.Nombre + " " + x.Apellido).FirstOrDefault();

                        if (changeid == "True")
                        {
                            var result = MessageBox.Show("Debe de cambiar su contraseña, por favor coloque su contraseña", "Contraseña", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (result == DialogResult.OK)
                            {
                                UserPassword userPassword = new UserPassword();
                                userPassword.Show();
                                while (userPassword.Visible == true)
                                {
                                    await Task.Delay(1000); // Espera hasta que el formulario de contraseña se cierre
                                }
                                if (userPassword.password != "" && userPassword.Visible == false)
                                {
                                    var userchange = new MUsuario();
                                    userchange.Nombre = id.FirstOrDefault().Nombre;
                                    userchange.Apellido = id.FirstOrDefault().Apellido;
                                    userchange.Numero = id.FirstOrDefault().Numero;
                                    userchange.Correo = id.FirstOrDefault().Correo;
                                    userchange.Usuario = id.FirstOrDefault().Usuario;
                                    userchange.RolID = id.FirstOrDefault().RolID;
                                    userchange.ID = id.FirstOrDefault().ID;
                                    userchange.Contraseña = userPassword.password;
                                    userchange.FechaCreacion = id.FirstOrDefault().FechaCreacion;
                                    bool changeuser = await insertar.PutUser(userchange, true);
                                    if(changeuser)
                                    {
                                        MessageBox.Show("Contraseña actualizada");
                                        userPassword.Close();
                                    }
                                }
                            }
                        }
                    }
                    this.main.rol = Convert.ToInt32(rolid);
                    iniciar.inicio = true;
                    this.Close();

                    main.Enabled = true;
                    main.Show();
                }
                else
                {
                    // Si la autenticación falla, se muestra un mensaje de error
                    MessageBox.Show("Usuario/Contraseña incorrecta");
                }
            }
            else
            {
                // Si la autenticación falla, se muestra un mensaje de error
                MessageBox.Show("Usuario/Contraseña incorrecta");
            }
            pictureBox2.Visible = false; // Oculta el pictureBox2
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Evento que se ejecuta al cargar el formulario
            main.Hide(); // Oculta el formulario principal
            this.Enabled = false;
            Carga carga = new Carga(this);
            carga.Show(); // Muestra el formulario de carga
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Evento que se ejecuta al cerrar el formulario
            if (iniciar.inicio == false)
            {
                Application.Exit(); // Cierra la aplicación si no se ha iniciado sesión
            }
        }
    }
}
