/*Edgar Casasola LogIn 0901-16-9*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using System.Net;

namespace Appadmin
{
    public partial class Acceso : Form
    {
        /* MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port=3306; username=root; " +
            "password=; database=taquilla");
            */
        //establecemos la conexion con el nombre establecido en el origen de datos (ODBC)
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        public Acceso()
        {
            InitializeComponent();
            //inicializacion de elementos
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void sendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		void Bitacora(string Accion, string ip)
		{
			string query = "INSERT INTO bitacora (Usuario,Accion,Afectado,ipAddress,fechaHora) VALUES ('" + txtUser.Text + "','" + Accion +"','LOGIN "+ "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{

				consulta.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void Accesotext_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open(); //Abrimos la conexion creada.
            //Realizamos una selecion de la tabla usuarios.
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM usuarios WHERE Usuario='" + txtUser.Text + "' AND password= md5('"
                + txtPass.Text + "') ", conn); 
            OdbcDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {

				if (leer.GetValue(1).ToString() != "3")
				{
					MainMenu ss = new MainMenu(txtUser.Text, leer.GetValue(1).ToString());
					string aux = Convert.ToString(txtUser.Text);
					ss.Show();
				}
				else
				{
					Bita log = new Bita(txtUser.Text, leer.GetValue(1).ToString());
					log.Show();
				}
                this.Hide();
				string IP = "";
				IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
				foreach (IPAddress addr in localIPs)
				{
					IP += "   |   " + addr.ToString();
				}
				Bitacora("LOG IN", IP);
				
            }
            else //Si no lo es mostrara este mensaje.
            {
                MessageBox.Show("Ingrese sus datos correctamente", "ERROR AL INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
              
            conn.Close(); //Cerramos la conexion.
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            sendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void Acceso_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void Acceso_Load(object sender, EventArgs e)
        {

        }
    }
}
