namespace Appadmin
{
    partial class Cine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cine));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCine = new System.Windows.Forms.TextBox();
            this.btnAgregarCine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.btnModificarCine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cines";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(58, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cine:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(46, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCine
            // 
            this.txtCine.Location = new System.Drawing.Point(95, 50);
            this.txtCine.Name = "txtCine";
            this.txtCine.Size = new System.Drawing.Size(172, 20);
            this.txtCine.TabIndex = 3;
            this.txtCine.TextChanged += new System.EventHandler(this.TxtCine_TextChanged);
            this.txtCine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCine_KeyPress);
            // 
            // btnAgregarCine
            // 
            this.btnAgregarCine.BackColor = System.Drawing.Color.Gold;
            this.btnAgregarCine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnAgregarCine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCine.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCine.Location = new System.Drawing.Point(323, 31);
            this.btnAgregarCine.Name = "btnAgregarCine";
            this.btnAgregarCine.Size = new System.Drawing.Size(78, 27);
            this.btnAgregarCine.TabIndex = 5;
            this.btnAgregarCine.Text = "Agregar";
            this.btnAgregarCine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCine.UseVisualStyleBackColor = false;
            this.btnAgregarCine.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(323, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(439, 127);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // comboCiudad
            // 
            this.comboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.Location = new System.Drawing.Point(95, 77);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(172, 21);
            this.comboCiudad.TabIndex = 8;
            // 
            // btnModificarCine
            // 
            this.btnModificarCine.BackColor = System.Drawing.Color.Gold;
            this.btnModificarCine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnModificarCine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCine.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCine.Location = new System.Drawing.Point(323, 60);
            this.btnModificarCine.Name = "btnModificarCine";
            this.btnModificarCine.Size = new System.Drawing.Size(78, 27);
            this.btnModificarCine.TabIndex = 9;
            this.btnModificarCine.Text = "Actualizar";
            this.btnModificarCine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarCine.UseVisualStyleBackColor = false;
            this.btnModificarCine.Click += new System.EventHandler(this.btnModificarCine_Click);
            // 
            // Cine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(463, 281);
            this.Controls.Add(this.btnModificarCine);
            this.Controls.Add(this.comboCiudad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarCine);
            this.Controls.Add(this.txtCine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cines";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cine_FormClosed);
            this.Load += new System.EventHandler(this.Cine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCine;
        private System.Windows.Forms.Button btnAgregarCine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.Button btnModificarCine;
    }
}