namespace dotNETSpy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromGACMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showSearchDialogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsCSharpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsVisualBasicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileAsILMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInternalMembersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortTreeViewByNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.helpMenu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
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
            resources.ApplyResources(this.fileMenu, "fileMenu");
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            resources.ApplyResources(this.openFileMenuItem, "openFileMenuItem");
            // 
            // openFromGACMenuItem
            // 
            this.openFromGACMenuItem.Name = "openFromGACMenuItem";
            resources.ApplyResources(this.openFromGACMenuItem, "openFromGACMenuItem");
            // 
            // saveCodeMenuItem
            // 
            this.saveCodeMenuItem.Name = "saveCodeMenuItem";
            resources.ApplyResources(this.saveCodeMenuItem, "saveCodeMenuItem");
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
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
            resources.ApplyResources(this.viewMenu, "viewMenu");
            // 
            // showSearchDialogMenuItem
            // 
            this.showSearchDialogMenuItem.Name = "showSearchDialogMenuItem";
            resources.ApplyResources(this.showSearchDialogMenuItem, "showSearchDialogMenuItem");
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            resources.ApplyResources(this.refreshMenuItem, "refreshMenuItem");
            // 
            // decompileAsMenu
            // 
            this.decompileAsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decompileAsCSharpMenuItem,
            this.decompileAsVisualBasicMenuItem,
            this.decompileAsILMenuItem});
            this.decompileAsMenu.Name = "decompileAsMenu";
            resources.ApplyResources(this.decompileAsMenu, "decompileAsMenu");
            // 
            // decompileAsCSharpMenuItem
            // 
            this.decompileAsCSharpMenuItem.Name = "decompileAsCSharpMenuItem";
            resources.ApplyResources(this.decompileAsCSharpMenuItem, "decompileAsCSharpMenuItem");
            // 
            // decompileAsVisualBasicMenuItem
            // 
            this.decompileAsVisualBasicMenuItem.Name = "decompileAsVisualBasicMenuItem";
            resources.ApplyResources(this.decompileAsVisualBasicMenuItem, "decompileAsVisualBasicMenuItem");
            // 
            // decompileAsILMenuItem
            // 
            this.decompileAsILMenuItem.Name = "decompileAsILMenuItem";
            resources.ApplyResources(this.decompileAsILMenuItem, "decompileAsILMenuItem");
            // 
            // showInternalMembersMenuItem
            // 
            this.showInternalMembersMenuItem.Name = "showInternalMembersMenuItem";
            resources.ApplyResources(this.showInternalMembersMenuItem, "showInternalMembersMenuItem");
            // 
            // sortTreeViewByNameMenuItem
            // 
            this.sortTreeViewByNameMenuItem.Name = "sortTreeViewByNameMenuItem";
            resources.ApplyResources(this.sortTreeViewByNameMenuItem, "sortTreeViewByNameMenuItem");
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            resources.ApplyResources(this.optionsMenuItem, "optionsMenuItem");
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenu.Name = "helpMenu";
            resources.ApplyResources(this.helpMenu, "helpMenu");
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
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

