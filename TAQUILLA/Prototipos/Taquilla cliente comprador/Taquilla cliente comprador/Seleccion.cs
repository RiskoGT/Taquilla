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
    public partial class Frm_cartelera : Form
    {
        public Frm_cartelera()
        {
            InitializeComponent();
        }



		private void button9_Click(object sender, EventArgs e)
		{
			Form formulariobol = new Frm_boletos();
			formulariobol.Show();
			Visible = false;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Frm_cartelera_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
