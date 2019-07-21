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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cartelera frm = new Cartelera();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlInformes frm = new controlInformes();
            frm.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Acceso frm = new Acceso();
            frm.Show();
            this.Hide();
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
