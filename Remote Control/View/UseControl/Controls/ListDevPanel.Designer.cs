namespace Remote_Control
{
    partial class ListDevPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDevPanel));
            this.listTable = new System.Windows.Forms.DataGridView();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.showAllBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btwDel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnFav = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnSearch = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ListDevLabel = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listTable)).BeginInit();
            this.SuspendLayout();
            // 
            // listTable
            // 
            this.listTable.AllowUserToAddRows = false;
            this.listTable.AllowUserToDeleteRows = false;
            this.listTable.AllowUserToResizeRows = false;
            this.listTable.BackgroundColor = System.Drawing.Color.White;
            this.listTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listTable.Location = new System.Drawing.Point(0, 136);
            this.listTable.Name = "listTable";
            this.listTable.ReadOnly = true;
            this.listTable.RowHeadersVisible = false;
            this.listTable.RowHeadersWidth = 43;
            this.listTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listTable.Size = new System.Drawing.Size(736, 290);
            this.listTable.TabIndex = 31;
            this.listTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTable_CellClick);
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Name = "line2";
            this.line2.X1 = 24;
            this.line2.X2 = 719;
            this.line2.Y1 = 67;
            this.line2.Y2 = 67;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.showAllBtn,
            this.btwDel,
            this.btnFav,
            this.btnSearch,
            this.line2});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // showAllBtn
            // 
            this.showAllBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showAllBtn.BackgroundImage")));
            this.showAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showAllBtn.BorderColor = System.Drawing.Color.Gray;
            this.showAllBtn.CornerRadius = 5;
            this.showAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllBtn.FillColor = System.Drawing.Color.Transparent;
            this.showAllBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.showAllBtn.Location = new System.Drawing.Point(413, 86);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(110, 20);
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // btwDel
            // 
            this.btwDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btwDel.BackgroundImage")));
            this.btwDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btwDel.BorderColor = System.Drawing.Color.Gray;
            this.btwDel.CornerRadius = 5;
            this.btwDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btwDel.FillColor = System.Drawing.Color.Transparent;
            this.btwDel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.btwDel.Location = new System.Drawing.Point(294, 86);
            this.btwDel.Name = "btwDel";
            this.btwDel.Size = new System.Drawing.Size(89, 20);
            this.btwDel.Click += new System.EventHandler(this.btwDel_Click);
            // 
            // btnFav
            // 
            this.btnFav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFav.BackgroundImage")));
            this.btnFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFav.BorderColor = System.Drawing.Color.Gray;
            this.btnFav.CornerRadius = 5;
            this.btnFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFav.FillColor = System.Drawing.Color.Transparent;
            this.btnFav.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.btnFav.Location = new System.Drawing.Point(600, 83);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(107, 23);
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderColor = System.Drawing.Color.Gray;
            this.btnSearch.CornerRadius = 5;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.btnSearch.Location = new System.Drawing.Point(168, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 20);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ListDevLabel
            // 
            this.ListDevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListDevLabel.Location = new System.Drawing.Point(84, 18);
            this.ListDevLabel.Name = "ListDevLabel";
            this.ListDevLabel.Size = new System.Drawing.Size(275, 39);
            this.ListDevLabel.TabIndex = 37;
            this.ListDevLabel.Text = "List Of Devices";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Lights",
            "TV",
            "Air Conditioner",
            "Water Heater",
            "Washing Machine",
            "Dishwasher",
            "Stove",
            "Refrigerator"});
            this.cbType.Location = new System.Drawing.Point(24, 86);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 38;
            // 
            // ListDevPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.ListDevLabel);
            this.Controls.Add(this.listTable);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ListDevPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.ListDevPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView listTable;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label ListDevLabel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnSearch;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnFav;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btwDel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape showAllBtn;
        public System.Windows.Forms.ComboBox cbType;
    }
}
