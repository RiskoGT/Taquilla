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
        /*Grupo 2  taquilla  cliente comprador
        Gustavo Perez 0901-16-420 y Juan José Gámez 0901-16-47  */
        int contador = 0;
        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 = 0;
        int b1, b2, b3, b4, b5, b6, b7, b8, b9, b10 = 0;
        int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 = 0;
        int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 = 0;

        private void Btn_B7_Click(object sender, EventArgs e)
        {
            if (b7 == 0)
            {
                contador = contador + 1;
                Btn_B7.BackColor = Color.LawnGreen; ;
                b7 = b7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B7.BackColor = Color.White; ;
                b7 = 0;
            }
        }

        private void Btn_C8_Click(object sender, EventArgs e)
        {
            if (c8 == 0)
            {
                contador = contador + 1;
                Btn_C8.BackColor = Color.LawnGreen; ;
                c8 = c8+ 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C8.BackColor = Color.White;
                c8 = 0;
            }
        }

        private void Btn_C9_Click(object sender, EventArgs e)
        {
            if (c9 == 0)
            {
                contador = contador + 1;
                Btn_C9.BackColor = Color.LawnGreen; ;
                c9 = c9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C9.BackColor = Color.White; ;
                c9 = 0;
            }
        }

        private void Btn_C10_Click(object sender, EventArgs e)
        {
            if (c10 == 0)
            {
                contador = contador + 1;
                Btn_C10.BackColor = Color.LawnGreen; ;
                c10 = c10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C10.BackColor = Color.White; ;
                c10 = 0;
            }
        }

        private void Btn_D1_Click(object sender, EventArgs e)
        {
            if (d1 == 0)
            {
                contador = contador + 1;
                Btn_D1.BackColor = Color.LawnGreen; ;
                d1 = d1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D1.BackColor = Color.White; ;
                d1 = 0;
            }
        }

        private void Btn_E1_Click(object sender, EventArgs e)
        {
            if (e1 == 0)
            {
                contador = contador + 1;
                Btn_E1.BackColor = Color.LawnGreen; ;
                e1 = e1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E1.BackColor = Color.White; ;
                e1 = 0;
            }
        }

        private void Btn_F1_Click(object sender, EventArgs e)
        {
            if (f1 == 0)
            {
                contador = contador + 1;
                Btn_F1.BackColor = Color.LawnGreen; ;
                f1 = f1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F1.BackColor = Color.White; ;
                f1 = 0;
            }
        }

        private void Btn_G1_Click(object sender, EventArgs e)
        {
            if (g1 == 0)
            {
                contador = contador + 1;
                Btn_G1.BackColor = Color.LawnGreen; ;
                g1 = g1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G1.BackColor = Color.White; ;
                g1 = 0;
            }
        }

        private void Btn_H1_Click(object sender, EventArgs e)
        {

            if (h1 == 0)
            {
                contador = contador + 1;
                Btn_H1.BackColor = Color.LawnGreen; ;
                h1 = h1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H1.BackColor = Color.White; ;
                h1 = 0;
            }
        }

        private void Btn_I1_Click(object sender, EventArgs e)
        {
            if (i1 == 0)
            {
                contador = contador + 1;
                Btn_I1.BackColor = Color.LawnGreen; ;
                i1 = i1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I1.BackColor = Color.White; ;
                i1 = 0;
            }
        }

        private void Btn_D2_Click(object sender, EventArgs e)
        {
            if (d2 == 0)
            {
                contador = contador + 1;
                Btn_D2.BackColor = Color.LawnGreen; ;
                d2 = d2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D2.BackColor = Color.White; ;
                d2 = 0;
            }
        }

        private void Btn_D3_Click(object sender, EventArgs e)
        {
            if (d3 == 0)
            {
                contador = contador + 1;
                Btn_D3.BackColor = Color.LawnGreen; ;
                d3 = d3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D3.BackColor = Color.White; ;
                d3 = 0;
            }
        }

        private void Btn_D5_Click(object sender, EventArgs e)
        {
            if (d5 == 0)
            {
                contador = contador + 1;
                Btn_D5.BackColor = Color.LawnGreen; ;
                d5 = d5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D5.BackColor = Color.White; ;
                d5 = 0;
            }
        }

        private void Btn_D6_Click(object sender, EventArgs e)
        {
            if (d6 == 0)
            {
                contador = contador + 1;
                Btn_D6.BackColor = Color.LawnGreen; ;
                d6 = d6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D6.BackColor = Color.White; ;
                d6 = 0;
            }
        }

        private void Btn_D7_Click(object sender, EventArgs e)
        {
            if (d7 == 0)
            {
                contador = contador + 1;
                Btn_D7.BackColor = Color.LawnGreen; ;
                d7 = d7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D7.BackColor = Color.White; ;
                d7 = 0;
            }
        }

        private void Btn_D8_Click(object sender, EventArgs e)
        {
            if (d8 == 0)
            {
                contador = contador + 1;
                Btn_D8.BackColor = Color.LawnGreen; ;
                d8 = d8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D8.BackColor = Color.White; ;
                d8= 0;
            }
        }

        private void Btn_D9_Click(object sender, EventArgs e)
        {
            if (d9 == 0)
            {
                contador = contador + 1;
                Btn_D9.BackColor = Color.LawnGreen; ;
                d9 = d9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D9.BackColor = Color.White; ;
                d9 = 0;
            }
        }

        private void Btn_D10_Click(object sender, EventArgs e)
        {
            if (d10 == 0)
            {
                contador = contador + 1;
                Btn_D10.BackColor = Color.LawnGreen; ;
                d10 = d10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D10.BackColor = Color.White; ;
                d10 = 0;
            }
        }

        private void Btn_D4_Click(object sender, EventArgs e)
        {
            if (d4 == 0)
            {
                contador = contador + 1;
                Btn_D4.BackColor = Color.LawnGreen; ;
                d4 = d4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_D4.BackColor = Color.White; ;
                d4 = 0;
            }
        }

        private void Btn_E5_Click(object sender, EventArgs e)
        {
            if (e5 == 0)
            {
                contador = contador + 1;
                Btn_E5.BackColor = Color.LawnGreen; ;
                e5 = e5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E5.BackColor = Color.White; ;
                e5 = 0;
            }
        }

        private void Btn_E2_Click(object sender, EventArgs e)
        {
            if (e2 == 0)
            {
                contador = contador + 1;
                Btn_E2.BackColor = Color.LawnGreen; ;
                e2 = e2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E2.BackColor = Color.White; ;
                e2 = 0;
            }
        }

        private void Btn_E3_Click(object sender, EventArgs e)
        {
            if (e3 == 0)
            {
                contador = contador + 1;
                Btn_E3.BackColor = Color.LawnGreen; ;
                e3 = e3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E3.BackColor = Color.White; ;
                e3 = 0;
            }
        }

        private void Btn_E4_Click(object sender, EventArgs e)
        {
            if (e4 == 0)
            {
                contador = contador + 1;
                Btn_E4.BackColor = Color.LawnGreen; ;
                e4 = e4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E4.BackColor = Color.White; ;
                e4 = 0;
            }
        }

        private void Btn_E6_Click(object sender, EventArgs e)
        {
            if (e6 == 0)
            {
                contador = contador + 1;
                Btn_E6.BackColor = Color.LawnGreen; ;
                e6 = e6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E6.BackColor = Color.White; ;
                e6 = 0;
            }
        }

        private void Btn_E7_Click(object sender, EventArgs e)
        {
            if (e7 == 0)
            {
                contador = contador + 1;
                Btn_E7.BackColor = Color.LawnGreen; ;
                e7 = e7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E7.BackColor = Color.White; ;
                e7 = 0;
            }
        }

        private void Btn_E8_Click(object sender, EventArgs e)
        {
            if (e8 == 0)
            {
                contador = contador + 1;
                Btn_E8.BackColor = Color.LawnGreen; ;
                e8 = e8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E8.BackColor = Color.White; ;
                e8 = 0;
            }
        }

        private void Btn_E9_Click(object sender, EventArgs e)
        {
            if (e9 == 0)
            {
                contador = contador + 1;
                Btn_E9.BackColor = Color.LawnGreen; ;
                e9 = e9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E9.BackColor = Color.White; ;
                e9 = 0;
            }
        }

        private void Btn_E10_Click(object sender, EventArgs e)
        {
            if (e10 == 0)
            {
                contador = contador + 1;
                Btn_E10.BackColor = Color.LawnGreen; ;
                e10 = e10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_E10.BackColor = Color.White; ;
                e10 = 0;
            }
        }

        private void Btn_F2_Click(object sender, EventArgs e)
        {
            if (f2 == 0)
            {
                contador = contador + 1;
                Btn_F2.BackColor = Color.LawnGreen; ;
                f2 = f2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F2.BackColor = Color.White; ;
                f2= 0;
            }
        }

        private void Btn_F3_Click(object sender, EventArgs e)
        {
            if (f3 == 0)
            {
                contador = contador + 1;
                Btn_F3.BackColor = Color.LawnGreen; ;
                f3 = f3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F3.BackColor = Color.White; ;
                f3 = 0;
            }
        }

        private void Btn_F4_Click(object sender, EventArgs e)
        {
            if (f4 == 0)
            {
                contador = contador + 1;
                Btn_F4.BackColor = Color.LawnGreen; ;
                f4 = f4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F4.BackColor = Color.White; ;
                f4 = 0;
            }
        }

        private void Btn_F5_Click(object sender, EventArgs e)
        {
            if (f5 == 0)
            {
                contador = contador + 1;
                Btn_F5.BackColor = Color.LawnGreen; ;
                f5 = f5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F5.BackColor = Color.White; ;
                f5 = 0;
            }
        }

        private void Button57_Click(object sender, EventArgs e)
        {
            if (f6 == 0)
            {
                contador = contador + 1;
                Btn_F6.BackColor = Color.LawnGreen; ;
                f6 = f6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F6.BackColor = Color.White; ;
                f6 = 0;
            }
        }

        private void Btn_F7_Click(object sender, EventArgs e)
        {
            if (f7 == 0)
            {
                contador = contador + 1;
                Btn_F7.BackColor = Color.LawnGreen; ;
                f7 = f7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F7.BackColor = Color.White; ;
                f7 = 0;
            }
        }

        private void Btn_F8_Click(object sender, EventArgs e)
        {
            if (f8 == 0)
            {
                contador = contador + 1;
                Btn_F8.BackColor = Color.LawnGreen; ;
                f8 = f8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F8.BackColor = Color.White; ;
                f8 = 0;
            }
        }

        private void Btn_F9_Click(object sender, EventArgs e)
        {
            if (f9 == 0)
            {
                contador = contador + 1;
                Btn_F9.BackColor = Color.LawnGreen; ;
                f9 = f9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F9.BackColor = Color.White; ;
                f9 = 0;
            }
        }

        private void Btn_F10_Click(object sender, EventArgs e)
        {
            if (f10 == 0)
            {
                contador = contador + 1;
                Btn_F10.BackColor = Color.LawnGreen; ;
                f10 = f10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_F10.BackColor = Color.White; ;
                f10 = 0;
            }
        }

        private void Btn_G2_Click(object sender, EventArgs e)
        {
            if (g2 == 0)
            {
                contador = contador + 1;
                Btn_G2.BackColor = Color.LawnGreen; ;
                g2 = g2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G2.BackColor = Color.White; ;
                g2 = 0;
            }
        }

        private void Btn_G3_Click(object sender, EventArgs e)
        {
            if (g3 == 0)
            {
                contador = contador + 1;
                Btn_G3.BackColor = Color.LawnGreen; ;
                g3 = g3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G3.BackColor = Color.White; ;
                g3 = 0;
            }
        }

        private void Btn_G4_Click(object sender, EventArgs e)
        {
            if (g4 == 0)
            {
                contador = contador + 1;
                Btn_G4.BackColor = Color.LawnGreen; ;
                g4 = g4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G4.BackColor = Color.White; ;
                g4 = 0;
            }
        }

        private void Btn_G5_Click(object sender, EventArgs e)
        {
            if (g5 == 0)
            {
                contador = contador + 1;
                Btn_G5.BackColor = Color.LawnGreen; ;
                g5 = g5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G5.BackColor = Color.White; ;
                g5 = 0;
            }
        }

        private void Btn_G6_Click(object sender, EventArgs e)
        {
            if (g6 == 0)
            {
                contador = contador + 1;
                Btn_G6.BackColor = Color.LawnGreen; ;
                g6 = g6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G6.BackColor = Color.White; ;
                g6 = 0;
            }
        }

        private void Btn_G7_Click(object sender, EventArgs e)
        {
            if (g7 == 0)
            {
                contador = contador + 1;
                Btn_G7.BackColor = Color.LawnGreen; ;
                g7 = g7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G7.BackColor = Color.White; ;
                g7 = 0;
            }
        }

        private void Btn_G8_Click(object sender, EventArgs e)
        {
            if (g8 == 0)
            {
                contador = contador + 1;
                Btn_G8.BackColor = Color.LawnGreen; ;
                g8 = g8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G8.BackColor = Color.White; ;
                g8= 0;
            }
        }

        private void Btn_G9_Click(object sender, EventArgs e)
        {
            if (g9 == 0)
            {
                contador = contador + 1;
                Btn_G9.BackColor = Color.LawnGreen; ;
                g9 = g9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G9.BackColor = Color.White; ;
                g9 = 0;
            }
        }

        private void Btn_G10_Click(object sender, EventArgs e)
        {
            if (g10 == 0)
            {
                contador = contador + 1;
                Btn_G10.BackColor = Color.LawnGreen; ;
                g10 = g1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_G10.BackColor = Color.White; ;
                g10 = 0;
            }
        }

        private void Btn_H2_Click(object sender, EventArgs e)
        {
            if (h2 == 0)
            {
                contador = contador + 1;
                Btn_H2.BackColor = Color.LawnGreen; ;
                h2 = h2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H2.BackColor = Color.White; ;
                h2 = 0;
            }
        }

        private void Btn_H3_Click(object sender, EventArgs e)
        {
            if (h3 == 0)
            {
                contador = contador + 1;
                Btn_H3.BackColor = Color.LawnGreen; ;
                h3 = h3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H3.BackColor = Color.White; ;
                h3 = 0;
            }
        }

        private void Btn_H4_Click(object sender, EventArgs e)
        {
            if (h4 == 0)
            {
                contador = contador + 1;
                Btn_H4.BackColor = Color.LawnGreen; ;
                h4 = h4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H4.BackColor = Color.White; ;
                h4 = 0;
            }
        }

        private void Btn_H5_Click(object sender, EventArgs e)
        {
            if (h5 == 0)
            {
                contador = contador + 1;
                Btn_H5.BackColor = Color.LawnGreen; ;
                h5 = h5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H5.BackColor = Color.White; ;
                h5 = 0;
            }
        }

        private void Btn_H6_Click(object sender, EventArgs e)
        {
            if (h6 == 0)
            {
                contador = contador + 1;
                Btn_H6.BackColor = Color.LawnGreen; ;
                h6 = h6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H6.BackColor = Color.White; ;
                h6 = 0;
            }
        }

        private void Btn_H7_Click(object sender, EventArgs e)
        {
            if (h7 == 0)
            {
                contador = contador + 1;
                Btn_H7.BackColor = Color.LawnGreen; ;
                h7 = h7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H7.BackColor = Color.White; ;
                h7 = 0;
            }
        }

        private void Btn_H8_Click(object sender, EventArgs e)
        {
            if (h8 == 0)
            {
                contador = contador + 1;
                Btn_H8.BackColor = Color.LawnGreen; ;
                h8 = h8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H8.BackColor = Color.White; ;
                h8 = 0;
            }
        }

        private void Btn_H9_Click(object sender, EventArgs e)
        {
            if (h9 == 0)
            {
                contador = contador + 1;
                Btn_H9.BackColor = Color.LawnGreen; ;
                h9 = h9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H9.BackColor = Color.White; ;
                h9 = 0;
            }
        }

        private void Btn_H10_Click(object sender, EventArgs e)
        {
            if (h10 == 0)
            {
                contador = contador + 1;
                Btn_H10.BackColor = Color.LawnGreen; ;
                h10 = h10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_H10.BackColor = Color.White; ;
                h10 = 0;
            }
        }

        private void Btn_I2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                contador = contador + 1;
                Btn_I2.BackColor = Color.LawnGreen; ;
                i2 = i2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I2.BackColor = Color.White; ;
                i2 = 0;
            }
        }

        private void Btn_I3_Click(object sender, EventArgs e)
        {
            if (i3 == 0)
            {
                contador = contador + 1;
                Btn_I3.BackColor = Color.LawnGreen; ;
                i3 = i3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I3.BackColor = Color.White; ;
                i3 = 0;
            }
        }

        private void Btn_I4_Click(object sender, EventArgs e)
        {
            if (i4 == 0)
            {
                contador = contador + 1;
                Btn_I4.BackColor = Color.LawnGreen; ;
                i4 = i4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I4.BackColor = Color.White; ;
                i4 = 0;
            }
        }

        private void Btn_I5_Click(object sender, EventArgs e)
        {
            if (i5 == 0)
            {
                contador = contador + 1;
                Btn_I5.BackColor = Color.LawnGreen; ;
                i5 = i5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I5.BackColor = Color.White; ;
                i5 = 0;
            }
        }

        private void Btn_I6_Click(object sender, EventArgs e)
        {
            if (i6 == 0)
            {
                contador = contador + 1;
                Btn_I6.BackColor = Color.LawnGreen; ;
                i6 = i1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I6.BackColor = Color.White; ;
                i6 = 0;
            }
        }

        private void Btn_I7_Click(object sender, EventArgs e)
        {
            if (i7 == 0)
            {
                contador = contador + 1;
                Btn_I7.BackColor = Color.LawnGreen; ;
                i7 = i7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I7.BackColor = Color.White; ;
                i7 = 0;
            }
        }

        private void Btn_I8_Click(object sender, EventArgs e)
        {
            if (i8 == 0)
            {
                contador = contador + 1;
                Btn_I8.BackColor = Color.LawnGreen; ;
                i8 = i8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I8.BackColor = Color.White; ;
                i8 = 0;
            }
        }

        private void Btn_I9_Click(object sender, EventArgs e)
        {
            if (i9 == 0)
            {
                contador = contador + 1;
                Btn_I9.BackColor = Color.LawnGreen; ;
                i9 = i9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I9.BackColor = Color.White; ;
                i9 = 0;
            }
        }

        private void Btn_I10_Click(object sender, EventArgs e)
        {
            if (i10 == 0)
            {
                contador = contador + 1;
                Btn_I10.BackColor = Color.LawnGreen; ;
                i10 = i10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_I10.BackColor = Color.White; ;
                i10 = 0;
            }
        }

		private void Frm_asientos_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Int32.Parse(Txt_asientos.Text) == contador)
			{
				Btn_A1.Enabled = false; Btn_A2.Enabled = false; Btn_A3.Enabled = false; Btn_A4.Enabled = false; Btn_A5.Enabled = false;
				Btn_A6.Enabled = false; Btn_A7.Enabled = false; Btn_A8.Enabled = false; Btn_A9.Enabled = false; Btn_A10.Enabled = false;
				Btn_B1.Enabled = false; Btn_B2.Enabled = false; Btn_B3.Enabled = false; Btn_B4.Enabled = false; Btn_B5.Enabled = false;
				Btn_B6.Enabled = false; Btn_B7.Enabled = false; Btn_B8.Enabled = false; Btn_B9.Enabled = false; Btn_B10.Enabled = false;
				Btn_C1.Enabled = false; Btn_C2.Enabled = false; Btn_C3.Enabled = false; Btn_C4.Enabled = false; Btn_C5.Enabled = false;
				Btn_C6.Enabled = false; Btn_C7.Enabled = false; Btn_C8.Enabled = false; Btn_C9.Enabled = false; Btn_C10.Enabled = false;
				Btn_D1.Enabled = false; Btn_D2.Enabled = false; Btn_D3.Enabled = false; Btn_D4.Enabled = false; Btn_D5.Enabled = false;
				Btn_D6.Enabled = false; Btn_D7.Enabled = false; Btn_D8.Enabled = false; Btn_D9.Enabled = false; Btn_D10.Enabled = false;
				Btn_E1.Enabled = false; Btn_E2.Enabled = false; Btn_E3.Enabled = false; Btn_E4.Enabled = false; Btn_E5.Enabled = false;
				Btn_E6.Enabled = false; Btn_E7.Enabled = false; Btn_E8.Enabled = false; Btn_E9.Enabled = false; Btn_E10.Enabled = false;
				Btn_F1.Enabled = false; Btn_F2.Enabled = false; Btn_F3.Enabled = false; Btn_F4.Enabled = false; Btn_F5.Enabled = false;
				Btn_E10.Enabled = false; Btn_F7.Enabled = false; Btn_F8.Enabled = false; Btn_F9.Enabled = false; Btn_F10.Enabled = false;
				Btn_H1.Enabled = false; Btn_H2.Enabled = false; Btn_H3.Enabled = false; Btn_H4.Enabled = false; Btn_H5.Enabled = false;
				Btn_H6.Enabled = false; Btn_H7.Enabled = false; Btn_H8.Enabled = false; Btn_H9.Enabled = false; Btn_H10.Enabled = false;
				Btn_I1.Enabled = false; Btn_I2.Enabled = false; Btn_I3.Enabled = false; Btn_I4.Enabled = false; Btn_I5.Enabled = false;
				Btn_I6.Enabled = false; Btn_I7.Enabled = false; Btn_I8.Enabled = false; Btn_I9.Enabled = false; Btn_I10.Enabled = false;
			}
			if (Int32.Parse(Txt_asientos.Text) < contador)
			{
				Btn_A1.Enabled = true; Btn_A2.Enabled = true; Btn_A3.Enabled = true; Btn_A4.Enabled = true; Btn_A5.Enabled = true;
				Btn_A6.Enabled = true; Btn_A7.Enabled = true; Btn_A8.Enabled = true; Btn_A9.Enabled = true; Btn_A10.Enabled = true;
				Btn_B1.Enabled = true; Btn_B2.Enabled = true; Btn_B3.Enabled = true; Btn_B4.Enabled = true; Btn_B5.Enabled = true;
				Btn_B6.Enabled = true; Btn_B7.Enabled = true; Btn_B8.Enabled = true; Btn_B9.Enabled = true; Btn_B10.Enabled = true;
				Btn_C1.Enabled = true; Btn_C2.Enabled = true; Btn_C3.Enabled = true; Btn_C4.Enabled = true; Btn_C5.Enabled = true;
				Btn_C6.Enabled = true; Btn_C7.Enabled = true; Btn_C8.Enabled = true; Btn_C9.Enabled = true; Btn_C10.Enabled = true;
				Btn_D1.Enabled = true; Btn_D2.Enabled = true; Btn_D3.Enabled = true; Btn_D4.Enabled = true; Btn_D5.Enabled = true;
				Btn_D6.Enabled = true; Btn_D7.Enabled = true; Btn_D8.Enabled = true; Btn_D9.Enabled = true; Btn_D10.Enabled = true;
				Btn_E1.Enabled = true; Btn_E2.Enabled = true; Btn_E3.Enabled = true; Btn_E4.Enabled = true; Btn_E5.Enabled = true;
				Btn_E6.Enabled = true; Btn_E7.Enabled = true; Btn_E8.Enabled = true; Btn_E9.Enabled = true; Btn_E10.Enabled = true;
				Btn_F1.Enabled = true; Btn_F2.Enabled = true; Btn_F3.Enabled = true; Btn_F4.Enabled = true; Btn_F5.Enabled = true;
				Btn_E10.Enabled = true; Btn_F7.Enabled = true; Btn_F8.Enabled = true; Btn_F9.Enabled = true; Btn_F10.Enabled = true;
				Btn_H1.Enabled = true; Btn_H2.Enabled = true; Btn_H3.Enabled = true; Btn_H4.Enabled = true; Btn_H5.Enabled = true;
				Btn_H6.Enabled = true; Btn_H7.Enabled = true; Btn_H8.Enabled = true; Btn_H9.Enabled = true; Btn_H10.Enabled = true;
				Btn_I1.Enabled = true; Btn_I2.Enabled = true; Btn_I3.Enabled = true; Btn_I4.Enabled = true; Btn_I5.Enabled = true;
				Btn_I6.Enabled = true; Btn_I7.Enabled = true; Btn_I8.Enabled = true; Btn_I9.Enabled = true; Btn_I10.Enabled = true;
			}
		}

     

        private void Btn_C5_Click(object sender, EventArgs e)
        {
            if (c5 == 0)
            {
                contador = contador + 1;
                Btn_C5.BackColor = Color.LawnGreen; ;
                c5 = c5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C5.BackColor = Color.White; ;
                c5 = 0;
            }
        }

        private void Btn_C3_Click(object sender, EventArgs e)
        {
            if (c3 == 0)
            {
                contador = contador + 1;
                Btn_C3.BackColor = Color.LawnGreen; ;
                c3 = c3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C3.BackColor = Color.White; ;
                c3 = 0;
            }
        }

        private void Btn_C2_Click(object sender, EventArgs e)
        {
            if (c2 == 0)
            {
                contador = contador + 1;
                Btn_C2.BackColor = Color.LawnGreen; ;
                c2 = c2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C2.BackColor = Color.White; ;
                c2 = 0;
            }
        }

        private void Btn_C4_Click(object sender, EventArgs e)
        {
            if (c4 == 0)
            {
                contador = contador + 1;
                Btn_C4.BackColor = Color.LawnGreen; ;
                c4 = c4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C4.BackColor = Color.White; ;
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
                Btn_B2.BackColor = Color.LawnGreen; ;
                b2 = b2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B2.BackColor = Color.White; ;
                b2 = 0;
            }
        }

        private void Btn_B3_Click(object sender, EventArgs e)
        {
            if (b3 == 0)
            {
                contador = contador + 1;
                Btn_B3.BackColor = Color.LawnGreen; ;
                b3 = b3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B3.BackColor = Color.White; ;
                b3 = 0;
            }
        }

        private void Btn_B4_Click(object sender, EventArgs e)
        {
            if (b4 == 0)
            {
                contador = contador + 1;
                Btn_B4.BackColor = Color.LawnGreen; ;
                b4 = b4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B4.BackColor = Color.White; ;
                b4 = 0;
            }
        }

        private void Btn_B5_Click(object sender, EventArgs e)
        {
            if (b5 == 0)
            {
                contador = contador + 1;
                Btn_B5.BackColor = Color.LawnGreen; ;
                b5 = b5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B5.BackColor = Color.White; ;
                b5 = 0;
            }
        }

        private void Btn_B6_Click(object sender, EventArgs e)
        {
            if (b6 == 0)
            {
                contador = contador + 1;
                Btn_B6.BackColor = Color.LawnGreen; ;
                b6 = b6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B6.BackColor = Color.White; ;
                b6 = 0;
            }
        }

        private void Btn_B8_Click(object sender, EventArgs e)
        {
            if (b8 == 0)
            {
                contador = contador + 1;
                Btn_B8.BackColor = Color.LawnGreen; ;
                b8 = b8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B8.BackColor = Color.White; ;
                b8 = 0;
            }
        }

        private void Btn_B9_Click(object sender, EventArgs e)
        {
            if (b9 == 0)
            {
                contador = contador + 1;
                Btn_B9.BackColor = Color.LawnGreen; ;
                b1 = b1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B9.BackColor = Color.White; ;
                b9 = 0;
            }
        }

        private void Btn_B10_Click(object sender, EventArgs e)
        {
            if (b10 == 0)
            {
                contador = contador + 1;
                Btn_B10.BackColor = Color.LawnGreen; ;
                b10 = b10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B10.BackColor = Color.White; ;
                b10 = 0;
            }
        }

        private void Btn_C1_Click(object sender, EventArgs e)
        {
            if (c1 == 0)
            {
                contador = contador + 1;
                Btn_C1.BackColor = Color.LawnGreen; ;
                c1 = c1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C1.BackColor = Color.White; ;
                c1 = 0;
            }
        }

        private void Btn_A3_Click(object sender, EventArgs e)
        {
            if (a3 == 0)
            {
                contador = contador + 1;
                Btn_A3.BackColor = Color.LawnGreen; ;
                a3 = a3 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A3.BackColor = Color.White; ;
                a3 = 0;
            }
        }

        private void Btn_A4_Click(object sender, EventArgs e)
        {
            if (a4 == 0)
            {
                contador = contador + 1;
                Btn_A4.BackColor = Color.LawnGreen; ;
                a4 = a4 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A4.BackColor = Color.White; ;
                a4 = 0;
            }
        }

        private void Btn_A5_Click(object sender, EventArgs e)
        {
            if (a5 == 0)
            {
                contador = contador + 1;
                Btn_A5.BackColor = Color.LawnGreen; ;
                a5 = a5 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A5.BackColor = Color.White; ;
                a5 = 0;
            }
        }

        private void Btn_A6_Click(object sender, EventArgs e)
        {
            if (a6 == 0)
            {
                contador = contador + 1;
                Btn_A6.BackColor = Color.LawnGreen; ;
                a6 = a6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A6.BackColor = Color.White; ;
                a6 = 0;
            }
        }

        private void Btn_A7_Click(object sender, EventArgs e)
        {
            if (a7 == 0)
            {
                contador = contador + 1;
                Btn_A7.BackColor = Color.LawnGreen; ;
                a7 = a7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A7.BackColor = Color.White; ;
                a7 = 0;
            }
        }

        private void Btn_A8_Click(object sender, EventArgs e)
        {
            if (a8 == 0)
            {
                contador = contador + 1;
                Btn_A8.BackColor = Color.LawnGreen; ;
                a8 = a8 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A8.BackColor = Color.White; ;
                a8 = 0;
            }
        }

        private void Btn_A9_Click(object sender, EventArgs e)
        {
            if (a9 == 0)
            {
                contador = contador + 1;
                Btn_A9.BackColor = Color.LawnGreen; ;
                a9 = a9 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A9.BackColor = Color.White; ;
                a9 = 0;
            }
        }

        private void Btn_A10_Click(object sender, EventArgs e)
        {
            if (a10 == 0)
            {
                contador = contador + 1;
                Btn_A1.BackColor = Color.LawnGreen; ;
                a10 = a10 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A10.BackColor = Color.White; ;
                a10 = 0;
            }
        }

        private void Btn_B1_Click(object sender, EventArgs e)
        {
            if (b1 == 0)
            {
                contador = contador + 1;
                Btn_B1.BackColor = Color.LawnGreen; ;
                b1 = b1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_B1.BackColor = Color.White; ;
                b1 = 0;
            }
        }

        public Frm_asientos()
        {
            InitializeComponent();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (c6 == 0)
            {
                contador = contador + 1;
                Btn_C6.BackColor = Color.LawnGreen; ;
                c6 = c6 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C6.BackColor = Color.White; ;
                c6 = 0;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (c7 == 0)
            {
                contador = contador + 1;
                Btn_C7.BackColor = Color.LawnGreen; ;
                c7 = c7 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_C7.BackColor = Color.White;
                c7 = 0;

            }
        }

            private void Btn_confirmar_Click(object sender, EventArgs e)
        {
           int prueba= int.Parse(Txt_asientos.Text);




            if (contador > 0 && contador == prueba)
            {
                Form formulariopag = new Frm_pago();
                formulariopag.Show();
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
                Btn_A1.BackColor = Color.White; Btn_A2.BackColor = Color.White; Btn_A3.BackColor = Color.White; Btn_A4.BackColor = Color.White; Btn_A5.BackColor = Color.White;
                Btn_A6.BackColor = Color.White; Btn_A7.BackColor = Color.White; Btn_A8.BackColor = Color.White; Btn_A9.BackColor = Color.White; Btn_A10.BackColor = Color.White;
                Btn_B1.BackColor = Color.White; Btn_B2.BackColor = Color.White; Btn_B3.BackColor = Color.White; Btn_B4.BackColor = Color.White; Btn_B5.BackColor = Color.White;
                Btn_B6.BackColor = Color.White; Btn_B7.BackColor = Color.White; Btn_B8.BackColor = Color.White; Btn_B9.BackColor = Color.White; Btn_B10.BackColor = Color.White;
                Btn_C1.BackColor = Color.White; Btn_C2.BackColor = Color.White; Btn_C3.BackColor = Color.White; Btn_C4.BackColor = Color.White; Btn_C5.BackColor = Color.White;
                Btn_C6.BackColor = Color.White; Btn_C7.BackColor = Color.White; Btn_C8.BackColor = Color.White; Btn_C9.BackColor = Color.White; Btn_C10.BackColor = Color.White;
                Btn_D1.BackColor = Color.White; Btn_D2.BackColor = Color.White; Btn_D3.BackColor = Color.White; Btn_D4.BackColor = Color.White; Btn_D5.BackColor = Color.White;
                Btn_D6.BackColor = Color.White; Btn_D7.BackColor = Color.White; Btn_D8.BackColor = Color.White; Btn_D9.BackColor = Color.White; Btn_D10.BackColor = Color.White;
                Btn_E1.BackColor = Color.White; Btn_E2.BackColor = Color.White; Btn_E3.BackColor = Color.White; Btn_E4.BackColor = Color.White; Btn_E5.BackColor = Color.White;
                Btn_E6.BackColor = Color.White; Btn_E7.BackColor = Color.White; Btn_E8.BackColor = Color.White; Btn_E9.BackColor = Color.White; Btn_E10.BackColor = Color.White;
                Btn_F1.BackColor = Color.White; Btn_F2.BackColor = Color.White; Btn_F3.BackColor = Color.White; Btn_F4.BackColor = Color.White; Btn_F5.BackColor = Color.White;
                Btn_E10.BackColor = Color.White; Btn_F7.BackColor = Color.White; Btn_F8.BackColor = Color.White; Btn_F9.BackColor = Color.White; Btn_F10.BackColor = Color.White;
                Btn_H1.BackColor = Color.White; Btn_H2.BackColor = Color.White; Btn_H3.BackColor = Color.White; Btn_H4.BackColor = Color.White; Btn_H5.BackColor = Color.White;
                Btn_H6.BackColor = Color.White; Btn_H7.BackColor = Color.White; Btn_H8.BackColor = Color.White; Btn_H9.BackColor = Color.White; Btn_H10.BackColor = Color.White;
                Btn_I1.BackColor = Color.White; Btn_I2.BackColor = Color.White; Btn_I3.BackColor = Color.White; Btn_I4.BackColor = Color.White; Btn_I5.BackColor = Color.White;
                Btn_I6.BackColor = Color.White; Btn_I7.BackColor = Color.White; Btn_I8.BackColor = Color.White; Btn_I9.BackColor = Color.White; Btn_I10.BackColor = Color.White;
            }
           
        }
        private void Btn_A1_Click(object sender, EventArgs e)
        {
            if (a1 == 0)
            {
                contador = contador + 1;
                Btn_A1.BackColor = Color.LawnGreen; ;
                a1 = a1 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A1.BackColor = Color.White; ;
                a1 = 0;
            }
        }

        private void Btn_A2_Click(object sender, EventArgs e)
        {
            if (a2 == 0)
            {
                contador = contador + 1;
                Btn_A2.BackColor = Color.LawnGreen; ;
                a2 = a2 + 1;
            }
            else
            {
                contador = contador - 1;
                Btn_A2.BackColor = Color.White; ;
                a2 = 0;
            }
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
