namespace Remote_Control
{
    partial class ImpPropPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpPropPanel));
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbPass = new System.Windows.Forms.ComboBox();
            this.Rtb = new System.Windows.Forms.RichTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCancel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnSave = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lastSaveTable = new System.Windows.Forms.DataGridView();
            this.nameVal = new System.Windows.Forms.Label();
            this.snVal = new System.Windows.Forms.Label();
            this.modelVal = new System.Windows.Forms.Label();
            this.passVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lastSaveTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(215, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(215, 161);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(215, 271);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(408, 67);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(94, 16);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Serial Number";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(408, 271);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(68, 16);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(408, 161);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(511, 161);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 16);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Location = new System.Drawing.Point(215, 181);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(177, 20);
            this.tbName.TabIndex = 9;
            this.tbName.Text = "Type Name";
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbModel
            // 
            this.tbModel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbModel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbModel.Location = new System.Drawing.Point(215, 291);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(143, 20);
            this.tbModel.TabIndex = 10;
            this.tbModel.Text = "Type Model";
            this.tbModel.Click += new System.EventHandler(this.tbModel_Click);
            this.tbModel.Validating += new System.ComponentModel.CancelEventHandler(this.tbModel_Validating);
            // 
            // tbSN
            // 
            this.tbSN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSN.Location = new System.Drawing.Point(411, 87);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(174, 20);
            this.tbSN.TabIndex = 11;
            this.tbSN.Text = "Type Serial Number";
            this.tbSN.Click += new System.EventHandler(this.tbSN_Click);
            this.tbSN.Validating += new System.ComponentModel.CancelEventHandler(this.tbSN_Validating);
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbDate.Location = new System.Drawing.Point(409, 181);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(84, 20);
            this.tbDate.TabIndex = 12;
            this.tbDate.TextChanged += new System.EventHandler(this.tbDate_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPass.Location = new System.Drawing.Point(409, 318);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(149, 20);
            this.tbPass.TabIndex = 15;
            this.tbPass.Text = "Type Password";
            this.tbPass.Click += new System.EventHandler(this.tbPass_Click);
            this.tbPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbPass_Validating);
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbTime.Location = new System.Drawing.Point(512, 181);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(59, 20);
            this.tbTime.TabIndex = 13;
            this.tbTime.TextChanged += new System.EventHandler(this.tbTime_TextChanged);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Lights",
            "TV",
            "Stove",
            "Air Conditioner",
            "Refrigerator",
            "Washing Machine",
            "Water Heater",
            "Dishwasher"});
            this.cbType.Location = new System.Drawing.Point(215, 87);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 8;
            this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
            // 
            // cbPass
            // 
            this.cbPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbPass.FormattingEnabled = true;
            this.cbPass.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbPass.Location = new System.Drawing.Point(409, 291);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(72, 21);
            this.cbPass.TabIndex = 14;
            this.cbPass.Text = "YES";
            this.cbPass.SelectedIndexChanged += new System.EventHandler(this.cbPass_SelectedIndexChanged);
            // 
            // Rtb
            // 
            this.Rtb.Location = new System.Drawing.Point(-1, 368);
            this.Rtb.Name = "Rtb";
            this.Rtb.ReadOnly = true;
            this.Rtb.Size = new System.Drawing.Size(736, 58);
            this.Rtb.TabIndex = 0;
            this.Rtb.Text = " . . .";
            this.Rtb.TextChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnCancel,
            this.btnSave});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 19;
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
            this.btnCancel.Location = new System.Drawing.Point(608, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 25);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.CornerRadius = 5;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.btnSave.Location = new System.Drawing.Point(609, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 25);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lastSaveTable
            // 
            this.lastSaveTable.AllowUserToAddRows = false;
            this.lastSaveTable.AllowUserToDeleteRows = false;
            this.lastSaveTable.AllowUserToResizeRows = false;
            this.lastSaveTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastSaveTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastSaveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lastSaveTable.Location = new System.Drawing.Point(0, 0);
            this.lastSaveTable.Name = "lastSaveTable";
            this.lastSaveTable.ReadOnly = true;
            this.lastSaveTable.RowHeadersVisible = false;
            this.lastSaveTable.RowHeadersWidth = 38;
            this.lastSaveTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lastSaveTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lastSaveTable.Size = new System.Drawing.Size(212, 369);
            this.lastSaveTable.TabIndex = 0;
            // 
            // nameVal
            // 
            this.nameVal.AutoSize = true;
            this.nameVal.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameVal.ForeColor = System.Drawing.Color.Red;
            this.nameVal.Location = new System.Drawing.Point(218, 204);
            this.nameVal.Name = "nameVal";
            this.nameVal.Size = new System.Drawing.Size(167, 14);
            this.nameVal.TabIndex = 20;
            this.nameVal.Text = "*Please type in valid name of device ";
            this.nameVal.Visible = false;
            // 
            // snVal
            // 
            this.snVal.AutoSize = true;
            this.snVal.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snVal.ForeColor = System.Drawing.Color.Red;
            this.snVal.Location = new System.Drawing.Point(410, 110);
            this.snVal.Name = "snVal";
            this.snVal.Size = new System.Drawing.Size(164, 14);
            this.snVal.TabIndex = 21;
            this.snVal.Text = "*Please type in valid Serial Number";
            this.snVal.Visible = false;
            // 
            // modelVal
            // 
            this.modelVal.AutoSize = true;
            this.modelVal.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelVal.ForeColor = System.Drawing.Color.Red;
            this.modelVal.Location = new System.Drawing.Point(215, 314);
            this.modelVal.Name = "modelVal";
            this.modelVal.Size = new System.Drawing.Size(166, 14);
            this.modelVal.TabIndex = 22;
            this.modelVal.Text = "*Please type in valid model of device";
            this.modelVal.Visible = false;
            // 
            // passVal
            // 
            this.passVal.AutoSize = true;
            this.passVal.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passVal.ForeColor = System.Drawing.Color.Red;
            this.passVal.Location = new System.Drawing.Point(408, 341);
            this.passVal.Name = "passVal";
            this.passVal.Size = new System.Drawing.Size(106, 14);
            this.passVal.TabIndex = 23;
            this.passVal.Text = "*Password is not valid";
            this.passVal.Visible = false;
            // 
            // ImpPropPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.passVal);
            this.Controls.Add(this.modelVal);
            this.Controls.Add(this.snVal);
            this.Controls.Add(this.nameVal);
            this.Controls.Add(this.lastSaveTable);
            this.Controls.Add(this.Rtb);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ImpPropPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.ImpPropPanel_Load);
            this.VisibleChanged += new System.EventHandler(this.ImpPropPanel_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.lastSaveTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.ComboBox cbPass;
        private System.Windows.Forms.RichTextBox Rtb;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnCancel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnSave;
        private System.Windows.Forms.DataGridView lastSaveTable;
        public System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label nameVal;
        private System.Windows.Forms.Label snVal;
        private System.Windows.Forms.Label modelVal;
        private System.Windows.Forms.Label passVal;
    }
}
