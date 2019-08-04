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
        public frmTipoPago(int tiempo)
        {
            InitializeComponent();
            tiempo2 = tiempo;
        }

        private void BtPago_Click(object sender, EventArgs e)
        {
            int tipo = 2;
            Frm_pago avilitar = new Frm_pago(tiempo2, tipo);
            avilitar.Show();
            Visible = false;
        }

        private void BtReservar_Click(object sender, EventArgs e)
        {
            int tipo = 1;
            Frm_pago avilitar = new Frm_pago(tiempo2, tipo);
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

       
    }
}
