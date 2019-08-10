using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla_cliente_comprador
{
    public partial class frmTipoPago : Form
    {
        int tiempo2 = 0;
		int tipoPago=0;
		string cineSeleccionado;
		int nofuncion;
		int noTercera;
		int noAdulto;
		int noNino;
		string[] Elegidos2 = new string[10];
		public frmTipoPago(int tiempo,string[] arr, int funcion, string cine, int trecera, int adulto, int nino)
        {
            InitializeComponent();
			nofuncion = funcion;
			cineSeleccionado = cine;
			noTercera = trecera;
			noAdulto = adulto;
			noNino = nino;
			tiempo2 = tiempo;
			Elegidos2 = arr;
        }

        private void BtPago_Click(object sender, EventArgs e)
        {
            int tipo = 2;
			tipoPago = 0;
            Frm_pago avilitar = new Frm_pago(tiempo2, tipo,Elegidos2,nofuncion,cineSeleccionado,tipoPago,noTercera,noAdulto,noNino);
            avilitar.Show();
            Visible = false;
        }

        private void BtReservar_Click(object sender, EventArgs e)
        {
            int tipo = 1;
			tipoPago = 1;
            Frm_pago avilitar = new Frm_pago(tiempo2, tipo,Elegidos2,nofuncion,cineSeleccionado, tipoPago,noTercera,noAdulto,noNino);
            avilitar.Show();
            Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo2 > 0)
            {
                tiempo2 = tiempo2 - 1;
                lbtiempo2.Text = tiempo2.ToString();
            }
        }

		private void frmTipoPago_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
