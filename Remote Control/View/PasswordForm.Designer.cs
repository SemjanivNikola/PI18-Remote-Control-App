namespace Remote_Control
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.lblText = new System.Windows.Forms.Label();
            this.tbPassVal = new System.Windows.Forms.TextBox();
            this.pbVal = new System.Windows.Forms.PictureBox();
            this.btnConn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCancel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(10, 24);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(160, 15);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Type the password of device";
            // 
            // tbPassVal
            // 
            this.tbPassVal.Location = new System.Drawing.Point(12, 50);
            this.tbPassVal.Name = "tbPassVal";
            this.tbPassVal.Size = new System.Drawing.Size(157, 20);
            this.tbPassVal.TabIndex = 1;
            this.tbPassVal.TextChanged += new System.EventHandler(this.tbPassVal_TextChanged);
            // 
            // pbVal
            // 
            this.pbVal.Location = new System.Drawing.Point(175, 47);
            this.pbVal.Name = "pbVal";
            this.pbVal.Size = new System.Drawing.Size(28, 24);
            this.pbVal.TabIndex = 2;
            this.pbVal.TabStop = false;
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
            this.btnConn.Location = new System.Drawing.Point(132, 88);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(116, 31);
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnCancel,
            this.btnConn});
            this.shapeContainer1.Size = new System.Drawing.Size(256, 129);
            this.shapeContainer1.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(11, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 25);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 129);
            this.Controls.Add(this.pbVal);
            this.Controls.Add(this.tbPassVal);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnConn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnCancel;
        private System.Windows.Forms.TextBox tbPassVal;
        private System.Windows.Forms.PictureBox pbVal;
    }
}