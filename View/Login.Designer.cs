namespace MonitoraUFRGS.View
{
    partial class Login
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
            label_Titulo = new Label();
            label_Login = new Label();
            label_Cartao = new Label();
            textBox_Cartao = new TextBox();
            label_Senha = new Label();
            textBox1 = new TextBox();
            button_Logar = new Button();
            button_Cadastrar = new Button();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.Location = new Point(48, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(254, 45);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "MonitoraUFRGS";
            // 
            // label_Login
            // 
            label_Login.AutoSize = true;
            label_Login.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Login.Location = new Point(138, 66);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(59, 25);
            label_Login.TabIndex = 1;
            label_Login.Text = "Login";
            // 
            // label_Cartao
            // 
            label_Cartao.AutoSize = true;
            label_Cartao.Location = new Point(141, 112);
            label_Cartao.Name = "label_Cartao";
            label_Cartao.Size = new Size(56, 21);
            label_Cartao.TabIndex = 2;
            label_Cartao.Text = "Cartão";
            // 
            // textBox_Cartao
            // 
            textBox_Cartao.Location = new Point(89, 136);
            textBox_Cartao.Name = "textBox_Cartao";
            textBox_Cartao.Size = new Size(163, 29);
            textBox_Cartao.TabIndex = 3;
            textBox_Cartao.WordWrap = false;
            // 
            // label_Senha
            // 
            label_Senha.AutoSize = true;
            label_Senha.Location = new Point(141, 182);
            label_Senha.Name = "label_Senha";
            label_Senha.Size = new Size(53, 21);
            label_Senha.TabIndex = 4;
            label_Senha.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 29);
            textBox1.TabIndex = 5;
            // 
            // button_Logar
            // 
            button_Logar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_Logar.Location = new Point(48, 264);
            button_Logar.Name = "button_Logar";
            button_Logar.Size = new Size(106, 50);
            button_Logar.TabIndex = 6;
            button_Logar.Text = "Logar";
            button_Logar.UseVisualStyleBackColor = true;
            button_Logar.Click += button_Logar_Click;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_Cadastrar.Location = new Point(160, 264);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(142, 50);
            button_Cadastrar.TabIndex = 7;
            button_Cadastrar.Text = "Cadastrar-se";
            button_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 335);
            Controls.Add(button_Cadastrar);
            Controls.Add(button_Logar);
            Controls.Add(textBox1);
            Controls.Add(label_Senha);
            Controls.Add(textBox_Cartao);
            Controls.Add(label_Cartao);
            Controls.Add(label_Login);
            Controls.Add(label_Titulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private Label label_Login;
        private Label label_Cartao;
        private TextBox textBox_Cartao;
        private Label label_Senha;
        private TextBox textBox1;
        private Button button_Logar;
        private Button button_Cadastrar;
    }
}