namespace pryClinica_LP3
{
    partial class frmPrincipal
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
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvListaMedicos = new System.Windows.Forms.DataGridView();
            this.btnFrm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(252, 9);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidades.TabIndex = 0;
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Location = new System.Drawing.Point(12, 9);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(146, 13);
            this.lblSeleccione.TabIndex = 1;
            this.lblSeleccione.Text = "Seleccione una especialidad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(298, 52);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvListaMedicos
            // 
            this.dgvListaMedicos.AllowUserToAddRows = false;
            this.dgvListaMedicos.AllowUserToDeleteRows = false;
            this.dgvListaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMedicos.Location = new System.Drawing.Point(15, 81);
            this.dgvListaMedicos.Name = "dgvListaMedicos";
            this.dgvListaMedicos.ReadOnly = true;
            this.dgvListaMedicos.Size = new System.Drawing.Size(358, 150);
            this.dgvListaMedicos.TabIndex = 3;
            // 
            // btnFrm2
            // 
            this.btnFrm2.Location = new System.Drawing.Point(379, 52);
            this.btnFrm2.Name = "btnFrm2";
            this.btnFrm2.Size = new System.Drawing.Size(75, 23);
            this.btnFrm2.TabIndex = 4;
            this.btnFrm2.Text = "frm2";
            this.btnFrm2.UseVisualStyleBackColor = true;
            this.btnFrm2.Click += new System.EventHandler(this.btnFrm2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 330);
            this.Controls.Add(this.btnFrm2);
            this.Controls.Add(this.dgvListaMedicos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.cmbEspecialidades);
            this.Name = "frmPrincipal";
            this.Text = "Consulta de Medicos por Especialidad";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvListaMedicos;
        private System.Windows.Forms.Button btnFrm2;
    }
}

