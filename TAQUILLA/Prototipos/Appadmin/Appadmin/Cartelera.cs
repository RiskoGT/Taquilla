/*Edgar Casasola Formulario Cartelera 0901-16-9*/
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
    public partial class Cartelera : Form
    {
        public Cartelera()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void regresarMenu_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
