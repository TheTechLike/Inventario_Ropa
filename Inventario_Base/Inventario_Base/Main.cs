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
    }
}
