using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appadmin
{
    public partial class frmTiempo : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        public frmTiempo()
        {
            InitializeComponent();
            tiempo1();
        }
        void tiempo1()
        {
            try
            {


                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM timer", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    txtTiempo.Text = (reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (txtTiempo.Text != "")
            {

                string query = "UPDATE timer SET " +
                "tiempo='" + txtTiempo.Text + "' WHERE noRegistro =" + "1";
                conn.Open();
                OdbcCommand consulta = new OdbcCommand(query, conn);
                try
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("Datos Actualizados Correctamente");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("\t Error! \n\n " + ex.ToString());
                    conn.Close();
                }
                txtTiempo.Text = "";


            }
            else
            {
                MessageBox.Show("Por favor, llene los campos para ingresar");

            }
        }

        private void FrmTiempo_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usuario = "usuario";
            MainMenu frm = new MainMenu(usuario);
            frm.Show();
            this.Hide();
        }
    }
}
