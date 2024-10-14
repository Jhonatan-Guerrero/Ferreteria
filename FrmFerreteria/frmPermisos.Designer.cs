namespace FrmFerreteria
{
    partial class frmPermisos
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
            this.btnGuardarPermisos = new System.Windows.Forms.Button();
            this.cmbActualizacion = new System.Windows.Forms.ComboBox();
            this.cmbEliminacion = new System.Windows.Forms.ComboBox();
            this.cmbEscritura = new System.Windows.Forms.ComboBox();
            this.cmbLectura = new System.Windows.Forms.ComboBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dtgvPermisos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarPermisos
            // 
            this.btnGuardarPermisos.Location = new System.Drawing.Point(948, 413);
            this.btnGuardarPermisos.Name = "btnGuardarPermisos";
            this.btnGuardarPermisos.Size = new System.Drawing.Size(139, 36);
            this.btnGuardarPermisos.TabIndex = 42;
            this.btnGuardarPermisos.Text = "GuardarPermisos";
            this.btnGuardarPermisos.UseVisualStyleBackColor = true;
            this.btnGuardarPermisos.Click += new System.EventHandler(this.btnGuardarPermisos_Click);
            // 
            // cmbActualizacion
            // 
            this.cmbActualizacion.FormattingEnabled = true;
            this.cmbActualizacion.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbActualizacion.Location = new System.Drawing.Point(939, 188);
            this.cmbActualizacion.Name = "cmbActualizacion";
            this.cmbActualizacion.Size = new System.Drawing.Size(148, 24);
            this.cmbActualizacion.TabIndex = 41;
            // 
            // cmbEliminacion
            // 
            this.cmbEliminacion.FormattingEnabled = true;
            this.cmbEliminacion.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbEliminacion.Location = new System.Drawing.Point(939, 134);
            this.cmbEliminacion.Name = "cmbEliminacion";
            this.cmbEliminacion.Size = new System.Drawing.Size(148, 24);
            this.cmbEliminacion.TabIndex = 40;
            // 
            // cmbEscritura
            // 
            this.cmbEscritura.FormattingEnabled = true;
            this.cmbEscritura.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbEscritura.Location = new System.Drawing.Point(939, 73);
            this.cmbEscritura.Name = "cmbEscritura";
            this.cmbEscritura.Size = new System.Drawing.Size(148, 24);
            this.cmbEscritura.TabIndex = 39;
            // 
            // cmbLectura
            // 
            this.cmbLectura.FormattingEnabled = true;
            this.cmbLectura.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbLectura.Location = new System.Drawing.Point(939, 12);
            this.cmbLectura.Name = "cmbLectura";
            this.cmbLectura.Size = new System.Drawing.Size(148, 24);
            this.cmbLectura.TabIndex = 38;
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.Size = new System.Drawing.Size(347, 386);
            this.dtgvUsuarios.TabIndex = 36;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // dtgvPermisos
            // 
            this.dtgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPermisos.Location = new System.Drawing.Point(377, 12);
            this.dtgvPermisos.Name = "dtgvPermisos";
            this.dtgvPermisos.Size = new System.Drawing.Size(344, 386);
            this.dtgvPermisos.TabIndex = 43;
            this.dtgvPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPermisos_CellClick);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 461);
            this.Controls.Add(this.dtgvPermisos);
            this.Controls.Add(this.btnGuardarPermisos);
            this.Controls.Add(this.cmbActualizacion);
            this.Controls.Add(this.cmbEliminacion);
            this.Controls.Add(this.cmbEscritura);
            this.Controls.Add(this.cmbLectura);
            this.Controls.Add(this.dtgvUsuarios);
            this.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPermisos";
            this.Text = "frmPermisos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPermisos;
        private System.Windows.Forms.ComboBox cmbActualizacion;
        private System.Windows.Forms.ComboBox cmbEliminacion;
        private System.Windows.Forms.ComboBox cmbEscritura;
        private System.Windows.Forms.ComboBox cmbLectura;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.DataGridView dtgvPermisos;
    }
}