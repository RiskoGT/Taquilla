using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Taquilla_cliente_comprador
{
    public partial class Frm_pago : Form
    {
        Correo c = new Correo();

        /*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        int tiempo = 0;// tiempo será extraible desde base de datos y de modificara desde la app de administrador
        public Frm_pago(int dato)
        {
            InitializeComponent();
            tiempo = dato;
            Combomes.Items.Add("1");
            Combomes.Items.Add("2");
            Combomes.Items.Add("3");
            Combomes.Items.Add("4");
            Combomes.Items.Add("5");
            Combomes.Items.Add("6");
            Combomes.Items.Add("7");
            Combomes.Items.Add("8");
            Combomes.Items.Add("9");
            Combomes.Items.Add("10");
            Combomes.Items.Add("11");
            Combomes.Items.Add("12");
            ComboAño.Items.Add("19");
            ComboAño.Items.Add("20");
            ComboAño.Items.Add("21");
            ComboAño.Items.Add("22");
            ComboAño.Items.Add("23");
            ComboAño.Items.Add("24");
            ComboAño.Items.Add("25");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tiempo == 0)
            {
                MessageBox.Show("El tiempo de Compra a terminado!");
                Form formularioca = new frmMenu();
                formularioca.Show();
                Visible = false;

            }
            else
            {
                if (txtCorreo.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtCodigo.Text.Trim() == "" || txtTarjeta.Text.Trim() == "" || txtTelefono.Text.Trim() == "")
                {
                    MessageBox.Show("Profavor llenar las casillas!!");
                }
                else
                {
                    c.enviarCorreo( txtCorreo.Text);

                    Form formulariopago = new frmMenu();
                    formulariopago.Show();
                    Visible = false;
                    Form formulariopago1 = new frmConfirmasion();
                    formulariopago1.Show();
                    timer1.Enabled = false;
                }
            }
        }

		private void Frm_pago_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
           
			Process.Start("Manual.pdf");

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

        private void Frm_pago_Load(object sender, EventArgs e)
        {

        }
    }
}
