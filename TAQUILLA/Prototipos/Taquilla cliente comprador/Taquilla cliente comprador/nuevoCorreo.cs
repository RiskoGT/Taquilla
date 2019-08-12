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
{
    public partial class nuevoCorreo : Form
    {
		Thread th;
		Correo c = new Correo();

		string nom;
		string arch;
        public nuevoCorreo(string nombre , string archivo)
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
			c.enviarCorreo(textBox1.Text, nom, arch);// se envia el correo electronico
			Application.Exit();
			this.Close();
				th = new Thread(opennewform);
				th.SetApartmentState(ApartmentState.STA);
				th.Start();
		}
		private void opennewform()
		{
			Application.Run(new frmMenu());
		}

	}
}
