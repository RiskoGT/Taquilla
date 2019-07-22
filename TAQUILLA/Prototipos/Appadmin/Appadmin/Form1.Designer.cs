namespace Appadmin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Ayuda = new System.Windows.Forms.Button();
            this.gestionUsuarios = new System.Windows.Forms.Button();
            this.informes = new System.Windows.Forms.Button();
            this.gestionCartelera = new System.Windows.Forms.Button();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.tableLayoutPanel1);
            this.panelPrincipal.Controls.Add(this.barraTitulo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(731, 478);
            this.panelPrincipal.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.11962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88038F));
            this.tableLayoutPanel1.Controls.Add(this.Ayuda, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gestionUsuarios, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.informes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gestionCartelera, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 422);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Ayuda
            // 
            this.Ayuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ayuda.BackgroundImage")));
            this.Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ayuda.ForeColor = System.Drawing.Color.White;
            this.Ayuda.Location = new System.Drawing.Point(549, 2);
            this.Ayuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(180, 418);
            this.Ayuda.TabIndex = 3;
            this.Ayuda.UseVisualStyleBackColor = true;
            // 
            // gestionUsuarios
            // 
            this.gestionUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gestionUsuarios.BackgroundImage")));
            this.gestionUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gestionUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gestionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.gestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.gestionUsuarios.Location = new System.Drawing.Point(366, 2);
            this.gestionUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gestionUsuarios.Name = "gestionUsuarios";
            this.gestionUsuarios.Size = new System.Drawing.Size(179, 418);
            this.gestionUsuarios.TabIndex = 2;
            this.gestionUsuarios.UseVisualStyleBackColor = true;
            this.gestionUsuarios.Click += new System.EventHandler(this.GestionUsuarios_Click);
            // 
            // informes
            // 
            this.informes.BackColor = System.Drawing.Color.Transparent;
            this.informes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("informes.BackgroundImage")));
            this.informes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.informes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.informes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informes.ForeColor = System.Drawing.Color.White;
            this.informes.Location = new System.Drawing.Point(184, 2);
            this.informes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.informes.Name = "informes";
            this.informes.Size = new System.Drawing.Size(178, 418);
            this.informes.TabIndex = 1;
            this.informes.UseVisualStyleBackColor = false;
            this.informes.Click += new System.EventHandler(this.button2_Click);
            // 
            // gestionCartelera
            // 
            this.gestionCartelera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gestionCartelera.BackgroundImage")));
            this.gestionCartelera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gestionCartelera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gestionCartelera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.gestionCartelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionCartelera.ForeColor = System.Drawing.Color.White;
            this.gestionCartelera.Location = new System.Drawing.Point(2, 2);
            this.gestionCartelera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gestionCartelera.Name = "gestionCartelera";
            this.gestionCartelera.Size = new System.Drawing.Size(178, 418);
            this.gestionCartelera.TabIndex = 0;
            this.gestionCartelera.UseVisualStyleBackColor = true;
            this.gestionCartelera.Click += new System.EventHandler(this.button1_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.Gray;
            this.barraTitulo.Controls.Add(this.panel1);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(731, 56);
            this.barraTitulo.TabIndex = 2;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 72);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 56);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 56);
            this.panel3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 56);
            this.label1.TabIndex = 37;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(686, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(45, 56);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 56);
            this.label2.TabIndex = 36;
            this.label2.Text = "GESTIONES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(731, 478);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelPrincipal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.barraTitulo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button gestionCartelera;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button gestionUsuarios;
        private System.Windows.Forms.Button informes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

