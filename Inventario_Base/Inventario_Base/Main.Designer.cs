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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            cerrarSessionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.NavajoWhite;
            button1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(577, 288);
            button1.Name = "button1";
            button1.Size = new Size(339, 180);
            button1.TabIndex = 0;
            button1.Text = "➕ Agregar prenda";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.NavajoWhite;
            button2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold);
            button2.Location = new Point(1084, 288);
            button2.Name = "button2";
            button2.Size = new Size(339, 180);
            button2.TabIndex = 1;
            button2.Text = "🔎Buscar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.NavajoWhite;
            button3.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(1084, 533);
            button3.Name = "button3";
            button3.Size = new Size(339, 180);
            button3.TabIndex = 2;
            button3.Text = "⛔Eliminar prenda";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.NavajoWhite;
            button4.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(577, 533);
            button4.Name = "button4";
            button4.Size = new Size(339, 180);
            button4.TabIndex = 3;
            button4.Text = "📝Actualizar prenda";
            button4.UseVisualStyleBackColor = false;
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
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem, modificarUsuarioToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 100F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(250, 177);
            label1.TabIndex = 5;
            label1.Text = "🛍️";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 71);
            label2.Name = "label2";
            label2.Size = new Size(563, 115);
            label2.TabIndex = 6;
            label2.Text = "Nombre_Tienda";
            label2.Click += label2_Click;
            // 
            // cerrarSessionToolStripMenuItem
            // 
            cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            cerrarSessionToolStripMenuItem.Size = new Size(180, 22);
            cerrarSessionToolStripMenuItem.Text = "Cerrar Session";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(180, 22);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            modificarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2055, 882);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Inventario TechLike";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
