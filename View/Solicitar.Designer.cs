namespace MonitoraUFRGS
{
    partial class Solicitar
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
            label_Text = new Label();
            label_Data = new Label();
            label_Hora = new Label();
            label_Disciplina = new Label();
            date_Data = new DateTimePicker();
            date_Hora = new DateTimePicker();
            textBox_Disciplina = new TextBox();
            checkBox_Remota = new CheckBox();
            button_Solicitar = new Button();
            SuspendLayout();
            // 
            // label_Text
            // 
            label_Text.AutoSize = true;
            label_Text.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Text.Location = new Point(88, 9);
            label_Text.Margin = new Padding(4, 0, 4, 0);
            label_Text.Name = "label_Text";
            label_Text.Size = new Size(178, 37);
            label_Text.TabIndex = 0;
            label_Text.Text = "Solicitar Aula";
            // 
            // label_Data
            // 
            label_Data.AutoSize = true;
            label_Data.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Data.Location = new Point(12, 124);
            label_Data.Name = "label_Data";
            label_Data.Size = new Size(51, 25);
            label_Data.TabIndex = 1;
            label_Data.Text = "Data";
            // 
            // label_Hora
            // 
            label_Hora.AutoSize = true;
            label_Hora.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Hora.Location = new Point(12, 175);
            label_Hora.Name = "label_Hora";
            label_Hora.Size = new Size(53, 25);
            label_Hora.TabIndex = 2;
            label_Hora.Text = "Hora";
            // 
            // label_Disciplina
            // 
            label_Disciplina.AutoSize = true;
            label_Disciplina.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Disciplina.Location = new Point(12, 71);
            label_Disciplina.Name = "label_Disciplina";
            label_Disciplina.Size = new Size(94, 25);
            label_Disciplina.TabIndex = 3;
            label_Disciplina.Text = "Disciplina";
            // 
            // date_Data
            // 
            date_Data.Format = DateTimePickerFormat.Short;
            date_Data.Location = new Point(196, 121);
            date_Data.Name = "date_Data";
            date_Data.Size = new Size(136, 29);
            date_Data.TabIndex = 4;
            // 
            // date_Hora
            // 
            date_Hora.Format = DateTimePickerFormat.Time;
            date_Hora.Location = new Point(196, 171);
            date_Hora.Name = "date_Hora";
            date_Hora.Size = new Size(136, 29);
            date_Hora.TabIndex = 5;
            // 
            // textBox_Disciplina
            // 
            textBox_Disciplina.Location = new Point(154, 71);
            textBox_Disciplina.Name = "textBox_Disciplina";
            textBox_Disciplina.Size = new Size(178, 29);
            textBox_Disciplina.TabIndex = 6;
            textBox_Disciplina.TextChanged += textBox_Disciplina_TextChanged;
            // 
            // checkBox_Remota
            // 
            checkBox_Remota.AutoSize = true;
            checkBox_Remota.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_Remota.Location = new Point(16, 222);
            checkBox_Remota.Name = "checkBox_Remota";
            checkBox_Remota.Size = new Size(134, 29);
            checkBox_Remota.TabIndex = 7;
            checkBox_Remota.Text = "Aula remota";
            checkBox_Remota.UseVisualStyleBackColor = true;
            // 
            // button_Solicitar
            // 
            button_Solicitar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_Solicitar.Location = new Point(108, 271);
            button_Solicitar.Name = "button_Solicitar";
            button_Solicitar.Size = new Size(134, 41);
            button_Solicitar.TabIndex = 8;
            button_Solicitar.Text = "Solicitar aula";
            button_Solicitar.UseVisualStyleBackColor = true;
            button_Solicitar.Click += button_Solicitar_Click;
            // 
            // Solicitar
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 335);
            Controls.Add(button_Solicitar);
            Controls.Add(checkBox_Remota);
            Controls.Add(textBox_Disciplina);
            Controls.Add(date_Hora);
            Controls.Add(date_Data);
            Controls.Add(label_Disciplina);
            Controls.Add(label_Hora);
            Controls.Add(label_Data);
            Controls.Add(label_Text);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Solicitar";
            Text = "Solicitar Aula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Text;
        private Label label_Data;
        private Label label_Hora;
        private Label label_Disciplina;
        private DateTimePicker date_Data;
        private DateTimePicker date_Hora;
        private TextBox textBox_Disciplina;
        private CheckBox checkBox_Remota;
        private Button button_Solicitar;
    }
}