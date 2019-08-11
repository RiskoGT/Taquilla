using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Taquilla_cliente_comprador
{

	public partial class Frm_pago : Form
	{
		OdbcConnection conn = new OdbcConnection("Dsn=cine");
		Correo c = new Correo();

		/*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
		int tiempo = 0;// tiempo será extraible desde base de datos y de modificara desde la app de administrador
		int op = 0;
		string cineSeleccionado;
		int nofuncion;
		string linea;
		string texto;
		int tipoPago;
		int noTercera;
		int noAdulto;
		int noNino;
		string[] Elegidos2 = new string[10];
		public Frm_pago(int dato, int info, string[] arr, int funcion, string cine, int opcionPago, int trecera, int adulto, int nino)
		{
			InitializeComponent();
			tiempo = dato; // se asigna el tiempo restante
			 // se cargan la variables acarreadas del proceso de compra
			Elegidos2 = arr; 
			tipoPago = opcionPago; 
			// se asigna el formato de la fecha actual
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			nofuncion = funcion;
			cineSeleccionado = cine;
			noTercera = trecera;
			noAdulto = adulto;
			noNino = nino;
		    op = info;
			if (info == 1)
			{

				lbPagoCompra.Text = "Reservación ";
				txtTarjeta.Visible = false;
				txtCodigo.Visible = false;
				lbSeguridad.Visible = false;
				lbVencimiento.Visible = false;
				lbSeguridad.Visible = false;
				dateTimePicker2.Visible = false;
				lbVencimiento.Visible = false;

				lbTarjeta.Visible = false;

			}
			else if (info == 2)
			{

				lbPagoCompra.Text = "Pago";
				txtTelefono.Visible = true;
				txtTarjeta.Visible = true;
				txtCodigo.Visible = true;
				lbSeguridad.Visible = true;
				lbVencimiento.Visible = true;
				lbSeguridad.Visible = true;
				dateTimePicker2.Visible = true;
				lbVencimiento.Visible = true;
				
				lbTarjeta.Visible = true;

			}
			


		}

		void cambiarEstadoAsientos(string asiento)// cambia el estado de los asientos a ocupados
		{
			//Gustavo Perez
			string query = "UPDATE Asientos SET " +
				"estado=1 WHERE idAsiento= '" + asiento + "' AND idFuncion =" + nofuncion;
			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
				consulta.ExecuteNonQuery();
				conn.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
		}

		void Reservacion()// ingresa las cabeceras de las reservasiones
		{
			//Gustavo Perez
			string query = "INSERT INTO Reservaciones (idFuncion, Fecha, Cine) Values(" + nofuncion + ",'" + dateTimePicker1.Text + "','" + cineSeleccionado + "') ";

			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
				consulta.ExecuteNonQuery();
				conn.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
		}
		int obtenerReservacion()//obtiene la ultima reservacion ingresada
		{
			//Gustavo Perez
			int id = 0;
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT idReservacion FROM Reservaciones ORDER BY idReservacion DESC", conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				id = Convert.ToInt32(reader.GetValue(0).ToString());


			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return id;
		}
		void detalleReservacion(string asiento)// ingresa detalles de reservacion
		{
			//Gustavo Perez
			int id =obtenerReservacion();
			string query = "INSERT INTO detalleReservacion (idReservacion, idFuncion, idAsiento) Values(" + id.ToString() + "," + nofuncion + ",'" + asiento + "') ";

			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
				consulta.ExecuteNonQuery();
				conn.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
		}
		void Factura()// ingresa los encabezados de factura
		{
			//Gustavo Perez
			string query = "INSERT INTO encabezadosFactura (fechaFactura, Cine, Funcion) Values('" + dateTimePicker1.Text + "','" + cineSeleccionado + "'," + nofuncion + ") ";
			lbCorreo.Text = dateTimePicker1.Text;
			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
				consulta.ExecuteNonQuery();
				conn.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
		}
		int obtenerFactura()// obtiene el id de la ultima facutra ingresada
		{
			//Gustavo Perez
			int id = 0;
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT numeroFactura FROM encabezadosFactura ORDER BY numeroFactura DESC", conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				id = Convert.ToInt32(reader.GetValue(0).ToString());


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return id;
		}
		void boleto(string asiento, string tipo)// ingresa un nuevo boleto
		{
			string Peli = obtenerPelicula();
			//Gustavo Perez
			string query = "INSERT INTO Boletos (idFuncion, idAsiento, Fecha, Cine, tipoBoleto)" +
			" Values(" + nofuncion + ",'" + asiento + "','" + dateTimePicker1.Text + "', '" + cineSeleccionado + "', '" + tipo + "') ";
			texto +="Funcion: "+ Peli+ "   Asiento: "+asiento+"   Fecha: " + dateTimePicker1.Text+"   Cine: "+cineSeleccionado+"    Tipo Boleto: "+ tipo+"\n";
			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
				consulta.ExecuteNonQuery();
				conn.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
		}
		int obtenerBoleto()// Obtiene el ultimo boleto registrado
		{
			//Gustavo Perez
			int id = 0;
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT idBoleto FROM Boletos ORDER BY idBoleto DESC", conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				id = Convert.ToInt32(reader.GetValue(0).ToString());


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return id;
		}
		string obtenerPelicula()// Obtiene el ultimo boleto registrado
		{
			//Gustavo Perez
			string id = "";
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT Titulo FROM Peliculas where idPelicula= (SELECT idPelicula from Funciones where idFuncion="+nofuncion+")" , conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();
				id = reader.GetValue(0).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return id;
		}
		int obtenerCosto(int idBoleto)// obtiene el costo de un boleto
		{
			//Gustavo Perez
			int id = 0;
			string tipo = "";
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT tipoBoleto FROM Boletos where idBoleto =" + idBoleto, conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				tipo = reader.GetValue(0).ToString();


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT Precio FROM tiposBoleto where Tipo ='" + tipo + "'", conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				id = Convert.ToInt32(reader.GetValue(0).ToString());


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return id;
		}
		void detalleFactura(string asiento)// ingresa los detalles de factura
		{
			//Gustavo Perez
			string query = "INSERT INTO detalleFactura (numeroFactura, idBoleto, costo)" +
				" Values(" + obtenerFactura() + "," + obtenerBoleto() + "," + obtenerCosto(obtenerBoleto()) + ") ";

			conn.Open();
			OdbcCommand consulta = new OdbcCommand(query, conn);
			try
			{
				consulta.ExecuteNonQuery();
				conn.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show("\t Error! \n\n " + ex.ToString());
				conn.Close();
			}
		}
		
		string pdfFactura()// caraga de BD los datos de la factura al PDF
		{
			//Gustavo Perez
			string cadena = "";
			string Peli = obtenerPelicula();
			int id=obtenerFactura();
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT numeroFactura, fechaFactura, Cine, Funcion FROM encabezadosFactura where numeroFactura="+id, conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				cadena =" Factura No. "+reader.GetValue(0).ToString()+ "\n  Fecha: " + reader.GetValue(1).ToString() 
					+ "\n   Cine: " + reader.GetValue(2).ToString()
					+ "\n   Funcion: " + Peli +"\n\n";


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return cadena;
		}
		string pdfDetalleFact()// Carga  de BD los detalles de la factura al PDF
		{
			//Gustavo Perez
			string cadena = "";
			int id = obtenerFactura();
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT idBoleto, Costo  FROM detalleFactura where numeroFactura=" + id, conn);
				OdbcDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{

					cadena += " Boleto No. " + reader.GetValue(0).ToString() + " -  Costo: Q" + reader.GetValue(1).ToString()
						+ ".00\n";
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			// total
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT SUM(Costo)  FROM detalleFactura where numeroFactura=" +id, conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				cadena += " TOTAL = " + reader.GetValue(0).ToString()+".00\n";


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return cadena;
		}
		string pdfReservacion()// Carga de BD los datos de reservacion al PDF
		{
			//Gustavo Perez
			string cadena = "";
			string Peli = obtenerPelicula();
			int id = obtenerReservacion();
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT idReservacion, idFuncion, Fecha, Cine FROM Reservaciones where idReservacion=" + id, conn);
				OdbcDataReader reader = command.ExecuteReader();
				reader.Read();

				cadena = " Reservacion No. " + reader.GetValue(0).ToString() + "\n  Funcion: " + Peli
					+ "\n   Fecha: " + reader.GetValue(2).ToString()
					+ "\n   Cine: " + reader.GetValue(3).ToString() + "\n\n";


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return cadena;
		}
		string pdfDetalleReservacion() // carga de Bd los datos de reservacion al PDF
		{
			//Gustavo Perez
			string cadena = "";
			string Peli = obtenerPelicula();
			int id = obtenerReservacion();
			try
			{

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT idFuncion, idAsiento FROM detalleReservacion where idReservacion=" + id, conn);
				OdbcDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{

					cadena += "Funcion No. " + Peli + " -  Asiento: " + reader.GetValue(1).ToString()
						+ "\n";
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			return cadena;
		}
		void nuevoPDF (string texto, string nombre) // Crea el PDF a adjuntar al correo
		{//Gustavo Perez

			iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
			try
			{
				
				PdfWriter.GetInstance(doc, new FileStream(nombre, FileMode.Create));
				doc.Open();
			
				doc.Add(new iTextSharp.text.Paragraph(texto));
				doc.Close();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				doc.Close();
			}
			
		}
		void letra(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }

        }
        void letrasimbolo(KeyPressEventArgs e)
        {


            if (char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsPunctuation(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }

        }
        void numero(KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }
		bool validarEmail(string email)// Valida la estructura del correo porporcionado
		{
			//Gustavo Perez
			try
			{
				var mail = new System.Net.Mail.MailAddress(email);
				return true;
			}
			catch
			{
				return false;
			}
		}
		private void Button1_Click(object sender, EventArgs e)
		{
		//Juan Gamez y Gustavo Perez
			if (!validarEmail(txtCorreo.Text))// se valida la direccion de correo antes de realizar el proceso
			{
				MessageBox.Show("Direccion de Correo no Valida!");
			}
			else { 
				if (tiempo == 0)
				{
					MessageBox.Show("El tiempo de Compra a terminado!");
					Form formularioca = new frmMenu();
					formularioca.Show();
					Visible = false;

				}
			else
			{
				if (txtCorreo.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtTelefono.Text.Trim() == "")
				{
					MessageBox.Show("Profavor llenar las casillas!!");
				}
				else
				{
					string nomArchivo = "PDF/" + dateTimePicker1.Text +" "+DateTime.Now.ToString("hh - mm -ss tt")+ ".pdf";
					//ASIENTOS SELECIONADOS//
					int noAsiento1 = 0;
					while (Elegidos2[noAsiento1] != "$")
					{
						cambiarEstadoAsientos(Elegidos2[noAsiento1]);
						noAsiento1++;
						if (noAsiento1 == 10) { break; }
					}
					if (tipoPago == 0)
					{
						//factrua//
						Factura();
						int noAsiento = 0;
						int cntTercera = 0;
						int cntAdulto = 0;
						int cntNino = 0;
							// Se cargan de boletos datos a PDF de envio
						texto += "==================================================================================================\n";
						texto += "                          BOLETOS\n";
						texto += "==================================================================================================\n";
						while (Elegidos2[noAsiento] != "$")// se controla el numero de asientos elegidos
						{
							if (cntTercera < noTercera)// se asignan asientos de tercera edad
							{
								boleto(Elegidos2[noAsiento], "3ra Edad");
								cntTercera++;
								detalleFactura(Elegidos2[noAsiento]);
								noAsiento++;
							}
							if (cntAdulto < noAdulto)// se asignan asientos de adultos
							{
								boleto(Elegidos2[noAsiento], "Adulto");
								cntAdulto++;
								detalleFactura(Elegidos2[noAsiento]);
								noAsiento++;
							}
							if (cntNino < noNino)// se asignan asientos de ninos
							{
								boleto(Elegidos2[noAsiento], "Niño");
								cntNino++;
								detalleFactura(Elegidos2[noAsiento]);
								noAsiento++;
							}

							if (noAsiento == 10) { break; }// se termina el proceso al llegar al limite de asientos
						}
						// se cargan datos de Fatura al PDF
						texto += "====================================================================================================\n";
						linea = "\n\n=================================================================================================\n";
						texto += linea;
						linea = "            FACTURA TAQUILLA\n";
						texto += linea;
						texto += "\t" + pdfFactura();//encabezado
						texto += "\t" + pdfDetalleFact();// detalle
						linea = "======================================================================================================\n";
						texto += linea;
						
						nuevoPDF(texto, nomArchivo);// Se crea el PDF

					}
					else
					{
						//reservacion//
						Reservacion();
						int noAsiento = 0;
						while (Elegidos2[noAsiento] != "$")// se controla el numero de asientos elegidos
						{
							detalleReservacion(Elegidos2[noAsiento]);
							noAsiento++;
							if (noAsiento == 10) { break; }// se detienen al llegar al limite de asientos
						}
						// se cargan datos de reseracion al PDF
						linea = "\n\n=====================================================================================================\n";
						texto += linea;
						linea = "            RESERVACION CINE\n";
						texto += linea;
						texto += "\t" + pdfReservacion();
						texto += "\t" + pdfDetalleReservacion();
						linea = "===========================================================================================================\n";
						texto += linea;
						
						nuevoPDF(texto, nomArchivo);// Se crea el PDF
						}

					c.enviarCorreo(txtCorreo.Text, txtNombre.Text, nomArchivo);// se envia el correo electronico
						Application.Exit();
				}
			}
			}
        }

		private void Frm_pago_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}


        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
           Form formulariocal = new frmMenu();
            MessageBox.Show("Su compra a sido cancelada, Gracias!!");
            formulariocal.Show();
            Visible = false;
        }

        private void TxtCorreo_Validated(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                Error.SetError(txtCorreo, "Por favor introduzca el correo electrónico ");
               /* txtCorreo.Focus();*/
                  }
            else {
                Error.Clear();
               
            }
        }

        private void TxtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                Error.SetError(txtNombre, "Por favor introduzca su nombre");
                /* txtCorreo.Focus();*/
            }
            else
            {
                Error.Clear();

            }

        }

        private void TxtTarjeta_Validated(object sender, EventArgs e)
        {
            if (txtTarjeta.Text.Trim() == "")
            {
                Error.SetError(txtTarjeta, "Por favor introduzca el numero de tarjeta");
                /* txtCorreo.Focus();*/
            }
            else
            {
                Error.Clear();

            }
        }

        private void TxtCodigo_Validated(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                Error.SetError(txtCodigo, "Por favor introduzca el CW de la tarjeta");
                /* txtCorreo.Focus();*/
            }
            else
            {
                Error.Clear();

            }

        }

        private void TxtTelefono_Validated(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                Error.SetError(txtTelefono, "Por favor introduzca su numero telefónico");
                /* txtCorreo.Focus();*/
            }
            else
            {
                Error.Clear();

            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{

            if (tiempo > 0)
            {
                tiempo = tiempo - 1;
                lbtiempo.Text = tiempo.ToString();
            }

        }
               
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
        }
                
       

        private void TxtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);

        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
        }

      

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, " Página web ayuda/ayuda.chm", "menutipopago.html");
        }

        private void Frm_pago_Load(object sender, EventArgs e)
        {

        }
    }
}
