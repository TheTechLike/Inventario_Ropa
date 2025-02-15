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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSessionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            marcaBindingSource = new BindingSource(components);
            splitContainer1 = new SplitContainer();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.NavajoWhite;
            button1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(1320, 65);
            button1.Name = "button1";
            button1.Size = new Size(202, 58);
            button1.TabIndex = 0;
            button1.Text = "➕ Agregar prenda";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.NavajoWhite;
            button2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button2.Location = new Point(870, 65);
            button2.Name = "button2";
            button2.Size = new Size(202, 58);
            button2.TabIndex = 1;
            button2.Text = "🔎Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.NavajoWhite;
            button3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(1545, 65);
            button3.Name = "button3";
            button3.Size = new Size(202, 58);
            button3.TabIndex = 2;
            button3.Text = "⛔Eliminar prenda";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.NavajoWhite;
            button4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(1095, 65);
            button4.Name = "button4";
            button4.Size = new Size(202, 58);
            button4.TabIndex = 3;
            button4.Text = "📝Actualizar prenda";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, usuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2055, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
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
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem, modificarUsuarioToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Size = new Size(168, 22);
            agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 100F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(250, 177);
            label1.TabIndex = 5;
            label1.Text = "🛍️";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(284, 37);
            label2.Name = "label2";
            label2.Size = new Size(563, 115);
            label2.TabIndex = 6;
            label2.Text = "Nombre_Tienda";
            label2.Click += label2_Click;
            // 
            // marcaBindingSource
            // 
            marcaBindingSource.DataMember = "Marca";
            marcaBindingSource.DataSource = typeof(DataSet1);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Size = new Size(2055, 923);
            splitContainer1.SplitterDistance = 179;
            splitContainer1.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2055, 947);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Inventario TechLike";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)marcaBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private BindingSource marcaBindingSource;
        private SplitContainer splitContainer1;
    }
}
