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
    public partial class Multimedia : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        string user;
        public Multimedia(string usuario)
        {
            InitializeComponent();
            user = usuario;
            this.WindowState = FormWindowState.Maximized;
			llenartbl();
			btnActualizar.Enabled = false;
			
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
			cod.CommandText = ("SELECT * FROM multimedia");

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
            MainMenu frm = new MainMenu(user);
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCiudad_Click(object sender, EventArgs e)
        {            
            Ciudad frm = new Ciudad();
            frm.Show();
        }

        private void BtnCine_Click(object sender, EventArgs e)
        {
            Cine frm = new Cine();
            frm.Show();
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
			MainMenu mainMenu = new MainMenu(user);
			mainMenu.Show();
		}

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		

        private void TextBox1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_StyleChanged_1(object sender, EventArgs e)
        {
            webPeli.Navigate(txtPeli.Text);

        }

        private void TxtPeli_TextChanged(object sender, EventArgs e)
        {
            webPeli.Navigate(txtPeli.Text);
			btnVer.Enabled = true;
        }

        private void Multimedia_Load(object sender, EventArgs e)
        {

        }

		private void button2_Click(object sender, EventArgs e)
		{
			

			string query = "INSERT INTO multimedia (Afiche, Trailer) VALUES ('"+txtAfiche.Text+"', '"+txtPeli.Text+"')";
			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Datos Registrados Correctamente");
					
					conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
			txtPeli.Text = "";
			txtAfiche.Text="";
			picAfiche.BackgroundImage = global::Appadmin.Properties.Resources.fondopic;

		}


		private void button2_Click_1(object sender, EventArgs e)
		{
			WebRequest request = WebRequest.Create(txtAfiche.Text); //Initializes an instance with the given URL
			using (var response = request.GetResponse()) //Tries to access the object
			{
				using (var str = response.GetResponseStream()) //Returns the metadata of the image
				{
					picAfiche.BackgroundImage = Bitmap.FromStream(str); //Creates a bitmap based on the loaded metadata, in the sequence inserts into the image property.
					picAfiche.BackgroundImageLayout = ImageLayout.Stretch;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtPeli.Text !="" && txtAfiche.Text!="")
			{

				string query = "INSERT INTO multimedia (Afiche, Trailer) VALUES ('" + txtAfiche.Text + "', '" + txtPeli.Text + "')";
				conn.Open();
				OdbcCommand consulta = new OdbcCommand(query, conn);
				try
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Datos Registrados Correctamente");
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("INSERT", IP,"MULTIMEDIA");
					// FIN BITACORA
					llenartbl();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("\t Error! \n\n " + ex.ToString());
					conn.Close();
				}
				txtPeli.Text = "";
				txtAfiche.Text = "";
				picAfiche.BackgroundImage = global::Appadmin.Properties.Resources.fondopic;

			}
			else
			{
				MessageBox.Show("Por favor, llene los campos para ingresar");

			}
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			webPeli.Navigate(txtPeli.Text);
			btnVer.Enabled = true;
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			btnGuardar.Enabled = false;
			btnEliminar.Enabled = false;
			btnActualizar.Enabled = true;
			tblMulitimedia.Enabled = false;
			if (tblMulitimedia.SelectedRows.Count == 1)
			{
				
				
				txtAfiche.Text = tblMulitimedia.CurrentRow.Cells[1].Value.ToString();
				txtPeli.Text = tblMulitimedia.CurrentRow.Cells[2].Value.ToString();
			
			}
			else
			{
				MessageBox.Show("Porfavor Seleccione un registro de la tabla");

			}
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			btnGuardar.Enabled = true;
			btnEliminar.Enabled = true;
			btnActualizar.Enabled = false;
			if (txtPeli.Text != "" && txtAfiche.Text != "")
			{

				string query = "UPDATE multimedia SET " +
			"Afiche='" + txtAfiche.Text + "',Trailer='" + txtPeli.Text + "'" + " WHERE NoRegistro =" + tblMulitimedia.CurrentRow.Cells[0].Value.ToString();
				conn.Open();
				OdbcCommand consulta = new OdbcCommand(query, conn);
				try
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Datos Actualizados Correctamente");
					tblMulitimedia.Enabled = true;
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("UPDATE", IP, "MULTIMEDIA");
					// FIN BITACORA
					llenartbl();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("\t Error! \n\n " + ex.ToString());
					conn.Close();
				}
				txtPeli.Text = "";
				txtAfiche.Text = "";
				picAfiche.BackgroundImage = global::Appadmin.Properties.Resources.fondopic;

			}
			else
			{
				MessageBox.Show("Por favor, llene los campos para ingresar");

			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			tblMulitimedia.Enabled = false;
			if (tblMulitimedia.SelectedRows.Count == 1)
			{
				string query = "DELETE FROM multimedia WHERE NoRegistro=" + tblMulitimedia.CurrentRow.Cells[0].Value.ToString();
				conn.Open();
				OdbcCommand consulta = new OdbcCommand(query, conn);
				try
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Datos Eliminados Correctamente");
					tblMulitimedia.Enabled = true;
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("DELETE", IP, "MULTIMEDIA");
					// FIN BITACORA
					llenartbl();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("\t Error! \n\n " + ex.ToString());
					conn.Close();
				}
				txtPeli.Text = "";
				txtAfiche.Text = "";
				picAfiche.BackgroundImage = global::Appadmin.Properties.Resources.fondopic;

			}
			else
			{
				MessageBox.Show("Porfavor Seleccione un registro de la tabla");

			}
		}
	}

       
	
    
}
