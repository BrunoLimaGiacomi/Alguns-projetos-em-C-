namespace Win_VisualizadorImagens
{
    partial class FrmVisualizarImagem
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
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSemImagem = new System.Windows.Forms.RadioButton();
            this.rdoImagem2 = new System.Windows.Forms.RadioButton();
            this.rdoImagem1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBordas3D = new System.Windows.Forms.RadioButton();
            this.rdoBordasFixas = new System.Windows.Forms.RadioButton();
            this.rdoSemBordas = new System.Windows.Forms.RadioButton();
            this.chkVisivelInvisivel = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbFoto
            // 
            this.pcbFoto.Image = global::Win_VisualizadorImagens.Properties.Resources.Alimentossaudaveis;
            this.pcbFoto.Location = new System.Drawing.Point(12, 12);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(687, 315);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 0;
            this.pcbFoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSemImagem);
            this.groupBox1.Controls.Add(this.rdoImagem2);
            this.groupBox1.Controls.Add(this.rdoImagem1);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Imagens";
            // 
            // rdoSemImagem
            // 
            this.rdoSemImagem.AutoSize = true;
            this.rdoSemImagem.Location = new System.Drawing.Point(15, 90);
            this.rdoSemImagem.Name = "rdoSemImagem";
            this.rdoSemImagem.Size = new System.Drawing.Size(141, 22);
            this.rdoSemImagem.TabIndex = 2;
            this.rdoSemImagem.TabStop = true;
            this.rdoSemImagem.Text = "Sem Imagem";
            this.rdoSemImagem.UseVisualStyleBackColor = true;
            this.rdoSemImagem.CheckedChanged += new System.EventHandler(this.rdoSemImagem_CheckedChanged);
            // 
            // rdoImagem2
            // 
            this.rdoImagem2.AutoSize = true;
            this.rdoImagem2.Location = new System.Drawing.Point(15, 58);
            this.rdoImagem2.Name = "rdoImagem2";
            this.rdoImagem2.Size = new System.Drawing.Size(115, 22);
            this.rdoImagem2.TabIndex = 1;
            this.rdoImagem2.TabStop = true;
            this.rdoImagem2.Text = "Imagem 2";
            this.rdoImagem2.UseVisualStyleBackColor = true;
            this.rdoImagem2.CheckedChanged += new System.EventHandler(this.rdoImagem2_CheckedChanged);
            // 
            // rdoImagem1
            // 
            this.rdoImagem1.AutoSize = true;
            this.rdoImagem1.Location = new System.Drawing.Point(15, 26);
            this.rdoImagem1.Name = "rdoImagem1";
            this.rdoImagem1.Size = new System.Drawing.Size(115, 22);
            this.rdoImagem1.TabIndex = 0;
            this.rdoImagem1.TabStop = true;
            this.rdoImagem1.Text = "Imagem 1";
            this.rdoImagem1.UseVisualStyleBackColor = true;
            this.rdoImagem1.CheckedChanged += new System.EventHandler(this.rdoImagem1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBordas3D);
            this.groupBox2.Controls.Add(this.rdoBordasFixas);
            this.groupBox2.Controls.Add(this.rdoSemBordas);
            this.groupBox2.Location = new System.Drawing.Point(211, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bordas";
            // 
            // rdoBordas3D
            // 
            this.rdoBordas3D.AutoSize = true;
            this.rdoBordas3D.Location = new System.Drawing.Point(18, 90);
            this.rdoBordas3D.Name = "rdoBordas3D";
            this.rdoBordas3D.Size = new System.Drawing.Size(52, 22);
            this.rdoBordas3D.TabIndex = 3;
            this.rdoBordas3D.TabStop = true;
            this.rdoBordas3D.Text = "3D";
            this.rdoBordas3D.UseVisualStyleBackColor = true;
            this.rdoBordas3D.CheckedChanged += new System.EventHandler(this.rdoBordas3D_CheckedChanged);
            // 
            // rdoBordasFixas
            // 
            this.rdoBordasFixas.AutoSize = true;
            this.rdoBordasFixas.Location = new System.Drawing.Point(18, 58);
            this.rdoBordasFixas.Name = "rdoBordasFixas";
            this.rdoBordasFixas.Size = new System.Drawing.Size(132, 22);
            this.rdoBordasFixas.TabIndex = 2;
            this.rdoBordasFixas.TabStop = true;
            this.rdoBordasFixas.Text = "Fixa Simples";
            this.rdoBordasFixas.UseVisualStyleBackColor = true;
            this.rdoBordasFixas.CheckedChanged += new System.EventHandler(this.rdoBordasFixas_CheckedChanged);
            // 
            // rdoSemBordas
            // 
            this.rdoSemBordas.AutoSize = true;
            this.rdoSemBordas.Location = new System.Drawing.Point(18, 26);
            this.rdoSemBordas.Name = "rdoSemBordas";
            this.rdoSemBordas.Size = new System.Drawing.Size(128, 22);
            this.rdoSemBordas.TabIndex = 1;
            this.rdoSemBordas.TabStop = true;
            this.rdoSemBordas.Text = "Sem Bordas";
            this.rdoSemBordas.UseVisualStyleBackColor = true;
            this.rdoSemBordas.CheckedChanged += new System.EventHandler(this.rdoSemBordas_CheckedChanged);
            // 
            // chkVisivelInvisivel
            // 
            this.chkVisivelInvisivel.AutoSize = true;
            this.chkVisivelInvisivel.Location = new System.Drawing.Point(411, 345);
            this.chkVisivelInvisivel.Name = "chkVisivelInvisivel";
            this.chkVisivelInvisivel.Size = new System.Drawing.Size(246, 22);
            this.chkVisivelInvisivel.TabIndex = 3;
            this.chkVisivelInvisivel.Text = "Imagem Visível / Invisível";
            this.chkVisivelInvisivel.UseVisualStyleBackColor = true;
            this.chkVisivelInvisivel.CheckedChanged += new System.EventHandler(this.chkVisivelInvisivel_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(411, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(288, 52);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmVisualizarImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(711, 468);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.chkVisivelInvisivel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbFoto);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmVisualizarImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioButton PictureBox e CheckBox";
            this.Activated += new System.EventHandler(this.FrmVisualizarImagem_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSemImagem;
        private System.Windows.Forms.RadioButton rdoImagem2;
        private System.Windows.Forms.RadioButton rdoImagem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoBordas3D;
        private System.Windows.Forms.RadioButton rdoBordasFixas;
        private System.Windows.Forms.RadioButton rdoSemBordas;
        private System.Windows.Forms.CheckBox chkVisivelInvisivel;
        private System.Windows.Forms.Button btnSair;
    }
}

