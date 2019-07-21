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
    public partial class Frm_asientos : Form
    {
        int contador = 0;
        
        public Frm_asientos()
        {
            InitializeComponent();
        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {

        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
           int prueba= int.Parse(Txt_asientos.Text);
            
            


            if (contador > 0&& contador==prueba)
            {
                Form formulariopag = new Frm_pago();
                formulariopag.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Asientos no seleccionados");
                contador = 0;
                
            }

           
        }

        private void Btn_A1_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            Btn_A1.BackColor = Color.LawnGreen;
        }

        private void Btn_A2_Click(object sender, EventArgs e)
        {
            Btn_A2.BackColor = Color.LawnGreen;
            contador = contador + 1;
        }

        private void Txt_asientos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_asientos_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form formulariopag = new Frm_boletos();
            formulariopag.Show();
            Visible = false;
        }
    }
}
