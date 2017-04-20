namespace VotoElectronico.Desktop
{
    partial class FRMResultadosVotacion
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
            this.dgvResultadoVotaciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoVotaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultadoVotaciones
            // 
            this.dgvResultadoVotaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoVotaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvResultadoVotaciones.Location = new System.Drawing.Point(12, 12);
            this.dgvResultadoVotaciones.Name = "dgvResultadoVotaciones";
            this.dgvResultadoVotaciones.Size = new System.Drawing.Size(482, 390);
            this.dgvResultadoVotaciones.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre Candidato";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total de Votos";
            this.Column2.Name = "Column2";
            // 
            // FRMResultadosVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 420);
            this.Controls.Add(this.dgvResultadoVotaciones);
            this.Name = "FRMResultadosVotacion";
            this.Text = "Resultados Votacion";
            this.Load += new System.EventHandler(this.FRMResultadosVotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoVotaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultadoVotaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}