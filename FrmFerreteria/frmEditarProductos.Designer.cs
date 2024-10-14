namespace FrmFerreteria
{
    partial class frmEditarProductos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(703, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(112, 28);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(645, 20);
            this.txtProductos.TabIndex = 4;
            this.txtProductos.TextChanged += new System.EventHandler(this.txtProductos_TextChanged);
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Location = new System.Drawing.Point(24, 78);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.Size = new System.Drawing.Size(733, 282);
            this.dtgvProductos.TabIndex = 3;
            this.dtgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProductos_CellClick);
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 446);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.dtgvProductos);
            this.Name = "frmEditarProductos";
            this.Text = "frmEditarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.DataGridView dtgvProductos;
    }
}