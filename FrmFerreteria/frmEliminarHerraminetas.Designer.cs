namespace FrmFerreteria
{
    partial class frmEliminarHerraminetas
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
            this.txtHerramientas = new System.Windows.Forms.TextBox();
            this.dtgvHerramientas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHerramientas
            // 
            this.txtHerramientas.Location = new System.Drawing.Point(187, 52);
            this.txtHerramientas.Name = "txtHerramientas";
            this.txtHerramientas.Size = new System.Drawing.Size(475, 20);
            this.txtHerramientas.TabIndex = 0;
            this.txtHerramientas.TextChanged += new System.EventHandler(this.txtHerramientas_TextChanged);
            // 
            // dtgvHerramientas
            // 
            this.dtgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHerramientas.Location = new System.Drawing.Point(38, 112);
            this.dtgvHerramientas.Name = "dtgvHerramientas";
            this.dtgvHerramientas.Size = new System.Drawing.Size(624, 231);
            this.dtgvHerramientas.TabIndex = 2;
            this.dtgvHerramientas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHerramientas_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(596, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEliminarHerraminetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgvHerramientas);
            this.Controls.Add(this.txtHerramientas);
            this.Name = "frmEliminarHerraminetas";
            this.Text = "frmEliminarHerraminetas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHerramientas;
        private System.Windows.Forms.DataGridView dtgvHerramientas;
        private System.Windows.Forms.Button btnSalir;
    }
}