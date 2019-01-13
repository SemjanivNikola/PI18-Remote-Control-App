namespace Remote_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.BackTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ForrwardTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrDevTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTool = new System.Windows.Forms.ToolStripMenuItem();
            this.disconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.IzbornikProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.importDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IzbornikAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.ListButton = new System.Windows.Forms.Button();
            this.ConnButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToolBar.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackTool,
            this.ForrwardTool,
            this.CurrDevTool,
            this.RefreshTool,
            this.disconToolStripMenuItem});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ToolBar.Size = new System.Drawing.Size(876, 28);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "ToolBar";
            // 
            // BackTool
            // 
            this.BackTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackTool.Image = ((System.Drawing.Image)(resources.GetObject("BackTool.Image")));
            this.BackTool.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BackTool.Name = "BackTool";
            this.BackTool.Padding = new System.Windows.Forms.Padding(0);
            this.BackTool.Size = new System.Drawing.Size(24, 24);
            this.BackTool.Text = "Back";
            this.BackTool.Click += new System.EventHandler(this.BackTool_Click);
            // 
            // ForrwardTool
            // 
            this.ForrwardTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForrwardTool.Image = ((System.Drawing.Image)(resources.GetObject("ForrwardTool.Image")));
            this.ForrwardTool.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ForrwardTool.Name = "ForrwardTool";
            this.ForrwardTool.Padding = new System.Windows.Forms.Padding(0);
            this.ForrwardTool.Size = new System.Drawing.Size(24, 24);
            this.ForrwardTool.Text = "Forward";
            this.ForrwardTool.Click += new System.EventHandler(this.ForrwardTool_Click);
            // 
            // CurrDevTool
            // 
            this.CurrDevTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrDevTool.Image = global::Remote_Control.Properties.Resources.CurrentGray;
            this.CurrDevTool.Name = "CurrDevTool";
            this.CurrDevTool.Padding = new System.Windows.Forms.Padding(35, 0, 4, 0);
            this.CurrDevTool.Size = new System.Drawing.Size(63, 24);
            this.CurrDevTool.Text = "CurrDev";
            this.CurrDevTool.Click += new System.EventHandler(this.CurrDevTool_Click);
            // 
            // RefreshTool
            // 
            this.RefreshTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshTool.Image = ((System.Drawing.Image)(resources.GetObject("RefreshTool.Image")));
            this.RefreshTool.Name = "RefreshTool";
            this.RefreshTool.Size = new System.Drawing.Size(32, 24);
            this.RefreshTool.Text = "Refresh";
            // 
            // disconToolStripMenuItem
            // 
            this.disconToolStripMenuItem.Name = "disconToolStripMenuItem";
            this.disconToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // MenuBar
            // 
            this.MenuBar.AllowMerge = false;
            this.MenuBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IzbornikProgram,
            this.IzbornikAbout});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuBar.Size = new System.Drawing.Size(876, 24);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "TrakaIzbornici";
            // 
            // IzbornikProgram
            // 
            this.IzbornikProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDeviceToolStripMenuItem,
            this.deleteDeviceToolStripMenuItem,
            this.connectToDeviceToolStripMenuItem,
            this.listOfDeviceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.IzbornikProgram.Name = "IzbornikProgram";
            this.IzbornikProgram.Size = new System.Drawing.Size(65, 20);
            this.IzbornikProgram.Text = "Program";
            // 
            // importDeviceToolStripMenuItem
            // 
            this.importDeviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickImportToolStripMenuItem,
            this.selectDeviceToolStripMenuItem});
            this.importDeviceToolStripMenuItem.Name = "importDeviceToolStripMenuItem";
            this.importDeviceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importDeviceToolStripMenuItem.Text = "Import Device";
            // 
            // quickImportToolStripMenuItem
            // 
            this.quickImportToolStripMenuItem.Name = "quickImportToolStripMenuItem";
            this.quickImportToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.quickImportToolStripMenuItem.Text = "Quick Import";
            this.quickImportToolStripMenuItem.Click += new System.EventHandler(this.quickImportToolStripMenuItem_Click);
            // 
            // selectDeviceToolStripMenuItem
            // 
            this.selectDeviceToolStripMenuItem.Name = "selectDeviceToolStripMenuItem";
            this.selectDeviceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectDeviceToolStripMenuItem.Text = "Select Device";
            this.selectDeviceToolStripMenuItem.Click += new System.EventHandler(this.selectDeviceToolStripMenuItem_Click);
            // 
            // deleteDeviceToolStripMenuItem
            // 
            this.deleteDeviceToolStripMenuItem.Name = "deleteDeviceToolStripMenuItem";
            this.deleteDeviceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteDeviceToolStripMenuItem.Text = "Delete Device";
            // 
            // connectToDeviceToolStripMenuItem
            // 
            this.connectToDeviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.item3ToolStripMenuItem});
            this.connectToDeviceToolStripMenuItem.Name = "connectToDeviceToolStripMenuItem";
            this.connectToDeviceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.connectToDeviceToolStripMenuItem.Text = "Connect to Device";
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.item1ToolStripMenuItem.Text = "Item1";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.item2ToolStripMenuItem.Text = "Item2";
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.item3ToolStripMenuItem.Text = "Item3";
            // 
            // listOfDeviceToolStripMenuItem
            // 
            this.listOfDeviceToolStripMenuItem.Name = "listOfDeviceToolStripMenuItem";
            this.listOfDeviceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listOfDeviceToolStripMenuItem.Text = "List of Device";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // IzbornikAbout
            // 
            this.IzbornikAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developersToolStripMenuItem,
            this.applicationToolStripMenuItem});
            this.IzbornikAbout.Name = "IzbornikAbout";
            this.IzbornikAbout.Size = new System.Drawing.Size(52, 20);
            this.IzbornikAbout.Text = "About";
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.developersToolStripMenuItem.Text = "Developers";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonPanel.Controls.Add(this.LogoBox);
            this.ButtonPanel.Controls.Add(this.ListButton);
            this.ButtonPanel.Controls.Add(this.ConnButton);
            this.ButtonPanel.Controls.Add(this.DelButton);
            this.ButtonPanel.Controls.Add(this.ImportButton);
            this.ButtonPanel.Location = new System.Drawing.Point(1, 54);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(135, 427);
            this.ButtonPanel.TabIndex = 2;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(3, 218);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(135, 124);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 4;
            this.LogoBox.TabStop = false;
            // 
            // ListButton
            // 
            this.ListButton.BackColor = System.Drawing.Color.LightGray;
            this.ListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListButton.ForeColor = System.Drawing.Color.DarkGray;
            this.ListButton.Image = global::Remote_Control.Properties.Resources.ListGray;
            this.ListButton.Location = new System.Drawing.Point(0, 129);
            this.ListButton.Margin = new System.Windows.Forms.Padding(2);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(135, 44);
            this.ListButton.TabIndex = 3;
            this.ListButton.Text = "List of Device";
            this.ListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ListButton.UseVisualStyleBackColor = false;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // ConnButton
            // 
            this.ConnButton.BackColor = System.Drawing.Color.LightGray;
            this.ConnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnButton.ForeColor = System.Drawing.Color.DarkGray;
            this.ConnButton.Image = global::Remote_Control.Properties.Resources.ConnectGray;
            this.ConnButton.Location = new System.Drawing.Point(0, 86);
            this.ConnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnButton.Name = "ConnButton";
            this.ConnButton.Size = new System.Drawing.Size(135, 44);
            this.ConnButton.TabIndex = 2;
            this.ConnButton.Text = "Connect to Device";
            this.ConnButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConnButton.UseVisualStyleBackColor = false;
            this.ConnButton.Click += new System.EventHandler(this.ConnButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.LightGray;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.ForeColor = System.Drawing.Color.DarkGray;
            this.DelButton.Image = ((System.Drawing.Image)(resources.GetObject("DelButton.Image")));
            this.DelButton.Location = new System.Drawing.Point(0, 43);
            this.DelButton.Margin = new System.Windows.Forms.Padding(2);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(135, 44);
            this.DelButton.TabIndex = 1;
            this.DelButton.Text = "Delete Device";
            this.DelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.LightGray;
            this.ImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.ForeColor = System.Drawing.Color.DarkGray;
            this.ImportButton.Image = ((System.Drawing.Image)(resources.GetObject("ImportButton.Image")));
            this.ImportButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImportButton.Location = new System.Drawing.Point(0, 0);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(135, 44);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "Import Device";
            this.ImportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusLabel,
            this.ConStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 482);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusBar.Size = new System.Drawing.Size(876, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Maximum = 300;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusLabel.Text = "Ready";
            // 
            // ConStatus
            // 
            this.ConStatus.Margin = new System.Windows.Forms.Padding(635, 3, 0, 2);
            this.ConStatus.Name = "ConStatus";
            this.ConStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConStatus.Size = new System.Drawing.Size(79, 17);
            this.ConStatus.Text = "Disconnected";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Location = new System.Drawing.Point(138, 55);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(736, 426);
            this.MainPanel.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 504);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Remote Control App";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolBar;
        private System.Windows.Forms.ToolStripMenuItem BackTool;
        private System.Windows.Forms.ToolStripMenuItem ForrwardTool;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem IzbornikProgram;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button ConnButton;
        private System.Windows.Forms.ToolStripMenuItem CurrDevTool;
        private System.Windows.Forms.ToolStripMenuItem IzbornikAbout;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ConStatus;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem importDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.ToolStripMenuItem RefreshTool;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem disconToolStripMenuItem;
    }
}

