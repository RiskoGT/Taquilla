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
        public controlInformes(string user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            usuario = user;
        }        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void sendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
            MainMenu frm = new MainMenu(usuario);
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
    }
}
