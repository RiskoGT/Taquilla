using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Taquilla_cliente_comprador
{
    public partial class Filtro : Form
    {
		/*Grupo 2  taquilla  cliente comprador
         Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
		OdbcConnection conn = new OdbcConnection("Dsn=Cine");
		public Filtro()
        {
            InitializeComponent();
            
        }
		void llenarLista()
		{
			try
			{
				comboBox1.Text = "EMPLEADOS";
				comboBox1.Items.Clear();

				conn.Open();
				OdbcCommand command = new OdbcCommand("SELECT * FROM empleados", conn);
				OdbcDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox1.Refresh();
					comboBox1.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString() + " " + reader.GetValue(3).ToString());
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
            Form formulario = new frmCartelera();
            formulario.Show();
            Visible = false;
         
        }

		private void Filtro_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("Manual.pdf");
		}

		private void tlppanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Form formulario = new frmCartelera();
			formulario.Show();
			Visible = false;
		}

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
