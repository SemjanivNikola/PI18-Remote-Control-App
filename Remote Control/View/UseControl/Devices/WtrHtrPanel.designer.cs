namespace Remote_Control
{
    partial class WtrHtrPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WtrHtrPanel));
            this.modelWH = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameWH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbWtrHtr = new System.Windows.Forms.PictureBox();
            this.Plus = new System.Windows.Forms.PictureBox();
            this.Minus = new System.Windows.Forms.PictureBox();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.CO2 = new System.Windows.Forms.Label();
            this.tbCo2 = new System.Windows.Forms.TextBox();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.TempPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWtrHtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modelWH
            // 
            this.modelWH.AutoSize = true;
            this.modelWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelWH.Location = new System.Drawing.Point(75, 291);
            this.modelWH.Name = "modelWH";
            this.modelWH.Size = new System.Drawing.Size(10, 15);
            this.modelWH.TabIndex = 5;
            this.modelWH.Text = "/";
            // 
            // DevConnected
            // 
            this.DevConnected.AutoSize = true;
            this.DevConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevConnected.Location = new System.Drawing.Point(139, 261);
            this.DevConnected.Name = "DevConnected";
            this.DevConnected.Size = new System.Drawing.Size(0, 15);
            this.DevConnected.TabIndex = 4;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model.Location = new System.Drawing.Point(21, 291);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(48, 15);
            this.Model.TabIndex = 3;
            this.Model.Text = "Model :";
            // 
            // DeviceConnected
            // 
            this.DeviceConnected.AutoSize = true;
            this.DeviceConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceConnected.Location = new System.Drawing.Point(21, 261);
            this.DeviceConnected.Name = "DeviceConnected";
            this.DeviceConnected.Size = new System.Drawing.Size(112, 15);
            this.DeviceConnected.TabIndex = 2;
            this.DeviceConnected.Text = "Device Connected :";
            // 
            // nameWH
            // 
            this.nameWH.AutoSize = true;
            this.nameWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameWH.Location = new System.Drawing.Point(86, 225);
            this.nameWH.Name = "nameWH";
            this.nameWH.Size = new System.Drawing.Size(10, 15);
            this.nameWH.TabIndex = 1;
            this.nameWH.Text = "/";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.modelWH);
            this.panel1.Controls.Add(this.DevConnected);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.DeviceConnected);
            this.panel1.Controls.Add(this.nameWH);
            this.panel1.Controls.Add(this.pbWtrHtr);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 52;
            // 
            // pbWtrHtr
            // 
            this.pbWtrHtr.Image = ((System.Drawing.Image)(resources.GetObject("pbWtrHtr.Image")));
            this.pbWtrHtr.InitialImage = null;
            this.pbWtrHtr.Location = new System.Drawing.Point(21, 16);
            this.pbWtrHtr.Name = "pbWtrHtr";
            this.pbWtrHtr.Size = new System.Drawing.Size(191, 194);
            this.pbWtrHtr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWtrHtr.TabIndex = 0;
            this.pbWtrHtr.TabStop = false;
            // 
            // Plus
            // 
            this.Plus.Image = ((System.Drawing.Image)(resources.GetObject("Plus.Image")));
            this.Plus.Location = new System.Drawing.Point(307, 118);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(46, 45);
            this.Plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus.TabIndex = 72;
            this.Plus.TabStop = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Image = ((System.Drawing.Image)(resources.GetObject("Minus.Image")));
            this.Minus.Location = new System.Drawing.Point(158, 118);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(55, 45);
            this.Minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus.TabIndex = 71;
            this.Minus.TabStop = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(219, 131);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.ReadOnly = true;
            this.tbTemp.Size = new System.Drawing.Size(82, 20);
            this.tbTemp.TabIndex = 70;
            this.tbTemp.Text = "0";
            this.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CO2
            // 
            this.CO2.AutoSize = true;
            this.CO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO2.Location = new System.Drawing.Point(93, 194);
            this.CO2.Name = "CO2";
            this.CO2.Size = new System.Drawing.Size(40, 16);
            this.CO2.TabIndex = 69;
            this.CO2.Text = "CO2 :";
            // 
            // tbCo2
            // 
            this.tbCo2.Location = new System.Drawing.Point(219, 190);
            this.tbCo2.Name = "tbCo2";
            this.tbCo2.ReadOnly = true;
            this.tbCo2.Size = new System.Drawing.Size(82, 20);
            this.tbCo2.TabIndex = 73;
            this.tbCo2.Text = "0";
            this.tbCo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisconnectBtn.BackgroundImage")));
            this.DisconnectBtn.BorderColor = System.Drawing.Color.Gray;
            this.DisconnectBtn.CornerRadius = 5;
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FillColor = System.Drawing.Color.Red;
            this.DisconnectBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DisconnectBtn.Location = new System.Drawing.Point(161, 371);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.line2,
            this.OnOff,
            this.DisconnectBtn});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 75;
            this.shapeContainer1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Name = "line2";
            this.line2.X1 = 5;
            this.line2.X2 = 491;
            this.line2.Y1 = 342;
            this.line2.Y2 = 342;
            // 
            // OnOff
            // 
            this.OnOff.BackgroundImage = global::Remote_Control.Properties.Resources.off;
            this.OnOff.BorderColor = System.Drawing.Color.Gray;
            this.OnOff.CornerRadius = 5;
            this.OnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnOff.FillColor = System.Drawing.Color.Transparent;
            this.OnOff.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OnOff.Location = new System.Drawing.Point(25, 35);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(61, 22);
            this.OnOff.Click += new System.EventHandler(this.OnOff_Click);
            // 
            // TempPictureBox
            // 
            this.TempPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TempPictureBox.Image")));
            this.TempPictureBox.Location = new System.Drawing.Point(85, 114);
            this.TempPictureBox.Name = "TempPictureBox";
            this.TempPictureBox.Size = new System.Drawing.Size(53, 52);
            this.TempPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TempPictureBox.TabIndex = 76;
            this.TempPictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WtrHtrPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TempPictureBox);
            this.Controls.Add(this.tbCo2);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.CO2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "WtrHtrPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.WaterHeaterPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWtrHtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modelWH;
        private System.Windows.Forms.Label DevConnected;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label DeviceConnected;
        private System.Windows.Forms.Label nameWH;
        private System.Windows.Forms.PictureBox pbWtrHtr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Plus;
        private System.Windows.Forms.PictureBox Minus;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Label CO2;
        private System.Windows.Forms.TextBox tbCo2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox TempPictureBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private System.Windows.Forms.Timer timer1;
    }
}
