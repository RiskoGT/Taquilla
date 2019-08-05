/*Edgar Casasola Formulario Cartelera 0901-16-9*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
using System.Net;

namespace Appadmin
{
    public partial class Bita : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        string user;
		string level;
        public Bita(string usuario, string nivel)
        {
            InitializeComponent();
            user = usuario;
            this.WindowState = FormWindowState.Maximized;
			llenartbl();
			level = nivel;
			conn.Open();
			//BITACORA
			String IP = "";
			IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress addr in localIPs)
			{
				IP += "   |   " + addr.ToString();
			}
			Bitacora("SELECT", IP, "BITACORA");
			// FIN BITACORA
			conn.Close();

		}
		void Bitacora(string Accion, string ip, string Afectado)
		{
			string query = "INSERT INTO Bitacora (Usuario,Accion,Afectado,ipAddress,fechaHora) VALUES ('" + user + "','" + Accion + "',' "+Afectado + "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
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
		void llenartbl()
		{

			OdbcCommand cod = new OdbcCommand();
			cod.Connection = conn;
			cod.CommandText = ("SELECT * FROM bitacora order by NoReg DESC");

			try
			{
				OdbcDataAdapter eje = new OdbcDataAdapter();
				eje.SelectCommand = cod;
				DataTable datos = new DataTable();
				eje.Fill(datos);
				tblMulitimedia.DataSource = datos;
				eje.Update(datos);
				conn.Close();
			}
			catch (Exception e)
			{

				MessageBox.Show("ERROR" + e.ToString());
				conn.Close();
			}
		}
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void regresarMenu_Click_1(object sender, EventArgs e)
        {
            MenuCartelera frm = new MenuCartelera(user,level);
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

		private void Cartelera_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();

		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuCartelera mainMenu = new MenuCartelera(user, level);
			mainMenu.Show();
		}

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		

        private void TextBox1_StyleChanged(object sender, EventArgs e)
        {

        }

    

        private void Multimedia_Load(object sender, EventArgs e)
        {

        }

		

		
		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			
		}

		
	}

       
	
    
}
