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
using System.Net;

namespace Appadmin
{
    public partial class Funciones : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
       string usuario;
		string nivel;
        public Funciones(string user, string level)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            llenarCombos();
            llenartbl();
			nivel = level;
            usuario = user;
        }
        
        void llenarCombos()
        {
            //llenado de comboBox CLASIFICACION
            try
            {
                ComboPelicula.Items.Clear();
                ComboPelicula.Text = "Peliculas";


                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM peliculas", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComboPelicula.Refresh();
                    ComboPelicula.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            try
            {
                comboCine.Text = "Cine";
                comboCine.Items.Clear();

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM cines", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboCine.Refresh();
                    comboCine.Items.Add(reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();


        }
        void llenartbl()
        {

            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT * FROM funciones");

            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                dtgFunciones.DataSource = datos;
                eje.Update(datos);
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }
        void Bitacora(string Accion, string ip, string Afectado)
        {
            string query = "INSERT INTO Bitacora (Usuario,Accion,Afectado,ipAddress,fechaHora) VALUES ('" + usuario + "','" + Accion + "',' " + Afectado + "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
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
        void numero(KeyPressEventArgs e)
        {
            char dosp = (char)58;
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (e.KeyChar == dosp)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        void letrasimbolo(KeyPressEventArgs e)
        {


            if (char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsPunctuation(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }

        }

        void numerosimbolo(KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsPunctuation(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;

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
            MainMenu frm = new MainMenu(usuario, nivel);
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
			MenuCartelera mainMenu = new MenuCartelera(usuario, nivel);
			mainMenu.Show();
		}

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO funciones (idPelicula,  idSala, cine, horaFuncion) VALUES ('" +ComboPelicula.Text[0]
               + "','" + comboSala.Text + "','" + comboCine.Text + "','" + txtDuracion.Text + "')";
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (comboSala.Text != "" && comboCine.Text != "" && ComboPelicula.Text != "" && txtDuracion.Text !="")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");
                    txtDuracion.Text=" ";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("INSERT", IP, "FUNCIONES");
					// FIN BITACORA
					conn.Close();
                    llenartbl();
                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
                conn.Close();
            }
            llenarCombos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
         

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE funciones SET "+
            "idPelicula=" + ComboPelicula.Text[0] + ",idSala=" + comboSala.Text + "," +
            "cine='" + comboCine.Text + "',horaFuncion='" + txtDuracion.Text+ "' WHERE idFuncion =" + dtgFunciones.CurrentRow.Cells[0].Value.ToString();//+ dataGridView1.CurrentRow.Cells[0].Value.ToString();

            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (comboSala.Text != "" && comboCine.Text != "" && ComboPelicula.Text != "" && txtDuracion.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO");
                    txtDuracion.Text = " ";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("UPDATE", IP, "FUNCIONES");
					// FIN BITACORA
					conn.Close();
                    llenartbl();
                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
                conn.Close();
            }
            llenarCombos();
            btnIngresar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM funciones WHERE  idPelicula ='" + dtgFunciones.CurrentRow.Cells[0].Value.ToString() + "'";

            conn.Open();

            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (dtgFunciones.SelectedRows.Count == 1)
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("ELIMINADO");
                    
                    txtDuracion.Text = " ";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("DELETE", IP, "FUNCIONES");
					// FIN BITACORA
					conn.Close();
                    llenartbl();

                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
                conn.Close();
            }
            llenarCombos();
           
        }

        private void Funciones_Load(object sender, EventArgs e)
        {

        }

		private void comboCine_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				comboSala.Text = "Sala";
				comboSala.Items.Clear();

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT * FROM salas WHERE salas.idCine = (SELECT idCine FROM cines WHERE nombreCine='"+comboCine.Text+"')", conn);
				OdbcDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboSala.Refresh();
					comboSala.Items.Add(reader.GetValue(0).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
		}

        private void TxtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
            //simbolo(e);
        }

		private void dtgFunciones_DoubleClick(object sender, EventArgs e)
		{

			if (dtgFunciones.SelectedRows.Count == 1)
			{
				string nomPelicula = " ";
                string sala = "";
				try
				{

					conn.Open();
					OdbcCommand command = new OdbcCommand("SELECT titulo FROM peliculas WHERE idPelicula =" + dtgFunciones.CurrentRow.Cells[1].Value.ToString(), conn);
					OdbcDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{

						nomPelicula = reader.GetValue(0).ToString();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				conn.Close();
                try
                {

                    conn.Open();
                    OdbcCommand command = new OdbcCommand("SELECT * FROM funciones ", conn);
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        sala = reader.GetValue(2).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();

                btnActualizar.Enabled = true;
				btnIngresar.Enabled = false;
				btnEliminar.Enabled = true;
				ComboPelicula.Text = dtgFunciones.CurrentRow.Cells[1].Value.ToString() + " - " + nomPelicula;
                comboSala.Text = sala;
				comboCine.Text = dtgFunciones.CurrentRow.Cells[3].Value.ToString();
				txtDuracion.Text = dtgFunciones.CurrentRow.Cells[4].Value.ToString();
				btnActualizar.Enabled = true;
			}
			
		}
	}

       
	
    
}
