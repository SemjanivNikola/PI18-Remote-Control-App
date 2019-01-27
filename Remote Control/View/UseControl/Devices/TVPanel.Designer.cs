namespace Remote_Control
{
    partial class TVPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TVPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerTick = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.modelTV = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameTV = new System.Windows.Forms.Label();
            this.TVPictureBox = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.startStopbtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.line1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.volFrame = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.currVolLine = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.muteDisplay = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tbChannel = new System.Windows.Forms.TextBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.Plus2 = new System.Windows.Forms.PictureBox();
            this.Minus2 = new System.Windows.Forms.PictureBox();
            this.Plus1 = new System.Windows.Forms.PictureBox();
            this.Minus1 = new System.Windows.Forms.PictureBox();
            this.pbMute = new System.Windows.Forms.PictureBox();
            this.lblVol = new System.Windows.Forms.Label();
            this.cbOffTimer = new System.Windows.Forms.ComboBox();
            this.lblCurrVol = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSetTimer = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.timerTick);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.modelTV);
            this.panel1.Controls.Add(this.DevConnected);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.DeviceConnected);
            this.panel1.Controls.Add(this.nameTV);
            this.panel1.Controls.Add(this.TVPictureBox);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 91;
            // 
            // timerTick
            // 
            this.timerTick.AutoSize = true;
            this.timerTick.BackColor = System.Drawing.Color.Transparent;
            this.timerTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerTick.Location = new System.Drawing.Point(113, 325);
            this.timerTick.Name = "timerTick";
            this.timerTick.Size = new System.Drawing.Size(0, 15);
            this.timerTick.TabIndex = 113;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(18, 325);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(89, 15);
            this.lblTimer.TabIndex = 112;
            this.lblTimer.Text = "Turning Off in : ";
            // 
            // modelTV
            // 
            this.modelTV.AutoSize = true;
            this.modelTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelTV.Location = new System.Drawing.Point(79, 292);
            this.modelTV.Name = "modelTV";
            this.modelTV.Size = new System.Drawing.Size(12, 16);
            this.modelTV.TabIndex = 5;
            this.modelTV.Text = "/";
            // 
            // DevConnected
            // 
            this.DevConnected.AutoSize = true;
            this.DevConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DevConnected.Location = new System.Drawing.Point(152, 261);
            this.DevConnected.Name = "DevConnected";
            this.DevConnected.Size = new System.Drawing.Size(0, 16);
            this.DevConnected.TabIndex = 4;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Model.Location = new System.Drawing.Point(21, 291);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(52, 16);
            this.Model.TabIndex = 3;
            this.Model.Text = "Model :";
            // 
            // DeviceConnected
            // 
            this.DeviceConnected.AutoSize = true;
            this.DeviceConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeviceConnected.Location = new System.Drawing.Point(21, 261);
            this.DeviceConnected.Name = "DeviceConnected";
            this.DeviceConnected.Size = new System.Drawing.Size(125, 16);
            this.DeviceConnected.TabIndex = 2;
            this.DeviceConnected.Text = "Device Connected :";
            // 
            // nameTV
            // 
            this.nameTV.AutoSize = true;
            this.nameTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTV.Location = new System.Drawing.Point(79, 222);
            this.nameTV.Name = "nameTV";
            this.nameTV.Size = new System.Drawing.Size(12, 16);
            this.nameTV.TabIndex = 1;
            this.nameTV.Text = "/";
            // 
            // TVPictureBox
            // 
            this.TVPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TVPictureBox.Image")));
            this.TVPictureBox.Location = new System.Drawing.Point(21, 16);
            this.TVPictureBox.Name = "TVPictureBox";
            this.TVPictureBox.Size = new System.Drawing.Size(191, 194);
            this.TVPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TVPictureBox.TabIndex = 0;
            this.TVPictureBox.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.startStopbtn,
            this.line1,
            this.line2,
            this.volFrame,
            this.currVolLine,
            this.muteDisplay,
            this.DisconnectBtn,
            this.OnOff});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 92;
            this.shapeContainer1.TabStop = false;
            // 
            // startStopbtn
            // 
            this.startStopbtn.BackgroundImage = global::Remote_Control.Properties.Resources.start;
            this.startStopbtn.BorderColor = System.Drawing.Color.Gray;
            this.startStopbtn.CornerRadius = 5;
            this.startStopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startStopbtn.FillColor = System.Drawing.Color.Transparent;
            this.startStopbtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.startStopbtn.Location = new System.Drawing.Point(200, 303);
            this.startStopbtn.Name = "startStopbtn";
            this.startStopbtn.Size = new System.Drawing.Size(75, 22);
            this.startStopbtn.Click += new System.EventHandler(this.startStopbtn_Click);
            // 
            // line1
            // 
            this.line1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line1.Name = "line1";
            this.line1.X1 = 5;
            this.line1.X2 = 491;
            this.line1.Y1 = 74;
            this.line1.Y2 = 74;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Name = "line2";
            this.line2.X1 = 9;
            this.line2.X2 = 495;
            this.line2.Y1 = 347;
            this.line2.Y2 = 347;
            // 
            // volFrame
            // 
            this.volFrame.BorderColor = System.Drawing.Color.Gray;
            this.volFrame.CornerRadius = 2;
            this.volFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volFrame.FillColor = System.Drawing.Color.Transparent;
            this.volFrame.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.volFrame.Location = new System.Drawing.Point(210, 223);
            this.volFrame.Name = "volFrame";
            this.volFrame.Size = new System.Drawing.Size(204, 28);
            // 
            // currVolLine
            // 
            this.currVolLine.BorderColor = System.Drawing.Color.Gray;
            this.currVolLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currVolLine.FillColor = System.Drawing.Color.Lime;
            this.currVolLine.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.currVolLine.Location = new System.Drawing.Point(210, 223);
            this.currVolLine.Name = "currVolLine";
            this.currVolLine.Size = new System.Drawing.Size(1, 28);
            // 
            // muteDisplay
            // 
            this.muteDisplay.BackColor = System.Drawing.Color.Transparent;
            this.muteDisplay.BorderColor = System.Drawing.Color.Black;
            this.muteDisplay.CornerRadius = 3;
            this.muteDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteDisplay.FillColor = System.Drawing.Color.Lime;
            this.muteDisplay.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.muteDisplay.Location = new System.Drawing.Point(25, 157);
            this.muteDisplay.Name = "muteDisplay";
            this.muteDisplay.Size = new System.Drawing.Size(77, 6);
            this.muteDisplay.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisconnectBtn.BackgroundImage")));
            this.DisconnectBtn.BorderColor = System.Drawing.Color.Gray;
            this.DisconnectBtn.CornerRadius = 5;
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FillColor = System.Drawing.Color.Transparent;
            this.DisconnectBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DisconnectBtn.Location = new System.Drawing.Point(157, 368);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // OnOff
            // 
            this.OnOff.BackgroundImage = global::Remote_Control.Properties.Resources.off;
            this.OnOff.BorderColor = System.Drawing.Color.Gray;
            this.OnOff.CornerRadius = 5;
            this.OnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnOff.FillColor = System.Drawing.Color.Transparent;
            this.OnOff.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OnOff.Location = new System.Drawing.Point(34, 33);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(61, 22);
            this.OnOff.Click += new System.EventHandler(this.OnOff_Click);
            // 
            // tbChannel
            // 
            this.tbChannel.Location = new System.Drawing.Point(279, 108);
            this.tbChannel.Name = "tbChannel";
            this.tbChannel.Size = new System.Drawing.Size(75, 20);
            this.tbChannel.TabIndex = 102;
            this.tbChannel.Text = "0";
            this.tbChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannel.Location = new System.Drawing.Point(266, 80);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(102, 15);
            this.lblChannel.TabIndex = 105;
            this.lblChannel.Text = "Current Channel :";
            // 
            // Plus2
            // 
            this.Plus2.Image = ((System.Drawing.Image)(resources.GetObject("Plus2.Image")));
            this.Plus2.Location = new System.Drawing.Point(421, 217);
            this.Plus2.Name = "Plus2";
            this.Plus2.Size = new System.Drawing.Size(76, 40);
            this.Plus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus2.TabIndex = 107;
            this.Plus2.TabStop = false;
            this.Plus2.Click += new System.EventHandler(this.Plus2_Click);
            // 
            // Minus2
            // 
            this.Minus2.Image = ((System.Drawing.Image)(resources.GetObject("Minus2.Image")));
            this.Minus2.Location = new System.Drawing.Point(128, 217);
            this.Minus2.Name = "Minus2";
            this.Minus2.Size = new System.Drawing.Size(76, 40);
            this.Minus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus2.TabIndex = 106;
            this.Minus2.TabStop = false;
            this.Minus2.Click += new System.EventHandler(this.Minus2_Click);
            // 
            // Plus1
            // 
            this.Plus1.Image = ((System.Drawing.Image)(resources.GetObject("Plus1.Image")));
            this.Plus1.Location = new System.Drawing.Point(360, 98);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(76, 40);
            this.Plus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus1.TabIndex = 104;
            this.Plus1.TabStop = false;
            this.Plus1.Click += new System.EventHandler(this.Plus1_Click);
            // 
            // Minus1
            // 
            this.Minus1.Image = ((System.Drawing.Image)(resources.GetObject("Minus1.Image")));
            this.Minus1.Location = new System.Drawing.Point(197, 98);
            this.Minus1.Name = "Minus1";
            this.Minus1.Size = new System.Drawing.Size(76, 40);
            this.Minus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus1.TabIndex = 103;
            this.Minus1.TabStop = false;
            this.Minus1.Click += new System.EventHandler(this.Minus1_Click);
            // 
            // pbMute
            // 
            this.pbMute.Image = global::Remote_Control.Properties.Resources.volume;
            this.pbMute.Location = new System.Drawing.Point(32, 88);
            this.pbMute.Name = "pbMute";
            this.pbMute.Size = new System.Drawing.Size(64, 64);
            this.pbMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMute.TabIndex = 101;
            this.pbMute.TabStop = false;
            this.pbMute.Click += new System.EventHandler(this.pbMute_Click);
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.Location = new System.Drawing.Point(288, 196);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(55, 15);
            this.lblVol.TabIndex = 108;
            this.lblVol.Text = "Volume :";
            // 
            // cbOffTimer
            // 
            this.cbOffTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOffTimer.FormattingEnabled = true;
            this.cbOffTimer.Items.AddRange(new object[] {
            "None",
            "1",
            "5",
            "10",
            "20",
            "60"});
            this.cbOffTimer.Location = new System.Drawing.Point(53, 302);
            this.cbOffTimer.Name = "cbOffTimer";
            this.cbOffTimer.Size = new System.Drawing.Size(121, 21);
            this.cbOffTimer.TabIndex = 109;
            // 
            // lblCurrVol
            // 
            this.lblCurrVol.AutoSize = true;
            this.lblCurrVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrVol.Location = new System.Drawing.Point(349, 196);
            this.lblCurrVol.Name = "lblCurrVol";
            this.lblCurrVol.Size = new System.Drawing.Size(14, 15);
            this.lblCurrVol.TabIndex = 110;
            this.lblCurrVol.Text = "2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblSetTimer
            // 
            this.lblSetTimer.AutoSize = true;
            this.lblSetTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblSetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTimer.Location = new System.Drawing.Point(50, 284);
            this.lblSetTimer.Name = "lblSetTimer";
            this.lblSetTimer.Size = new System.Drawing.Size(84, 15);
            this.lblSetTimer.TabIndex = 111;
            this.lblSetTimer.Text = "Set \'Off Timer\'";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMin.Location = new System.Drawing.Point(125, 305);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(23, 13);
            this.lblMin.TabIndex = 130;
            this.lblMin.Text = "min";
            // 
            // TVPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSetTimer);
            this.Controls.Add(this.lblCurrVol);
            this.Controls.Add(this.cbOffTimer);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.Plus2);
            this.Controls.Add(this.Minus2);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.Plus1);
            this.Controls.Add(this.Minus1);
            this.Controls.Add(this.tbChannel);
            this.Controls.Add(this.pbMute);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TVPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.TVPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label modelTV;
        private System.Windows.Forms.Label DevConnected;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label DeviceConnected;
        private System.Windows.Forms.Label nameTV;
        private System.Windows.Forms.PictureBox TVPictureBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape muteDisplay;
        private System.Windows.Forms.PictureBox pbMute;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape volFrame;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape currVolLine;
        private System.Windows.Forms.PictureBox Plus1;
        private System.Windows.Forms.PictureBox Minus1;
        private System.Windows.Forms.TextBox tbChannel;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.PictureBox Minus2;
        private System.Windows.Forms.PictureBox Plus2;
        private Microsoft.VisualBasic.PowerPacks.LineShape line1;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.ComboBox cbOffTimer;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape startStopbtn;
        private System.Windows.Forms.Label lblCurrVol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSetTimer;
        private System.Windows.Forms.Label timerTick;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblMin;
    }
}
