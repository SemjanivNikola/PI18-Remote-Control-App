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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WtrHtrPanel));
            this.modelWH = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameWH = new System.Windows.Forms.Label();
            this.LabelOnOff = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WaterHeaterBox = new System.Windows.Forms.PictureBox();
            this.Plus1 = new System.Windows.Forms.PictureBox();
            this.Minus1 = new System.Windows.Forms.PictureBox();
            this.PlateValue1 = new System.Windows.Forms.TextBox();
            this.CO2 = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaterHeaterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus1)).BeginInit();
            this.SuspendLayout();
            // 
            // modelWH
            // 
            this.modelWH.AutoSize = true;
            this.modelWH.Location = new System.Drawing.Point(66, 291);
            this.modelWH.Name = "modelWH";
            this.modelWH.Size = new System.Drawing.Size(12, 13);
            this.modelWH.TabIndex = 5;
            this.modelWH.Text = "/";
            // 
            // DevConnected
            // 
            this.DevConnected.AutoSize = true;
            this.DevConnected.Location = new System.Drawing.Point(126, 261);
            this.DevConnected.Name = "DevConnected";
            this.DevConnected.Size = new System.Drawing.Size(12, 13);
            this.DevConnected.TabIndex = 4;
            this.DevConnected.Text = "/";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(21, 291);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(42, 13);
            this.Model.TabIndex = 3;
            this.Model.Text = "Model :";
            // 
            // DeviceConnected
            // 
            this.DeviceConnected.AutoSize = true;
            this.DeviceConnected.Location = new System.Drawing.Point(21, 261);
            this.DeviceConnected.Name = "DeviceConnected";
            this.DeviceConnected.Size = new System.Drawing.Size(102, 13);
            this.DeviceConnected.TabIndex = 2;
            this.DeviceConnected.Text = "Device Connected :";
            // 
            // nameWH
            // 
            this.nameWH.AutoSize = true;
            this.nameWH.Location = new System.Drawing.Point(100, 224);
            this.nameWH.Name = "nameWH";
            this.nameWH.Size = new System.Drawing.Size(12, 13);
            this.nameWH.TabIndex = 1;
            this.nameWH.Text = "/";
            // 
            // LabelOnOff
            // 
            this.LabelOnOff.AutoSize = true;
            this.LabelOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOnOff.ForeColor = System.Drawing.Color.White;
            this.LabelOnOff.Location = new System.Drawing.Point(29, 19);
            this.LabelOnOff.Name = "LabelOnOff";
            this.LabelOnOff.Size = new System.Drawing.Size(64, 16);
            this.LabelOnOff.TabIndex = 53;
            this.LabelOnOff.Text = "ON/OFF";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.modelWH);
            this.panel1.Controls.Add(this.DevConnected);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.DeviceConnected);
            this.panel1.Controls.Add(this.nameWH);
            this.panel1.Controls.Add(this.WaterHeaterBox);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 52;
            // 
            // WaterHeaterBox
            // 
            this.WaterHeaterBox.Image = ((System.Drawing.Image)(resources.GetObject("WaterHeaterBox.Image")));
            this.WaterHeaterBox.InitialImage = null;
            this.WaterHeaterBox.Location = new System.Drawing.Point(21, 16);
            this.WaterHeaterBox.Name = "WaterHeaterBox";
            this.WaterHeaterBox.Size = new System.Drawing.Size(191, 194);
            this.WaterHeaterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WaterHeaterBox.TabIndex = 0;
            this.WaterHeaterBox.TabStop = false;
            // 
            // Plus1
            // 
            this.Plus1.Image = ((System.Drawing.Image)(resources.GetObject("Plus1.Image")));
            this.Plus1.Location = new System.Drawing.Point(307, 118);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(46, 45);
            this.Plus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus1.TabIndex = 72;
            this.Plus1.TabStop = false;
            // 
            // Minus1
            // 
            this.Minus1.Image = ((System.Drawing.Image)(resources.GetObject("Minus1.Image")));
            this.Minus1.Location = new System.Drawing.Point(158, 118);
            this.Minus1.Name = "Minus1";
            this.Minus1.Size = new System.Drawing.Size(55, 45);
            this.Minus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus1.TabIndex = 71;
            this.Minus1.TabStop = false;
            // 
            // PlateValue1
            // 
            this.PlateValue1.Location = new System.Drawing.Point(219, 143);
            this.PlateValue1.Name = "PlateValue1";
            this.PlateValue1.Size = new System.Drawing.Size(82, 20);
            this.PlateValue1.TabIndex = 70;
            this.PlateValue1.Text = "0";
            this.PlateValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CO2
            // 
            this.CO2.AutoSize = true;
            this.CO2.Location = new System.Drawing.Point(40, 294);
            this.CO2.Name = "CO2";
            this.CO2.Size = new System.Drawing.Size(31, 13);
            this.CO2.TabIndex = 69;
            this.CO2.Text = "CO2:";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(68, 133);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(70, 13);
            this.Temperature.TabIndex = 68;
            this.Temperature.Text = "Temperature:";
            this.Temperature.Click += new System.EventHandler(this.Plate1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 365);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(503, 61);
            this.textBox.TabIndex = 74;
            this.textBox.Text = " . . . ";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisconnectBtn.BackgroundImage")));
            this.DisconnectBtn.BorderColor = System.Drawing.Color.Red;
            this.DisconnectBtn.CornerRadius = 5;
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FillColor = System.Drawing.Color.Red;
            this.DisconnectBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DisconnectBtn.Location = new System.Drawing.Point(191, 303);
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
            this.DisconnectBtn});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 75;
            this.shapeContainer1.TabStop = false;
            // 
            // WtrHtrPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Plus1);
            this.Controls.Add(this.Minus1);
            this.Controls.Add(this.PlateValue1);
            this.Controls.Add(this.CO2);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.LabelOnOff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "WtrHtrPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.WaterHeaterPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaterHeaterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modelWH;
        private System.Windows.Forms.Label DevConnected;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label DeviceConnected;
        private System.Windows.Forms.Label nameWH;
        private System.Windows.Forms.PictureBox WaterHeaterBox;
        private System.Windows.Forms.Label LabelOnOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Plus1;
        private System.Windows.Forms.PictureBox Minus1;
        private System.Windows.Forms.TextBox PlateValue1;
        private System.Windows.Forms.Label CO2;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox textBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}
