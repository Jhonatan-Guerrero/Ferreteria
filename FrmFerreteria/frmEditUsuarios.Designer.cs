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
            this.dtgvEliminarU = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEliminarU)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEliminarU
            // 
            this.dtgvEliminarU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEliminarU.Location = new System.Drawing.Point(12, 70);
            this.dtgvEliminarU.Name = "dtgvEliminarU";
            this.dtgvEliminarU.Size = new System.Drawing.Size(763, 329);
            this.dtgvEliminarU.TabIndex = 0;
            this.dtgvEliminarU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEliminarU_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmEditUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgvEliminarU);
            this.Name = "frmEditUsuarios";
            this.Text = "frmEditUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEliminarU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEliminarU;
        private System.Windows.Forms.TextBox textBox1;
    }
}