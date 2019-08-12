/*
 * Integrantes a Cargo:
 * 0901-16-   9 Edgar Casasola
 * 0901-16- 420 Gustavo Perez
 * 
 * Edgar creo el form con los respectivos elementos
 * Gustavo agrego diseño y código a los botones 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Appadmin
{
    public partial class MainMenu : Form
    {
        string user;
		string level;

        public MainMenu(string usuario, string nivel)
        {
            InitializeComponent();
            user = usuario;
			level = nivel;
			if (nivel == "1")
			{
				button2.Enabled = false;
				button3.Enabled = false;
				button5.Enabled = false;
			}
        }        
       
       
        private void button2_Click(object sender, EventArgs e)
        {
            controlInformes frm = new controlInformes(user, level);
            frm.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Acceso frm = new Acceso();
            frm.Show();
            this.Hide();
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void GestionUsuarios_Click(object sender, EventArgs e)
        {
            gestionUsuarios frm = new gestionUsuarios(user, level);
            frm.Show();
            this.Hide();
        }

		private void button1_Click_1(object sender, EventArgs e)
		{
			MenuCartelera frm = new MenuCartelera(user, level);
			frm.Show();
			this.Hide();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			controlInformes frm = new controlInformes(user,level);
			frm.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
            gestionUsuarios frm = new gestionUsuarios(user, level);
			frm.Show();
			this.Hide();
		}

		private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
		{
            Acceso frm = new Acceso();
            frm.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmTiempo frm = new frmTiempo(user, level);
            frm.Show();
            this.Hide();
        }
    }
}
