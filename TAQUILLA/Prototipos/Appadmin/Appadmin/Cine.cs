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
    
    public partial class Cine : Form
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
        public Cine(string usuario ,string nivel)
        {
            InitializeComponent();
			llenarCombos();
			llenartabla();
			user = usuario;
			level = nivel;
        }
		void Bitacora(string Accion, string ip, string Afectado)
		{
			string query = "INSERT INTO bitacora (Usuario,Accion,Afectado,ipAddress,fechaHora) VALUES ('" + user + "','" + Accion + "',' " + Afectado + "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
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

        private void Cine_Load(object sender, EventArgs e)
        {

        }
        void llenartabla()
        {
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM cines");
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO cines (idCiudad, nombreCine) VALUES ('" + comboCiudad.Text[0]
                + "', '" + txtCine.Text + "')";
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtCine.Text != "" && comboCiudad.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");
                    txtCine.Text = "";
                    comboCiudad.Text = "";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("INSERT", IP, "Cines");
					// FIN BITACORA
					conn.Close();
                    llenartabla(); //llenamos el DataGridView de Ciudades
                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
                conn.Close();
            }
        }
        void llenarCombos()
        {
            //llenado de comboBox CLASIFICACION
            try
            {
                comboCiudad.Text = "Ciudad";
                comboCiudad.Items.Clear();

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM ciudades", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboCiudad.Refresh();
                    comboCiudad.Items.Add(reader.GetValue(0).ToString() + " - "
                        + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

		private void btnModificarCine_Click(object sender, EventArgs e)
		{
            btnAgregarCine.Enabled = true;
            button2.Enabled = true;
			if (txtCine.Text != "" && comboCiudad.Text != "")
			{

				string query = "UPDATE cines SET " +
				"nombreCine='" + txtCine.Text + "',idCiudad='" + comboCiudad.Text[0] + "'" + " WHERE idCine =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
					Bitacora("UPDATE", IP, "CINES");
					// FIN BITACORA
					llenartabla();
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("\t Error! \n\n " + ex.ToString());
					conn.Close();
				}
				txtCine.Text = "";
				llenarCombos();

			}
			else
			{
				MessageBox.Show("Por favor, llene los campos para ingresar");

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				string query = "DELETE  from cines " +
				" WHERE idCine =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
					Bitacora("DELETE", IP, "CINES");
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

		private void Cine_FormClosed(object sender, FormClosedEventArgs e)
		{
			MenuCartelera nuevo = new MenuCartelera(user, level);
			nuevo.Show();
			this.Hide();
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			btnAgregarCine.Enabled = false;
			button2.Enabled = false;
			if (dataGridView1.SelectedRows.Count == 1)
			{
				txtCine.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


				string ciudadId;
				conn.Open();
				OdbcCommand command = new OdbcCommand(""
				+ "SELECT nombreCiudad FROM ciudades WHERE idCiudad = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", conn);
				OdbcDataReader funciones = command.ExecuteReader();

				funciones.Read();

				ciudadId = funciones.GetValue(0).ToString();

				conn.Close();
				comboCiudad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " - "+ ciudadId;
			}
			else
			{
				MessageBox.Show("Porfavor Seleccione un registro de la tabla");

			}

			
		}

        private void TxtCine_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCine_KeyPress(object sender, KeyPressEventArgs e)
        {
            letra(e);
        }
    }
}
