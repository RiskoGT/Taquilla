/*Randy Choc Gestion Usuarios 0901-16-1288*/
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
    public partial class gestionUsuarios : Form
    {

        /* MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port=3306; username=root; " +
            "password=; database=taquilla");
            */
        //establecemos la conexion con el nombre establecido en el origen de datos (ODBC)
        OdbcConnection conn = new OdbcConnection("Dsn=cine");
        public gestionUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            txtApellido.Clear();
            txtBusqueda.Clear();
            txtContra.Clear();
            txtDir.Clear();
            txtDpi.Focus();
            txtEmail.Clear();
            txtNombre.Clear();
            txtSexo.Clear();
            txtTel.Clear();
            txtTelCasa.Clear();
            txtUsuario.Clear();
           }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void RegresarMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click_1(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
