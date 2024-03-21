namespace construir_app
{
    partial class frmDiscos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscos));
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.lblGrilla = new System.Windows.Forms.Label();
            this.lblTapaDisco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.GridColor = System.Drawing.Color.SlateBlue;
            this.dgvDiscos.Location = new System.Drawing.Point(29, 86);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.RowHeadersWidth = 62;
            this.dgvDiscos.RowTemplate.Height = 28;
            this.dgvDiscos.Size = new System.Drawing.Size(854, 472);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbxDisco
            // 
            this.pbxDisco.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pbxDisco.Location = new System.Drawing.Point(931, 84);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(475, 475);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 1;
            this.pbxDisco.TabStop = false;
            // 
            // lblGrilla
            // 
            this.lblGrilla.AutoSize = true;
            this.lblGrilla.BackColor = System.Drawing.Color.Transparent;
            this.lblGrilla.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrilla.Location = new System.Drawing.Point(30, 22);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(126, 44);
            this.lblGrilla.TabIndex = 2;
            this.lblGrilla.Text = "Discos";
            // 
            // lblTapaDisco
            // 
            this.lblTapaDisco.AutoSize = true;
            this.lblTapaDisco.BackColor = System.Drawing.Color.Transparent;
            this.lblTapaDisco.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTapaDisco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTapaDisco.Location = new System.Drawing.Point(933, 22);
            this.lblTapaDisco.Name = "lblTapaDisco";
            this.lblTapaDisco.Size = new System.Drawing.Size(97, 44);
            this.lblTapaDisco.TabIndex = 3;
            this.lblTapaDisco.Text = "Tapa";
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1441, 624);
            this.Controls.Add(this.lblTapaDisco);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.dgvDiscos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1463, 680);
            this.MinimumSize = new System.Drawing.Size(1463, 680);
            this.Name = "frmDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.frmDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.Label lblGrilla;
        private System.Windows.Forms.Label lblTapaDisco;
    }
}

