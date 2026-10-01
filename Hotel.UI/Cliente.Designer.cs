namespace Hotel.UI
{
    partial class Cliente
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
            BtnSalvar = new Button();
            BtnDelet = new Button();
            Dtgpoople = new DataGridView();
            BtnTos = new Button();
            label2 = new Label();
            label3 = new Label();
            TxtUser = new TextBox();
            TxtSenha = new TextBox();
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Dtgpoople).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.Location = new Point(364, 424);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(123, 25);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "SALVAR";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnDelet
            // 
            BtnDelet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelet.Location = new Point(364, 390);
            BtnDelet.Name = "BtnDelet";
            BtnDelet.Size = new Size(123, 28);
            BtnDelet.TabIndex = 5;
            BtnDelet.Text = "DELETAR";
            BtnDelet.UseVisualStyleBackColor = true;
            BtnDelet.Click += BtnDelet_Click;
            // 
            // Dtgpoople
            // 
            Dtgpoople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtgpoople.Location = new Point(493, 2);
            Dtgpoople.Name = "Dtgpoople";
            Dtgpoople.Size = new Size(305, 447);
            Dtgpoople.TabIndex = 7;
            // 
            // BtnTos
            // 
            BtnTos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTos.Location = new Point(364, 359);
            BtnTos.Name = "BtnTos";
            BtnTos.Size = new Size(123, 25);
            BtnTos.TabIndex = 9;
            BtnTos.Text = "BUSCAR TODOS";
            BtnTos.UseVisualStyleBackColor = true;
            BtnTos.Click += BtnTos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 18);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 1;
            label2.Text = "usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 74);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 1;
            label3.Text = "senha";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(2, 48);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(185, 23);
            TxtUser.TabIndex = 2;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(2, 94);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(185, 23);
            TxtSenha.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(203, 415);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(116, 23);
            BtnBuscar.TabIndex = 6;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(12, 415);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(185, 23);
            TxtBuscar.TabIndex = 8;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnTos);
            Controls.Add(TxtBuscar);
            Controls.Add(Dtgpoople);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnDelet);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnSalvar);
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)Dtgpoople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Button BtnDelet;
        private DataGridView Dtgpoople;
        private Button BtnTos;
        private Label label2;
        private Label label3;
        private TextBox TxtUser;
        private TextBox TxtSenha;
        private Button BtnBuscar;
        private TextBox TxtBuscar;
    }
}