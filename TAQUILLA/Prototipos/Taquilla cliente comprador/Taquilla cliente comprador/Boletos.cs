using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Taquilla_cliente_comprador
{
   
    public partial class Frm_boletos : Form
    {
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
                asi.Txt_asientos.Text = Txt_totalB.Text;
                  

            
            asi.Show();
            Visible = false;


        }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
             int.Parse(Txt_3ra.Text);
            cont1++;
            Txt_3ra.Text = cont1.ToString();
                       
            count1 = count1 + 35;
            int.Parse(Txt_3raT.Text);
           
            Txt_3raT.Text = count1.ToString();
         
            count4 = count4 + 35;
            int.Parse(Txt_total.Text);

            Txt_total.Text = count4.ToString();

            count5 = count5 + 1;
            int.Parse(Txt_totalB.Text);

            Txt_totalB.Text = count5.ToString();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int.Parse(Txt_3ra.Text);
            cont1--;
            Txt_3ra.Text = cont1.ToString();
            if (cont1 >= 0) {
                count1 = count1 - 35;
                int.Parse(Txt_3raT.Text);
                Txt_3raT.Text = count1.ToString();
                count4 = count4 - 35;
                int.Parse(Txt_total.Text);
                Txt_total.Text = count4.ToString();
                count5 = count5 - 1;
                int.Parse(Txt_totalB.Text);

                Txt_totalB.Text = count5.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
                cont1 = 0;
                int.Parse(Txt_3ra.Text);

                Txt_3ra.Text = cont1.ToString();
            }
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
          int.Parse(Txt_adulto.Text);
            cont2++;
            Txt_adulto.Text = cont2.ToString();
            count2 = count2 + 38;
            int.Parse(Txt_adultoT.Text);
            Txt_adultoT.Text = count2.ToString();
            count4 = count4 + 38;
            int.Parse(Txt_total.Text);
            Txt_total.Text = count4.ToString();
            count5 = count5 + 1;
            int.Parse(Txt_totalB.Text);

            Txt_totalB.Text = count5.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
             int.Parse(Txt_adulto.Text);
            cont2--;
            Txt_adulto.Text = cont2.ToString();
            if (cont2 >= 0)
            {
                count2 = count2 - 38;
                int.Parse(Txt_adultoT.Text);
                Txt_adultoT.Text = count2.ToString();
                count4 = count4 - 38;
                int.Parse(Txt_total.Text);
                Txt_total.Text = count4.ToString();
                count5 = count5 - 1;
                int.Parse(Txt_totalB.Text);

                Txt_totalB.Text = count5.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
                cont2 = 0;
                int.Parse(Txt_adulto.Text);

                Txt_adulto.Text = cont2.ToString();
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
             int.Parse(Txt_niño.Text);
            cont3++;
            Txt_niño.Text = cont3.ToString();
            count3 = count3 + 30;
            int.Parse(Txt_niñoT.Text);
            Txt_niñoT.Text = count3.ToString();
            count4 = count4 + 30;
            int.Parse(Txt_total.Text);
            Txt_total.Text = count4.ToString();
            count5 = count5 + 1;
            int.Parse(Txt_totalB.Text);

            Txt_totalB.Text = count5.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int.Parse(Txt_niño.Text);
            cont3--;
            Txt_niño.Text = cont3.ToString();
            if (cont3 >= 0)
            {
                count3 = count3 - 30;
                int.Parse(Txt_niñoT.Text);
                Txt_niñoT.Text = count3.ToString();
                count4 = count4 - 30;
                int.Parse(Txt_total.Text);
                Txt_total.Text = count4.ToString();
                count5 = count5 - 1;
                int.Parse(Txt_totalB.Text);

                Txt_totalB.Text = count5.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
                cont3 = 0;
                int.Parse(Txt_niño.Text);

                Txt_niño.Text = cont3.ToString();
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
            Form formularioayu = new Frm_ayudabol();
            formularioayu.Show();
          
        }
    }
}
