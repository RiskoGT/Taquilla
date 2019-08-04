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
    public partial class peliculas : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        string usuario;
        int idGlobal;
        public peliculas(string user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            usuario = user;
            txtTitulo.Focus();
            llenarCombos();
            llenarTabla();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();            
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
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {

        }

        private void regresarMenu_Click_1(object sender, EventArgs e)
        {            
            MainMenu frm = new MainMenu(usuario);
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
            MainMenu mainMenu = new MainMenu(usuario);
            mainMenu.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Peliculas_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(usuario);  //mensaje para determinar si el usuario sigue activo en el sistema
            txtEstreno.Text = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
            txtFin.Text = dateTimePicker2.Value.Date.ToString("yyyy/MM/dd");            
            string query = "INSERT INTO peliculas(Titulo, Multimedia, Formato, Clasificación, Sinopsis,"
                + " Duracion, semanaEstrenoInicio, semanaEstrenoFin, Usuario) VALUES " +
                "('" + txtTitulo.Text + "'," + comboMulti.Text[0] + ",'" + comboFormato.Text +
                "','" + comboClas.Text + "','" + txtSinopsis.Text + "','" + txtDuracion.Text +
                "','" + txtEstreno.Text + "','" + txtFin.Text + "','" + usuario + "')";            
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtTitulo.Text != "" && txtSinopsis.Text != "" && txtDuracion.Text != "" &&
                    comboMulti.Text != "Multimedia" && comboClas.Text != "Clasificación" &&
                    comboFormato.Text != "Formato")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("Datos Registrados Correctamente");
                    txtTitulo.Text = "";
                    txtSinopsis.Text = "";
                    txtDuracion.Text = "";
                    txtEstreno.Text = "";
                    txtFin.Text = "";
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("INSERT", IP, "PELICULAS");
					// FIN BITACORA
					llenarTabla();
                    llenarCombos();
                    conn.Close();
                    comboFormato.Text = "Formato";
                    txtTitulo.Focus();
                    dateTimePicker1.ResetText();
                    dateTimePicker2.ResetText();                    
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los Campos! \n\n GRACIAS!!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t Error! \n\n " + ex.ToString());
                conn.Close();
            }
        }
        void llenarTabla()
        {
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM peliculas");
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
                MessageBox.Show("\t Error en llenado de Tablas!! \n\n" + e.ToString());
                conn.Close();
            }
        }
        void llenarCombos()
        {
            // codigo para llenar el comboBox MULTIMEDIA
            try
            {
                comboMulti.Text = "Multimedia"; 
                comboMulti.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM multimedia", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboMulti.Refresh();
                    comboMulti.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            // codigo para llenar el comboBox CLASIFICACION
            try
            {
                comboClas.Text = "Clasificación";
                comboClas.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM clasificacion", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboClas.Refresh();
                    comboClas.Items.Add(reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM peliculas WHERE idPelicula =" 
                + dataGridView1.CurrentRow.Cells[0].Value.ToString();            
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show(" Eliminado Correctamente! ");
					//BITACORA
					String IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					Bitacora("DELETE", IP, "PELICULAS");
					// FIN BITACORA
					llenarTabla();
                    conn.Close();                    
                    txtTitulo.Focus();
                    //conn.Open();
                    //log(operacion);
                }
                else
                {
                   MessageBox.Show(" Por favor Seleccione Registro a Eliminar!");
                   conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error!" + ex.ToString());
                conn.Close();
            }
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{            
            if (dataGridView1.SelectedRows.Count == 1)
            {                
                btnActualizar.Enabled = true;
                btnIngresar.Enabled = false;
                btnEliminar.Enabled = false; 
                idGlobal = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtTitulo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();                
                //comboMulti.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int aux = Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                string auxi;
                try
                {
                    conn.Open();
                    OdbcCommand command = new OdbcCommand("SELECT * FROM multimedia WHERE NoRegistro=" + aux, conn);
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboMulti.Refresh();
                        comboMulti.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                        auxi = reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString();
                        //MessageBox.Show(auxi);
                        comboMulti.Text = auxi;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error mostrar registro multimedia: " + ex);
                    conn.Close();
                }
                comboFormato.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();                
                comboClas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtSinopsis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtDuracion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
            else { MessageBox.Show("Porfavor Seleccione un registro de la tabla"); }
        }

        private void TxtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            /* string auxem = comboBox1.Text;
            string[] separarem;
            separarem = auxem.Split(' ');

            string auxve = comboBox2.Text;
            string[] separarve;
            separarve = auxve.Split(' '); */
            txtEstreno.Text = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
            txtFin.Text = dateTimePicker2.Value.Date.ToString("yyyy/MM/dd");
            string query = "UPDATE peliculas SET Titulo = '" + txtTitulo.Text
                + "', Multimedia='" + comboMulti.Text + "'," + " Formato= '" + comboFormato.Text 
                + "', Clasificación= '" + comboClas.Text + "' , Sinopsis= '" + txtSinopsis.Text 
                + "', Duracion='" + txtDuracion.Text + "', semanaEstrenoInicio= '" + txtEstreno.Text 
                + "', semanaEstrenoFin= '" + txtFin.Text + "' WHERE  idPelicula =" + idGlobal; 
            //+ dataGridView1.CurrentRow.Cells[0].Value.ToString();            
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtTitulo.Text != "" && txtDuracion.Text != "" && txtSinopsis.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("Actualizado");
                    conn.Close();
                    llenarTabla();
                    llenarCombos();
                    conn.Open();                    
                    txtTitulo.Text = "";
                    txtDuracion.Text = "";
                    txtSinopsis.Text = "";                    
                    btnActualizar.Enabled = false;
                    btnIngresar.Enabled = true;
                    btnEliminar.Enabled = true;
                    conn.Close();
                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\n\n " + ex.ToString());
                conn.Close();
            }
        }
    }
}
