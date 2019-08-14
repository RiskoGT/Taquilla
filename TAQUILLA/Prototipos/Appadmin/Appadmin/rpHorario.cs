/*
 * Integrantes a Cargo:
 * 0901-16-1288 Randy Choc
 * 
 * Randy creo el form con los respectivos elementos
 * Randy agrego diseño y codigo al boton CONSULTAR 
 */
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using Appadmin;

namespace WindowsFormsAppPruebas
{
    public partial class rpHorario : Form
    {
        public rpHorario()
        {
            InitializeComponent();
            txtInicio.Text = "";
            txtFin.Text = "";
            comboMes.Refresh();
        }
        private void RpHorario_Load(object sender, EventArgs e)
        {            
            rpHorario horario = new rpHorario();              
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //validaciones para seleccionar los rangos de fecha segun el mes ingresado 
            if (comboMes.Text == "Enero")
            {
                txtInicio.Text = "2019-01-01";
                txtFin.Text = "2019-01-31";
            }
            else if (comboMes.Text == "Febrero")
            {
                txtInicio.Text = "2019-02-01";
                txtFin.Text = "2019-02-28";
            } else if (comboMes.Text == "Marzo")
            {
                txtInicio.Text = "2019-03-01";
                txtFin.Text = "2019-03-31";
            }
            else if (comboMes.Text == "Abril")
            {
                txtInicio.Text = "2019-04-01";
                txtFin.Text = "2019-04-30";
            } else if (comboMes.Text == "Mayo")
            {
                txtInicio.Text = "2019-05-01";
                txtFin.Text = "2019-05-31";
            }
            else if (comboMes.Text == "Junio")
            {
                txtInicio.Text = "2019-06-01";
                txtFin.Text = "2019-06-30";
            } else if (comboMes.Text == "Julio")
            {
                txtInicio.Text = "2019-07-01";
                txtFin.Text = "2019-07-31";
            } else if (comboMes.Text == "Agosto")
            {
                txtInicio.Text = "2019-08-01";
                txtFin.Text = "2019-08-31";
            }
            else if (comboMes.Text == "Septiembre")
            {
                txtInicio.Text = "2019-09-01";
                txtFin.Text = "2019-09-30";
            }
            else if (comboMes.Text == "Octubre")
            {
                txtInicio.Text = "2019-10-01";
                txtFin.Text = "2019-10-31";
            }
            else if (comboMes.Text == "Noviembre")
            {
                txtInicio.Text = "2019-11-01";
                txtFin.Text = "2019-11-30";
            }
            else if (comboMes.Text == "Diciembre")
            {
                txtInicio.Text = "2019-12-01";
                txtFin.Text = "2019-12-31";
            }
            //Creamos el objeto que apuntara al reporte de crystal en mi caso ganancias.rpt
            ganancias crystalrpt = new ganancias();            
            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto que contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            try
            {
                //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
                pdv.Value = DateTime.Parse(txtInicio.Text);
                pfds = crystalrpt.DataDefinition.ParameterFields;
                pfd = pfds["date1"];
                pvs.Add(pdv);
                pfd.ApplyCurrentValues(pvs);

                //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
                pdv.Value = DateTime.Parse(txtFin.Text);
                pfds = crystalrpt.DataDefinition.ParameterFields;
                pfd = pfds["date2"];
                pvs.Add(pdv);
                pfd.ApplyCurrentValues(pvs);

                //aqui pasamos el tercer valor del textbox y el nombre del tercer parametro
                pdv.Value = comboMes.Text;
                pfds = crystalrpt.DataDefinition.ParameterFields;
                pfd = pfds["mes"];
                pvs.Add(pdv);
                pfd.ApplyCurrentValues(pvs);

                crystalReportViewer1.ReportSource = crystalrpt;
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Show();

                txtInicio.Text = "";
                txtFin.Text = "";
                comboMes.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un Mes!", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInicio.Text = "";
                txtFin.Text = "";
                comboMes.Refresh();
            }            
        }
        private void LbVentasPorMes_Click(object sender, EventArgs e)
        {
        }
    }
}