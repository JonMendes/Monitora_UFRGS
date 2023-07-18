namespace MonitoraUFRGS
{
    partial class Principal
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
            button_FormSolicitar = new Button();
            button_FormConfirmar = new Button();
            SuspendLayout();
            // 
            // button_FormSolicitar
            // 
            button_FormSolicitar.Location = new Point(106, 120);
            button_FormSolicitar.Name = "button_FormSolicitar";
            button_FormSolicitar.Size = new Size(133, 37);
            button_FormSolicitar.TabIndex = 0;
            button_FormSolicitar.Text = "Solicitar Aula";
            button_FormSolicitar.UseVisualStyleBackColor = true;
            button_FormSolicitar.Click += button_FormSolicitar_Click;
            // 
            // button_FormConfirmar
            // 
            button_FormConfirmar.Location = new Point(106, 190);
            button_FormConfirmar.Name = "button_FormConfirmar";
            button_FormConfirmar.Size = new Size(133, 37);
            button_FormConfirmar.TabIndex = 1;
            button_FormConfirmar.Text = "Confirmar Aula";
            button_FormConfirmar.UseVisualStyleBackColor = true;
            button_FormConfirmar.Click += button_FormConfirmar_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 335);
            Controls.Add(button_FormConfirmar);
            Controls.Add(button_FormSolicitar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Principal";
            Text = "MonitoraUFRGS";
            ResumeLayout(false);
        }

        #endregion

        private Button button_FormSolicitar;
        private Button button_FormConfirmar;
    }
}