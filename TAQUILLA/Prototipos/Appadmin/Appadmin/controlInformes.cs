using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Appadmin
{
    public partial class controlInformes : Form
    {
        string usuario;
		string level;
		public controlInformes(string user, string nivel)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            usuario = user;
			level = nivel;
        }        
        
     

        private void controlInformes_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu(usuario, level);
            frm.Show();
            this.Hide();
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu(usuario, level);
            mainMenu.Show();
        }

        private void BtnReporteTaquillera_Click(object sender, EventArgs e)
        {
            ReporteTaquillera taquis = new ReporteTaquillera();
            taquis.Show();
        }
    }
}
