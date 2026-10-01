namespace Hotel.UI
{
    partial class HOME
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
            label1 = new Label();
            BtnCliente = new Button();
            BtnHospedagem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 40);
            label1.Name = "label1";
            label1.Size = new Size(221, 47);
            label1.TabIndex = 0;
            label1.Text = "TELA HOME";
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(335, 151);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(165, 65);
            BtnCliente.TabIndex = 1;
            BtnCliente.Text = "CADASTRO CLIENTE";
            BtnCliente.UseVisualStyleBackColor = true;
            BtnCliente.Click += BtnCliente_Click;
            // 
            // BtnHospedagem
            // 
            BtnHospedagem.Location = new Point(335, 287);
            BtnHospedagem.Name = "BtnHospedagem";
            BtnHospedagem.Size = new Size(165, 60);
            BtnHospedagem.TabIndex = 2;
            BtnHospedagem.Text = "HOSPEDAGEM";
            BtnHospedagem.UseVisualStyleBackColor = true;
            BtnHospedagem.Click += BtnHospedagem_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 555);
            Controls.Add(BtnHospedagem);
            Controls.Add(BtnCliente);
            Controls.Add(label1);
            Name = "HOME";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnCliente;
        private Button BtnHospedagem;
    }
}
