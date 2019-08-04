/*Randy Choc Gestion Usuarios 0901-16-1288*/
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
    public partial class gestionUsuarios : Form
    {

        /* MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port=3306; username=root; " +
            "password=; database=taquilla");
            */
        //establecemos la conexion con el nombre establecido en el origen de datos (ODBC)
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        string user;
        public gestionUsuarios(string usuario)
        {
            InitializeComponent();
            user = usuario;
            label14.Text = user;
            this.WindowState = FormWindowState.Maximized;
            txtApellido.Clear();
            txtContra.Clear();
            comboSexo.SelectedText = "Sexo";
            txtDpi.Focus();
            txtNombre.Clear();
            txtTel.Clear();
            btnActualizar.Enabled = false;
            txtUsuario.Clear();
			dtpFechaInicio.Format = DateTimePickerFormat.Custom;
			dtpFechaInicio.CustomFormat = "yyyy-MM-dd";
			dtpFechaNac.Format = DateTimePickerFormat.Custom;
			dtpFechaNac.CustomFormat = "yyyy-MM-dd";
			llenartbl();
            comboSexo.Items.Add("Sexo");
            comboSexo.SelectedItem = "Sexo";
            //llenarCombos();
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
		void llenartbl() {

            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT * FROM usuarios");

            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                tblContenido.DataSource = datos;
                eje.Update(datos);
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }
        void llenarCombos()
        {
            //llenado de comboBox CLASIFICACION
            try
            {
                comboPerfil.Text = "Perfiles";
                comboPerfil.Items.Clear();

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM perfiles", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboPerfil.Refresh();
                    comboPerfil.Items.Add(reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        void letra(KeyPressEventArgs e) {
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

        void letrasimbolo(KeyPressEventArgs e) {


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
        void numero(KeyPressEventArgs e) {

            if (char.IsNumber(e.KeyChar))
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

        void log(string queryin)
        {
            string query =/*es bitacora uno no es una letra l de leon*/ "INSERT INTO bitacora1  (Usuario,operacion,fecha) VALUES ('" + txtUsuario + "','" + queryin + "','" + DateTime.Now.ToString("G") + "')";
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {

                consulta.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.ToString());
                conn.Close();
            }
        }
        private void GestionUsuarios_Load(object sender, EventArgs e)
        {

        }

         private void RegresarMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu(user);
            frm.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click_1(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu(user);
            frm.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu(user);
            mainMenu.Show();
        }

        private void TblContenido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO usuarios (Usuario,  idPerfil, Password, DPI, Nombres, Apellidos, Telefono , Correo, Sexo , fechaNac, fechaInicio) VALUES ('" + txtUsuario.Text
               + "','" + comboPerfil.Text[0] + "', MD5('" + txtContra.Text + "'),'" + txtDpi.Text + "','" + txtNombre.Text + "','"
               + txtApellido.Text + "','" + txtTel.Text + "','" + txtCorreo.Text + "','" + comboSexo.Text + "','" + dtpFechaNac.Text + "','"+ dtpFechaInicio.Text + "')";
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtUsuario.Text != "" &&  txtContra.Text != "" && txtDpi.Text != "" && txtNombre.Text!= "" && txtApellido.Text != "" && txtTel.Text != "" && txtCorreo.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");
                    txtApellido.Text = "";
                    txtContra.Text = "";
                    txtCorreo.Text = "";
                    txtDpi.Text = "";
                    txtNombre.Text = "";
                    txtTel.Text = "";
                    txtUsuario.Text = "";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("INSERT", IP, "USUARIOS");
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
        }

        private void TxtContra_TextChanged(object sender, EventArgs e)
        {

        }        
        private void BtnModif_Click(object sender, EventArgs e)
        {
			string query = "UPDATE usuarios SET " +
			"idPerfil='" + comboPerfil.Text + "',password= MD5('" + txtContra.Text + "'),DPI='" + txtDpi.Text + "'," +
			"Nombres='" + txtNombre.Text + "',Apellidos='" + txtApellido.Text + "',Telefono='" + txtTel.Text + "',Correo='" + txtCorreo.Text + "',Sexo='" +
			 comboSexo.Text + "',fechaNac='" + dtpFechaNac.Text + "',fechaInicio='" + dtpFechaInicio.Text + "'" + " WHERE Usuario ='" + txtUsuario.Text +"'";//+ dataGridView1.CurrentRow.Cells[0].Value.ToString();

			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
				if (txtUsuario.Text != "" && txtContra.Text != "" && txtDpi.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtTel.Text != "" && txtCorreo.Text != "")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Actualizacion Correcta");
					txtApellido.Text = "";
					txtContra.Text = "";
					txtCorreo.Text = "";
					txtDpi.Text = "";
					txtNombre.Text = "";
					txtTel.Text = "";
					txtUsuario.Text = "";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("UPDATE", IP, "USUARIOS");
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

		}

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM usuarios  WHERE  Usuario ='" + tblContenido.CurrentRow.Cells[0].Value.ToString()+ "'";
           
            conn.Open();

            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (tblContenido.SelectedRows.Count == 1)
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("Eliminar");
                    txtApellido.Text = "";
                    txtContra.Text = "";
                    txtCorreo.Text = "";
                    txtDpi.Text = "";
                    txtNombre.Text = "";
                    txtTel.Text = "";
                    txtUsuario.Text = "";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("DELETE", IP, "USUARIOS");
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

        }

		private void button2_Click(object sender, EventArgs e)
		{

		}

        private void GestionUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TblContenido_DoubleClick(object sender, EventArgs e)
        {

            if (tblContenido.SelectedRows.Count == 1)
            {
                btnActualizar.Enabled = true;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                txtUsuario.Text = tblContenido.CurrentRow.Cells[0].Value.ToString();
                comboPerfil.Text = tblContenido.CurrentRow.Cells[1].Value.ToString();
                txtContra.Text = tblContenido.CurrentRow.Cells[2].Value.ToString();
                txtDpi.Text = tblContenido.CurrentRow.Cells[3].Value.ToString();
                txtNombre.Text = tblContenido.CurrentRow.Cells[4].Value.ToString();
                txtApellido.Text = tblContenido.CurrentRow.Cells[5].Value.ToString();
                txtTel.Text = tblContenido.CurrentRow.Cells[6].Value.ToString();
                txtCorreo.Text = tblContenido.CurrentRow.Cells[7].Value.ToString();
                comboSexo.Text = tblContenido.CurrentRow.Cells[8].Value.ToString();
                dtpFechaNac.Text = tblContenido.CurrentRow.Cells[9].Value.ToString();
                dtpFechaInicio.Text = tblContenido.CurrentRow.Cells[10].Value.ToString();
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Porfavor Seleccione un registro de la tabla");
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = false;
                txtApellido.Text = "";
                txtContra.Text = "";
                txtCorreo.Text = "";

                txtDpi.Text = "";
                txtNombre.Text = "";
                txtTel.Text = "";

                txtUsuario.Text = "";
            }
        }

        private void TxtDpi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtDpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            numero(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letra(e);
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            letra(e);
        }

        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasimbolo(e);
        }

        private void ComboSexo_DropDown(object sender, EventArgs e)
        {
            comboSexo.Items.Remove( "Sexo");
        }

        private void ComboSexo_DropDownClosed(object sender, EventArgs e)
        {
            comboSexo.Items.Add("Sexo");
            comboSexo.SelectedItem = "Sexo";
        }
    }
    }

