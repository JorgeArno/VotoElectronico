namespace VotoElectronico.Desktop
{
    partial class frmVotoEletronico
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnRegistrarVotante = new System.Windows.Forms.Button();
            this.btnRegistrarAntecedentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarVotante = new System.Windows.Forms.TextBox();
            this.txtBuscarAntecedente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidarVotante = new System.Windows.Forms.Button();
            this.btnEliminarVotante = new System.Windows.Forms.Button();
            this.btnActualizarVotante = new System.Windows.Forms.Button();
            this.btnBuscarVotante = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAntecedente = new System.Windows.Forms.Button();
            this.btnActualizarAntecedente = new System.Windows.Forms.Button();
            this.btnBuscarAntecedente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 12);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(786, 334);
            this.dgvResults.TabIndex = 0;
            // 
            // btnRegistrarVotante
            // 
            this.btnRegistrarVotante.Location = new System.Drawing.Point(51, 34);
            this.btnRegistrarVotante.Name = "btnRegistrarVotante";
            this.btnRegistrarVotante.Size = new System.Drawing.Size(249, 47);
            this.btnRegistrarVotante.TabIndex = 1;
            this.btnRegistrarVotante.Text = "Registrar Votante";
            this.btnRegistrarVotante.UseVisualStyleBackColor = true;
            this.btnRegistrarVotante.Click += new System.EventHandler(this.btnRegistrarVotante_Click);
            // 
            // btnRegistrarAntecedentes
            // 
            this.btnRegistrarAntecedentes.Location = new System.Drawing.Point(82, 34);
            this.btnRegistrarAntecedentes.Name = "btnRegistrarAntecedentes";
            this.btnRegistrarAntecedentes.Size = new System.Drawing.Size(249, 47);
            this.btnRegistrarAntecedentes.TabIndex = 2;
            this.btnRegistrarAntecedentes.Text = "Registrar Antecedente";
            this.btnRegistrarAntecedentes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Votante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Antecedente";
            // 
            // txtBuscarVotante
            // 
            this.txtBuscarVotante.Location = new System.Drawing.Point(51, 141);
            this.txtBuscarVotante.Name = "txtBuscarVotante";
            this.txtBuscarVotante.Size = new System.Drawing.Size(249, 20);
            this.txtBuscarVotante.TabIndex = 5;
            // 
            // txtBuscarAntecedente
            // 
            this.txtBuscarAntecedente.Location = new System.Drawing.Point(82, 141);
            this.txtBuscarAntecedente.Name = "txtBuscarAntecedente";
            this.txtBuscarAntecedente.Size = new System.Drawing.Size(249, 20);
            this.txtBuscarAntecedente.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValidarVotante);
            this.groupBox1.Controls.Add(this.btnEliminarVotante);
            this.groupBox1.Controls.Add(this.btnActualizarVotante);
            this.groupBox1.Controls.Add(this.btnBuscarVotante);
            this.groupBox1.Controls.Add(this.btnRegistrarVotante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscarVotante);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 298);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Votantes";
            // 
            // btnValidarVotante
            // 
            this.btnValidarVotante.Location = new System.Drawing.Point(51, 254);
            this.btnValidarVotante.Name = "btnValidarVotante";
            this.btnValidarVotante.Size = new System.Drawing.Size(241, 35);
            this.btnValidarVotante.TabIndex = 9;
            this.btnValidarVotante.Text = "Validar Votante";
            this.btnValidarVotante.UseVisualStyleBackColor = true;
            this.btnValidarVotante.Click += new System.EventHandler(this.btnValidarVotante_Click);
            // 
            // btnEliminarVotante
            // 
            this.btnEliminarVotante.Location = new System.Drawing.Point(217, 190);
            this.btnEliminarVotante.Name = "btnEliminarVotante";
            this.btnEliminarVotante.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarVotante.TabIndex = 8;
            this.btnEliminarVotante.Text = "Eliminar";
            this.btnEliminarVotante.UseVisualStyleBackColor = true;
            // 
            // btnActualizarVotante
            // 
            this.btnActualizarVotante.Location = new System.Drawing.Point(136, 190);
            this.btnActualizarVotante.Name = "btnActualizarVotante";
            this.btnActualizarVotante.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarVotante.TabIndex = 7;
            this.btnActualizarVotante.Text = "Actualizar";
            this.btnActualizarVotante.UseVisualStyleBackColor = true;
            this.btnActualizarVotante.Click += new System.EventHandler(this.btnActualizarVotante_Click);
            // 
            // btnBuscarVotante
            // 
            this.btnBuscarVotante.Location = new System.Drawing.Point(55, 190);
            this.btnBuscarVotante.Name = "btnBuscarVotante";
            this.btnBuscarVotante.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVotante.TabIndex = 6;
            this.btnBuscarVotante.Text = "Buscar";
            this.btnBuscarVotante.UseVisualStyleBackColor = true;
            this.btnBuscarVotante.Click += new System.EventHandler(this.btnBuscarVotante_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarAntecedente);
            this.groupBox2.Controls.Add(this.btnActualizarAntecedente);
            this.groupBox2.Controls.Add(this.btnBuscarAntecedente);
            this.groupBox2.Controls.Add(this.btnRegistrarAntecedentes);
            this.groupBox2.Controls.Add(this.txtBuscarAntecedente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(407, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 298);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Antecedentes";
            // 
            // btnEliminarAntecedente
            // 
            this.btnEliminarAntecedente.Location = new System.Drawing.Point(250, 190);
            this.btnEliminarAntecedente.Name = "btnEliminarAntecedente";
            this.btnEliminarAntecedente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAntecedente.TabIndex = 9;
            this.btnEliminarAntecedente.Text = "Eliminar";
            this.btnEliminarAntecedente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarAntecedente
            // 
            this.btnActualizarAntecedente.Location = new System.Drawing.Point(169, 190);
            this.btnActualizarAntecedente.Name = "btnActualizarAntecedente";
            this.btnActualizarAntecedente.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarAntecedente.TabIndex = 8;
            this.btnActualizarAntecedente.Text = "Actualizar";
            this.btnActualizarAntecedente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAntecedente
            // 
            this.btnBuscarAntecedente.Location = new System.Drawing.Point(88, 190);
            this.btnBuscarAntecedente.Name = "btnBuscarAntecedente";
            this.btnBuscarAntecedente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAntecedente.TabIndex = 7;
            this.btnBuscarAntecedente.Text = "Buscar";
            this.btnBuscarAntecedente.UseVisualStyleBackColor = true;
            // 
            // frmVotoEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResults);
            this.Name = "frmVotoEletronico";
            this.Text = "Voto Electronico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnRegistrarVotante;
        private System.Windows.Forms.Button btnRegistrarAntecedentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarVotante;
        private System.Windows.Forms.TextBox txtBuscarAntecedente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarVotante;
        private System.Windows.Forms.Button btnActualizarVotante;
        private System.Windows.Forms.Button btnBuscarVotante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarAntecedente;
        private System.Windows.Forms.Button btnActualizarAntecedente;
        private System.Windows.Forms.Button btnBuscarAntecedente;
        private System.Windows.Forms.Button btnValidarVotante;
    }
}

