namespace VotoElectronico.Desktop
{
    partial class FRMRegistrarActualizarAntecedente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCrime = new System.Windows.Forms.TextBox();
            this.btnRegistrarAntecedente = new System.Windows.Forms.Button();
            this.btnRestablecerFormulario = new System.Windows.Forms.Button();
            this.btnActualizarAntecedentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crimen o Delito Cometido";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(35, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(274, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(315, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(274, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(35, 121);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(270, 20);
            this.txtCedula.TabIndex = 6;
            // 
            // txtCrime
            // 
            this.txtCrime.Location = new System.Drawing.Point(35, 181);
            this.txtCrime.Multiline = true;
            this.txtCrime.Name = "txtCrime";
            this.txtCrime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCrime.Size = new System.Drawing.Size(554, 185);
            this.txtCrime.TabIndex = 7;
            // 
            // btnRegistrarAntecedente
            // 
            this.btnRegistrarAntecedente.Location = new System.Drawing.Point(62, 390);
            this.btnRegistrarAntecedente.Name = "btnRegistrarAntecedente";
            this.btnRegistrarAntecedente.Size = new System.Drawing.Size(230, 58);
            this.btnRegistrarAntecedente.TabIndex = 8;
            this.btnRegistrarAntecedente.Text = "Registrar Antecedente";
            this.btnRegistrarAntecedente.UseVisualStyleBackColor = true;
            this.btnRegistrarAntecedente.Click += new System.EventHandler(this.btnRegistrarAntecedente_Click);
            // 
            // btnRestablecerFormulario
            // 
            this.btnRestablecerFormulario.Location = new System.Drawing.Point(313, 390);
            this.btnRestablecerFormulario.Name = "btnRestablecerFormulario";
            this.btnRestablecerFormulario.Size = new System.Drawing.Size(230, 58);
            this.btnRestablecerFormulario.TabIndex = 9;
            this.btnRestablecerFormulario.Text = "Restablecer Formulario";
            this.btnRestablecerFormulario.UseVisualStyleBackColor = true;
            this.btnRestablecerFormulario.Click += new System.EventHandler(this.btnRestablecerFormulario_Click);
            // 
            // btnActualizarAntecedentes
            // 
            this.btnActualizarAntecedentes.Location = new System.Drawing.Point(187, 390);
            this.btnActualizarAntecedentes.Name = "btnActualizarAntecedentes";
            this.btnActualizarAntecedentes.Size = new System.Drawing.Size(230, 58);
            this.btnActualizarAntecedentes.TabIndex = 10;
            this.btnActualizarAntecedentes.Text = "Actualizar Antecedentes";
            this.btnActualizarAntecedentes.UseVisualStyleBackColor = true;
            this.btnActualizarAntecedentes.Click += new System.EventHandler(this.btnActualizarAntecedentes_Click);
            // 
            // FRMRegistrarActualizarAntecedente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 492);
            this.Controls.Add(this.btnActualizarAntecedentes);
            this.Controls.Add(this.btnRestablecerFormulario);
            this.Controls.Add(this.btnRegistrarAntecedente);
            this.Controls.Add(this.txtCrime);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMRegistrarActualizarAntecedente";
            this.Text = " Antecedentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCrime;
        private System.Windows.Forms.Button btnRegistrarAntecedente;
        private System.Windows.Forms.Button btnRestablecerFormulario;
        private System.Windows.Forms.Button btnActualizarAntecedentes;
    }
}