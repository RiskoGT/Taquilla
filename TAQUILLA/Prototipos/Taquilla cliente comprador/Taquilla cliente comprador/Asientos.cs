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
            Form formulariopag = new Frm_pago();
            formulariopag.Show();
            Visible = false;
        }
    }
}
