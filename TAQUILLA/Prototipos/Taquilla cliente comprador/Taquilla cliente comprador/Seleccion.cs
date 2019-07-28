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
		int sala = 1;
		int numSalas = 0;
		string[] salas = new string[140];

		public frmCartelera()
		{
			InitializeComponent();
            webPelicula.Navigate("https://www.youtube.com/watch?v=BfSAvH2fGkE&pbjreload=10");
			webPelicula.Stop();
			Cartelera();
	
		}
		void llenarCartelera(int a, int b, int c, int d, int e)
		{
			lbtitulo.Text = salas[a];//titulo 2
			lbFormato.Text = salas[b];//formato 3
			lbClasificacion.Text = salas[c];//clasificacion 4
			lbSinopsis.Text = salas[d];//sinopsis 5
			lbHora.Text = salas[e];//hora 6
		}
		void Cartelera()
		{
			conn.Open();
			OdbcCommand command = new OdbcCommand(""
			+ "select A.idfuncion,"+
			"(SELECT titulo FROM peliculas WHERE idPelicula = A.idPelicula) titulo,"+
			"(SELECT formato FROM peliculas WHERE idPelicula = A.idPelicula) formato ,"+
			"(SELECT clasificación FROM peliculas WHERE idPelicula = A.idPelicula) clasificacion,"+
			"(SELECT sinopsis FROM peliculas WHERE idPelicula = A.idPelicula) sinopsis, A.horaFuncion "+
			"from funciones A where a.cine = '"+"Portales'", conn);
			OdbcDataReader funciones = command.ExecuteReader();

			int pos = 1;
			while (funciones.Read())
			{
		
				salas[pos] = funciones.GetValue(0).ToString(); // funcion
				pos++;
				salas[pos] = funciones.GetValue(1).ToString();//titulo
				pos++;
				salas[pos] = funciones.GetValue(2).ToString();//formato
				pos++;
				salas[pos] = funciones.GetValue(3).ToString(); // clasificacion
				pos++;
				salas[pos] = funciones.GetValue(4).ToString();//sinopsis
				pos++;
				salas[pos] = funciones.GetValue(5).ToString();//hora
				pos++;
				numSalas++;

			}
			conn.Close();
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

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (sala == 1)
			{
				llenarCartelera(2, 3, 4, 5, 6);
				btnMenos.Enabled = false;
			}

			if (sala > 1 && sala < numSalas)
			{
				btnMenos.Enabled = true;
				btnMas.Enabled = true;
				switch (sala)
				{
					case 1:
						llenarCartelera(2,3,4,5,6);
						break;
					case 2:
						llenarCartelera(8,9,10,11,12);
						break;
					case 3:
						llenarCartelera(14, 15, 16, 17, 18);
						break;
					case 4:
						llenarCartelera(20,21,22,23,24);
						break;
					case 5:
						llenarCartelera(26,27,28,29,30);
						break;
					case 6:
						llenarCartelera(32,33,34,35,36);
						break;
					case 7:
						llenarCartelera(38,39,40,41,42);
						break;
					case 8:
						llenarCartelera(43,44,45,46,47);
						break;
					case 9:
						llenarCartelera(49,50,51,52,53);
						break;
				}
			} else if (sala == numSalas)
			{
				btnMas.Enabled = false;
				switch (sala)
				{
					case 1:
						llenarCartelera(2, 3, 4, 5, 6);
						break;
					case 2:
						llenarCartelera(8, 9, 10, 11, 12);
						break;
					case 3:
						llenarCartelera(14, 15, 16, 17, 18);
						break;
					case 4:
						llenarCartelera(20, 21, 22, 23, 24);
						break;
					case 5:
						llenarCartelera(26, 27, 28, 29, 30);
						break;
					case 6:
						llenarCartelera(32, 33, 34, 35, 36);
						break;
					case 7:
						llenarCartelera(38, 39, 40, 41, 42);
						break;
					case 8:
						llenarCartelera(43, 44, 45, 46, 47);
						break;
					case 9:
						llenarCartelera(49, 50, 51, 52, 53);
						break;
				}
			}
			





		}

		private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnMas_Click(object sender, EventArgs e)
		{
			sala++;
		}

		private void btnMenos_Click(object sender, EventArgs e)
		{
			sala--;
		}
	}
    }

