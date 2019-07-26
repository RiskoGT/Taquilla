using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Taquilla_cliente_comprador
{
   
    public partial class Frm_boletos : Form   
    {
        /*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        int cont1 = 0; int cont2 = 0; int cont3 = 0;
        int count1=0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        public Frm_boletos()
        {
            InitializeComponent();
        }

        private void Txt_niño_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Siguente_Click(object sender, EventArgs e)
        {

            if (count4 == 0)
            { MessageBox.Show("Por favor, seleccione al menos 1 boleto para continuar, Gracias!!"); }
            else {

                Frm_asientos asi = new Frm_asientos();
                asi.Txt_asientos.Text = txtTotalB.Text;
                  

            
            asi.Show();
            Visible = false;


        }
        }

        private void Button2_Click(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
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

        private void Button4_Click(object sender, EventArgs e)
        {
          int.Parse(txtAdulto.Text);
            cont2++;
            txtAdulto.Text = cont2.ToString();
            count2 = count2 + 38;
            int.Parse(txtAdultoT.Text);
            txtAdultoT.Text = count2.ToString();
            count4 = count4 + 38;
            int.Parse(txtTotal.Text);
            txtTotal.Text = count4.ToString();
            count5 = count5 + 1;
            int.Parse(txtTotalB.Text);

            txtTotalB.Text = count5.ToString();
        }

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

        private void Button6_Click(object sender, EventArgs e)
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

        private void Txt_total_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Txt_3raT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            Form formulariocar = new Frm_cartelera();
            formulariocar.Show();
            Visible = false;
        }

		private void Frm_boletos_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Btn_canTBoletos_Click(object sender, EventArgs e)
		{

		}

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {

		}

        private void Frm_boletos_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TlpPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
