namespace Inventario_Base
{
    public partial class Main : Form
    {
        public string nombreuser = "";
        public int rol = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login = new Login(this);
            Inicio iniciar = new Inicio();
            if (iniciar.inicio == false)
            {

                this.Enabled = false;
                login.Show();
            }


        }

        private void Roles(int rol)
        {
            switch (rol)
            {
                case 2:
                    agregarUsuarioToolStripMenuItem.Visible = false;
                    modificarUsuarioToolStripMenuItem.Visible = false;
                    eliminarUsuarioToolStripMenuItem.Visible = false;
                    break;
                case 3:
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

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            label3.Text = "Bienvenido/a" + " " + nombreuser;
            Roles(rol);
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarU agregarU = new AgregarU();
            agregarU.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
