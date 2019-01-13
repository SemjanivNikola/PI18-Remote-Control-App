namespace Remote_Control
{
    partial class WasMachinePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WasMachinePanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.modelWM = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameWM = new System.Windows.Forms.Label();
            this.WascMashheBox = new System.Windows.Forms.PictureBox();
            this.LabelOnOff = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.DelayStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChoseTemperature = new System.Windows.Forms.Label();
            this.cbTemp = new System.Windows.Forms.ComboBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Centrifuga = new System.Windows.Forms.PictureBox();
            this.Jeans = new System.Windows.Forms.PictureBox();
            this.BlackLoundrey = new System.Windows.Forms.PictureBox();
            this.Wool = new System.Windows.Forms.PictureBox();
            this.Snickers = new System.Windows.Forms.PictureBox();
            this.WhiteLoundrey = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WascMashheBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Centrifuga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLoundrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snickers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteLoundrey)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.modelWM);
            this.panel1.Controls.Add(this.DevConnected);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.DeviceConnected);
            this.panel1.Controls.Add(this.nameWM);
            this.panel1.Controls.Add(this.WascMashheBox);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 4;
            // 
            // modelWM
            // 
            this.modelWM.AutoSize = true;
            this.modelWM.Location = new System.Drawing.Point(69, 291);
            this.modelWM.Name = "modelWM";
            this.modelWM.Size = new System.Drawing.Size(12, 13);
            this.modelWM.TabIndex = 5;
            this.modelWM.Text = "/";
            // 
            // DevConnected
            // 
            this.DevConnected.AutoSize = true;
            this.DevConnected.Location = new System.Drawing.Point(127, 261);
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
            // nameWM
            // 
            this.nameWM.AutoSize = true;
            this.nameWM.Location = new System.Drawing.Point(100, 224);
            this.nameWM.Name = "nameWM";
            this.nameWM.Size = new System.Drawing.Size(12, 13);
            this.nameWM.TabIndex = 1;
            this.nameWM.Text = "/";
            // 
            // WascMashheBox
            // 
            this.WascMashheBox.Image = ((System.Drawing.Image)(resources.GetObject("WascMashheBox.Image")));
            this.WascMashheBox.Location = new System.Drawing.Point(21, 16);
            this.WascMashheBox.Name = "WascMashheBox";
            this.WascMashheBox.Size = new System.Drawing.Size(191, 194);
            this.WascMashheBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WascMashheBox.TabIndex = 0;
            this.WascMashheBox.TabStop = false;
            this.WascMashheBox.Click += new System.EventHandler(this.StovePictureBox_Click);
            // 
            // LabelOnOff
            // 
            this.LabelOnOff.AutoSize = true;
            this.LabelOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOnOff.ForeColor = System.Drawing.Color.White;
            this.LabelOnOff.Location = new System.Drawing.Point(36, 37);
            this.LabelOnOff.Name = "LabelOnOff";
            this.LabelOnOff.Size = new System.Drawing.Size(64, 16);
            this.LabelOnOff.TabIndex = 11;
            this.LabelOnOff.Text = "ON/OFF";
            // 
            // cbTimer
            // 
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Location = new System.Drawing.Point(362, 53);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(121, 21);
            this.cbTimer.TabIndex = 38;
            this.cbTimer.SelectedIndexChanged += new System.EventHandler(this.TimerComboBox_SelectedIndexChanged);
            // 
            // DelayStart
            // 
            this.DelayStart.AutoSize = true;
            this.DelayStart.Location = new System.Drawing.Point(294, 56);
            this.DelayStart.Name = "DelayStart";
            this.DelayStart.Size = new System.Drawing.Size(62, 13);
            this.DelayStart.TabIndex = 39;
            this.DelayStart.Text = "Delay Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "SET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "PAUSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(405, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "STOP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "70°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "60°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "50°";
            // 
            // ChoseTemperature
            // 
            this.ChoseTemperature.AutoSize = true;
            this.ChoseTemperature.Location = new System.Drawing.Point(253, 95);
            this.ChoseTemperature.Name = "ChoseTemperature";
            this.ChoseTemperature.Size = new System.Drawing.Size(103, 13);
            this.ChoseTemperature.TabIndex = 57;
            this.ChoseTemperature.Text = "Chose Temperature:";
            // 
            // cbTemp
            // 
            this.cbTemp.FormattingEnabled = true;
            this.cbTemp.Location = new System.Drawing.Point(362, 92);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(121, 21);
            this.cbTemp.TabIndex = 56;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(289, 237);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(90, 74);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 55;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(200, 237);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 74);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 54;
            this.pictureBox7.TabStop = false;
            // 
            // Centrifuga
            // 
            this.Centrifuga.Image = ((System.Drawing.Image)(resources.GetObject("Centrifuga.Image")));
            this.Centrifuga.Location = new System.Drawing.Point(114, 237);
            this.Centrifuga.Name = "Centrifuga";
            this.Centrifuga.Size = new System.Drawing.Size(90, 74);
            this.Centrifuga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Centrifuga.TabIndex = 53;
            this.Centrifuga.TabStop = false;
            // 
            // Jeans
            // 
            this.Jeans.Image = ((System.Drawing.Image)(resources.GetObject("Jeans.Image")));
            this.Jeans.Location = new System.Drawing.Point(375, 134);
            this.Jeans.Name = "Jeans";
            this.Jeans.Size = new System.Drawing.Size(90, 74);
            this.Jeans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Jeans.TabIndex = 52;
            this.Jeans.TabStop = false;
            // 
            // BlackLoundrey
            // 
            this.BlackLoundrey.Image = ((System.Drawing.Image)(resources.GetObject("BlackLoundrey.Image")));
            this.BlackLoundrey.Location = new System.Drawing.Point(288, 134);
            this.BlackLoundrey.Name = "BlackLoundrey";
            this.BlackLoundrey.Size = new System.Drawing.Size(90, 74);
            this.BlackLoundrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlackLoundrey.TabIndex = 51;
            this.BlackLoundrey.TabStop = false;
            // 
            // Wool
            // 
            this.Wool.Image = ((System.Drawing.Image)(resources.GetObject("Wool.Image")));
            this.Wool.Location = new System.Drawing.Point(108, 134);
            this.Wool.Name = "Wool";
            this.Wool.Size = new System.Drawing.Size(96, 74);
            this.Wool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Wool.TabIndex = 47;
            this.Wool.TabStop = false;
            // 
            // Snickers
            // 
            this.Snickers.Image = ((System.Drawing.Image)(resources.GetObject("Snickers.Image")));
            this.Snickers.Location = new System.Drawing.Point(201, 134);
            this.Snickers.Name = "Snickers";
            this.Snickers.Size = new System.Drawing.Size(90, 74);
            this.Snickers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Snickers.TabIndex = 46;
            this.Snickers.TabStop = false;
            // 
            // WhiteLoundrey
            // 
            this.WhiteLoundrey.Image = ((System.Drawing.Image)(resources.GetObject("WhiteLoundrey.Image")));
            this.WhiteLoundrey.Location = new System.Drawing.Point(21, 134);
            this.WhiteLoundrey.Name = "WhiteLoundrey";
            this.WhiteLoundrey.Size = new System.Drawing.Size(90, 74);
            this.WhiteLoundrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WhiteLoundrey.TabIndex = 45;
            this.WhiteLoundrey.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 365);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(503, 61);
            this.textBox.TabIndex = 43;
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
            this.DisconnectBtn.Location = new System.Drawing.Point(86, 327);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.DisconnectBtn});
            this.shapeContainer2.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer2.TabIndex = 58;
            this.shapeContainer2.TabStop = false;
            // 
            // WasMachinePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ChoseTemperature);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Centrifuga);
            this.Controls.Add(this.Jeans);
            this.Controls.Add(this.BlackLoundrey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Wool);
            this.Controls.Add(this.Snickers);
            this.Controls.Add(this.WhiteLoundrey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelayStart);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.LabelOnOff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer2);
            this.Name = "WasMachinePanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.WasMachinePanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WascMashheBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Centrifuga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackLoundrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snickers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteLoundrey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label modelWM;
        private System.Windows.Forms.Label DevConnected;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label DeviceConnected;
        private System.Windows.Forms.Label nameWM;
        private System.Windows.Forms.PictureBox WascMashheBox;
        private System.Windows.Forms.Label LabelOnOff;
        private System.Windows.Forms.ComboBox cbTimer;
        private System.Windows.Forms.Label DelayStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox WhiteLoundrey;
        private System.Windows.Forms.PictureBox Snickers;
        private System.Windows.Forms.PictureBox Wool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox BlackLoundrey;
        private System.Windows.Forms.PictureBox Jeans;
        private System.Windows.Forms.PictureBox Centrifuga;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label ChoseTemperature;
        private System.Windows.Forms.ComboBox cbTemp;
        private System.Windows.Forms.RichTextBox textBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}
