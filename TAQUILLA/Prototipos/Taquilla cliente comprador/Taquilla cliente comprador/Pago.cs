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
    public partial class Frm_pago : Form
    {
        /*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        
        public Frm_pago()
        {
            InitializeComponent();
            Combomes.Items.Add("1");
            Combomes.Items.Add("2");
            Combomes.Items.Add("3");
            Combomes.Items.Add("4");
            Combomes.Items.Add("5");
            Combomes.Items.Add("6");
            Combomes.Items.Add("7");
            Combomes.Items.Add("8");
            Combomes.Items.Add("9");
            Combomes.Items.Add("10");
            Combomes.Items.Add("11");
            Combomes.Items.Add("12");
            ComboAño.Items.Add("19");
            ComboAño.Items.Add("20");
            ComboAño.Items.Add("21");
            ComboAño.Items.Add("22");
            ComboAño.Items.Add("23");
            ComboAño.Items.Add("24");
            ComboAño.Items.Add("25");

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form formulariopago = new Frm_menu();
            formulariopago.Show();
            Visible = false;
            Form formulariopago1 = new Frm_Confirmasion();
            formulariopago1.Show();
            
          
        }

		private void Frm_pago_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
           

			Process.Start("Manual.pdf");

		}

        private void Frm_pago_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
      

        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
           
            Form formulariocal = new Frm_menu();
            MessageBox.Show("Su compra a sido cancelada, Gracias!!");
            formulariocal.Show();
            Visible = false;
         
        }

        private void Combomes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
