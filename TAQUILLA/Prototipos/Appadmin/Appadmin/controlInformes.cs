/*
 * Integrantes a Cargo:
 * 0901-16-1288 Randy Choc 
 * 0901-16- 420 Gustavo Perez
 * 
 * Randy creo la maquetación del form
 * Randy creo el form con los respectivos elementos
 * Gustavo agrego diseño y presentación al form
 * Randy agrego código de Mantenimientos 
 */
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
using WindowsFormsAppPruebas;

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
            //inicializamos los siguientes componentes y variables 
            usuario = user;
			level = nivel;
            lbUsuario.Text = user;
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
            //llamamos el form MainMenu
            MainMenu frm = new MainMenu(usuario, level);
            //mostramos el form 
            frm.Show();
            //ocultamos el form actual 
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
            //ocultamos la ventana actual 
            this.Hide();
            //llamamos el form MainMenu
            MainMenu mainMenu = new MainMenu(usuario, level);
            //mostramos el form 
            mainMenu.Show();
        }
        private void BtnReporteTaquillera_Click(object sender, EventArgs e)
        {
            ReporteTaquillera taquis = new ReporteTaquillera();
            taquis.Show();
        }

        private void ControlInformes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mainM = new MainMenu(usuario, level);
            mainM.Show();
        }

        private void BtnReporteGanancia_Click(object sender, EventArgs e)
        {
            //creamos una nueva conexion con el form 'rpHorario' 
            rpHorario horario = new rpHorario();
            //mostrarmos el form 'rpHorario'
            horario.Show();
        }
    }
}
