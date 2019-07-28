using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Appadmin
{
    public partial class Ciudad : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=cine");        
        public Ciudad()
        {
            InitializeComponent();
            llenartabla();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Ciudad_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ciudades (nombreCiudad) VALUES ('" + txtCiudad.Text 
                + ", " + txtDepa.Text + "')";            
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtCiudad.Text != "" && txtDepa.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");                    
                    txtCiudad.Text = "";
                    txtDepa.Text = "";
                    conn.Close();
                    llenartabla(); //llenamos el DataGridView de Ciudades
                }
                else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); conn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
                conn.Close();
            }
        }

        void llenartabla()
        {
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM ciudades");
            try
            {
                OdbcDataAdapter ejecutar = new OdbcDataAdapter();
                ejecutar.SelectCommand = codigo;
                DataTable datostabla = new DataTable();
                ejecutar.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                ejecutar.Update(datostabla);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }
    }
}
