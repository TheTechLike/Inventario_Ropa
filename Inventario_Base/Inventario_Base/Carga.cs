using Inventario_Base.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Inventario_Base
{
    public partial class Carga : Form
    {
        private static string errorBD ="";
        bool Sin = false;
        public Carga()
        {
            InitializeComponent();
           

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private  void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100 || Sin == true) 
            {
                progressBar1.Value = 100;
                timer1.Stop();
                timer2.Enabled = true;
                timer2.Start();



            }
        }


        private async Task<bool> SincronizacionDB()
        {
            string apiUrl = "http://10.0.0.129:1025/api/marca";
            string local = Conexion.conectionstringlocal;
            bool canConnect = await CanConnectToApi(apiUrl);
            bool canConnectLocal = CanConnectToLocal(local);
            if (canConnect && canConnectLocal)
            {
                Sincronizacion sincronizacion = new Sincronizacion();
                await sincronizacion.Sincronizar();
                return true;
            }
            else
            {
                if (!canConnectLocal)
                {
                    timer1.Stop();
                    DialogResult result=MessageBox.Show("No se puede conectar a la base de datos local\n Error: "+errorBD , "Error",MessageBoxButtons.CancelTryContinue ,MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    else
                    {
                        timer1.Start();
                    }
                }

                return false;
            }




        }

        private async Task<bool> CanConnectToApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    return response.IsSuccessStatusCode;
                }
                catch (Exception )
                {
                    
                    return false;
                }
            }
        }
        private bool CanConnectToLocal(string local)
        {
            using (SqlConnection cn = new SqlConnection(local))
            {
                try
                {
                    cn.Open();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    errorBD = (e.Message);
                    return false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval == 3000)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private async void Carga_Load(object sender, EventArgs e)
        {
            timer1.Start();
           if( await SincronizacionDB())
            {
                Sin = true;
            }
        }
    }
}
