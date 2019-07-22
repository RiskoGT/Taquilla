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

namespace Appadmin
{
    public partial class gestionUsuarios : Form
    {
        public gestionUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void RegresarMenu_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
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
    }
}
