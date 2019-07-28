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
namespace Appadmin
{
    public partial class gestionUsuarios : Form
    {

        /* MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port=3306; username=root; " +
            "password=; database=taquilla");
            */
        //establecemos la conexion con el nombre establecido en el origen de datos (ODBC)
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        public gestionUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            txtApellido.Clear();
            txtBusqueda.Clear();
            txtContra.Clear();
            txtDir.Clear();
            txtDpi.Focus();
            txtNombre.Clear();
            txtSexo.Clear();
            txtTel.Clear();
            txtTelCasa.Clear();
            txtUsuario.Clear();

            llenartbl();
            llenarCombos();
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
            private void GestionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void RegresarMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
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
            MainMenu frm = new MainMenu();
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
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void TblContenido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO usuarios (Usuario, Password, idPerfil, DPI, Nombres, Apellidos, Telefono , Correo, Sexo , fechaNac, fechaInicio) VALUES ('" + txtUsuario.Text
               + "," + comboPerfil.SelectedIndex + "," + txtContra.Text + "," + txtDpi.Text + "," + txtNombre.Text + ","
               + txtApellido.Text + "," + txtTel.Text + "," + txtCorreo.Text + "," + txtSexo.Text + "," +dtpFechaNac.Value + ","+dtpFechaInicio.Value + "')";
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtUsuario.Text != "" &&  txtContra.Text != "" && txtDpi.Text != "" && txtNombre.Text!= "" && txtApellido.Text != "" && txtTel.Text != "" && txtCorreo.Text != "" && txtSexo.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");
                    txtApellido.Text = "";
                    txtContra.Text = "";
                    txtCorreo.Text = "";
                    txtDir.Text = "";
                    txtDpi.Text = "";
                    txtNombre.Text = "";
                    txtSexo.Text = "";
                    txtTel.Text = "";
                    txtTelCasa.Text = "";
                    txtUsuario.Text = "";
                    conn.Close();
                    llenartbl(); //llenamos el DataGridView de Ciudades
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
    }
}
