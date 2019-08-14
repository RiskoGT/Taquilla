/*
 * Integrantes a Cargo:
 * 0901-16-   9 Edgar Casasola
 * 0901-16- 420 Gustavo Perez
 * 
 * Edgar creo el form con los respectivos elementos
 * Gustavo agrego diseño y funcionalidades a los botones 
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
    public partial class MenuCartelera : Form
    {
        string user;
		string level;
        public MenuCartelera(string usuario, string nivel)
        {
            InitializeComponent();
            user = usuario;
			level = nivel;
        }        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void sendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


 

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
            ReleaseCapture();
            sendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            sendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GestionUsuarios_Click(object sender, EventArgs e)
        {
            gestionUsuarios frm = new gestionUsuarios(user,level);
            frm.Show();
            this.Hide();
        }

		private void button1_Click_1(object sender, EventArgs e)
		{
			peliculas frm = new peliculas(user, level);
			frm.Show();
			this.Hide();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Multimedia frm = new Multimedia(user, level);
			frm.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
            Funciones frm = new Funciones(user, level);
			frm.Show();
			this.Hide();
		}

		private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
		{
			MainMenu nuevo = new MainMenu(user, level);
			nuevo.Show();
			this.Hide();
		}

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

		private void button4_Click_1(object sender, EventArgs e)
		{
			Ciudad nuevo = new Ciudad(user, level);
			nuevo.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Cine nuevo = new Cine(user, level);
			nuevo.Show();
			this.Hide();
		}

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Pagina de ayuda admin/ayudaAdmin.chm", "menuCartelera.html"); //Esta funcion abre la opcion de ayuda con HTML
        }
    }
}
