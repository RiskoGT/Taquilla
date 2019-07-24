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
namespace Appadmin
{
    public partial class Acceso : Form
    {
        /* MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port=3306; username=root; " +
            "password=; database=taquilla");
            */
        public Acceso()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void sendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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
            System.Data.SqlClient.SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source = .\\SQL";


            this.Hide();
            MainMenu frm = new MainMenu();
            frm.Show();
            
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
	}
}
