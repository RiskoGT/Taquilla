using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla_cliente_comprador
{
    public partial class frmAsientos : Form
    {
        /*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        int contador = 0;
        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 = 0;
        int b1, b2, b3, b4, b5, b6, b7, b8, b9, b10 = 0;
        int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 = 0;
        int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 = 0;
        int tiempo=0;
		int nofuncion=0;
		string[] Asientos = new string[90];
		OdbcConnection conn = new OdbcConnection("Dsn=cine");
		public frmAsientos(int dato, int funcion)
		{
			InitializeComponent();
			tiempo = dato;
			nofuncion = funcion;
			estadoAsientos();
		}

		void estadoAsientos()
		{
			
				conn.Open();
				OdbcCommand command = new OdbcCommand(""
				+ "SELECT  estado FROM asientos WHERE idFuncion= " + nofuncion + "", conn);
				OdbcDataReader funciones = command.ExecuteReader();

				int pos = 0;
				while (funciones.Read())
				{
				switch (pos)
				{
					case 0:
						if (funciones.GetValue(0).ToString() == "0") { btnA1.BackColor = Color.White; } else { btnA1.BackColor = Color.Red; btnA1.Enabled = false; }
						break;
					case 1:
						if (funciones.GetValue(0).ToString() == "0") { btnA10.BackColor = Color.White; } else { btnA10.BackColor = Color.Red; btnA10.Enabled = false; }
						break;
					case 2:
						if (funciones.GetValue(0).ToString() == "0") { btnA2.BackColor = Color.White; } else { btnA2.BackColor = Color.Red; btnA2.Enabled = false; }
						break;
					case 3:
						if (funciones.GetValue(0).ToString() == "0") { btnA3.BackColor = Color.White; } else { btnA3.BackColor = Color.Red; btnA3.Enabled = false; }
						break;
					case 4:
						if (funciones.GetValue(0).ToString() == "0") { btnA4.BackColor = Color.White; } else { btnA4.BackColor = Color.Red; btnA4.Enabled = false; }
						break;
					case 5:
						if (funciones.GetValue(0).ToString() == "0") { btnA5.BackColor = Color.White; } else { btnA5.BackColor = Color.Red; btnA5.Enabled = false; }
						break;
					case 6:
						if (funciones.GetValue(0).ToString() == "0") { btnA6.BackColor = Color.White; } else { btnA6.BackColor = Color.Red; btnA6.Enabled = false; }
						break;
					case 7:
						if (funciones.GetValue(0).ToString() == "0") { btnA7.BackColor = Color.White; } else { btnA7.BackColor = Color.Red; btnA7.Enabled = false; }
						break;
					case 8:
						if (funciones.GetValue(0).ToString() == "0") { btnA8.BackColor = Color.White; } else { btnA8.BackColor = Color.Red; btnA8.Enabled = false; }
						break;
					case 9:
						if (funciones.GetValue(0).ToString() == "0") { btnA9.BackColor = Color.White; } else { btnA9.BackColor = Color.Red; btnA9.Enabled = false; }
						break;
					case 10:
						if (funciones.GetValue(0).ToString() == "0") { btnB1.BackColor = Color.White; } else { btnB1.BackColor = Color.Red; btnB1.Enabled = false; }
						break;
					case 11:
						if (funciones.GetValue(0).ToString() == "0") { btnB10.BackColor = Color.White; } else { btnB10.BackColor = Color.Red; btnB10.Enabled = false; }
						break;
					case 12:
						if (funciones.GetValue(0).ToString() == "0") { btnB2.BackColor = Color.White; } else { btnB2.BackColor = Color.Red; btnB2.Enabled = false; }
						break;
					case 13:
						if (funciones.GetValue(0).ToString() == "0") { btnB3.BackColor = Color.White; } else { btnB3.BackColor = Color.Red; btnB3.Enabled = false; }
						break;
					case 14:
						if (funciones.GetValue(0).ToString() == "0") { btnB4.BackColor = Color.White; } else { btnB4.BackColor = Color.Red; btnB4.Enabled = false; }
						break;
					case 15:
						if (funciones.GetValue(0).ToString() == "0") { btnB5.BackColor = Color.White; } else { btnB5.BackColor = Color.Red; btnB5.Enabled = false; }
						break;
					case 16:
						if (funciones.GetValue(0).ToString() == "0") { btnB6.BackColor = Color.White; } else { btnB6.BackColor = Color.Red; btnB6.Enabled = false; }
						break;
					case 17:
						if (funciones.GetValue(0).ToString() == "0") { btnB7.BackColor = Color.White; } else { btnB7.BackColor = Color.Red; btnB7.Enabled = false; }
						break;
					case 18:
						if (funciones.GetValue(0).ToString() == "0") { btnB8.BackColor = Color.White; } else { btnB8.BackColor = Color.Red; btnB8.Enabled = false; }
						break;
					case 19:
						if (funciones.GetValue(0).ToString() == "0") { btnB9.BackColor = Color.White; } else { btnB9.BackColor = Color.Red; btnB9.Enabled = false; }
						break;
					case 20:
						if (funciones.GetValue(0).ToString() == "0") { btnC1.BackColor = Color.White; } else { btnC1.BackColor = Color.Red; btnC1.Enabled = false; }
						break;
					case 21:
						if (funciones.GetValue(0).ToString() == "0") { btnC10.BackColor = Color.White; } else { btnC10.BackColor = Color.Red; btnC10.Enabled = false; }
						break;
					case 22:
						if (funciones.GetValue(0).ToString() == "0") { btnC2.BackColor = Color.White; } else { btnC2.BackColor = Color.Red; btnC2.Enabled = false; }
						break;
					case 23:
						if (funciones.GetValue(0).ToString() == "0") { btnC3.BackColor = Color.White; } else { btnC3.BackColor = Color.Red; btnC3.Enabled = false; }
						break;
					case 24:
						if (funciones.GetValue(0).ToString() == "0") { btnC4.BackColor = Color.White; } else { btnC4.BackColor = Color.Red; btnC4.Enabled = false; }
						break;
					case 25:
						if (funciones.GetValue(0).ToString() == "0") { btnC5.BackColor = Color.White; } else { btnC5.BackColor = Color.Red; btnC5.Enabled = false; }
						break;
					case 26:
						if (funciones.GetValue(0).ToString() == "0") { btnC6.BackColor = Color.White; } else { btnC6.BackColor = Color.Red; btnC6.Enabled = false; }
						break;
					case 27:
						if (funciones.GetValue(0).ToString() == "0") { btnC7.BackColor = Color.White; } else { btnC7.BackColor = Color.Red; btnC7.Enabled = false; }
						break;
					case 28:
						if (funciones.GetValue(0).ToString() == "0") { btnC8.BackColor = Color.White; } else { btnC8.BackColor = Color.Red; btnC8.Enabled = false; }
						break;
					case 29:
						if (funciones.GetValue(0).ToString() == "0") { btnC9.BackColor = Color.White; } else { btnC9.BackColor = Color.Red; btnC9.Enabled = false; }
						break;
					case 30:
						if (funciones.GetValue(0).ToString() == "0") { btnD1.BackColor = Color.White; } else { btnD1.BackColor = Color.Red; btnD1.Enabled = false; }
						break;
					case 31:
						if (funciones.GetValue(0).ToString() == "0") { btnD10.BackColor = Color.White; } else { btnD10.BackColor = Color.Red; btnD10.Enabled = false; }
						break;
					case 32:
						if (funciones.GetValue(0).ToString() == "0") { btnD2.BackColor = Color.White; } else { btnD2.BackColor = Color.Red; btnD2.Enabled = false; }
						break;
					case 33:
						if (funciones.GetValue(0).ToString() == "0") { btnD3.BackColor = Color.White; } else { btnD3.BackColor = Color.Red; btnD3.Enabled = false; }
						break;
					case 34:
						if (funciones.GetValue(0).ToString() == "0") { btnD4.BackColor = Color.White; } else { btnD4.BackColor = Color.Red; btnD4.Enabled = false; }
						break;
					case 35:
						if (funciones.GetValue(0).ToString() == "0") { btnD5.BackColor = Color.White; } else { btnD5.BackColor = Color.Red; btnD5.Enabled = false; }
						break;
					case 36:
						if (funciones.GetValue(0).ToString() == "0") { btnD6.BackColor = Color.White; } else { btnD6.BackColor = Color.Red; btnD6.Enabled = false; }
						break;
					case 37:
						if (funciones.GetValue(0).ToString() == "0") { btnD7.BackColor = Color.White; } else { btnD7.BackColor = Color.Red; btnD7.Enabled = false; }
						break;
					case 38:
						if (funciones.GetValue(0).ToString() == "0") { btnD8.BackColor = Color.White; } else { btnD8.BackColor = Color.Red; btnD8.Enabled = false; }
						break;
					case 39:
						if (funciones.GetValue(0).ToString() == "0") { btnD9.BackColor = Color.White; } else { btnD9.BackColor = Color.Red; btnD9.Enabled = false; }
						break;
					case 40:
						if (funciones.GetValue(0).ToString() == "0") { btnE1.BackColor = Color.White; } else { btnE1.BackColor = Color.Red; btnE1.Enabled = false; }
						break;
					case 41:
						if (funciones.GetValue(0).ToString() == "0") { btnE10.BackColor = Color.White; } else { btnE10.BackColor = Color.Red; btnE10.Enabled = false; }
						break;
					case 42:
						if (funciones.GetValue(0).ToString() == "0") { btnE2.BackColor = Color.White; } else { btnE2.BackColor = Color.Red; btnE2.Enabled = false; }
						break;
					case 43:
						if (funciones.GetValue(0).ToString() == "0") { btnE3.BackColor = Color.White; } else { btnE3.BackColor = Color.Red; btnE3.Enabled = false; }
						break;
					case 44:
						if (funciones.GetValue(0).ToString() == "0") { btnE4.BackColor = Color.White; } else { btnE4.BackColor = Color.Red; btnE4.Enabled = false; }
						break;
					case 45:
						if (funciones.GetValue(0).ToString() == "0") { btnE5.BackColor = Color.White; } else { btnE5.BackColor = Color.Red; btnE5.Enabled = false; }
						break;
					case 46:
						if (funciones.GetValue(0).ToString() == "0") { btnE6.BackColor = Color.White; } else { btnE6.BackColor = Color.Red; btnE6.Enabled = false; }
						break;
					case 47:
						if (funciones.GetValue(0).ToString() == "0") { btnE7.BackColor = Color.White; } else { btnE7.BackColor = Color.Red; btnE7.Enabled = false; }
						break;
					case 48:
						if (funciones.GetValue(0).ToString() == "0") { btnE8.BackColor = Color.White; } else { btnE8.BackColor = Color.Red; btnE8.Enabled = false; }
						break;
					case 49:
						if (funciones.GetValue(0).ToString() == "0") { btnE9.BackColor = Color.White; } else { btnE9.BackColor = Color.Red; btnE9.Enabled = false; }
						break;
					case 50:
						if (funciones.GetValue(0).ToString() == "0") { btnF1.BackColor = Color.White; } else { btnF1.BackColor = Color.Red; btnF1.Enabled = false; }
						break;
					case 51:
						if (funciones.GetValue(0).ToString() == "0") { btnF10.BackColor = Color.White; } else { btnF10.BackColor = Color.Red; btnF10.Enabled = false; }
						break;
					case 52:
						if (funciones.GetValue(0).ToString() == "0") { btnF2.BackColor = Color.White; } else { btnF2.BackColor = Color.Red; btnF2.Enabled = false; }
						break;
					case 53:
						if (funciones.GetValue(0).ToString() == "0") { btnF3.BackColor = Color.White; } else { btnF3.BackColor = Color.Red; btnF3.Enabled = false; }
						break;
					case 54:
						if (funciones.GetValue(0).ToString() == "0") { btnF4.BackColor = Color.White; } else { btnF4.BackColor = Color.Red; btnF4.Enabled = false; }
						break;
					case 55:
						if (funciones.GetValue(0).ToString() == "0") { btnF5.BackColor = Color.White; } else { btnF5.BackColor = Color.Red; btnF5.Enabled = false; }
						break;
					case 56:
						if (funciones.GetValue(0).ToString() == "0") { btnF6.BackColor = Color.White; } else { btnF6.BackColor = Color.Red; btnF6.Enabled = false; }
						break;
					case 57:
						if (funciones.GetValue(0).ToString() == "0") { btnF7.BackColor = Color.White; } else { btnF7.BackColor = Color.Red; btnF7.Enabled = false; }
						break;
					case 58:
						if (funciones.GetValue(0).ToString() == "0") { btnF8.BackColor = Color.White; } else { btnF8.BackColor = Color.Red; btnF8.Enabled = false; }
						break;
					case 59:
						if (funciones.GetValue(0).ToString() == "0") { btnF9.BackColor = Color.White; } else { btnF9.BackColor = Color.Red; btnF9.Enabled = false; }
						break;
					case 60:
						if (funciones.GetValue(0).ToString() == "0") { btnG1.BackColor = Color.White; } else { btnG1.BackColor = Color.Red; btnG1.Enabled = false; }
						break;
					case 61:
						if (funciones.GetValue(0).ToString() == "0") { btnG10.BackColor = Color.White; } else { btnG10.BackColor = Color.Red; btnG10.Enabled = false; }
						break;
					case 62:
						if (funciones.GetValue(0).ToString() == "0") { btnG2.BackColor = Color.White; } else { btnG2.BackColor = Color.Red; btnG2.Enabled = false; }
						break;
					case 63:
						if (funciones.GetValue(0).ToString() == "0") { btnG3.BackColor = Color.White; } else { btnG3.BackColor = Color.Red; btnG3.Enabled = false; }
						break;
					case 64:
						if (funciones.GetValue(0).ToString() == "0") { btnG4.BackColor = Color.White; } else { btnG4.BackColor = Color.Red; btnG4.Enabled = false; }
						break;
					case 65:
						if (funciones.GetValue(0).ToString() == "0") { btnG5.BackColor = Color.White; } else { btnG5.BackColor = Color.Red; btnG5.Enabled = false; }
						break;
					case 66:
						if (funciones.GetValue(0).ToString() == "0") { btnG6.BackColor = Color.White; } else { btnG6.BackColor = Color.Red; btnG6.Enabled = false; }
						break;
					case 67:
						if (funciones.GetValue(0).ToString() == "0") { btnG7.BackColor = Color.White; } else { btnG7.BackColor = Color.Red; btnG7.Enabled = false; }
						break;
					case 68:
						if (funciones.GetValue(0).ToString() == "0") { btnG8.BackColor = Color.White; } else { btnG8.BackColor = Color.Red; btnG8.Enabled = false; }
						break;
					case 69:
						if (funciones.GetValue(0).ToString() == "0") { btnG9.BackColor = Color.White; } else { btnG9.BackColor = Color.Red; btnG9.Enabled = false; }
						break;
					case 70:
						if (funciones.GetValue(0).ToString() == "0") { btnH1.BackColor = Color.White; } else { btnH1.BackColor = Color.Red; btnH1.Enabled = false; }
						break;
					case 71:
						if (funciones.GetValue(0).ToString() == "0") { btnH10.BackColor = Color.White; } else { btnH10.BackColor = Color.Red; btnH10.Enabled = false; }
						break;
					case 72:
						if (funciones.GetValue(0).ToString() == "0") { btnH2.BackColor = Color.White; } else { btnH2.BackColor = Color.Red; btnH2.Enabled = false; }
						break;
					case 73:
						if (funciones.GetValue(0).ToString() == "0") { btnH3.BackColor = Color.White; } else { btnH3.BackColor = Color.Red; btnH3.Enabled = false; }
						break;
					case 74:
						if (funciones.GetValue(0).ToString() == "0") { btnH4.BackColor = Color.White; } else { btnH4.BackColor = Color.Red; btnH4.Enabled = false; }
						break;
					case 75:
						if (funciones.GetValue(0).ToString() == "0") { btnH5.BackColor = Color.White; } else { btnH5.BackColor = Color.Red; btnH5.Enabled = false; }
						break;
					case 76:
						if (funciones.GetValue(0).ToString() == "0") { btnH6.BackColor = Color.White; } else { btnH6.BackColor = Color.Red; btnH6.Enabled = false; }
						break;
					case 77:
						if (funciones.GetValue(0).ToString() == "0") { btnH7.BackColor = Color.White; } else { btnH7.BackColor = Color.Red; btnH7.Enabled = false; }
						break;
					case 78:
						if (funciones.GetValue(0).ToString() == "0") { btnH8.BackColor = Color.White; } else { btnH8.BackColor = Color.Red; btnH8.Enabled = false; }
						break;
					case 79:
						if (funciones.GetValue(0).ToString() == "0") { btnH9.BackColor = Color.White; } else { btnH9.BackColor = Color.Red; btnH9.Enabled = false; }
						break;
					case 80:
						if (funciones.GetValue(0).ToString() == "0") { btnI1.BackColor = Color.White; } else { btnI1.BackColor = Color.Red; btnI1.Enabled = false; }
						break;
					case 81:
						if (funciones.GetValue(0).ToString() == "0") { btnI10.BackColor = Color.White; } else { btnI10.BackColor = Color.Red; btnI10.Enabled = false; }
						break;
					case 82:
						if (funciones.GetValue(0).ToString() == "0") { btnI2.BackColor = Color.White; } else { btnI2.BackColor = Color.Red; btnI2.Enabled = false; }
						break;
					case 83:
						if (funciones.GetValue(0).ToString() == "0") { btnI3.BackColor = Color.White; } else { btnI3.BackColor = Color.Red; btnI3.Enabled = false; }
						break;
					case 84:
						if (funciones.GetValue(0).ToString() == "0") { btnI4.BackColor = Color.White; } else { btnI4.BackColor = Color.Red; btnI4.Enabled = false; }
						break;
					case 85:
						if (funciones.GetValue(0).ToString() == "0") { btnI5.BackColor = Color.White; } else { btnI5.BackColor = Color.Red; btnI5.Enabled = false; }
						break;
					case 86:
						if (funciones.GetValue(0).ToString() == "0") { btnI6.BackColor = Color.White; } else { btnI6.BackColor = Color.Red; btnI6.Enabled = false; }
						break;
					case 87:
						if (funciones.GetValue(0).ToString() == "0") { btnI7.BackColor = Color.White; } else { btnI7.BackColor = Color.Red; btnI7.Enabled = false; }
						break;
					case 88:
						if (funciones.GetValue(0).ToString() == "0") { btnI8.BackColor = Color.White; } else { btnI8.BackColor = Color.Red; btnI8.Enabled = false; }
						break;
					case 89:
						if (funciones.GetValue(0).ToString() == "0") { btnI9.BackColor = Color.White; } else { btnI9.BackColor = Color.Red; btnI9.Enabled = false; }
						break;
				}
					pos++;
				}
				conn.Close();

			}
		private void Btn_B7_Click(object sender, EventArgs e)
        {
            if (b7 == 0)
            {
                contador = contador + 1;
                btnB7.BackColor = Color.LawnGreen; ;
                b7 = b7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB7.BackColor = Color.White; ;
                b7 = 0;
            }
        }

        private void Btn_C8_Click(object sender, EventArgs e)
        {
            if (c8 == 0)
            {
                contador = contador + 1;
                btnC8.BackColor = Color.LawnGreen; ;
                c8 = c8+ 1;
            }
            else
            {
                contador = contador - 1;
                btnC8.BackColor = Color.White;
                c8 = 0;
            }
        }

        private void Btn_C9_Click(object sender, EventArgs e)
        {
            if (c9 == 0)
            {
                contador = contador + 1;
                btnC9.BackColor = Color.LawnGreen; ;
                c9 = c9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC9.BackColor = Color.White; ;
                c9 = 0;
            }
        }

        private void Btn_C10_Click(object sender, EventArgs e)
        {
            if (c10 == 0)
            {
                contador = contador + 1;
                btnC10.BackColor = Color.LawnGreen; ;
                c10 = c10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC10.BackColor = Color.White; ;
                c10 = 0;
            }
        }

        private void Btn_D1_Click(object sender, EventArgs e)
        {
            if (d1 == 0)
            {
                contador = contador + 1;
                btnD1.BackColor = Color.LawnGreen; ;
                d1 = d1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD1.BackColor = Color.White; ;
                d1 = 0;
            }
        }

        private void Btn_E1_Click(object sender, EventArgs e)
        {
            if (e1 == 0)
            {
                contador = contador + 1;
                btnE1.BackColor = Color.LawnGreen; ;
                e1 = e1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE1.BackColor = Color.White; ;
                e1 = 0;
            }
        }

        private void Btn_F1_Click(object sender, EventArgs e)
        {
            if (f1 == 0)
            {
                contador = contador + 1;
                btnF1.BackColor = Color.LawnGreen; ;
                f1 = f1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF1.BackColor = Color.White; ;
                f1 = 0;
            }
        }

        private void Btn_G1_Click(object sender, EventArgs e)
        {
            if (g1 == 0)
            {
                contador = contador + 1;
                btnG1.BackColor = Color.LawnGreen; ;
                g1 = g1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG1.BackColor = Color.White; ;
                g1 = 0;
            }
        }

        private void Btn_H1_Click(object sender, EventArgs e)
        {

            if (h1 == 0)
            {
                contador = contador + 1;
                btnH1.BackColor = Color.LawnGreen; ;
                h1 = h1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH1.BackColor = Color.White; ;
                h1 = 0;
            }
        }

        private void Btn_I1_Click(object sender, EventArgs e)
        {
            if (i1 == 0)
            {
                contador = contador + 1;
                btnI1.BackColor = Color.LawnGreen; ;
                i1 = i1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI1.BackColor = Color.White; ;
                i1 = 0;
            }
        }

        private void Btn_D2_Click(object sender, EventArgs e)
        {
            if (d2 == 0)
            {
                contador = contador + 1;
                btnD2.BackColor = Color.LawnGreen; ;
                d2 = d2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD2.BackColor = Color.White; ;
                d2 = 0;
            }
        }

        private void Btn_D3_Click(object sender, EventArgs e)
        {
            if (d3 == 0)
            {
                contador = contador + 1;
                btnD3.BackColor = Color.LawnGreen; ;
                d3 = d3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD3.BackColor = Color.White; ;
                d3 = 0;
            }
        }

        private void Btn_D5_Click(object sender, EventArgs e)
        {
            if (d5 == 0)
            {
                contador = contador + 1;
                btnD5.BackColor = Color.LawnGreen; ;
                d5 = d5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD5.BackColor = Color.White; ;
                d5 = 0;
            }
        }

        private void Btn_D6_Click(object sender, EventArgs e)
        {
            if (d6 == 0)
            {
                contador = contador + 1;
                btnD6.BackColor = Color.LawnGreen; ;
                d6 = d6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD6.BackColor = Color.White; ;
                d6 = 0;
            }
        }

        private void Btn_D7_Click(object sender, EventArgs e)
        {
            if (d7 == 0)
            {
                contador = contador + 1;
                btnD7.BackColor = Color.LawnGreen; ;
                d7 = d7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD7.BackColor = Color.White; ;
                d7 = 0;
            }
        }

        private void Btn_D8_Click(object sender, EventArgs e)
        {
            if (d8 == 0)
            {
                contador = contador + 1;
                btnD8.BackColor = Color.LawnGreen; ;
                d8 = d8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD8.BackColor = Color.White; ;
                d8= 0;
            }
        }

        private void Btn_D9_Click(object sender, EventArgs e)
        {
            if (d9 == 0)
            {
                contador = contador + 1;
                btnD9.BackColor = Color.LawnGreen; ;
                d9 = d9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD9.BackColor = Color.White; ;
                d9 = 0;
            }
        }

        private void Btn_D10_Click(object sender, EventArgs e)
        {
            if (d10 == 0)
            {
                contador = contador + 1;
                btnD10.BackColor = Color.LawnGreen; ;
                d10 = d10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD10.BackColor = Color.White; ;
                d10 = 0;
            }
        }

        private void Btn_D4_Click(object sender, EventArgs e)
        {
            if (d4 == 0)
            {
                contador = contador + 1;
                btnD4.BackColor = Color.LawnGreen; ;
                d4 = d4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnD4.BackColor = Color.White; ;
                d4 = 0;
            }
        }

        private void Btn_E5_Click(object sender, EventArgs e)
        {
            if (e5 == 0)
            {
                contador = contador + 1;
                btnE5.BackColor = Color.LawnGreen; ;
                e5 = e5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE5.BackColor = Color.White; ;
                e5 = 0;
            }
        }

        private void Btn_E2_Click(object sender, EventArgs e)
        {
            if (e2 == 0)
            {
                contador = contador + 1;
                btnE2.BackColor = Color.LawnGreen; ;
                e2 = e2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE2.BackColor = Color.White; ;
                e2 = 0;
            }
        }

        private void Btn_E3_Click(object sender, EventArgs e)
        {
            if (e3 == 0)
            {
                contador = contador + 1;
                btnE3.BackColor = Color.LawnGreen; ;
                e3 = e3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE3.BackColor = Color.White; ;
                e3 = 0;
            }
        }

        private void Btn_E4_Click(object sender, EventArgs e)
        {
            if (e4 == 0)
            {
                contador = contador + 1;
                btnE4.BackColor = Color.LawnGreen; ;
                e4 = e4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE4.BackColor = Color.White; ;
                e4 = 0;
            }
        }

        private void Btn_E6_Click(object sender, EventArgs e)
        {
            if (e6 == 0)
            {
                contador = contador + 1;
                btnE6.BackColor = Color.LawnGreen; ;
                e6 = e6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE6.BackColor = Color.White; ;
                e6 = 0;
            }
        }

        private void Btn_E7_Click(object sender, EventArgs e)
        {
            if (e7 == 0)
            {
                contador = contador + 1;
                btnE7.BackColor = Color.LawnGreen; ;
                e7 = e7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE7.BackColor = Color.White; ;
                e7 = 0;
            }
        }

        private void Btn_E8_Click(object sender, EventArgs e)
        {
            if (e8 == 0)
            {
                contador = contador + 1;
                btnE8.BackColor = Color.LawnGreen; ;
                e8 = e8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE8.BackColor = Color.White; ;
                e8 = 0;
            }
        }

        private void Btn_E9_Click(object sender, EventArgs e)
        {
            if (e9 == 0)
            {
                contador = contador + 1;
                btnE9.BackColor = Color.LawnGreen; ;
                e9 = e9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE9.BackColor = Color.White; ;
                e9 = 0;
            }
        }

        private void Btn_E10_Click(object sender, EventArgs e)
        {
            if (e10 == 0)
            {
                contador = contador + 1;
                btnE10.BackColor = Color.LawnGreen; ;
                e10 = e10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnE10.BackColor = Color.White; ;
                e10 = 0;
            }
        }

        private void Btn_F2_Click(object sender, EventArgs e)
        {
            if (f2 == 0)
            {
                contador = contador + 1;
                btnF2.BackColor = Color.LawnGreen; ;
                f2 = f2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF2.BackColor = Color.White; ;
                f2= 0;
            }
        }

        private void Btn_F3_Click(object sender, EventArgs e)
        {
            if (f3 == 0)
            {
                contador = contador + 1;
                btnF3.BackColor = Color.LawnGreen; ;
                f3 = f3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF3.BackColor = Color.White; ;
                f3 = 0;
            }
        }

        private void Btn_F4_Click(object sender, EventArgs e)
        {
            if (f4 == 0)
            {
                contador = contador + 1;
                btnF4.BackColor = Color.LawnGreen; ;
                f4 = f4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF4.BackColor = Color.White; ;
                f4 = 0;
            }
        }

        private void Btn_F5_Click(object sender, EventArgs e)
        {
            if (f5 == 0)
            {
                contador = contador + 1;
                btnF5.BackColor = Color.LawnGreen; ;
                f5 = f5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF5.BackColor = Color.White; ;
                f5 = 0;
            }
        }

        private void Button57_Click(object sender, EventArgs e)
        {
            if (f6 == 0)
            {
                contador = contador + 1;
                btnF6.BackColor = Color.LawnGreen; ;
                f6 = f6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF6.BackColor = Color.White; ;
                f6 = 0;
            }
        }

        private void Btn_F7_Click(object sender, EventArgs e)
        {
            if (f7 == 0)
            {
                contador = contador + 1;
                btnF7.BackColor = Color.LawnGreen; ;
                f7 = f7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF7.BackColor = Color.White; ;
                f7 = 0;
            }
        }

        private void Btn_F8_Click(object sender, EventArgs e)
        {
            if (f8 == 0)
            {
                contador = contador + 1;
                btnF8.BackColor = Color.LawnGreen; ;
                f8 = f8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF8.BackColor = Color.White; ;
                f8 = 0;
            }
        }

        private void Btn_F9_Click(object sender, EventArgs e)
        {
            if (f9 == 0)
            {
                contador = contador + 1;
                btnF9.BackColor = Color.LawnGreen; ;
                f9 = f9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF9.BackColor = Color.White; ;
                f9 = 0;
            }
        }

        private void Btn_F10_Click(object sender, EventArgs e)
        {
            if (f10 == 0)
            {
                contador = contador + 1;
                btnF10.BackColor = Color.LawnGreen; ;
                f10 = f10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnF10.BackColor = Color.White; ;
                f10 = 0;
            }
        }

        private void Btn_G2_Click(object sender, EventArgs e)
        {
            if (g2 == 0)
            {
                contador = contador + 1;
                btnG2.BackColor = Color.LawnGreen; ;
                g2 = g2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG2.BackColor = Color.White; ;
                g2 = 0;
            }
        }

        private void Btn_G3_Click(object sender, EventArgs e)
        {
            if (g3 == 0)
            {
                contador = contador + 1;
                btnG3.BackColor = Color.LawnGreen; ;
                g3 = g3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG3.BackColor = Color.White; ;
                g3 = 0;
            }
        }

        private void Btn_G4_Click(object sender, EventArgs e)
        {
            if (g4 == 0)
            {
                contador = contador + 1;
                btnG4.BackColor = Color.LawnGreen; ;
                g4 = g4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG4.BackColor = Color.White; ;
                g4 = 0;
            }
        }

        private void Btn_G5_Click(object sender, EventArgs e)
        {
            if (g5 == 0)
            {
                contador = contador + 1;
                btnG5.BackColor = Color.LawnGreen; ;
                g5 = g5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG5.BackColor = Color.White; ;
                g5 = 0;
            }
        }

        private void Btn_G6_Click(object sender, EventArgs e)
        {
            if (g6 == 0)
            {
                contador = contador + 1;
                btnG6.BackColor = Color.LawnGreen; ;
                g6 = g6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG6.BackColor = Color.White; ;
                g6 = 0;
            }
        }

        private void Btn_G7_Click(object sender, EventArgs e)
        {
            if (g7 == 0)
            {
                contador = contador + 1;
                btnG7.BackColor = Color.LawnGreen; ;
                g7 = g7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG7.BackColor = Color.White; ;
                g7 = 0;
            }
        }

        private void Btn_G8_Click(object sender, EventArgs e)
        {
            if (g8 == 0)
            {
                contador = contador + 1;
                btnG8.BackColor = Color.LawnGreen; ;
                g8 = g8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG8.BackColor = Color.White; ;
                g8= 0;
            }
        }

        private void Btn_G9_Click(object sender, EventArgs e)
        {
            if (g9 == 0)
            {
                contador = contador + 1;
                btnG9.BackColor = Color.LawnGreen; ;
                g9 = g9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG9.BackColor = Color.White; ;
                g9 = 0;
            }
        }

        private void Btn_G10_Click(object sender, EventArgs e)
        {
            if (g10 == 0)
            {
                contador = contador + 1;
                btnG10.BackColor = Color.LawnGreen; ;
                g10 = g1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnG10.BackColor = Color.White; ;
                g10 = 0;
            }
        }

        private void Btn_H2_Click(object sender, EventArgs e)
        {
            if (h2 == 0)
            {
                contador = contador + 1;
                btnH2.BackColor = Color.LawnGreen; ;
                h2 = h2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH2.BackColor = Color.White; ;
                h2 = 0;
            }
        }

        private void Btn_H3_Click(object sender, EventArgs e)
        {
            if (h3 == 0)
            {
                contador = contador + 1;
                btnH3.BackColor = Color.LawnGreen; ;
                h3 = h3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH3.BackColor = Color.White; ;
                h3 = 0;
            }
        }

        private void Btn_H4_Click(object sender, EventArgs e)
        {
            if (h4 == 0)
            {
                contador = contador + 1;
                btnH4.BackColor = Color.LawnGreen; ;
                h4 = h4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH4.BackColor = Color.White; ;
                h4 = 0;
            }
        }

        private void Btn_H5_Click(object sender, EventArgs e)
        {
            if (h5 == 0)
            {
                contador = contador + 1;
                btnH5.BackColor = Color.LawnGreen; ;
                h5 = h5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH5.BackColor = Color.White; ;
                h5 = 0;
            }
        }

        private void Btn_H6_Click(object sender, EventArgs e)
        {
            if (h6 == 0)
            {
                contador = contador + 1;
                btnH6.BackColor = Color.LawnGreen; ;
                h6 = h6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH6.BackColor = Color.White; ;
                h6 = 0;
            }
        }

        private void Btn_H7_Click(object sender, EventArgs e)
        {
            if (h7 == 0)
            {
                contador = contador + 1;
                btnH7.BackColor = Color.LawnGreen; ;
                h7 = h7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH7.BackColor = Color.White; ;
                h7 = 0;
            }
        }

        private void Btn_H8_Click(object sender, EventArgs e)
        {
            if (h8 == 0)
            {
                contador = contador + 1;
                btnH8.BackColor = Color.LawnGreen; ;
                h8 = h8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH8.BackColor = Color.White; ;
                h8 = 0;
            }
        }

        private void Btn_H9_Click(object sender, EventArgs e)
        {
            if (h9 == 0)
            {
                contador = contador + 1;
                btnH9.BackColor = Color.LawnGreen; ;
                h9 = h9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH9.BackColor = Color.White; ;
                h9 = 0;
            }
        }

        private void Btn_H10_Click(object sender, EventArgs e)
        {
            if (h10 == 0)
            {
                contador = contador + 1;
                btnH10.BackColor = Color.LawnGreen; ;
                h10 = h10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnH10.BackColor = Color.White; ;
                h10 = 0;
            }
        }

        private void Btn_I2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                contador = contador + 1;
                btnI2.BackColor = Color.LawnGreen; ;
                i2 = i2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI2.BackColor = Color.White; ;
                i2 = 0;
            }
        }

        private void Btn_I3_Click(object sender, EventArgs e)
        {
            if (i3 == 0)
            {
                contador = contador + 1;
                btnI3.BackColor = Color.LawnGreen; ;
                i3 = i3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI3.BackColor = Color.White; ;
                i3 = 0;
            }
        }

        private void Btn_I4_Click(object sender, EventArgs e)
        {
            if (i4 == 0)
            {
                contador = contador + 1;
                btnI4.BackColor = Color.LawnGreen; ;
                i4 = i4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI4.BackColor = Color.White; ;
                i4 = 0;
            }
        }

        private void Btn_I5_Click(object sender, EventArgs e)
        {
            if (i5 == 0)
            {
                contador = contador + 1;
                btnI5.BackColor = Color.LawnGreen; ;
                i5 = i5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI5.BackColor = Color.White; ;
                i5 = 0;
            }
        }

        private void Btn_I6_Click(object sender, EventArgs e)
        {
            if (i6 == 0)
            {
                contador = contador + 1;
                btnI6.BackColor = Color.LawnGreen; ;
                i6 = i1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI6.BackColor = Color.White; ;
                i6 = 0;
            }
        }

        private void Btn_I7_Click(object sender, EventArgs e)
        {
            if (i7 == 0)
            {
                contador = contador + 1;
                btnI7.BackColor = Color.LawnGreen; ;
                i7 = i7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI7.BackColor = Color.White; ;
                i7 = 0;
            }
        }

        private void Btn_I8_Click(object sender, EventArgs e)
        {
            if (i8 == 0)
            {
                contador = contador + 1;
                btnI8.BackColor = Color.LawnGreen; ;
                i8 = i8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI8.BackColor = Color.White; ;
                i8 = 0;
            }
        }

        private void Btn_I9_Click(object sender, EventArgs e)
        {
            if (i9 == 0)
            {
                contador = contador + 1;
                btnI9.BackColor = Color.LawnGreen; ;
                i9 = i9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI9.BackColor = Color.White; ;
                i9 = 0;
            }
        }

        private void Btn_I10_Click(object sender, EventArgs e)
        {
            if (i10 == 0)
            {
                contador = contador + 1;
                btnI10.BackColor = Color.LawnGreen; ;
                i10 = i10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnI10.BackColor = Color.White; ;
                i10 = 0;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo = tiempo - 1;
                lbTiempo.Text = tiempo.ToString();
            }
        }

        private void Frm_asientos_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Int32.Parse(txtAsientos.Text) == contador)
			{
				btnA1.Enabled = false; btnA2.Enabled = false; btnA3.Enabled = false; btnA4.Enabled = false; btnA5.Enabled = false;
				btnA6.Enabled = false; btnA7.Enabled = false; btnA8.Enabled = false; btnA9.Enabled = false; btnA10.Enabled = false;
				btnB1.Enabled = false; btnB2.Enabled = false; btnB3.Enabled = false; btnB4.Enabled = false; btnB5.Enabled = false;
				btnB6.Enabled = false; btnB7.Enabled = false; btnB8.Enabled = false; btnB9.Enabled = false; btnB10.Enabled = false;
				btnC1.Enabled = false; btnC2.Enabled = false; btnC3.Enabled = false; btnC4.Enabled = false; btnC5.Enabled = false;
				btnC6.Enabled = false; btnC7.Enabled = false; btnC8.Enabled = false; btnC9.Enabled = false; btnC10.Enabled = false;
				btnD1.Enabled = false; btnD2.Enabled = false; btnD3.Enabled = false; btnD4.Enabled = false; btnD5.Enabled = false;
				btnD6.Enabled = false; btnD7.Enabled = false; btnD8.Enabled = false; btnD9.Enabled = false; btnD10.Enabled = false;
				btnE1.Enabled = false; btnE2.Enabled = false; btnE3.Enabled = false; btnE4.Enabled = false; btnE5.Enabled = false;
				btnE6.Enabled = false; btnE7.Enabled = false; btnE8.Enabled = false; btnE9.Enabled = false; btnE10.Enabled = false;
				btnF1.Enabled = false; btnF2.Enabled = false; btnF3.Enabled = false; btnF4.Enabled = false; btnF5.Enabled = false;
				btnE10.Enabled = false; btnF7.Enabled = false; btnF8.Enabled = false; btnF9.Enabled = false; btnF10.Enabled = false;
				btnH1.Enabled = false; btnH2.Enabled = false; btnH3.Enabled = false; btnH4.Enabled = false; btnH5.Enabled = false;
				btnH6.Enabled = false; btnH7.Enabled = false; btnH8.Enabled = false; btnH9.Enabled = false; btnH10.Enabled = false;
				btnI1.Enabled = false; btnI2.Enabled = false; btnI3.Enabled = false; btnI4.Enabled = false; btnI5.Enabled = false;
				btnI6.Enabled = false; btnI7.Enabled = false; btnI8.Enabled = false; btnI9.Enabled = false; btnI10.Enabled = false;
			}
			if (Int32.Parse(txtAsientos.Text) < contador)
			{
				btnA1.Enabled = true; btnA2.Enabled = true; btnA3.Enabled = true; btnA4.Enabled = true; btnA5.Enabled = true;
				btnA6.Enabled = true; btnA7.Enabled = true; btnA8.Enabled = true; btnA9.Enabled = true; btnA10.Enabled = true;
				btnB1.Enabled = true; btnB2.Enabled = true; btnB3.Enabled = true; btnB4.Enabled = true; btnB5.Enabled = true;
				btnB6.Enabled = true; btnB7.Enabled = true; btnB8.Enabled = true; btnB9.Enabled = true; btnB10.Enabled = true;
				btnC1.Enabled = true; btnC2.Enabled = true; btnC3.Enabled = true; btnC4.Enabled = true; btnC5.Enabled = true;
				btnC6.Enabled = true; btnC7.Enabled = true; btnC8.Enabled = true; btnC9.Enabled = true; btnC10.Enabled = true;
				btnD1.Enabled = true; btnD2.Enabled = true; btnD3.Enabled = true; btnD4.Enabled = true; btnD5.Enabled = true;
				btnD6.Enabled = true; btnD7.Enabled = true; btnD8.Enabled = true; btnD9.Enabled = true; btnD10.Enabled = true;
				btnE1.Enabled = true; btnE2.Enabled = true; btnE3.Enabled = true; btnE4.Enabled = true; btnE5.Enabled = true;
				btnE6.Enabled = true; btnE7.Enabled = true; btnE8.Enabled = true; btnE9.Enabled = true; btnE10.Enabled = true;
				btnF1.Enabled = true; btnF2.Enabled = true; btnF3.Enabled = true; btnF4.Enabled = true; btnF5.Enabled = true;
				btnE10.Enabled = true; btnF7.Enabled = true; btnF8.Enabled = true; btnF9.Enabled = true; btnF10.Enabled = true;
				btnH1.Enabled = true; btnH2.Enabled = true; btnH3.Enabled = true; btnH4.Enabled = true; btnH5.Enabled = true;
				btnH6.Enabled = true; btnH7.Enabled = true; btnH8.Enabled = true; btnH9.Enabled = true; btnH10.Enabled = true;
				btnI1.Enabled = true; btnI2.Enabled = true; btnI3.Enabled = true; btnI4.Enabled = true; btnI5.Enabled = true;
				btnI6.Enabled = true; btnI7.Enabled = true; btnI8.Enabled = true; btnI9.Enabled = true; btnI10.Enabled = true;
			}
		}

     

        private void Btn_C5_Click(object sender, EventArgs e)
        {
            if (c5 == 0)
            {
                contador = contador + 1;
                btnC5.BackColor = Color.LawnGreen; ;
                c5 = c5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC5.BackColor = Color.White; ;
                c5 = 0;
            }
        }

        private void Btn_C3_Click(object sender, EventArgs e)
        {
            if (c3 == 0)
            {
                contador = contador + 1;
                btnC3.BackColor = Color.LawnGreen; ;
                c3 = c3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC3.BackColor = Color.White; ;
                c3 = 0;
            }
        }

        private void Btn_C2_Click(object sender, EventArgs e)
        {
            if (c2 == 0)
            {
                contador = contador + 1;
                btnC2.BackColor = Color.LawnGreen; ;
                c2 = c2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC2.BackColor = Color.White; ;
                c2 = 0;
            }
        }

        private void Btn_C4_Click(object sender, EventArgs e)
        {
            if (c4 == 0)
            {
                contador = contador + 1;
                btnC4.BackColor = Color.LawnGreen; ;
                c4 = c4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC4.BackColor = Color.White; ;
                c4 = 0;
            }
        }

        int e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 = 0;
        int f1, f2, f3, f4, f5, f6, f7, f8, f9, f10 = 0;
        int g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 = 0;
        int h1, h2, h3, h4, h5, h6, h7, h8, h9, h10 = 0;
        int i1, i2, i3, i4, i5, i6, i7, i8, i9, i10 = 0;


        private void Btn_B2_Click(object sender, EventArgs e)
        {
            if (b2 == 0)
            {
                contador = contador + 1;
                btnB2.BackColor = Color.LawnGreen; ;
                b2 = b2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB2.BackColor = Color.White; ;
                b2 = 0;
            }
        }

        private void Btn_B3_Click(object sender, EventArgs e)
        {
            if (b3 == 0)
            {
                contador = contador + 1;
                btnB3.BackColor = Color.LawnGreen; ;
                b3 = b3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB3.BackColor = Color.White; ;
                b3 = 0;
            }
        }

        private void Btn_B4_Click(object sender, EventArgs e)
        {
            if (b4 == 0)
            {
                contador = contador + 1;
                btnB4.BackColor = Color.LawnGreen; ;
                b4 = b4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB4.BackColor = Color.White; ;
                b4 = 0;
            }
        }

        private void Btn_B5_Click(object sender, EventArgs e)
        {
            if (b5 == 0)
            {
                contador = contador + 1;
                btnB5.BackColor = Color.LawnGreen; ;
                b5 = b5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB5.BackColor = Color.White; ;
                b5 = 0;
            }
        }

        private void Btn_B6_Click(object sender, EventArgs e)
        {
            if (b6 == 0)
            {
                contador = contador + 1;
                btnB6.BackColor = Color.LawnGreen; ;
                b6 = b6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB6.BackColor = Color.White; ;
                b6 = 0;
            }
        }

        private void Btn_B8_Click(object sender, EventArgs e)
        {
            if (b8 == 0)
            {
                contador = contador + 1;
                btnB8.BackColor = Color.LawnGreen; ;
                b8 = b8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB8.BackColor = Color.White; ;
                b8 = 0;
            }
        }

        private void Btn_B9_Click(object sender, EventArgs e)
        {
            if (b9 == 0)
            {
                contador = contador + 1;
                btnB9.BackColor = Color.LawnGreen; ;
                b1 = b1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB9.BackColor = Color.White; ;
                b9 = 0;
            }
        }

        private void Btn_B10_Click(object sender, EventArgs e)
        {
            if (b10 == 0)
            {
                contador = contador + 1;
                btnB10.BackColor = Color.LawnGreen; ;
                b10 = b10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB10.BackColor = Color.White; ;
                b10 = 0;
            }
        }

        private void Btn_C1_Click(object sender, EventArgs e)
        {
            if (c1 == 0)
            {
                contador = contador + 1;
                btnC1.BackColor = Color.LawnGreen; ;
                c1 = c1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC1.BackColor = Color.White; ;
                c1 = 0;
            }
        }

        private void Btn_A3_Click(object sender, EventArgs e)
        {
            if (a3 == 0)
            {
                contador = contador + 1;
                btnA3.BackColor = Color.LawnGreen; ;
                a3 = a3 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA3.BackColor = Color.White; ;
                a3 = 0;
            }
        }

        private void Btn_A4_Click(object sender, EventArgs e)
        {
            if (a4 == 0)
            {
                contador = contador + 1;
                btnA4.BackColor = Color.LawnGreen; ;
                a4 = a4 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA4.BackColor = Color.White; ;
                a4 = 0;
            }
        }

        private void Btn_A5_Click(object sender, EventArgs e)
        {
            if (a5 == 0)
            {
                contador = contador + 1;
                btnA5.BackColor = Color.LawnGreen; ;
                a5 = a5 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA5.BackColor = Color.White; ;
                a5 = 0;
            }
        }

        private void Btn_A6_Click(object sender, EventArgs e)
        {
            if (a6 == 0)
            {
                contador = contador + 1;
                btnA6.BackColor = Color.LawnGreen; ;
                a6 = a6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA6.BackColor = Color.White; ;
                a6 = 0;
            }
        }

        private void Btn_A7_Click(object sender, EventArgs e)
        {
            if (a7 == 0)
            {
                contador = contador + 1;
                btnA7.BackColor = Color.LawnGreen; ;
                a7 = a7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA7.BackColor = Color.White; ;
                a7 = 0;
            }
        }

        private void Btn_A8_Click(object sender, EventArgs e)
        {
            if (a8 == 0)
            {
                contador = contador + 1;
                btnA8.BackColor = Color.LawnGreen; ;
                a8 = a8 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA8.BackColor = Color.White; ;
                a8 = 0;
            }
        }

        private void Btn_A9_Click(object sender, EventArgs e)
        {
            if (a9 == 0)
            {
                contador = contador + 1;
                btnA9.BackColor = Color.LawnGreen; ;
                a9 = a9 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA9.BackColor = Color.White; ;
                a9 = 0;
            }
        }

        private void Btn_A10_Click(object sender, EventArgs e)
        {
            if (a10 == 0)
            {
                contador = contador + 1;
                btnA1.BackColor = Color.LawnGreen; ;
                a10 = a10 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA10.BackColor = Color.White; ;
                a10 = 0;
            }
        }

        private void Btn_B1_Click(object sender, EventArgs e)
        {
            if (b1 == 0)
            {
                contador = contador + 1;
                btnB1.BackColor = Color.LawnGreen; ;
                b1 = b1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnB1.BackColor = Color.White; ;
                b1 = 0;
            }
        }

        

        private void Button16_Click(object sender, EventArgs e)
        {
            if (c6 == 0)
            {
                contador = contador + 1;
                btnC6.BackColor = Color.LawnGreen; ;
                c6 = c6 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC6.BackColor = Color.White; ;
                c6 = 0;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (c7 == 0)
            {
                contador = contador + 1;
                btnC7.BackColor = Color.LawnGreen; ;
                c7 = c7 + 1;
            }
            else
            {
                contador = contador - 1;
                btnC7.BackColor = Color.White;
                c7 = 0;

            }
        }

            private void Btn_confirmar_Click(object sender, EventArgs e)
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
                int prueba = int.Parse(txtAsientos.Text);

                if (contador > 0 && contador == prueba)
                {
                    frmTipoPago tipoPago = new frmTipoPago(tiempo);
                    tipoPago.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Asientos no seleccionados");
                    contador = 0;
                    a1 = 0; a2 = 0; a3 = 0; a4 = 0; a5 = 0; a6 = 0; a7 = 0; a8 = 0; a9 = 0; a10 = 0;
                    b1 = 0; b2 = 0; b3 = 0; b4 = 0; b5 = 0; b6 = 0; b7 = 0; b8 = 0; b9 = 0; b10 = 0;
                    c1 = 0; c2 = 0; c3 = 0; c4 = 0; c5 = 0; c6 = 0; c7 = 0; c8 = 0; c9 = 0; c10 = 0;
                    d1 = 0; d2 = 0; d3 = 0; d4 = 0; d5 = 0; d6 = 0; d7 = 0; d8 = 0; d9 = 0; d10 = 0;
                    e1 = 0; e2 = 0; e3 = 0; e4 = 0; e5 = 0; e6 = 0; e7 = 0; e8 = 0; e9 = 0; e10 = 0;
                    f1 = 0; f2 = 0; f3 = 0; f4 = 0; f5 = 0; f6 = 0; f7 = 0; f8 = 0; f9 = 0; f10 = 0;
                    g1 = 0; g2 = 0; g3 = 0; g4 = 0; g5 = 0; g6 = 0; g7 = 0; g8 = 0; g9 = 0; g10 = 0;
                    h1 = 0; h2 = 0; h3 = 0; h4 = 0; h5 = 0; h6 = 0; h7 = 0; h8 = 0; h9 = 0; h10 = 0;
                    i1 = 0; i2 = 0; i3 = 0; i4 = 0; i5 = 0; i6 = 0; i7 = 0; i8 = 0; i9 = 0; i10 = 0;
                    btnA1.BackColor = Color.White; btnA2.BackColor = Color.White; btnA3.BackColor = Color.White; btnA4.BackColor = Color.White; btnA5.BackColor = Color.White;
                    btnA6.BackColor = Color.White; btnA7.BackColor = Color.White; btnA8.BackColor = Color.White; btnA9.BackColor = Color.White; btnA10.BackColor = Color.White;
                    btnB1.BackColor = Color.White; btnB2.BackColor = Color.White; btnB3.BackColor = Color.White; btnB4.BackColor = Color.White; btnB5.BackColor = Color.White;
                    btnB6.BackColor = Color.White; btnB7.BackColor = Color.White; btnB8.BackColor = Color.White; btnB9.BackColor = Color.White; btnB10.BackColor = Color.White;
                    btnC1.BackColor = Color.White; btnC2.BackColor = Color.White; btnC3.BackColor = Color.White; btnC4.BackColor = Color.White; btnC5.BackColor = Color.White;
                    btnC6.BackColor = Color.White; btnC7.BackColor = Color.White; btnC8.BackColor = Color.White; btnC9.BackColor = Color.White; btnC10.BackColor = Color.White;
                    btnD1.BackColor = Color.White; btnD2.BackColor = Color.White; btnD3.BackColor = Color.White; btnD4.BackColor = Color.White; btnD5.BackColor = Color.White;
                    btnD6.BackColor = Color.White; btnD7.BackColor = Color.White; btnD8.BackColor = Color.White; btnD9.BackColor = Color.White; btnD10.BackColor = Color.White;
                    btnE1.BackColor = Color.White; btnE2.BackColor = Color.White; btnE3.BackColor = Color.White; btnE4.BackColor = Color.White; btnE5.BackColor = Color.White;
                    btnE6.BackColor = Color.White; btnE7.BackColor = Color.White; btnE8.BackColor = Color.White; btnE9.BackColor = Color.White; btnE10.BackColor = Color.White;
                    btnF1.BackColor = Color.White; btnF2.BackColor = Color.White; btnF3.BackColor = Color.White; btnF4.BackColor = Color.White; btnF5.BackColor = Color.White;
                    btnE10.BackColor = Color.White; btnF7.BackColor = Color.White; btnF8.BackColor = Color.White; btnF9.BackColor = Color.White; btnF10.BackColor = Color.White;
                    btnH1.BackColor = Color.White; btnH2.BackColor = Color.White; btnH3.BackColor = Color.White; btnH4.BackColor = Color.White; btnH5.BackColor = Color.White;
                    btnH6.BackColor = Color.White; btnH7.BackColor = Color.White; btnH8.BackColor = Color.White; btnH9.BackColor = Color.White; btnH10.BackColor = Color.White;
                    btnI1.BackColor = Color.White; btnI2.BackColor = Color.White; btnI3.BackColor = Color.White; btnI4.BackColor = Color.White; btnI5.BackColor = Color.White;
                    btnI6.BackColor = Color.White; btnI7.BackColor = Color.White; btnI8.BackColor = Color.White; btnI9.BackColor = Color.White; btnI10.BackColor = Color.White;
                }
            }
        }
        private void Btn_A1_Click(object sender, EventArgs e)
        {
            if (a1 == 0)
            {
                contador = contador + 1;
                btnA1.BackColor = Color.LawnGreen; ;
                a1 = a1 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA1.BackColor = Color.White; ;
                a1 = 0;
            }
        }

        private void Btn_A2_Click(object sender, EventArgs e)
        {
            if (a2 == 0)
            {
                contador = contador + 1;
                btnA2.BackColor = Color.LawnGreen; ;
                a2 = a2 + 1;
            }
            else
            {
                contador = contador - 1;
                btnA2.BackColor = Color.White; ;
                a2 = 0;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form formulariopag = new frmBoletos(1);
            formulariopag.Show();
            Visible = false;
        }
    }
}
