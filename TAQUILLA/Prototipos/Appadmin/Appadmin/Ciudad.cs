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
using System.Net;

namespace Appadmin
{
    public partial class Ciudad : Form
    {
        void letra(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }

        }
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
		string user = "";
		string level;

		public Ciudad(string usuario, string nivel)
        {
            InitializeComponent();
            llenartabla();
			user = usuario;
			level = nivel;
			button3.Enabled = false;
		}
		void Bitacora(string Accion, string ip, string Afectado)
		{
			string query = "INSERT INTO Bitacora (Usuario,Accion,Afectado,ipAddress,fechaHora) VALUES ('" + user + "','" + Accion + "',' " + Afectado + "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
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

		private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Ciudad_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ciudades (nombreCiudad) VALUES ('" + txtCiudad.Text 
           + "')";            
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtCiudad.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");                    
                    txtCiudad.Text = "";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("INSERT", IP, "CIUDADES");
					// FIN BITACORA
					conn.Close();
                    llenartabla(); 
                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
                conn.Close();
            }            
        }

        void llenartabla()
        {
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM ciudades");
            try
            {
                OdbcDataAdapter ejecutar = new OdbcDataAdapter();
                ejecutar.SelectCommand = codigo;
                DataTable datostabla = new DataTable();
                ejecutar.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                ejecutar.Update(datostabla);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }

        private void Ciudad_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {                        
        }

		private void Ciudad_FormClosed(object sender, FormClosedEventArgs e)
		{
			MenuCartelera nuevo = new MenuCartelera(user, level);
			nuevo.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = false;
			if (txtCiudad.Text != "")
			{

				string query = "UPDATE ciudades SET " +
				"nombreCiudad='" + txtCiudad.Text + "' WHERE idCiudad =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
				conn.Open();
				OdbcCommand consulta = new OdbcCommand(query, conn);
				try
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Datos Actualizados Correctamente");
					dataGridView1.Enabled = true;
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("UPDATE", IP, "CIUDADES");
					// FIN BITACORA
					llenartabla();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("\t Error! \n\n " + ex.ToString());
					conn.Close();
				}
				txtCiudad.Text = "";


			}
			else
			{
				MessageBox.Show("Por favor, llene los campos para ingresar");

			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = true;
			if (dataGridView1.SelectedRows.Count == 1)
			{
				txtCiudad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			}
			else
			{
				MessageBox.Show("Porfavor Seleccione un registro de la tabla");

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				string query = "DELETE  from ciudades " +
				" WHERE idCiudad =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
				conn.Open();
				OdbcCommand consulta = new OdbcCommand(query, conn);
				try
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Registro eliminado Correctamente");
					dataGridView1.Enabled = true;
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("DELETE", IP, "CIUDADES");
					// FIN BITACORA
					llenartabla();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("\t Error! \n\n " + ex.ToString());
					conn.Close();
				}
			}
			else
			{
				MessageBox.Show("Porfavor Seleccione un registro de la tabla");

			}
		}

        private void TxtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            letra(e);
        }
    }
}
