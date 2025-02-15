namespace Inventario_Base
{
    public partial class Main : Form
    {
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
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);

            inventario.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(inventario);
            this.splitContainer1.Panel2.Tag = inventario;
            inventario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Actualizar inventario = new Actualizar();
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);

            inventario.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(inventario);
            this.splitContainer1.Panel2.Tag = inventario;
            inventario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Eliminar inventario = new Eliminar();
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);

            inventario.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(inventario);
            this.splitContainer1.Panel2.Tag = inventario;
            inventario.Show();
        }
    }
}
