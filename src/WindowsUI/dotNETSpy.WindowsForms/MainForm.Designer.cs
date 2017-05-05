namespace dotNETSpy.WindowsForms
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
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromGACMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInternalMembersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortTreeViewByNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSearchDialogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsCSharpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsVisualBasicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsILMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.openFromGACMenuItem,
            toolStripSeparator1,
            this.saveCodeMenuItem,
            toolStripSeparator2,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSearchDialogMenuItem,
            this.refreshMenuItem,
            toolStripSeparator3,
            this.decompileAsMenu,
            this.showInternalMembersMenuItem,
            this.sortTreeViewByNameMenuItem,
            toolStripSeparator4,
            this.optionsMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "&About";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openFileMenuItem.Text = "&Open File...";
            // 
            // openFromGACMenuItem
            // 
            this.openFromGACMenuItem.Name = "openFromGACMenuItem";
            this.openFromGACMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openFromGACMenuItem.Text = "Open from &GAC...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // saveCodeMenuItem
            // 
            this.saveCodeMenuItem.Name = "saveCodeMenuItem";
            this.saveCodeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCodeMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveCodeMenuItem.Text = "&Save Code...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitMenuItem.Text = "E&xit";
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshMenuItem.Size = new System.Drawing.Size(251, 22);
            this.refreshMenuItem.Text = "&Refresh";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(248, 6);
            // 
            // showInternalMembersMenuItem
            // 
            this.showInternalMembersMenuItem.Name = "showInternalMembersMenuItem";
            this.showInternalMembersMenuItem.Size = new System.Drawing.Size(251, 22);
            this.showInternalMembersMenuItem.Text = "Show non-public types/&members";
            // 
            // sortTreeViewByNameMenuItem
            // 
            this.sortTreeViewByNameMenuItem.Name = "sortTreeViewByNameMenuItem";
            this.sortTreeViewByNameMenuItem.Size = new System.Drawing.Size(251, 22);
            this.sortTreeViewByNameMenuItem.Text = "Sort assembly list by &name";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(248, 6);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(251, 22);
            this.optionsMenuItem.Text = "&Options...";
            // 
            // showSearchDialogMenuItem
            // 
            this.showSearchDialogMenuItem.Name = "showSearchDialogMenuItem";
            this.showSearchDialogMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.showSearchDialogMenuItem.Size = new System.Drawing.Size(251, 22);
            this.showSearchDialogMenuItem.Text = "&Search...";
            // 
            // decompileAsMenu
            // 
            this.decompileAsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decompileAsCSharpMenuItem,
            this.decompileAsVisualBasicMenuItem,
            this.decompileAsILMenuItem});
            this.decompileAsMenu.Name = "decompileAsMenu";
            this.decompileAsMenu.Size = new System.Drawing.Size(251, 22);
            this.decompileAsMenu.Text = "&Decompile as";
            // 
            // decompileAsCSharpMenuItem
            // 
            this.decompileAsCSharpMenuItem.Name = "decompileAsCSharpMenuItem";
            this.decompileAsCSharpMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decompileAsCSharpMenuItem.Text = "&C#";
            // 
            // decompileAsVisualBasicMenuItem
            // 
            this.decompileAsVisualBasicMenuItem.Name = "decompileAsVisualBasicMenuItem";
            this.decompileAsVisualBasicMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decompileAsVisualBasicMenuItem.Text = "&Visual Basic";
            // 
            // decompileAsILMenuItem
            // 
            this.decompileAsILMenuItem.Name = "decompileAsILMenuItem";
            this.decompileAsILMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decompileAsILMenuItem.Text = "CI&L";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(639, 461);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(655, 500);
            this.Name = "MainForm";
            this.Text = "dotNETSpy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromGACMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCodeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInternalMembersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortTreeViewByNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSearchDialogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompileAsMenu;
        private System.Windows.Forms.ToolStripMenuItem decompileAsCSharpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompileAsVisualBasicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompileAsILMenuItem;
    }
}

