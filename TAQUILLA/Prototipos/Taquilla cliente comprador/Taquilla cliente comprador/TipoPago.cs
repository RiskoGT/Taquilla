﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//juan jose Gamez

namespace Taquilla_cliente_comprador
{
    public partial class frmTipoPago : Form
    {
        int tiempo2 = 0;
		int tipoPago=0;// determina si se realizara una compra o reservacion
		// Variables acarreadas para querys
		string cineSeleccionado;
		int nofuncion;
		int noTercera;
		int noAdulto;
		int noNino;
		// asientos elegidos
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
        //juan gamez
        private void BtPago_Click(object sender, EventArgs e) //Esta opcion abre el menu de pago
        {
            int tipo = 2;
			tipoPago = 0;// Pagar
            Frm_pago avilitar = new Frm_pago(tiempo2, tipo,Elegidos2,nofuncion,cineSeleccionado,tipoPago,noTercera,noAdulto,noNino);
            avilitar.Show();
            Visible = false;
        }
        //juan Gamez
        private void BtReservar_Click(object sender, EventArgs e) //Esta opcion abrira la opcion de reservar
        {
            int tipo = 1;
			tipoPago = 1;//Reservar
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Form formulariopago = new frmMenu();
            formulariopago.Show();
            Visible = false;
        }
        //juan Gamez
        private void Lbayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, " Página web ayuda/ayuda.chm", "menutipopago.html");//Esta funcion abre la opcion de ayuda con HTML
        }

      
    }
}
