namespace Inventario_Base
{
    public partial class Main : Form
    {
        public string nombreuser = ""; // Almacena el nombre del usuario
        public int rol = 0; // Almacena el rol del usuario

        public Main()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Evento que se ejecuta al cargar el formulario
            Login login = new Login(this); // Crea una instancia del formulario de Login
            Inicio iniciar = new Inicio(); // Crea una instancia de la clase Inicio
            if (iniciar.inicio == false)
            {
                // Si el inicio no ha sido completado, deshabilita el formulario principal y muestra el formulario de Login
                this.Enabled = false;
                login.Show();
            }
        }

        private void Roles(int rol)
        {
            // Configura la visibilidad y habilitaci�n de controles seg�n el rol del usuario
            switch (rol)
            {
                case 2:
                    // Si el rol es 2 (Supervisor), oculta las opciones de agregar, modificar y eliminar usuario
                    agregarUsuarioToolStripMenuItem.Visible = false;
                    modificarUsuarioToolStripMenuItem.Visible = false;
                    eliminarUsuarioToolStripMenuItem.Visible = false;
                    break;
                case 3:
                    // Si el rol es 3 (Empleado), oculta el men� de usuario y deshabilita el bot�n de eliminar
                    usuarioToolStripMenuItem.Visible = false;
                    button3.Enabled = false;
                    button3.BackColor = Color.Gray;
                    break;
                default:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento vac�o para manejar clics en el label2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Agregar
            Agregar agregar = new Agregar();
            agregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Buscar dentro del panel3
            Buscar inventario = new Buscar();
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            inventario.TopLevel = false;
            this.panel3.Controls.Add(inventario);
            this.panel3.Tag = inventario;
            inventario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Actualizar dentro del panel3
            Actualizar inventario = new Actualizar();
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            inventario.TopLevel = false;
            this.panel3.Controls.Add(inventario);
            this.panel3.Tag = inventario;
            inventario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Eliminar dentro del panel3
            Eliminar inventario = new Eliminar();
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            inventario.TopLevel = false;
            this.panel3.Controls.Add(inventario);
            this.panel3.Tag = inventario;
            inventario.Show();
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            // Evento que se ejecuta al finalizar el redimensionamiento del formulario
            if (panel3.Controls.Count > 0)
            {
                if (panel3.Controls[0] is Form formulario)
                {
                    formulario.Dock = DockStyle.Fill;
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            // Evento que se ejecuta al cambiar el tama�o del formulario
            if (panel3.Controls.Count > 0)
            {
                if (panel3.Controls[0] is Form formulario)
                {
                    formulario.Dock = DockStyle.Fill;
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            // Evento que se ejecuta al cambiar la visibilidad del formulario
            label3.Text = "Bienvenido/a" + " " + nombreuser; // Muestra un mensaje de bienvenida con el nombre del usuario
            Roles(rol); // Configura los roles del usuario
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Agregar Usuario
            AgregarU agregarU = new AgregarU();
            agregarU.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Evento que se ejecuta al cerrar el formulario
            Application.Exit(); // Cierra la aplicaci�n
        }
    }
}
