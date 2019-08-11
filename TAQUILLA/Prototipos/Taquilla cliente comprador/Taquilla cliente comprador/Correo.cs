using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Taquilla_cliente_comprador
{
    class Correo
    {
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();
        string usu = "riskogt6@gmail.com";
        string pass = "Risgt657";
        string bol = " Risko   Boletos Comprados";
        string men = "Gracias por su compra:";
        string ruta = "PDF/ARCHIVO.pdf";
        public void enviarCorreo( string destinatario,string nombre)
        {
            try
            {
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = men+nombre;
                correos.Subject = bol;
                correos.IsBodyHtml = true;
                correos.To.Add(destinatario.Trim());

                if (ruta.Equals("") == false)
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                    correos.Attachments.Add(archivo);
        
                }

                correos.From = new MailAddress(usu);
                envios.Credentials = new NetworkCredential(usu, pass);

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

            
                envios.Send(correos);
				
				// abre el form de confirmacion
				Form formulariopago1 = new frmConfirmasion();
				formulariopago1.Show();
				

			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

