using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla_cliente_comprador
{ //Juan Gamez y Gustavo Perez
    public partial class frmConfirmasion : Form 
    {
		Thread th;
		string nom;
		string arch;
        public frmConfirmasion(string nombre, string archivo)
        {
            InitializeComponent();
			nom = nombre;
			arch = archivo;
        }

        private void Btn_acetar_Click(object sender, EventArgs e)
        {
            Form formulariocon = new frmMenu();
            formulariocon.Show();
            Visible = false;
        }

		private void Frm_Confirmasion_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
				this.Close();
				th = new Thread(opennewform);
				th.SetApartmentState(ApartmentState.STA);
				th.Start();
			

			
		}
		private void opennewform()
		{
			Application.Run(new frmMenu());
		}

		private void button1_Click(object sender, EventArgs e)
		{

			this.Close();
			th = new Thread(opennewform);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			nuevoCorreo nuevo = new nuevoCorreo(nom, arch);
			this.Hide();
			nuevo.Show();
		}

        private void FrmConfirmasion_Load(object sender, EventArgs e)
        {

        }
    }
}
