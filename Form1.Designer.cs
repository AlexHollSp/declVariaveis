namespace declVariaveis
{
    partial class frmSoma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblA = new Label();
            lblB = new Label();
            lblResultado = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtResultado = new TextBox();
            btnInteiros = new Button();
            btnReais = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(53, 14);
            lblA.Name = "lblA";
            lblA.Size = new Size(15, 15);
            lblA.TabIndex = 0;
            lblA.Text = "A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(53, 46);
            lblB.Name = "lblB";
            lblB.Size = new Size(14, 15);
            lblB.TabIndex = 1;
            lblB.Text = "B";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 85);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // txtA
            // 
            txtA.Location = new Point(70, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(70, 41);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(70, 77);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // btnInteiros
            // 
            btnInteiros.Location = new Point(196, 15);
            btnInteiros.Name = "btnInteiros";
            btnInteiros.Size = new Size(75, 23);
            btnInteiros.TabIndex = 6;
            btnInteiros.Text = "Inteiros";
            btnInteiros.UseVisualStyleBackColor = true;
            btnInteiros.Click += button1_Click;
            // 
            // btnReais
            // 
            btnReais.Location = new Point(196, 44);
            btnReais.Name = "btnReais";
            btnReais.Size = new Size(75, 23);
            btnReais.TabIndex = 7;
            btnReais.Text = "Reais";
            btnReais.UseVisualStyleBackColor = true;
            btnReais.Click += btnReais_Click;
            // 
            // frmSoma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 139);
            Controls.Add(btnReais);
            Controls.Add(btnInteiros);
            Controls.Add(txtResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblResultado);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "frmSoma";
            Text = "Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private Label lblResultado;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtResultado;
        private Button btnInteiros;
        private Button btnReais;
    }
}