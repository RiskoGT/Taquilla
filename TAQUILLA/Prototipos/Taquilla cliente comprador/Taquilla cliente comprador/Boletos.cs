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
        public Frm_boletos()
        {
            InitializeComponent();
        }

        private void Txt_niño_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Siguente_Click(object sender, EventArgs e)
        {
            Form formularioasi = new Frm_asientos();
            formularioasi.Show();
            Visible = false;
        }
    }
}
