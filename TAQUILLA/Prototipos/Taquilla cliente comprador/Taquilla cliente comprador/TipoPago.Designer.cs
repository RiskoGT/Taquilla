namespace Taquilla_cliente_comprador
{
    partial class frmTipoPago
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPago));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lbtiempo2 = new System.Windows.Forms.Label();
			this.lbltipo = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btPago = new System.Windows.Forms.Button();
			this.btReservar = new System.Windows.Forms.Button();
			this.lbtipo = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.615384F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92307F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.615384F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.lbtipo, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.30189F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
			this.tableLayoutPanel2.Controls.Add(this.button1, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(94, 146);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 7;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.51802F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.91967F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.86254F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.560137F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.02406F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.91967F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.673621F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(609, 291);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gold;
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(15, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(578, 61);
			this.button1.TabIndex = 4;
			this.button1.Text = "Regresar";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 5;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.020202F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.020202F));
			this.tableLayoutPanel3.Controls.Add(this.lbtiempo2, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.lbltipo, 1, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 45);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// lbtiempo2
			// 
			this.lbtiempo2.AutoSize = true;
			this.lbtiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtiempo2.ForeColor = System.Drawing.Color.White;
			this.lbtiempo2.Location = new System.Drawing.Point(305, 0);
			this.lbtiempo2.Name = "lbtiempo2";
			this.lbtiempo2.Size = new System.Drawing.Size(25, 25);
			this.lbtiempo2.TabIndex = 3;
			this.lbtiempo2.Text = "0";
			this.lbtiempo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbltipo
			// 
			this.lbltipo.AutoSize = true;
			this.lbltipo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltipo.Location = new System.Drawing.Point(14, 0);
			this.lbltipo.Name = "lbltipo";
			this.lbltipo.Size = new System.Drawing.Size(256, 43);
			this.lbltipo.TabIndex = 4;
			this.lbltipo.Text = "Tiempo";
			this.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 5;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.020202F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.020202F));
			this.tableLayoutPanel4.Controls.Add(this.btPago, 3, 1);
			this.tableLayoutPanel4.Controls.Add(this.btReservar, 1, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 62);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(578, 110);
			this.tableLayoutPanel4.TabIndex = 6;
			// 
			// btPago
			// 
			this.btPago.BackColor = System.Drawing.Color.Gold;
			this.btPago.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPago.Location = new System.Drawing.Point(305, 5);
			this.btPago.Name = "btPago";
			this.btPago.Size = new System.Drawing.Size(256, 99);
			this.btPago.TabIndex = 1;
			this.btPago.Text = "Pago";
			this.btPago.UseVisualStyleBackColor = false;
			this.btPago.Click += new System.EventHandler(this.BtPago_Click);
			// 
			// btReservar
			// 
			this.btReservar.BackColor = System.Drawing.Color.Gold;
			this.btReservar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btReservar.Location = new System.Drawing.Point(14, 5);
			this.btReservar.Name = "btReservar";
			this.btReservar.Size = new System.Drawing.Size(256, 99);
			this.btReservar.TabIndex = 0;
			this.btReservar.Text = "Reservar";
			this.btReservar.UseVisualStyleBackColor = false;
			this.btReservar.Click += new System.EventHandler(this.BtReservar_Click);
			// 
			// lbtipo
			// 
			this.lbtipo.AutoSize = true;
			this.lbtipo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtipo.ForeColor = System.Drawing.Color.Gold;
			this.lbtipo.Location = new System.Drawing.Point(94, 8);
			this.lbtipo.Name = "lbtipo";
			this.lbtipo.Size = new System.Drawing.Size(609, 127);
			this.lbtipo.TabIndex = 1;
			this.lbtipo.Text = "Tipo de Pago";
			this.lbtipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTipoPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmTipoPago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tipo de Pago";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTipoPago_FormClosed);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btReservar;
        private System.Windows.Forms.Button btPago;
        private System.Windows.Forms.Label lbtipo;
        private System.Windows.Forms.Label lbtiempo2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}