namespace Remote_Control
{
    partial class ConnDevPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnDevPanel));
            this.connTable = new System.Windows.Forms.DataGridView();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCancel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnConn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.TimerPnl = new System.Windows.Forms.Timer(this.components);
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WtrHtr = new System.Windows.Forms.PictureBox();
            this.AirCon = new System.Windows.Forms.PictureBox();
            this.labelTV = new System.Windows.Forms.Label();
            this.TV = new System.Windows.Forms.PictureBox();
            this.labelLight = new System.Windows.Forms.Label();
            this.Lights = new System.Windows.Forms.PictureBox();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Refri = new System.Windows.Forms.PictureBox();
            this.Stove = new System.Windows.Forms.PictureBox();
            this.DisWasher = new System.Windows.Forms.PictureBox();
            this.WasMachine = new System.Windows.Forms.PictureBox();
            this.RightArrowPicBox = new System.Windows.Forms.PictureBox();
            this.LeftArrowPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.connTable)).BeginInit();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WtrHtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lights)).BeginInit();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisWasher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WasMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPicBox)).BeginInit();
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
            this.connTable.Location = new System.Drawing.Point(0, 236);
            this.connTable.Name = "connTable";
            this.connTable.ReadOnly = true;
            this.connTable.RowHeadersVisible = false;
            this.connTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.connTable.Size = new System.Drawing.Size(578, 190);
            this.connTable.TabIndex = 0;
            this.connTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.connTable_CellContentClick);
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Name = "line2";
            this.line2.X1 = 21;
            this.line2.X2 = 716;
            this.line2.Y1 = 213;
            this.line2.Y2 = 213;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnCancel,
            this.btnConn,
            this.line2});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.CornerRadius = 5;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.btnCancel.Location = new System.Drawing.Point(601, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 25);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConn
            // 
            this.btnConn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConn.BackgroundImage")));
            this.btnConn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConn.CornerRadius = 5;
            this.btnConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.btnConn.Location = new System.Drawing.Point(593, 284);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(116, 31);
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // Pnl1
            // 
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Controls.Add(this.WtrHtr);
            this.Pnl1.Controls.Add(this.AirCon);
            this.Pnl1.Controls.Add(this.labelTV);
            this.Pnl1.Controls.Add(this.TV);
            this.Pnl1.Controls.Add(this.labelLight);
            this.Pnl1.Controls.Add(this.Lights);
            this.Pnl1.Location = new System.Drawing.Point(68, 29);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(602, 175);
            this.Pnl1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Water Heater";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Air Conditioner";
            // 
            // WtrHtr
            // 
            this.WtrHtr.BackColor = System.Drawing.Color.Transparent;
            this.WtrHtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WtrHtr.Image = ((System.Drawing.Image)(resources.GetObject("WtrHtr.Image")));
            this.WtrHtr.Location = new System.Drawing.Point(474, 3);
            this.WtrHtr.Name = "WtrHtr";
            this.WtrHtr.Size = new System.Drawing.Size(128, 128);
            this.WtrHtr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WtrHtr.TabIndex = 22;
            this.WtrHtr.TabStop = false;
            this.WtrHtr.Click += new System.EventHandler(this.WtrHtr_Click);
            // 
            // AirCon
            // 
            this.AirCon.BackColor = System.Drawing.Color.Transparent;
            this.AirCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AirCon.Image = ((System.Drawing.Image)(resources.GetObject("AirCon.Image")));
            this.AirCon.Location = new System.Drawing.Point(315, 3);
            this.AirCon.Name = "AirCon";
            this.AirCon.Size = new System.Drawing.Size(128, 128);
            this.AirCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AirCon.TabIndex = 21;
            this.AirCon.TabStop = false;
            this.AirCon.Click += new System.EventHandler(this.AirCon_Click);
            // 
            // labelTV
            // 
            this.labelTV.AutoSize = true;
            this.labelTV.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTV.Location = new System.Drawing.Point(180, 147);
            this.labelTV.Name = "labelTV";
            this.labelTV.Size = new System.Drawing.Size(73, 17);
            this.labelTV.TabIndex = 20;
            this.labelTV.Text = "Smart TV";
            // 
            // TV
            // 
            this.TV.BackColor = System.Drawing.Color.Transparent;
            this.TV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TV.Image = ((System.Drawing.Image)(resources.GetObject("TV.Image")));
            this.TV.Location = new System.Drawing.Point(156, 3);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(128, 128);
            this.TV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TV.TabIndex = 19;
            this.TV.TabStop = false;
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // labelLight
            // 
            this.labelLight.AutoSize = true;
            this.labelLight.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLight.Location = new System.Drawing.Point(41, 147);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(51, 17);
            this.labelLight.TabIndex = 18;
            this.labelLight.Text = "Lights";
            // 
            // Lights
            // 
            this.Lights.BackColor = System.Drawing.Color.Transparent;
            this.Lights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lights.Image = ((System.Drawing.Image)(resources.GetObject("Lights.Image")));
            this.Lights.Location = new System.Drawing.Point(0, 3);
            this.Lights.Name = "Lights";
            this.Lights.Size = new System.Drawing.Size(128, 128);
            this.Lights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Lights.TabIndex = 13;
            this.Lights.TabStop = false;
            this.Lights.Click += new System.EventHandler(this.Lights_Click);
            // 
            // Pnl2
            // 
            this.Pnl2.Controls.Add(this.label6);
            this.Pnl2.Controls.Add(this.label5);
            this.Pnl2.Controls.Add(this.label4);
            this.Pnl2.Controls.Add(this.label3);
            this.Pnl2.Controls.Add(this.Refri);
            this.Pnl2.Controls.Add(this.Stove);
            this.Pnl2.Controls.Add(this.DisWasher);
            this.Pnl2.Controls.Add(this.WasMachine);
            this.Pnl2.Location = new System.Drawing.Point(68, 29);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(602, 175);
            this.Pnl2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Refrigerator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Stove";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dish Washer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Washing Machine";
            // 
            // Refri
            // 
            this.Refri.BackColor = System.Drawing.Color.Transparent;
            this.Refri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refri.Image = ((System.Drawing.Image)(resources.GetObject("Refri.Image")));
            this.Refri.Location = new System.Drawing.Point(474, 3);
            this.Refri.Name = "Refri";
            this.Refri.Size = new System.Drawing.Size(128, 128);
            this.Refri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Refri.TabIndex = 18;
            this.Refri.TabStop = false;
            this.Refri.Click += new System.EventHandler(this.Refrigerator_Click);
            // 
            // Stove
            // 
            this.Stove.BackColor = System.Drawing.Color.Transparent;
            this.Stove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stove.Image = ((System.Drawing.Image)(resources.GetObject("Stove.Image")));
            this.Stove.Location = new System.Drawing.Point(315, 3);
            this.Stove.Name = "Stove";
            this.Stove.Size = new System.Drawing.Size(128, 128);
            this.Stove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Stove.TabIndex = 19;
            this.Stove.TabStop = false;
            this.Stove.Click += new System.EventHandler(this.Stove_Click);
            // 
            // DisWasher
            // 
            this.DisWasher.BackColor = System.Drawing.Color.Transparent;
            this.DisWasher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisWasher.Image = ((System.Drawing.Image)(resources.GetObject("DisWasher.Image")));
            this.DisWasher.Location = new System.Drawing.Point(156, 3);
            this.DisWasher.Name = "DisWasher";
            this.DisWasher.Size = new System.Drawing.Size(128, 128);
            this.DisWasher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DisWasher.TabIndex = 16;
            this.DisWasher.TabStop = false;
            this.DisWasher.Click += new System.EventHandler(this.DisWasher_Click);
            // 
            // WasMachine
            // 
            this.WasMachine.BackColor = System.Drawing.Color.Transparent;
            this.WasMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WasMachine.Image = ((System.Drawing.Image)(resources.GetObject("WasMachine.Image")));
            this.WasMachine.Location = new System.Drawing.Point(0, 3);
            this.WasMachine.Name = "WasMachine";
            this.WasMachine.Size = new System.Drawing.Size(128, 128);
            this.WasMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WasMachine.TabIndex = 17;
            this.WasMachine.TabStop = false;
            this.WasMachine.Click += new System.EventHandler(this.WasMachine_Click);
            // 
            // RightArrowPicBox
            // 
            this.RightArrowPicBox.Image = global::Remote_Control.Properties.Resources.right;
            this.RightArrowPicBox.Location = new System.Drawing.Point(669, 71);
            this.RightArrowPicBox.Name = "RightArrowPicBox";
            this.RightArrowPicBox.Size = new System.Drawing.Size(64, 64);
            this.RightArrowPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RightArrowPicBox.TabIndex = 3;
            this.RightArrowPicBox.TabStop = false;
            this.RightArrowPicBox.Click += new System.EventHandler(this.RightArrowPicBox_Click);
            // 
            // LeftArrowPicBox
            // 
            this.LeftArrowPicBox.Image = global::Remote_Control.Properties.Resources.leftGray;
            this.LeftArrowPicBox.Location = new System.Drawing.Point(3, 71);
            this.LeftArrowPicBox.Name = "LeftArrowPicBox";
            this.LeftArrowPicBox.Size = new System.Drawing.Size(64, 64);
            this.LeftArrowPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LeftArrowPicBox.TabIndex = 2;
            this.LeftArrowPicBox.TabStop = false;
            this.LeftArrowPicBox.Click += new System.EventHandler(this.LeftArrowPicBox_Click);
            // 
            // ConnDevPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.RightArrowPicBox);
            this.Controls.Add(this.LeftArrowPicBox);
            this.Controls.Add(this.connTable);
            this.Controls.Add(this.shapeContainer1);
            this.Controls.Add(this.Pnl2);
            this.Name = "ConnDevPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.ConnDevPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connTable)).EndInit();
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WtrHtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lights)).EndInit();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisWasher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WasMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView connTable;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox LeftArrowPicBox;
        private System.Windows.Forms.PictureBox RightArrowPicBox;
        private System.Windows.Forms.Timer TimerPnl;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.PictureBox Lights;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.PictureBox TV;
        private System.Windows.Forms.Label labelTV;
        private System.Windows.Forms.PictureBox AirCon;
        private System.Windows.Forms.PictureBox WtrHtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.PictureBox Refri;
        private System.Windows.Forms.PictureBox Stove;
        private System.Windows.Forms.PictureBox DisWasher;
        private System.Windows.Forms.PictureBox WasMachine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnConn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnCancel;
    }
}
