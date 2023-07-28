namespace MonitoraUFRGS.View
{
    partial class TelaAluno
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
            label_Title = new Label();
            button_Solicitar = new Button();
            button_AplicarMonitoria = new Button();
            button_Visualizar = new Button();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.Location = new Point(129, 9);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(90, 37);
            label_Title.TabIndex = 0;
            label_Title.Text = "Aluno";
            // 
            // button_Solicitar
            // 
            button_Solicitar.Location = new Point(102, 102);
            button_Solicitar.Name = "button_Solicitar";
            button_Solicitar.Size = new Size(143, 34);
            button_Solicitar.TabIndex = 1;
            button_Solicitar.Text = "Solicitar Aula";
            button_Solicitar.UseVisualStyleBackColor = true;
            button_Solicitar.Click += button_Solicitar_Click;
            // 
            // button_AplicarMonitoria
            // 
            button_AplicarMonitoria.Location = new Point(102, 210);
            button_AplicarMonitoria.Name = "button_AplicarMonitoria";
            button_AplicarMonitoria.Size = new Size(143, 36);
            button_AplicarMonitoria.TabIndex = 3;
            button_AplicarMonitoria.Text = "Aplicar Monitoria";
            button_AplicarMonitoria.UseVisualStyleBackColor = true;
            // 
            // button_Visualizar
            // 
            button_Visualizar.Location = new Point(102, 155);
            button_Visualizar.Name = "button_Visualizar";
            button_Visualizar.Size = new Size(143, 36);
            button_Visualizar.TabIndex = 4;
            button_Visualizar.Text = "Visualizar";
            button_Visualizar.UseVisualStyleBackColor = true;
            // 
            // TelaAluno
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 335);
            Controls.Add(button_Visualizar);
            Controls.Add(button_AplicarMonitoria);
            Controls.Add(button_Solicitar);
            Controls.Add(label_Title);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TelaAluno";
            Text = "TelaAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Title;
        private Button button_Solicitar;
        private Button button_AplicarMonitoria;
        private Button button_Visualizar;
    }
}