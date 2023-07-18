namespace MonitoraUFRGS
{
    partial class Confirmar
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
            label_Confirmar = new Label();
            list_Aulas = new ListBox();
            button_Confirmar = new Button();
            button_Recusar = new Button();
            SuspendLayout();
            // 
            // label_Confirmar
            // 
            label_Confirmar.AutoSize = true;
            label_Confirmar.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Confirmar.Location = new Point(69, 9);
            label_Confirmar.Name = "label_Confirmar";
            label_Confirmar.Size = new Size(202, 37);
            label_Confirmar.TabIndex = 0;
            label_Confirmar.Text = "Confirmar Aula";
            // 
            // list_Aulas
            // 
            list_Aulas.FormattingEnabled = true;
            list_Aulas.ItemHeight = 21;
            list_Aulas.Items.AddRange(new object[] { "Aula 1 - HH:MM DD/MM - Remoto", "Aula 2 - HH:MM DD/MM - Presencial", "Aula 3 - HH:MM DD/MM - Presencial", "Aula 4 - HH:MM DD/MM - Remoto" });
            list_Aulas.Location = new Point(12, 62);
            list_Aulas.Name = "list_Aulas";
            list_Aulas.Size = new Size(326, 130);
            list_Aulas.TabIndex = 1;
            // 
            // button_Confirmar
            // 
            button_Confirmar.Location = new Point(34, 212);
            button_Confirmar.Name = "button_Confirmar";
            button_Confirmar.Size = new Size(97, 36);
            button_Confirmar.TabIndex = 2;
            button_Confirmar.Text = "Confirmar";
            button_Confirmar.UseVisualStyleBackColor = true;
            button_Confirmar.Click += button_Confirmar_Click;
            // 
            // button_Recusar
            // 
            button_Recusar.Location = new Point(208, 212);
            button_Recusar.Name = "button_Recusar";
            button_Recusar.Size = new Size(97, 36);
            button_Recusar.TabIndex = 3;
            button_Recusar.Text = "Recusar";
            button_Recusar.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 335);
            Controls.Add(button_Recusar);
            Controls.Add(button_Confirmar);
            Controls.Add(list_Aulas);
            Controls.Add(label_Confirmar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Confirmar";
            Text = "Confirmar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Confirmar;
        private ListBox list_Aulas;
        private Button button_Confirmar;
        private Button button_Recusar;
    }
}