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
    public partial class BuscarU : Form
    {
        Consultar cn = new Consultar();
        public BuscarU()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BuscarU_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = await cn.GetUser(textBox1.Text);
            dataGridView1.Refresh();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await cn.GetUser(textBox1.Text);

        }
    }
}
