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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace Inventario_Base
{
    public partial class Carga : Form
    {
        private Login main; // Instancia de la clase Login
        private static string errorBD = ""; // Variable para almacenar mensajes de error de la base de datos

        public Carga(Login principal)
        {
            InitializeComponent();
            this.main = principal; // Asigna la instancia principal de Login
        }

        public int conectadolcl { get; set; } // Propiedad para indicar el estado de la conexión

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Evento vacío para manejar clics en la barra de progreso
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            // Evento que se ejecuta en cada tick del timer1
            this.main.Hide(); // Oculta el formulario principal
            progressBar1.Increment(1); // Incrementa el valor de la barra de progreso
            if (progressBar1.Value == 100 || await SincronizacionDB() == true)
            {
                // Si la barra de progreso llega a 100 o la sincronización es exitosa
                progressBar1.Value = 100;
                timer1.Stop(); // Detiene el timer1
                timer2.Enabled = true; // Habilita el timer2
                timer2.Start(); // Inicia el timer2
            }
        }

        private async Task<bool> SincronizacionDB()
        {
            // Método para sincronizar la base de datos
            string apiUrl = "http://10.0.0.129:1025/api/marca";
            string local = Conexion.conectionstringlocal;
            bool canConnect = await CanConnectToApi(apiUrl); // Verifica la conexión a la API
            bool canConnectLocal = CanConnectToLocal(local); // Verifica la conexión a la base de datos local
            if (canConnect && canConnectLocal)
            {
                // Si ambas conexiones son exitosas
                Sincronizacion sincronizacion = new Sincronizacion();
                try
                {
                    await sincronizacion.Sincronizar(); // Sincroniza la base de datos
                    label1.Text = "Sincronizacion Completa";
                    progressBar1.Value = 90;
                    conectadolcl = 0; // Ambos conectados
                }
                catch (Exception e)
                {
                    conectadolcl = 1; // Solo local o API
                    MessageBox.Show("Error al sincronizar la base de datos\n Error: " + e.Message + "Error", "\nErrorBD: " + sincronizacion.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            }
            else
            {
                if (!canConnectLocal)
                {
                    // Si no se puede conectar a la base de datos local
                    timer1.Stop();
                    DialogResult result = MessageBox.Show("No se puede conectar a la base de datos local\n Error: " + errorBD, "Error", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        conectadolcl = 2; // Solo API
                        Application.Exit();
                    }
                    else
                    {
                        timer1.Start();
                    }
                }
                else
                {
                    conectadolcl = 3; // Solo local
                    progressBar1.Value = 100;
                }
                return false;
            }
        }

        private async Task<bool> CanConnectToApi(string apiUrl)
        {
            // Método para verificar la conexión a la API
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    return response.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private bool CanConnectToLocal(string local)
        {
            // Método para verificar la conexión a la base de datos local
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
            // Evento que se ejecuta en cada tick del timer2
            if (timer2.Interval == 3000)
            {
                timer2.Stop();
                this.main.Enabled = true; // Habilita el formulario principal
                this.Close(); // Cierra el formulario de carga
                this.main.Show(); // Muestra el formulario principal
            }
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            // Evento que se ejecuta al cargar el formulario
            timer1.Start(); // Inicia el timer1
        }

        private void Carga_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Evento que se ejecuta al cerrar el formulario
            switch (conectadolcl)
            {
                case 1:
                    var result = MessageBox.Show("Error al conectar a la base de datos local o Api, Por favor verifique con su supervisor", "Advertencia", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else if (result == DialogResult.Retry)
                    {
                        Application.Restart();
                    }
                    break;
                case 3:
                    var result3 = MessageBox.Show("Error al conectar a la base de datos,Solo disponible para consultas o administrador. Por favor verifique con su supervisor", "Advertencia", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
                    if (result3 == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else if (result3 == DialogResult.Retry)
                    {
                        Application.Restart();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
