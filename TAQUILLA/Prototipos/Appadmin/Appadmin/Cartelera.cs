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
    public partial class Cartelera : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        public Cartelera()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            llenarCombos();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void regresarMenu_Click_1(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
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
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void llenarCombos()
        {
            //llenado de comboBox CLASIFICACION
            try
            {
                comboClas.Text = "Clasificacion";
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
            //llenado de comboBox SALA
            try
            {
                comboSala.Text = "Sala";
                comboSala.Items.Clear();

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM salas", conn);
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
            //llenado de comboBox CIUDAD
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
                    comboCiudad.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();             
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {

        }

        private void ComboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboCine.Text = "Cine";
                comboCine.Items.Clear();

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM cines where idCiudad = "
                    + comboCiudad.Text[0], conn);
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

        private void Button4_Click(object sender, EventArgs e)
        {
            
        }        

        private void BtnAgregarCiudad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ciudad ciu = new Ciudad();
            ciu.Show();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click_1(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
