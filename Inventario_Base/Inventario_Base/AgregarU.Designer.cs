namespace Inventario_Base
{
    partial class AgregarU
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(171, 602);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 123);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 29);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(484, 123);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 29);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 126);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(107, 256);
            maskedTextBox1.Margin = new Padding(4);
            maskedTextBox1.Mask = "0000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PromptChar = '-';
            maskedTextBox1.Size = new Size(116, 29);
            maskedTextBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(484, 255);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 29);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 2;
            label4.Text = "Correo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(107, 392);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 29);
            textBox4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 392);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 21);
            label6.TabIndex = 2;
            label6.Text = "Rol";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(484, 392);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 29);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombres";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 396);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 2;
            label5.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Location = new Point(432, 602);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(147, 46);
            button2.TabIndex = 0;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 464);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 25);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Usuario Local";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // AgregarU
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 715);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AgregarU";
            Text = "AgregarU";
            Load += AgregarU_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox1;
        private Label label1;
        private Label label5;
        private Label label3;
        private Button button2;
        private CheckBox checkBox1;
    }
}