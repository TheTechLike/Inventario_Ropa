namespace Inventario_Base
{
    partial class Actualizar
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
            splitContainer1 = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox4 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(comboBox4);
            splitContainer1.Panel1.Controls.Add(numericUpDown1);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(comboBox3);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(comboBox2);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1227, 695);
            splitContainer1.SplitterDistance = 407;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.PapayaWhip;
            button3.Location = new Point(302, 558);
            button3.Name = "button3";
            button3.Size = new Size(97, 23);
            button3.TabIndex = 11;
            button3.Text = "Aceptar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(154, 558);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 558);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar Marca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(125, 436);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(157, 24);
            comboBox4.TabIndex = 8;
            comboBox4.DropDown += comboBox4_DropDown;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            numericUpDown1.Location = new Point(125, 375);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(157, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            textBox3.Location = new Point(125, 312);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            textBox2.Location = new Point(125, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(125, 199);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(157, 24);
            comboBox3.TabIndex = 4;
            comboBox3.DropDown += comboBox3_DropDown;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            textBox1.Location = new Point(125, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(125, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(157, 24);
            comboBox2.TabIndex = 2;
            comboBox2.DropDown += comboBox2_DropDown;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 24);
            comboBox1.TabIndex = 1;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(819, 695);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Actualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1227, 695);
            Controls.Add(splitContainer1);
            Name = "Actualizar";
            Text = "Actualizar";
            WindowState = FormWindowState.Maximized;
            Load += Actualizar_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox4;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private SplitContainer splitContainer1;
    }
}