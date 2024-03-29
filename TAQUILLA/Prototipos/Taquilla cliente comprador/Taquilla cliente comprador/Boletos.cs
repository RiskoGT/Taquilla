﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Odbc;

namespace Taquilla_cliente_comprador
{
       public partial class frmBoletos : Form   
    {
        /*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        int cont1 = 0; int cont2 = 0; int cont3 = 0;
        int count1=0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int tiempo = 0;
		int nofuncion;
		string cineSeleccionado;
		OdbcConnection conn = new OdbcConnection("Dsn=cine");
        public frmBoletos(int funcion, string cine)
        {
            InitializeComponent();
			nofuncion = funcion;
			cineSeleccionado = cine;
			tiempo1();
            
        }
        //Juan Gamez Control del teimpo

        void tiempo1()
        {
            try
            {
               

                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM timer", conn); //El tiempo puede ser variable desde la aplicacion administrador
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    tiempo = Int32.Parse(reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }
              
        private void Btn_Siguente_Click(object sender, EventArgs e)
        {
            if (tiempo == 0)
            {
                MessageBox.Show("El tiempo de seleccion a terminado!");
                Form formularioca = new frmMenu();
                formularioca.Show();
                Visible = false;

            }
            else
            {
                if (count4 == 0)
                { MessageBox.Show("Por favor, seleccione al menos 1 boleto para continuar, Gracias!!"); }
                else
                {


					try
					{

						conn.Open();
						OdbcCommand command = new OdbcCommand("SELECT estado FROM asientos where  idFuncion="+nofuncion+" AND estado=0", conn);
						OdbcDataReader reader = command.ExecuteReader();
						if (reader.Read())
						{
							frmAsientos asi = new frmAsientos(tiempo, nofuncion, cineSeleccionado, Convert.ToInt32(txt3ra.Text), Convert.ToInt32(txtAdulto.Text), Convert.ToInt32(txtNiño.Text));
							asi.txtAsientos.Text = txtTotalB.Text;
							asi.Show();
							Visible = false;
						}
						else { MessageBox.Show("Funcion Llena"); }  
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					conn.Close();

                    


                }
            }
        }
        //juan Gamez
        private void Button2_Click(object sender, EventArgs e)//Validacion de los botones para los boletos
        { 
            if (txtTotalB.Text == "10")
            {
                MessageBox.Show("No se pueden seleccionar mas de 10 boletos!! Gracias");
                txtTotalB.Text = "0";
                count1 = 0;
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                cont1 = 0;
                cont2 = 0;
                cont3 = 0;
                txt3ra.Text = "0";
                txtAdulto.Text = "0";
                txtNiño.Text = "0";
                txt3raT.Text = "0";
                txtNiñoT.Text = "0";
                txtAdultoT.Text = "0";
                txtAdultoT.Text = "0";
                txtTotal.Text = "0";

            }
            else
            {
                int.Parse(txt3ra.Text);
                cont1++;
                txt3ra.Text = cont1.ToString();

                count1 = count1 + 35;
                int.Parse(txt3raT.Text);

                txt3raT.Text = count1.ToString();

                count4 = count4 + 35;
                int.Parse(txtTotal.Text);

                txtTotal.Text = count4.ToString();

                count5 = count5 + 1;
                int.Parse(txtTotalB.Text);

                txtTotalB.Text = count5.ToString();


            }
        }
        //Juan Gamez
        private void Button1_Click(object sender, EventArgs e)//Validaciones del contador de boletos
        {
            int.Parse(txt3ra.Text);
            cont1--;
            txt3ra.Text = cont1.ToString();
            if (cont1 >= 0) {
                count1 = count1 - 35;
                int.Parse(txt3raT.Text);
                txt3raT.Text = count1.ToString();
                count4 = count4 - 35;
                int.Parse(txtTotal.Text);
                txtTotal.Text = count4.ToString();
                count5 = count5 - 1;
                int.Parse(txtTotalB.Text);

                txtTotalB.Text = count5.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
                cont1 = 0;
                int.Parse(txt3ra.Text);

                txt3ra.Text = cont1.ToString();
            }
           
        }
        //Juan Gamez
        private void Button4_Click(object sender, EventArgs e) //Validacion para los 10 asientos
        {
            if (txtTotalB.Text == "10")
            {
                MessageBox.Show("No se pueden seleccionar mas de 10 boletos!! Gracias");
                txtTotalB.Text = "0";
                count1 = 0;
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                cont1 = 0;
                cont2 = 0;
                cont3 = 0;
                txt3ra.Text = "0";
                txtAdulto.Text = "0";
                txtNiño.Text = "0";
                txt3raT.Text = "0";
                txtNiñoT.Text = "0";
                txtAdultoT.Text = "0";
                txtAdultoT.Text = "0";
                txtTotal.Text = "0";

            }
            else
            {
                int.Parse(txtAdulto.Text);
                cont2++;
                txtAdulto.Text = cont2.ToString();
                count2 = count2 + 40;
                int.Parse(txtAdultoT.Text);
                txtAdultoT.Text = count2.ToString();
                count4 = count4 + 40;
                int.Parse(txtTotal.Text);
                txtTotal.Text = count4.ToString();
                count5 = count5 + 1;
                int.Parse(txtTotalB.Text);

                txtTotalB.Text = count5.ToString();
            }
        }
        //Juan Gamez
        private void Button3_Click(object sender, EventArgs e)
        {
             int.Parse(txtAdulto.Text);
            cont2--;
            txtAdulto.Text = cont2.ToString();
            if (cont2 >= 0)
            {
                count2 = count2 - 38;
                int.Parse(txtAdultoT.Text);
                txtAdultoT.Text = count2.ToString();
                count4 = count4 - 38;
                int.Parse(txtTotal.Text);
                txtTotal.Text = count4.ToString();
                count5 = count5 - 1;
                int.Parse(txtTotalB.Text);

                txtTotalB.Text = count5.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
                cont2 = 0;
                int.Parse(txtAdulto.Text);

                txtAdulto.Text = cont2.ToString();
            }

        }
        //Juan Gamez
        private void Button6_Click(object sender, EventArgs e)
        {
            if (txtTotalB.Text == "10")
            {
                MessageBox.Show("No se pueden seleccionar mas de 10 boletos!! Gracias");
                txtTotalB.Text = "0";
                count1 = 0;
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                cont1 = 0;
                cont2 = 0;
                cont3 = 0;
                txt3ra.Text = "0";
                txtAdulto.Text = "0";
                txtNiño.Text = "0";
                txt3raT.Text = "0";
                txtNiñoT.Text = "0";
                txtAdultoT.Text = "0";
                txtAdultoT.Text = "0";
                txtTotal.Text = "0";

            }
            else
            {
                int.Parse(txtNiño.Text);
                cont3++;
                txtNiño.Text = cont3.ToString();
                count3 = count3 + 30;
                int.Parse(txtNiñoT.Text);
                txtNiñoT.Text = count3.ToString();
                count4 = count4 + 30;
                int.Parse(txtTotal.Text);
                txtTotal.Text = count4.ToString();
                count5 = count5 + 1;
                int.Parse(txtTotalB.Text);

                txtTotalB.Text = count5.ToString();
            }
        }
        //Juan Gamez
        private void Button5_Click(object sender, EventArgs e)
        {
            int.Parse(txtNiño.Text);
            cont3--;
            txtNiño.Text = cont3.ToString();
            if (cont3 >= 0)
            {
                count3 = count3 - 30;
                int.Parse(txtNiñoT.Text);
                txtNiñoT.Text = count3.ToString();
                count4 = count4 - 30;
                int.Parse(txtTotal.Text);
                txtTotal.Text = count4.ToString();
                count5 = count5 - 1;
                int.Parse(txtTotalB.Text);

                txtTotalB.Text = count5.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
                cont3 = 0;
                int.Parse(txtNiño.Text);

                txtNiño.Text = cont3.ToString();
            }
           
        }

        //juan Gamez
        private void Btn_regresar_Click(object sender, EventArgs e) //Navegacion de Formularios
        {
            Form formulariocar = new Filtro(cineSeleccionado);
            formulariocar.Show();
            Visible = false;
        }

		private void Frm_boletos_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
        
                
        //Juan Gamez
        private void Timer1_Tick(object sender, EventArgs e)//Control del tiempo
        {
            if (tiempo > 0)
            {
                tiempo = tiempo - 1;
                lbTiempo.Text = tiempo.ToString();
            }
        }
        //juan Gamez
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, " Página web ayuda/ayuda.chm", "Menúboletos.html");//Abre el menu de ayuda HTML
        }
    }
}
