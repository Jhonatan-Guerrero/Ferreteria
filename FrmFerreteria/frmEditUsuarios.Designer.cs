namespace FrmFerreteria
{
    partial class frmEditUsuarios
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
            this.dtgvModificarU = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModificarU)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvModificarU
            // 
            this.dtgvModificarU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvModificarU.Location = new System.Drawing.Point(12, 70);
            this.dtgvModificarU.Name = "dtgvModificarU";
            this.dtgvModificarU.Size = new System.Drawing.Size(763, 329);
            this.dtgvModificarU.TabIndex = 0;
            this.dtgvModificarU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEliminarU_CellClick);
            this.dtgvModificarU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEliminarU_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(632, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 25);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEditUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgvModificarU);
            this.Name = "frmEditUsuarios";
            this.Text = "frmEditUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModificarU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvModificarU;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}