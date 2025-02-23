namespace Inventario_Base
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            marcaBindingSource = new BindingSource(components);
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSessionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            buscarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // marcaBindingSource
            // 
            marcaBindingSource.DataMember = "Marca";
            marcaBindingSource.DataSource = typeof(DataSet1);
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSessionToolStripMenuItem, ayudaToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            cerrarSessionToolStripMenuItem.Size = new Size(148, 22);
            cerrarSessionToolStripMenuItem.Text = "Cerrar Session";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(148, 22);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem, modificarUsuarioToolStripMenuItem, buscarUsuarioToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Size = new Size(168, 22);
            agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            agregarUsuarioToolStripMenuItem.Click += agregarUsuarioToolStripMenuItem_Click;
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(168, 22);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            modificarUsuarioToolStripMenuItem.Size = new Size(168, 22);
            modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            buscarUsuarioToolStripMenuItem.Size = new Size(168, 22);
            buscarUsuarioToolStripMenuItem.Text = "Buscar Usuario";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, usuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1808, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1808, 178);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1420, 78);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 10;
            label3.Text = "Bienvenido/a ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 19);
            label1.Name = "label1";
            label1.Size = new Size(185, 128);
            label1.TabIndex = 8;
            label1.Text = "🛍️";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 32);
            label2.Name = "label2";
            label2.Size = new Size(563, 115);
            label2.TabIndex = 9;
            label2.Text = "Nombre_Tienda";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(3, 203);
            button1.Name = "button1";
            button1.Size = new Size(266, 94);
            button1.TabIndex = 3;
            button1.TabStop = false;
            button1.Text = "➕ Agregar prenda";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(3, 303);
            button3.Name = "button3";
            button3.Size = new Size(266, 95);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.Text = "⛔Eliminar prenda";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(266, 94);
            button2.TabIndex = 1;
            button2.TabStop = false;
            button2.Text = "🔎Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 5;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(3, 103);
            button4.Name = "button4";
            button4.Size = new Size(266, 94);
            button4.TabIndex = 2;
            button4.TabStop = false;
            button4.Text = "📝Actualizar prenda";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 740);
            panel2.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button3, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(272, 401);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(272, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(1536, 740);
            panel3.TabIndex = 12;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1808, 942);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Inventario TechLike";
            WindowState = FormWindowState.Maximized;
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            SizeChanged += Main_SizeChanged;
            VisibleChanged += Main_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource marcaBindingSource;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private ToolStripMenuItem buscarUsuarioToolStripMenuItem;
    }
}
