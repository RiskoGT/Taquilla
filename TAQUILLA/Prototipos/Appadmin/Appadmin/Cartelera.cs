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

namespace Appadmin
{
    public partial class Cartelera : Form
    {
        public Cartelera()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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

        private void Label16_Click(object sender, EventArgs e)
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
	}
}
