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
        /*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        public Frm_pago()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form formulariopago = new Frm_menu();
            formulariopago.Show();
            Visible = false;
            Form formulariopago1 = new Frm_Confirmasion();
            formulariopago1.Show();
            
          
        }

		private void Frm_pago_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
           

			Process.Start("Manual.pdf");

		}

        private void Frm_pago_Load(object sender, EventArgs e)
        {

        }
    }
}
