﻿/*Edgar Casasola Formulario Cartelera 0901-16-9*/
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
        string usuario;
        public Cartelera(string user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            usuario = user;
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
            string queryPeli = "INSERT INTO peliculas (Titulo, Multimedia, Formato, Clasificación, " 
                + "semanaEstrenoInicio, semanaEstrenoFin, Usuario)" + "VALUES ('" + txtTitulo.Text + "',1,'" +  
                comboFormato.Text + "','" + comboClas.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + 
                "','" + usuario + "')";

            /*string queryFun = "INSERT INTO funciones (idSala, horaFuncion)" + "VALUES "
                + "('" + comboSala.Text + "', '" + txtHorario.Text + "')"; */
            conn.Open();
            OdbcCommand consultaPeli = new OdbcCommand(queryPeli, conn);
            // OdbcCommand consultaFun = new OdbcCommand(queryFun, conn);
            try
            {
                if (txtTitulo.Text != "" && txtHorario.Text != "")
                {
                    consultaPeli.ExecuteNonQuery();
                    //consultaFun.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");                    
                    txtTitulo.Text = "";
                    txtHorario.Text = "";
                    conn.Close();                    
                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
                conn.Close();
            }
        }        

        private void BtnAgregarCiudad_Click(object sender, EventArgs e)
        {
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

        private void Cartelera_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BtnUsuarioAct_Click(object sender, EventArgs e)
        {
            
        }
    }
}
