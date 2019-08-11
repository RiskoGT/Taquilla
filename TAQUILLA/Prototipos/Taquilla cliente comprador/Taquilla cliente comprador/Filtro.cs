using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Taquilla_cliente_comprador
{
    public partial class Filtro : Form
    {
		/*Grupo 2  taquilla  cliente comprador
         Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
		OdbcConnection conn = new OdbcConnection("Dsn=cine");
		string cineSeleccionado;
		public Filtro(string cine)
        {

            InitializeComponent();
			cineSeleccionado = cine;
     
        }
	

		private void Filtro_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

	
		private void button1_Click_1(object sender, EventArgs e)
		{
			
			Form formulario = new frmCartelera(cineSeleccionado, comboBox1.Text, comboBox2.Text);
			formulario.Show();
			Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form formulario = new frmMenu();
			formulario.Show();
			this.Visible = false;


		}

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, " Página web ayuda/ayuda.chm", "Filtros.html");
        }
    }
}
