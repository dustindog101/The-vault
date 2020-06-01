namespace The_vault
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.lbltitleitems = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtwebs = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtpassw = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtlgn = new Guna.UI.WinForms.GunaLineTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headwebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 1;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaLabel3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel3.Location = new System.Drawing.Point(3, 5);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(136, 37);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "The vault";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaControlBox2);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 42);
            this.panel1.TabIndex = 7;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel5.Location = new System.Drawing.Point(130, 13);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(395, 30);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "-A local Open-Source Password vault";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(705, 4);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 7;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(751, 4);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 6;
            this.gunaControlBox1.Click += new System.EventHandler(this.GunaControlBox1_Click);
            // 
            // lbltitleitems
            // 
            this.lbltitleitems.AutoSize = true;
            this.lbltitleitems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbltitleitems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitleitems.Location = new System.Drawing.Point(7, 0);
            this.lbltitleitems.Name = "lbltitleitems";
            this.lbltitleitems.Size = new System.Drawing.Size(22, 15);
            this.lbltitleitems.TabIndex = 14;
            this.lbltitleitems.Text = "???";
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.panel1;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(753, 7);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 1;
            this.gunaButton1.Size = new System.Drawing.Size(44, 42);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Text = "+";
            this.gunaButton1.TextOffsetX = -3;
            this.gunaButton1.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(19, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Website:";
            // 
            // txtwebs
            // 
            this.txtwebs.BackColor = System.Drawing.SystemColors.Control;
            this.txtwebs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtwebs.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtwebs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtwebs.LineColor = System.Drawing.Color.Gainsboro;
            this.txtwebs.Location = new System.Drawing.Point(80, 15);
            this.txtwebs.Name = "txtwebs";
            this.txtwebs.PasswordChar = '\0';
            this.txtwebs.Size = new System.Drawing.Size(164, 26);
            this.txtwebs.TabIndex = 9;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lbltitleitems);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel1.Controls.Add(this.txtpassw);
            this.gunaLinePanel1.Controls.Add(this.txtlgn);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.Controls.Add(this.gunaButton1);
            this.gunaLinePanel1.Controls.Add(this.txtwebs);
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 397);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(800, 52);
            this.gunaLinePanel1.TabIndex = 11;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel4.Location = new System.Drawing.Point(496, 23);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Password:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(253, 23);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Login:";
            // 
            // txtpassw
            // 
            this.txtpassw.BackColor = System.Drawing.SystemColors.Control;
            this.txtpassw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassw.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpassw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtpassw.LineColor = System.Drawing.Color.Gainsboro;
            this.txtpassw.Location = new System.Drawing.Point(557, 15);
            this.txtpassw.Name = "txtpassw";
            this.txtpassw.PasswordChar = '●';
            this.txtpassw.Size = new System.Drawing.Size(174, 26);
            this.txtpassw.TabIndex = 12;
            this.txtpassw.UseSystemPasswordChar = true;
            this.txtpassw.TextChanged += new System.EventHandler(this.Txtpassw_TextChanged);
            // 
            // txtlgn
            // 
            this.txtlgn.BackColor = System.Drawing.SystemColors.Control;
            this.txtlgn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlgn.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtlgn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtlgn.LineColor = System.Drawing.Color.Gainsboro;
            this.txtlgn.Location = new System.Drawing.Point(314, 15);
            this.txtlgn.Name = "txtlgn";
            this.txtlgn.PasswordChar = '\0';
            this.txtlgn.Size = new System.Drawing.Size(174, 26);
            this.txtlgn.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 356);
            this.panel2.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.headwebsite,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 356);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID:";
            // 
            // headwebsite
            // 
            this.headwebsite.Text = "Website";
            this.headwebsite.Width = 230;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Login";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 165;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this.gunaLabel5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedItemToolStripMenuItem,
            this.showPasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 48);
            // 
            // deleteSelectedItemToolStripMenuItem
            // 
            this.deleteSelectedItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editValueToolStripMenuItem,
            this.deleteValueToolStripMenuItem});
            this.deleteSelectedItemToolStripMenuItem.Name = "deleteSelectedItemToolStripMenuItem";
            this.deleteSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteSelectedItemToolStripMenuItem.Text = "Edit selected value";
            // 
            // editValueToolStripMenuItem
            // 
            this.editValueToolStripMenuItem.Name = "editValueToolStripMenuItem";
            this.editValueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.editValueToolStripMenuItem.Text = "Edit value";
            // 
            // deleteValueToolStripMenuItem
            // 
            this.deleteValueToolStripMenuItem.Name = "deleteValueToolStripMenuItem";
            this.deleteValueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteValueToolStripMenuItem.Text = "Delete value";
            // 
            // showPasswordToolStripMenuItem
            // 
            this.showPasswordToolStripMenuItem.Name = "showPasswordToolStripMenuItem";
            this.showPasswordToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showPasswordToolStripMenuItem.Text = "Show password";
            // 
            // MainForm
            // 
            this.AcceptButton = this.gunaButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txtpassw;
        private Guna.UI.WinForms.GunaLineTextBox txtlgn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtwebs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader headwebsite;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI.WinForms.GunaLabel lbltitleitems;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPasswordToolStripMenuItem;
    }
}