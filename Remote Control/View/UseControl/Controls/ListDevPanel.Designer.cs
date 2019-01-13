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
            this.components = new System.ComponentModel.Container();
            this.TimerPnl = new System.Windows.Forms.Timer(this.components);
            this.connTable = new System.Windows.Forms.DataGridView();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ListDevLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sQLiteTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.connTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // connTable
            // 
            this.connTable.AllowUserToAddRows = false;
            this.connTable.AllowUserToDeleteRows = false;
            this.connTable.AllowUserToResizeColumns = false;
            this.connTable.BackgroundColor = System.Drawing.Color.White;
            this.connTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connTable.Location = new System.Drawing.Point(91, 120);
            this.connTable.Name = "connTable";
            this.connTable.ReadOnly = true;
            this.connTable.RowHeadersVisible = false;
            this.connTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.connTable.Size = new System.Drawing.Size(578, 258);
            this.connTable.TabIndex = 31;
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
            this.line2});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // ListDevLabel
            // 
            this.ListDevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListDevLabel.Location = new System.Drawing.Point(84, 18);
            this.ListDevLabel.Name = "ListDevLabel";
            this.ListDevLabel.Size = new System.Drawing.Size(275, 39);
            this.ListDevLabel.TabIndex = 37;
            this.ListDevLabel.Text = "List Of Device";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sQLiteTransactionBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(548, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sQLiteTransactionBindingSource
            // 
            this.sQLiteTransactionBindingSource.DataSource = typeof(Finisar.SQLite.SQLiteTransaction);
            // 
            // ListDevPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ListDevLabel);
            this.Controls.Add(this.connTable);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ListDevPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.ListDevPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerPnl;
        private System.Windows.Forms.DataGridView connTable;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label ListDevLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sQLiteTransactionBindingSource;
    }
}
