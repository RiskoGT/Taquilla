using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading;
//Juan Jose Gamez Blanco 0901-16-47
namespace Taquilla_cliente_comprador
{
    class Correo //Se elabora una clase llamada correo
    {
		Thread th;
		string nom;
		string nomArch;
		MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();
        string usu = "riskogt6@gmail.com"; //En esta opcion se encuentra el correo de donde salen los mensajes
        string pass = "Risgt657";//Esta es la contraseña para que el sistema pueda acceder.
        string bol = " Risko   Boletos Comprados";//Este es el mensaje del correo
        string men = "Gracias por su compra:";
        public void enviarCorreo( string destinatario,string nombre, string nomArchivo)
        {
            try //En este try se encuentra los datos y requerimeintos necesarios para que se puega generar el correo.
            {
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = men+nombre;
                correos.Subject = bol;
                correos.IsBodyHtml = true;
                correos.To.Add(destinatario.Trim());

                if (nomArchivo.Equals("") == false) //Este if tiene el objetivo de verificar si se envio el correo corectamente.
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(nomArchivo);
					nomArch = nomArchivo;
					nom = nombre;
                    correos.Attachments.Add(archivo);
        
                }

                correos.From = new MailAddress(usu);
                envios.Credentials = new NetworkCredential(usu, pass); //En esta linne de codigo no serve para insertar los parametros solicitados

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

            
                envios.Send(correos);
				

				// abre el form de confirmacion
			
				th = new Thread(opennewform);
				th.SetApartmentState(ApartmentState.STA);
				th.Start();


			}
            catch (Exception ex) //si no se envian los correos se genera un mensaje de error
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

		private void opennewform()
		{
			Application.Run(new frmConfirmasion(nom, nomArch));
		}

	}
}

