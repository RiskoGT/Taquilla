using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
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
		OdbcConnection conn = new OdbcConnection("Dsn=cine");

		public frmMenu()
        {
            InitializeComponent();
			llenarLista(); //Se llena el Combobox de Ciudades con las ciudades que poseen cines registrados
			ComboSeleccioneCine.Enabled = false;// se deshabilita el combo de cine para evitar errores
			btnVerCartelera.Enabled = false;//se deshabilita el boton de siguiente para evitar que se pueda continuar sin seleccionar campos
        }

		void llenarLista()//lean el combo de ciudades
		{
			//Gustavo Perez
			try
			{
				ComboSeleccioneCiudad.Text = "Ciudades";
				ComboSeleccioneCiudad.Items.Clear();

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT * FROM ciudades A WHERE EXISTS(SELECT * FROM cines WHERE idCiudad = A.idCiudad) ", conn);
				OdbcDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					ComboSeleccioneCiudad.Refresh();
					ComboSeleccioneCiudad.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
		}


		
		private void Btn_verCartelera_Click(object sender, EventArgs e)
        {
            Form formulario = new Filtro(ComboSeleccioneCine.Text);
            formulario.Show();
            Visible = false;    
        }

		private void Frm_menu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	

		private void ComboSeleccioneCiudad_SelectedIndexChanged(object sender, EventArgs e)// se llena el combo de cines dependiendo la ciudad elegida
		{
			//Gustavo Perez
			try
			{
				ComboSeleccioneCine.Text = "Cines";
				ComboSeleccioneCine.Items.Clear();

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT * FROM cines A where A.idCiudad ="+ComboSeleccioneCiudad.Text[0] +
					 " AND EXISTS(SELECT * FROM funciones WHERE cine = A.nombreCine) ", conn);
				OdbcDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					ComboSeleccioneCine.Refresh();
					ComboSeleccioneCine.Items.Add(reader.GetValue(2).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
			ComboSeleccioneCine.Enabled = true;
		}

		private void ComboSeleccioneCine_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnVerCartelera.Enabled = true;
		}

		private void ComboSeleccioneCiudad_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void ComboSeleccioneCine_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, " Página web ayuda/ayuda.chm", "menuPrincipal.html");
        }
    }
}
