namespace WindowsFormsAppPruebas
{
    partial class rpHorario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMes = new System.Windows.Forms.Label();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.lbVentasPorMes = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(831, 392);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(518, 68);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(153, 38);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Reporte";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.txtFin);
            this.panel1.Controls.Add(this.txtInicio);
            this.panel1.Controls.Add(this.lbVentasPorMes);
            this.panel1.Controls.Add(this.comboMes);
            this.panel1.Controls.Add(this.lbMes);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 127);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 392);
            this.panel2.TabIndex = 3;
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMes.Location = new System.Drawing.Point(129, 75);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(134, 23);
            this.lbMes.TabIndex = 5;
            this.lbMes.Text = "Seleccione un Mes: ";
            // 
            // comboMes
            // 
            this.comboMes.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboMes.Location = new System.Drawing.Point(269, 75);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(210, 31);
            this.comboMes.TabIndex = 6;
            // 
            // lbVentasPorMes
            // 
            this.lbVentasPorMes.AutoSize = true;
            this.lbVentasPorMes.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasPorMes.ForeColor = System.Drawing.Color.Yellow;
            this.lbVentasPorMes.Location = new System.Drawing.Point(292, 19);
            this.lbVentasPorMes.Name = "lbVentasPorMes";
            this.lbVentasPorMes.Size = new System.Drawing.Size(275, 32);
            this.lbVentasPorMes.TabIndex = 7;
            this.lbVentasPorMes.Text = "Reporte VENTAS POR MES";
            this.lbVentasPorMes.Click += new System.EventHandler(this.LbVentasPorMes_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(13, 48);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 8;
            this.txtInicio.Visible = false;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(13, 75);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 20);
            this.txtFin.TabIndex = 9;
            this.txtFin.Visible = false;
            // 
            // rpHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "rpHorario";
            this.Text = "Reporte VENTAS POR MES";
            this.Load += new System.EventHandler(this.RpHorario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbVentasPorMes;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFin;
    }
}