namespace Taquilla_cliente_comprador
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
			this.tlppanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.tlppanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.ComboSeleccioneCiudad = new System.Windows.Forms.ComboBox();
			this.ComboSeleccioneCine = new System.Windows.Forms.ComboBox();
			this.tlppanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lbTitulo = new System.Windows.Forms.Label();
			this.tlppanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnVerCartelera = new System.Windows.Forms.Button();
			this.tlppanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAyuda = new System.Windows.Forms.Button();
			this.tlppanel6.SuspendLayout();
			this.tlppanel4.SuspendLayout();
			this.tlppanel3.SuspendLayout();
			this.tlppanel1.SuspendLayout();
			this.tlppanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlppanel6
			// 
			this.tlppanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tlppanel6.ColumnCount = 3;
			this.tlppanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlppanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tlppanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlppanel6.Controls.Add(this.tlppanel4, 1, 1);
			this.tlppanel6.Controls.Add(this.tlppanel3, 1, 0);
			this.tlppanel6.Controls.Add(this.tlppanel1, 1, 2);
			this.tlppanel6.Controls.Add(this.tlppanel2, 0, 2);
			this.tlppanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlppanel6.Location = new System.Drawing.Point(0, 0);
			this.tlppanel6.Name = "tlppanel6";
			this.tlppanel6.RowCount = 3;
			this.tlppanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.76768F));
			this.tlppanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
			this.tlppanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
			this.tlppanel6.Size = new System.Drawing.Size(1184, 651);
			this.tlppanel6.TabIndex = 0;
			// 
			// tlppanel4
			// 
			this.tlppanel4.ColumnCount = 4;
			this.tlppanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlppanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlppanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlppanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlppanel4.Controls.Add(this.ComboSeleccioneCiudad, 1, 0);
			this.tlppanel4.Controls.Add(this.ComboSeleccioneCine, 2, 0);
			this.tlppanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlppanel4.Location = new System.Drawing.Point(121, 204);
			this.tlppanel4.Name = "tlppanel4";
			this.tlppanel4.RowCount = 1;
			this.tlppanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlppanel4.Size = new System.Drawing.Size(941, 55);
			this.tlppanel4.TabIndex = 0;
			// 
			// ComboSeleccioneCiudad
			// 
			this.ComboSeleccioneCiudad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ComboSeleccioneCiudad.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboSeleccioneCiudad.FormattingEnabled = true;
			this.ComboSeleccioneCiudad.Location = new System.Drawing.Point(97, 3);
			this.ComboSeleccioneCiudad.Name = "ComboSeleccioneCiudad";
			this.ComboSeleccioneCiudad.Size = new System.Drawing.Size(370, 42);
			this.ComboSeleccioneCiudad.TabIndex = 0;
			this.ComboSeleccioneCiudad.Text = "Seleccione Ciudad";
			this.ComboSeleccioneCiudad.SelectedIndexChanged += new System.EventHandler(this.ComboSeleccioneCiudad_SelectedIndexChanged);
			// 
			// ComboSeleccioneCine
			// 
			this.ComboSeleccioneCine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ComboSeleccioneCine.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboSeleccioneCine.FormattingEnabled = true;
			this.ComboSeleccioneCine.Location = new System.Drawing.Point(473, 3);
			this.ComboSeleccioneCine.Name = "ComboSeleccioneCine";
			this.ComboSeleccioneCine.Size = new System.Drawing.Size(370, 42);
			this.ComboSeleccioneCine.TabIndex = 1;
			this.ComboSeleccioneCine.Text = "Seleccione un cine";
			// 
			// tlppanel3
			// 
			this.tlppanel3.ColumnCount = 3;
			this.tlppanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlppanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tlppanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlppanel3.Controls.Add(this.lbTitulo, 1, 1);
			this.tlppanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlppanel3.Location = new System.Drawing.Point(121, 3);
			this.tlppanel3.Name = "tlppanel3";
			this.tlppanel3.RowCount = 3;
			this.tlppanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlppanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tlppanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlppanel3.Size = new System.Drawing.Size(941, 195);
			this.tlppanel3.TabIndex = 1;
			// 
			// lbTitulo
			// 
			this.lbTitulo.AutoSize = true;
			this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTitulo.Font = new System.Drawing.Font("Agency FB", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitulo.ForeColor = System.Drawing.Color.Gold;
			this.lbTitulo.Location = new System.Drawing.Point(159, 32);
			this.lbTitulo.Name = "lbTitulo";
			this.lbTitulo.Size = new System.Drawing.Size(621, 129);
			this.lbTitulo.TabIndex = 0;
			this.lbTitulo.Text = "Bienvenido ";
			this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlppanel1
			// 
			this.tlppanel1.ColumnCount = 3;
			this.tlppanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.70776F));
			this.tlppanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.99788F));
			this.tlppanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.400638F));
			this.tlppanel1.Controls.Add(this.btnVerCartelera, 1, 1);
			this.tlppanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlppanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tlppanel1.Location = new System.Drawing.Point(121, 265);
			this.tlppanel1.Name = "tlppanel1";
			this.tlppanel1.RowCount = 3;
			this.tlppanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.83425F));
			this.tlppanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16575F));
			this.tlppanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlppanel1.Size = new System.Drawing.Size(941, 383);
			this.tlppanel1.TabIndex = 2;
			this.tlppanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tlppanel1_Paint);
			// 
			// btnVerCartelera
			// 
			this.btnVerCartelera.BackColor = System.Drawing.Color.Gold;
			this.btnVerCartelera.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnVerCartelera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
			this.btnVerCartelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVerCartelera.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerCartelera.Location = new System.Drawing.Point(705, 292);
			this.btnVerCartelera.Name = "btnVerCartelera";
			this.btnVerCartelera.Size = new System.Drawing.Size(200, 67);
			this.btnVerCartelera.TabIndex = 0;
			this.btnVerCartelera.Text = "Siguiente";
			this.btnVerCartelera.UseVisualStyleBackColor = false;
			this.btnVerCartelera.Click += new System.EventHandler(this.Btn_verCartelera_Click);
			// 
			// tlppanel2
			// 
			this.tlppanel2.ColumnCount = 3;
			this.tlppanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
			this.tlppanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
			this.tlppanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
			this.tlppanel2.Controls.Add(this.btnAyuda, 1, 1);
			this.tlppanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlppanel2.Location = new System.Drawing.Point(3, 265);
			this.tlppanel2.Name = "tlppanel2";
			this.tlppanel2.RowCount = 3;
			this.tlppanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.2963F));
			this.tlppanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
			this.tlppanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.18518F));
			this.tlppanel2.Size = new System.Drawing.Size(112, 383);
			this.tlppanel2.TabIndex = 3;
			// 
			// btnAyuda
			// 
			this.btnAyuda.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
			this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAyuda.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAyuda.Location = new System.Drawing.Point(9, 276);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(93, 64);
			this.btnAyuda.TabIndex = 0;
			this.btnAyuda.Text = "Ayuda";
			this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAyuda.UseVisualStyleBackColor = false;
			this.btnAyuda.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1184, 651);
			this.Controls.Add(this.tlppanel6);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MinimumSize = new System.Drawing.Size(1200, 690);
			this.Name = "frmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cine";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_menu_FormClosed);
			this.tlppanel6.ResumeLayout(false);
			this.tlppanel4.ResumeLayout(false);
			this.tlppanel3.ResumeLayout(false);
			this.tlppanel3.PerformLayout();
			this.tlppanel1.ResumeLayout(false);
			this.tlppanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlppanel6;
        private System.Windows.Forms.TableLayoutPanel tlppanel4;
        private System.Windows.Forms.ComboBox ComboSeleccioneCiudad;
        private System.Windows.Forms.ComboBox ComboSeleccioneCine;
        private System.Windows.Forms.TableLayoutPanel tlppanel3;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TableLayoutPanel tlppanel1;
        private System.Windows.Forms.Button btnVerCartelera;
		private System.Windows.Forms.TableLayoutPanel tlppanel2;
		private System.Windows.Forms.Button btnAyuda;
	}
}

