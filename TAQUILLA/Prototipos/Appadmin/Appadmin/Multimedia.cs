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
using System.IO;

namespace Appadmin
{
    public partial class Multimedia : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        string user;
        public Multimedia(string usuario)
        {
            InitializeComponent();
            user = usuario;
            this.WindowState = FormWindowState.Maximized;
			textBox1.Enabled = false;
			button2.Enabled = false;
        }        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void regresarMenu_Click_1(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu(user);
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
			MainMenu mainMenu = new MainMenu(user);
			mainMenu.Show();
		}

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				textBox2.Text = openFileDialog1.FileName;
				pictureBox1.BackgroundImage = new Bitmap(openFileDialog1.FileName);
				pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			}
			textBox1.Enabled = true;

		}

        private void TextBox1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_StyleChanged_1(object sender, EventArgs e)
        {
            webPeli.Navigate(txtPeli.Text);

        }

        private void TxtPeli_TextChanged(object sender, EventArgs e)
        {
            webPeli.Navigate(txtPeli.Text);
			button2.Enabled = true;
        }

        private void Multimedia_Load(object sender, EventArgs e)
        {

        }

		private void button2_Click(object sender, EventArgs e)
		{
			string destino = @"C:\Users\gganp\Desktop\Taquilla\TAQUILLA\Prototipos\Taquilla cliente comprador\Taquilla cliente comprador\bin\Debug\Multimedia\"+textBox1.Text+".jpg";
			File.Copy(textBox2.Text, destino);

			string query = "INSERT INTO multimedia (Afiche, Trailer) VALUES ('Multimedia/"+textBox1.Text+".jpg', '"+txtPeli.Text+"')";
			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Datos Registrados Correctamente");
					
					conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
			textBox1.Text = "";
			txtPeli.Text = "";
			textBox2.Text="";
			pictureBox1.BackgroundImage = global::Appadmin.Properties.Resources.fondopic;

		}
	}

       
	
    
}
