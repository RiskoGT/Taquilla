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
    public partial class Cine : Form
    {
        OdbcConnection conn = new OdbcConnection("Dns=Cine");
        public Cine()
        {
            InitializeComponent();
            //llenarCombos();
            //llenartabla();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cine_Load(object sender, EventArgs e)
        {

        }
        void llenartabla()
        {
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM cines");
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO cines (idCiudad, nombreCine) VALUES ('" + comboCiudad.Text[0]
                + "', '" + txtCine.Text + "')";
            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                if (txtCine.Text != "" && comboCiudad.Text != "")
                {
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("INGRESO CORRECTO");
                    txtCine.Text = "";
                    comboCiudad.Text = "";
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
        void llenarCombos()
        {
            //llenado de comboBox CLASIFICACION
            try
            {
                comboCiudad.Text = "Ciudad";
                comboCiudad.Items.Clear();

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM ciudades", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboCiudad.Refresh();
                    comboCiudad.Items.Add(reader.GetValue(0).ToString() + " - "
                        + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
