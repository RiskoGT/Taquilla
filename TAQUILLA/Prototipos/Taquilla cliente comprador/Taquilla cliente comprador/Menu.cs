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
    public partial class frmMenu : Form
    {
        /*Grupo 2  taquilla  cliente comprador
         Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        public frmMenu()
        {
            InitializeComponent();
            ComboSeleccioneCiudad.Items.Add("Guatemala");
            ComboSeleccioneCiudad.Items.Add("Xela");
        }

        
        private void Btn_verCartelera_Click(object sender, EventArgs e)
        {
            Form formulario = new frmCartelera();
            formulario.Show();
            Visible = false;
         
        }

		private void Frm_menu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("Manual.pdf");
		}

    }
}
