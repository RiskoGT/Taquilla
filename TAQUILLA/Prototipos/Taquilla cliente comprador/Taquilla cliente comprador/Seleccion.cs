using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla_cliente_comprador
{
    public partial class frmCartelera : Form
    {
		/*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
		OdbcConnection conn = new OdbcConnection("Dsn=cine"); 
		int sala = 0;
    

        public frmCartelera()
		{
			InitializeComponent();
            webPelicula.Navigate("https://www.youtube.com/watch?v=BfSAvH2fGkE&pbjreload=10");
			webPelicula.Stop();
        }

               	private void button9_Click(object sender, EventArgs e)
		{
            webPelicula.Navigate("");
            Form formulariobol = new frmBoletos();
			formulariobol.Show();
			Visible = false;
		}


		private void Frm_cartelera_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			sala++;

        }

		private void button1_Click(object sender, EventArgs e)
		{
			sala--;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
           
            if (sala == 0) { button1.Enabled = false; button2.Enabled = true;
				pictureBox1.BackgroundImage = global::Taquilla_cliente_comprador.Properties.Resources.Rey_leon;
                
                label2.Text = "El Rey León(2019)";
				label4.Text = "A";
				label3.Text = "2D";
				label5.Text = "EL REY LEÓN de Disney, dirigida por Jon Favreau, nos lleva a la sabana africana donde un futuro"+
				" rey ha nacido. Simba idolatra a su padre, el rey Mufasa, y está entusiasmado con su destino real. Pero no todos"+
				" en el reino celebran la llegada del nuevo cachorro. Scar, el hermano de Mufasa y antiguo heredero al trono, tiene"+
				" sus propios planes. La batalla de La Roca del Rey se ve teñida de traición, tragedia y drama, y acaba forzando a Simba"+
				" al exilio. Con la ayuda de una curiosa pareja de amigos nuevos, Simba tendrá que arreglárselas para crecer y recuperar lo"+
				" que legítimamente le corresponde. El estelar reparto incluye a: Donald Glover como Simba, Beyoncé Knowles-Carter en el papel"+
				" de Nala, James Earl Jones como Mufasa, Chiwetel Ejiofor como Scar, Seth Rogen como Pumba y Billy Eichner en el papel de Timón.";
			}
			if (sala == 1) { button2.Enabled = false; button1.Enabled = true;
				pictureBox1.BackgroundImage = global::Taquilla_cliente_comprador.Properties.Resources.Spiderman;
                
                label2.Text = "Spider-Man: Lejos de casa";
				label4.Text = "B";
				label3.Text = "3D";
				label5.Text = "Peter Parker regresa en Spider-Man: Lejos de casa el siguiente capítulo en la serie de " +
					"Spider-Man: Homecoming. Nuestro amistoso vecino superhéroe decide unirse a sus mejores amigos Ned, MJ," +
					" y el resto del grupo a unas vacaciones europeas. Aunque, el plan de Peter sea dejar sus heroicidades atrás" +
					" durante unas pocas semanas, pronto desecha esas ideas para ayudar a regañadientes a Nick Furia a desentrañar " +
					"el misterio de los ataques de varias criaturas elementales, que están creando el caos en el mundo.";
			}

			
			
		}

		private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
		{

		}
	}
    }

