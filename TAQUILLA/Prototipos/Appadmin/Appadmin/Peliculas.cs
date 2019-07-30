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

namespace Appadmin
{
    public partial class peliculas : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        string usuario;
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
    }
}
