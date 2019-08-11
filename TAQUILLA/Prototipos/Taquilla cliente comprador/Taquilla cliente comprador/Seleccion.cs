using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla_cliente_comprador
{

	public partial class frmCartelera : Form
	{
		Thread th;
		/*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
		OdbcConnection conn = new OdbcConnection("Dsn=cine");
		int sala = 1;// variable para el control de la sala actual
		int numSalas = 0; // numero maximo de salas encontradas
		int funcion = 0; //almacena la funcion elegida
		string[] salas = new string[140]; // registra los datos de las salas encontradas
		string cineSeleccionado;//almacen el cine elegido
		string formatoPeli; //almacena el formato elegido
		string idiomaPeli; //almacena el idioma elegido

		public frmCartelera( string cine, string Formato, string idioma)
		{
			InitializeComponent();
			cineSeleccionado = cine;
			formatoPeli = Formato;
			idiomaPeli = idioma;
			Cartelera();// se cargan los datos de cartelera
			funcion = Convert.ToInt32(salas[1]);
			
		}
		void llenarCartelera(int a, int b, int c, int d, int e)//esta funcion asigna los datos encontrados para una funcion en sus campos
		{
			//Gustavo Perez
			lbtitulo.Text = salas[a];//titulo 2
			lbFormato.Text = salas[b];//formato 3
			lbClasificacion.Text = salas[c];//clasificacion 4
			lbSinopsis.Text = salas[d];//sinopsis 5
			lbHora.Text = salas[e];//hora 6
		}

		string MultimediaPeli()// Obtiene los datos de la BD la multimedia de la pelicula cargada en cartelera
		{ 
			//Gustavo Perez
			string idMulti;
			string imagen;
			conn.Open();
			OdbcCommand command = new OdbcCommand(""
			+ "SELECT multimedia FROM peliculas WHERE titulo = '"+ lbtitulo.Text+"'", conn);
			OdbcDataReader funciones = command.ExecuteReader();

			funciones.Read();
			
				idMulti = funciones.GetValue(0).ToString();

			conn.Close();

			conn.Open();
			OdbcCommand command2 = new OdbcCommand(""
			+ "SELECT Afiche FROM multimedia WHERE NoRegistro = " + idMulti , conn);
			OdbcDataReader funciones2 = command2.ExecuteReader();

			funciones2.Read();
			imagen = funciones2.GetValue(0).ToString();
			conn.Close();

			return imagen;
		}
		string MultimediaTrailer()  //carga el trailer de la pelicula cargada en cartelera
		{
			//Gustavo Perez
			string idMulti;
			string imagen;
			
			conn.Open();
			OdbcCommand command = new OdbcCommand(""
			+ "SELECT multimedia FROM peliculas WHERE titulo = '" + lbtitulo.Text + "'", conn);
			OdbcDataReader funciones = command.ExecuteReader();

			funciones.Read();

			idMulti = funciones.GetValue(0).ToString();

			conn.Close();

			conn.Open();
			OdbcCommand command2 = new OdbcCommand(""
			+ "SELECT Trailer FROM multimedia WHERE NoRegistro = " + idMulti, conn);
			OdbcDataReader funciones2 = command2.ExecuteReader();

			funciones2.Read();
			imagen = funciones2.GetValue(0).ToString();
			conn.Close();

			return imagen;
		}
		void cambiarCartelera(int sala)// Controla el cambio de sala en la cartelera y re asigna los datos de las peliculas
		{
			//Gustavo Perez
			WebRequest request = WebRequest.Create(MultimediaPeli()); // se abre el Url de la imagen
			using (var response = request.GetResponse()) 
			{
				using (var str = response.GetResponseStream()) //se obtiene la imagen de internet
				{
					picAfiche.BackgroundImage = Bitmap.FromStream(str); // se carga la imagen al programa
					picAfiche.BackgroundImageLayout = ImageLayout.Stretch;
				}
			}
			switch (sala) // se cambiaran los datos encontrados en la cartelera segun el numero de sala o funcion en que se este
			{
				case 1:
					funcion = Convert.ToInt32(salas[1]);
					llenarCartelera(2, 3, 4, 5, 6);
					break;
				case 2:
					funcion = Convert.ToInt32(salas[7]);
					llenarCartelera(8, 9, 10, 11, 12);
					break;
				case 3:
					funcion = Convert.ToInt32(salas[13]);
					llenarCartelera(14, 15, 16, 17, 18);
					break;
				case 4:
					funcion = Convert.ToInt32(salas[19]);
					llenarCartelera(20, 21, 22, 23, 24);
					break;
				case 5:
					funcion = Convert.ToInt32(salas[25]);
					llenarCartelera(26, 27, 28, 29, 30);
					break;
				case 6:
					funcion = Convert.ToInt32(salas[31]);
					llenarCartelera(32, 33, 34, 35, 36);
					break;
				case 7:
					funcion = Convert.ToInt32(salas[37]);
					llenarCartelera(38, 39, 40, 41, 42);
					break;
				case 8:
					funcion = Convert.ToInt32(salas[42]);
					llenarCartelera(43, 44, 45, 46, 47);
					break;
				case 9:
					funcion = Convert.ToInt32(salas[48]);
					llenarCartelera(49, 50, 51, 52, 53);
					break;
				case 10:
					funcion = Convert.ToInt32(salas[54]);
					llenarCartelera(55, 56, 57, 58, 59);
					break;
				case 11:
					funcion = Convert.ToInt32(salas[60]);
					llenarCartelera(61,62,63,64,65);
					break;
				case 12:
					funcion = Convert.ToInt32(salas[66]);
					llenarCartelera(67,68,69,70,71);
					break;
				case 13:
					funcion = Convert.ToInt32(salas[72]);
					llenarCartelera(73,74,75,76,77);
					break;
				case 14:
					funcion = Convert.ToInt32(salas[78]);
					llenarCartelera(79,80,81,82,83);
					break;
				case 15:
					funcion = Convert.ToInt32(salas[84]);
					llenarCartelera(85,86,87,88,89);
					break;
				case 16:
					funcion = Convert.ToInt32(salas[90]);
					llenarCartelera(91,92,93,94,95);
					break;
				case 17:
					funcion = Convert.ToInt32(salas[96]);
					llenarCartelera(97,98,99,100,101);
					break;
				case 18:
					funcion = Convert.ToInt32(salas[102]);
					llenarCartelera(103,104,105,106,107);
					break;
				case 19:
					funcion = Convert.ToInt32(salas[108]);
					llenarCartelera(109,110,111,112,113);
					break;
				case 20:
					funcion = Convert.ToInt32(salas[114]);
					llenarCartelera(115,116,117,118,119);
					break;
			}
		}

		void Cartelera()	// Obtiene los datos de las funciones de la BD
		{
			//Gustavo Perez
			int noCartelera = 0;
			if (formatoPeli == "Formato" && idiomaPeli == "Idioma")// sin ningun flitro
			{
				conn.Open();
				OdbcCommand command = new OdbcCommand(""
				+ "select A.idfuncion," +
				"(SELECT titulo FROM peliculas WHERE idPelicula = A.idPelicula) titulo," +
				"(SELECT formato FROM peliculas WHERE idPelicula = A.idPelicula) formato ," +
				"(SELECT clasificación FROM peliculas WHERE idPelicula = A.idPelicula) clasificacion," +
				"(SELECT sinopsis FROM peliculas WHERE idPelicula = A.idPelicula) sinopsis, A.horaFuncion " +
				"from funciones A where A.Cine = '" + cineSeleccionado + "'", conn);
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
					noCartelera++;
				}
				conn.Close();
			
			}else if (formatoPeli != "Formato" && idiomaPeli == "Idioma") // filtrando formato
			{
				conn.Open();
				OdbcCommand command = new OdbcCommand(""
				+ "select A.idfuncion," +
				"(SELECT titulo FROM peliculas WHERE idPelicula = A.idPelicula) titulo," +
				"(SELECT formato FROM peliculas WHERE idPelicula = A.idPelicula) formato ," +
				"(SELECT clasificación FROM peliculas WHERE idPelicula = A.idPelicula) clasificacion," +
				"(SELECT sinopsis FROM peliculas WHERE idPelicula = A.idPelicula) sinopsis, A.horaFuncion " +
				"from funciones A, peliculas where A.Cine = '" + cineSeleccionado + "'AND A.idPelicula = peliculas.idPelicula AND formato ='" + formatoPeli + "'", conn);
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
					noCartelera++;
				}
				conn.Close();
				
			}
			else if (formatoPeli == "Formato" && idiomaPeli != "Idioma") // filtrando idioma
			{
				conn.Open();
				OdbcCommand command = new OdbcCommand(""
				+ "select A.idfuncion," +
				"(SELECT titulo FROM peliculas WHERE idPelicula = A.idPelicula) titulo," +
				"(SELECT formato FROM peliculas WHERE idPelicula = A.idPelicula) formato ," +
				"(SELECT clasificación FROM peliculas WHERE idPelicula = A.idPelicula) clasificacion," +
				"(SELECT sinopsis FROM peliculas WHERE idPelicula = A.idPelicula) sinopsis, A.horaFuncion " +
				"from funciones A, peliculas where A.Cine = '" + cineSeleccionado + "'AND A.idPelicula = peliculas.idPelicula AND idioma ='" + idiomaPeli + "'", conn);
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
					noCartelera++;
				}
				conn.Close();
				
			}
			else if (formatoPeli != "Formato" && idiomaPeli != "Idioma") // filtrando idioma y formato
			{
				conn.Open();
				OdbcCommand command = new OdbcCommand(""
				+ "select A.idfuncion," +
				"(SELECT titulo FROM peliculas WHERE idPelicula = A.idPelicula) titulo," +
				"(SELECT formato FROM peliculas WHERE idPelicula = A.idPelicula) formato ," +
				"(SELECT clasificación FROM peliculas WHERE idPelicula = A.idPelicula) clasificacion," +
				"(SELECT sinopsis FROM peliculas WHERE idPelicula = A.idPelicula) sinopsis, A.horaFuncion " +
				"from funciones A, peliculas where A.Cine = '" + cineSeleccionado + "'AND A.idPelicula = peliculas.idPelicula AND formato ='" + 
				formatoPeli + "'"+ "AND idioma ='" + idiomaPeli + "'", conn);
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
					noCartelera++;
					
				}
				conn.Close();
			}
			if (noCartelera == 0)
			{
				MessageBox.Show("No Hay peliculas con esas Preferencias...");
				this.Close();
				th = new Thread(opennewform2);
				th.SetApartmentState(ApartmentState.STA);
				th.Start();
			}
			else { tmrCartelera.Enabled = true; }
			
		}
		private void button9_Click(object sender, EventArgs e)// btncontinuar
		{
			this.Close();
			th = new Thread(opennewform);// se crea un nuevo hilo para no bajar el rendimiento de la App
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}

		private void opennewform()
		{
			Application.Run(new frmBoletos(funcion,cineSeleccionado));
		}

		private void Frm_cartelera_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void timer1_Tick(object sender, EventArgs e) // controla constantemente el cambio de la cartelera
		{
			
			if (sala == 1)
			{	
				llenarCartelera(2, 3, 4, 5, 6);
				btnMenos.Enabled = false;
				btnMas.Enabled = true;
			}
			if (numSalas==1)
			{
				llenarCartelera(2, 3, 4, 5, 6);
				btnMenos.Enabled = false;
				btnMas.Enabled = false;
			}

			if (sala > 1 && sala < numSalas)
			{
				btnMenos.Enabled = true;
				btnMas.Enabled = true;
				cambiarCartelera(sala);
			} else if (sala == numSalas)
			{
				btnMas.Enabled = false;
				btnMenos.Enabled = true;
				cambiarCartelera(sala);
			}
			WebRequest request = WebRequest.Create(MultimediaPeli());
			using (var response = request.GetResponse()) 
			{
				using (var str = response.GetResponseStream()) 
				{
					picAfiche.BackgroundImage = Bitmap.FromStream(str); 
					picAfiche.BackgroundImageLayout = ImageLayout.Stretch;
				}
			}

		}

	
		private void btnMas_Click(object sender, EventArgs e)
		{
			sala++;
		}

		private void btnMenos_Click(object sender, EventArgs e)
		{
			sala--;
		}

		
		private void lbtitulo_TextChanged(object sender, EventArgs e)
		{
			webPelicula.Stop();
			webPelicula.Navigate(MultimediaTrailer());
	
		}

		private void Button2_Click(object sender, EventArgs e)
		{
		

			
				this.Close();
				th = new Thread(opennewform2);
				th.SetApartmentState(ApartmentState.STA);
				th.Start();
	
			
		}
		private void opennewform2()
		{
			Application.Run(new Filtro(cineSeleccionado));
		}

		private void frmCartelera_Load(object sender, EventArgs e)
		{

		}
	}
    }

