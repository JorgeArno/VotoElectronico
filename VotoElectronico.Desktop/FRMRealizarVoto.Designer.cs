namespace VotoElectronico.Desktop
{
    partial class FRMRealizarVoto
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
            this.btnVotar = new System.Windows.Forms.Button();
            this.rbtnPrimerCandidato = new System.Windows.Forms.RadioButton();
            this.rbtnTercerCandidato = new System.Windows.Forms.RadioButton();
            this.rbtnQuintoCandidato = new System.Windows.Forms.RadioButton();
            this.rbtnSegundoCandidato = new System.Windows.Forms.RadioButton();
            this.rbtnCuartoCandidato = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.Location = new System.Drawing.Point(88, 258);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(200, 78);
            this.btnVotar.TabIndex = 0;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // rbtnPrimerCandidato
            // 
            this.rbtnPrimerCandidato.AutoSize = true;
            this.rbtnPrimerCandidato.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPrimerCandidato.Location = new System.Drawing.Point(20, 54);
            this.rbtnPrimerCandidato.Name = "rbtnPrimerCandidato";
            this.rbtnPrimerCandidato.Size = new System.Drawing.Size(135, 19);
            this.rbtnPrimerCandidato.TabIndex = 1;
            this.rbtnPrimerCandidato.TabStop = true;
            this.rbtnPrimerCandidato.Text = "Primer Candidato";
            this.rbtnPrimerCandidato.UseVisualStyleBackColor = true;
            // 
            // rbtnTercerCandidato
            // 
            this.rbtnTercerCandidato.AutoSize = true;
            this.rbtnTercerCandidato.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTercerCandidato.Location = new System.Drawing.Point(20, 91);
            this.rbtnTercerCandidato.Name = "rbtnTercerCandidato";
            this.rbtnTercerCandidato.Size = new System.Drawing.Size(131, 19);
            this.rbtnTercerCandidato.TabIndex = 2;
            this.rbtnTercerCandidato.TabStop = true;
            this.rbtnTercerCandidato.Text = "Tercer Candidato";
            this.rbtnTercerCandidato.UseVisualStyleBackColor = true;
            // 
            // rbtnQuintoCandidato
            // 
            this.rbtnQuintoCandidato.AutoSize = true;
            this.rbtnQuintoCandidato.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQuintoCandidato.Location = new System.Drawing.Point(20, 128);
            this.rbtnQuintoCandidato.Name = "rbtnQuintoCandidato";
            this.rbtnQuintoCandidato.Size = new System.Drawing.Size(136, 19);
            this.rbtnQuintoCandidato.TabIndex = 3;
            this.rbtnQuintoCandidato.TabStop = true;
            this.rbtnQuintoCandidato.Text = "Quinto Candidato";
            this.rbtnQuintoCandidato.UseVisualStyleBackColor = true;
            // 
            // rbtnSegundoCandidato
            // 
            this.rbtnSegundoCandidato.AutoSize = true;
            this.rbtnSegundoCandidato.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSegundoCandidato.Location = new System.Drawing.Point(185, 54);
            this.rbtnSegundoCandidato.Name = "rbtnSegundoCandidato";
            this.rbtnSegundoCandidato.Size = new System.Drawing.Size(145, 19);
            this.rbtnSegundoCandidato.TabIndex = 4;
            this.rbtnSegundoCandidato.TabStop = true;
            this.rbtnSegundoCandidato.Text = "Segundo Candidato";
            this.rbtnSegundoCandidato.UseVisualStyleBackColor = true;
            // 
            // rbtnCuartoCandidato
            // 
            this.rbtnCuartoCandidato.AutoSize = true;
            this.rbtnCuartoCandidato.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCuartoCandidato.Location = new System.Drawing.Point(185, 91);
            this.rbtnCuartoCandidato.Name = "rbtnCuartoCandidato";
            this.rbtnCuartoCandidato.Size = new System.Drawing.Size(135, 19);
            this.rbtnCuartoCandidato.TabIndex = 5;
            this.rbtnCuartoCandidato.TabStop = true;
            this.rbtnCuartoCandidato.Text = "Cuarto Candidato";
            this.rbtnCuartoCandidato.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPrimerCandidato);
            this.groupBox1.Controls.Add(this.rbtnCuartoCandidato);
            this.groupBox1.Controls.Add(this.rbtnTercerCandidato);
            this.groupBox1.Controls.Add(this.rbtnSegundoCandidato);
            this.groupBox1.Controls.Add(this.rbtnQuintoCandidato);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidatos";
            // 
            // FRMRealizarVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVotar);
            this.Name = "FRMRealizarVoto";
            this.Text = "Realizar Voto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.RadioButton rbtnPrimerCandidato;
        private System.Windows.Forms.RadioButton rbtnTercerCandidato;
        private System.Windows.Forms.RadioButton rbtnQuintoCandidato;
        private System.Windows.Forms.RadioButton rbtnSegundoCandidato;
        private System.Windows.Forms.RadioButton rbtnCuartoCandidato;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}