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
    public partial class Funciones : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        string usuario;
        void llenarCombos()
        {
            //llenado de comboBox CLASIFICACION
            try
            {
                ComboPelicula.Text = "Peliculas";
                ComboPelicula.Items.Clear();

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM peliculas", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComboPelicula.Refresh();
                    ComboPelicula.Items.Add(reader.GetValue(0).ToString()+ " - "+ reader.GetValue(1).ToString());
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
        public Funciones(string user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            llenarCombos();
            llenartbl();
            usuario = user;
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
            
         

            if (dtgFunciones.SelectedRows.Count == 1)
            {
                string nomPelicula= " ";

                try
                {

                    conn.Open();
                    OdbcCommand command = new OdbcCommand("SELECT titulo FROM peliculas WHERE idPelicula ="+ dtgFunciones.CurrentRow.Cells[1].Value.ToString(), conn);
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

                btnActualizar.Enabled = true;
                btnIngresar.Enabled = false;
                btnEliminar.Enabled = true;
                ComboPelicula.Text = dtgFunciones.CurrentRow.Cells[1].Value.ToString() + " - "+ nomPelicula;
                comboSala.Text = dtgFunciones.CurrentRow.Cells[2].Value.ToString();
                comboCine.Text = dtgFunciones.CurrentRow.Cells[3].Value.ToString(); 
                txtDuracion.Text = dtgFunciones.CurrentRow.Cells[4].Value.ToString();
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Porfavor Seleccione un registro de la tabla");
                btnIngresar.Enabled = true;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = false;
                comboSala.Refresh();
                ComboPelicula.Refresh();
                comboCine.Refresh();
                txtDuracion.Text = "";
            }
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
	}

       
	
    
}
