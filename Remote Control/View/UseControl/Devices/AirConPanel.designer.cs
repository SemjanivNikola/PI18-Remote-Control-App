namespace Remote_Control
{ 
    partial class AirConPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirConPanel));
            this.DelayStart = new System.Windows.Forms.Label();
            this.infoPnl = new System.Windows.Forms.Panel();
            this.timerTick = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDS = new System.Windows.Forms.Label();
            this.lblOffT = new System.Windows.Forms.Label();
            this.modelAirCon = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameAirCon = new System.Windows.Forms.Label();
            this.AirConPictureBox = new System.Windows.Forms.PictureBox();
            this.FanValue = new System.Windows.Forms.TextBox();
            this.TemperatureValue = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timerBtnStartStop = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.startStopbtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Plus2 = new System.Windows.Forms.PictureBox();
            this.Minus2 = new System.Windows.Forms.PictureBox();
            this.Plus1 = new System.Windows.Forms.PictureBox();
            this.Minus1 = new System.Windows.Forms.PictureBox();
            this.radioHeat = new System.Windows.Forms.RadioButton();
            this.radioCold = new System.Windows.Forms.RadioButton();
            this.radioDry = new System.Windows.Forms.RadioButton();
            this.cbOffTimer = new System.Windows.Forms.ComboBox();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.lvlOffTimer = new System.Windows.Forms.Label();
            this.lblMin1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblMin2 = new System.Windows.Forms.Label();
            this.gbFanDirection = new System.Windows.Forms.GroupBox();
            this.radioSwing = new System.Windows.Forms.RadioButton();
            this.radioDown = new System.Windows.Forms.RadioButton();
            this.radioMid = new System.Windows.Forms.RadioButton();
            this.radioUp = new System.Windows.Forms.RadioButton();
            this.infoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirConPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus1)).BeginInit();
            this.gbFanDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // DelayStart
            // 
            this.DelayStart.AutoSize = true;
            this.DelayStart.Location = new System.Drawing.Point(23, 242);
            this.DelayStart.Name = "DelayStart";
            this.DelayStart.Size = new System.Drawing.Size(62, 13);
            this.DelayStart.TabIndex = 103;
            this.DelayStart.Text = "Delay Start:";
            // 
            // infoPnl
            // 
            this.infoPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoPnl.Controls.Add(this.timerTick);
            this.infoPnl.Controls.Add(this.lblStart);
            this.infoPnl.Controls.Add(this.lblDS);
            this.infoPnl.Controls.Add(this.lblOffT);
            this.infoPnl.Controls.Add(this.modelAirCon);
            this.infoPnl.Controls.Add(this.DevConnected);
            this.infoPnl.Controls.Add(this.Model);
            this.infoPnl.Controls.Add(this.DeviceConnected);
            this.infoPnl.Controls.Add(this.nameAirCon);
            this.infoPnl.Controls.Add(this.AirConPictureBox);
            this.infoPnl.Location = new System.Drawing.Point(503, 0);
            this.infoPnl.Name = "infoPnl";
            this.infoPnl.Size = new System.Drawing.Size(233, 426);
            this.infoPnl.TabIndex = 90;
            // 
            // timerTick
            // 
            this.timerTick.AutoSize = true;
            this.timerTick.BackColor = System.Drawing.Color.Transparent;
            this.timerTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerTick.Location = new System.Drawing.Point(113, 339);
            this.timerTick.Name = "timerTick";
            this.timerTick.Size = new System.Drawing.Size(0, 15);
            this.timerTick.TabIndex = 116;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(114, 378);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(0, 15);
            this.lblStart.TabIndex = 115;
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.BackColor = System.Drawing.Color.Transparent;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(18, 378);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(90, 15);
            this.lblDS.TabIndex = 114;
            this.lblDS.Text = "Delay start for : ";
            // 
            // lblOffT
            // 
            this.lblOffT.AutoSize = true;
            this.lblOffT.BackColor = System.Drawing.Color.Transparent;
            this.lblOffT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffT.Location = new System.Drawing.Point(18, 339);
            this.lblOffT.Name = "lblOffT";
            this.lblOffT.Size = new System.Drawing.Size(89, 15);
            this.lblOffT.TabIndex = 113;
            this.lblOffT.Text = "Turning Off in : ";
            // 
            // modelAirCon
            // 
            this.modelAirCon.AutoSize = true;
            this.modelAirCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelAirCon.Location = new System.Drawing.Point(79, 292);
            this.modelAirCon.Name = "modelAirCon";
            this.modelAirCon.Size = new System.Drawing.Size(12, 16);
            this.modelAirCon.TabIndex = 5;
            this.modelAirCon.Text = "/";
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
            // nameAirCon
            // 
            this.nameAirCon.AutoSize = true;
            this.nameAirCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameAirCon.Location = new System.Drawing.Point(79, 224);
            this.nameAirCon.Name = "nameAirCon";
            this.nameAirCon.Size = new System.Drawing.Size(12, 16);
            this.nameAirCon.TabIndex = 1;
            this.nameAirCon.Text = "/";
            // 
            // AirConPictureBox
            // 
            this.AirConPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AirConPictureBox.Image")));
            this.AirConPictureBox.Location = new System.Drawing.Point(24, 19);
            this.AirConPictureBox.Name = "AirConPictureBox";
            this.AirConPictureBox.Size = new System.Drawing.Size(191, 194);
            this.AirConPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AirConPictureBox.TabIndex = 0;
            this.AirConPictureBox.TabStop = false;
            // 
            // FanValue
            // 
            this.FanValue.Location = new System.Drawing.Point(390, 56);
            this.FanValue.Name = "FanValue";
            this.FanValue.Size = new System.Drawing.Size(25, 20);
            this.FanValue.TabIndex = 96;
            this.FanValue.Text = "0";
            this.FanValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.Location = new System.Drawing.Point(154, 98);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(25, 20);
            this.TemperatureValue.TabIndex = 93;
            this.TemperatureValue.Text = "0";
            this.TemperatureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.line2,
            this.timerBtnStartStop,
            this.startStopbtn,
            this.OnOff,
            this.DisconnectBtn});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 117;
            this.shapeContainer1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Name = "line2";
            this.line2.X1 = 7;
            this.line2.X2 = 493;
            this.line2.Y1 = 358;
            this.line2.Y2 = 358;
            // 
            // timerBtnStartStop
            // 
            this.timerBtnStartStop.BackgroundImage = global::Remote_Control.Properties.Resources.start;
            this.timerBtnStartStop.BorderColor = System.Drawing.Color.Gray;
            this.timerBtnStartStop.CornerRadius = 5;
            this.timerBtnStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerBtnStartStop.FillColor = System.Drawing.Color.Transparent;
            this.timerBtnStartStop.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.timerBtnStartStop.Location = new System.Drawing.Point(249, 303);
            this.timerBtnStartStop.Name = "timerBtnStartStop";
            this.timerBtnStartStop.Size = new System.Drawing.Size(75, 22);
            this.timerBtnStartStop.Click += new System.EventHandler(this.timerBtnStartStop_Click);
            // 
            // startStopbtn
            // 
            this.startStopbtn.BackgroundImage = global::Remote_Control.Properties.Resources.start;
            this.startStopbtn.BorderColor = System.Drawing.Color.Gray;
            this.startStopbtn.CornerRadius = 5;
            this.startStopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startStopbtn.FillColor = System.Drawing.Color.Transparent;
            this.startStopbtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.startStopbtn.Location = new System.Drawing.Point(251, 239);
            this.startStopbtn.Name = "startStopbtn";
            this.startStopbtn.Size = new System.Drawing.Size(75, 22);
            this.startStopbtn.Click += new System.EventHandler(this.startStopbtn_Click);
            // 
            // OnOff
            // 
            this.OnOff.BackgroundImage = global::Remote_Control.Properties.Resources.off;
            this.OnOff.BorderColor = System.Drawing.Color.Gray;
            this.OnOff.CornerRadius = 5;
            this.OnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnOff.FillColor = System.Drawing.Color.Transparent;
            this.OnOff.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OnOff.Location = new System.Drawing.Point(26, 19);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(61, 22);
            this.OnOff.Click += new System.EventHandler(this.OnOff_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisconnectBtn.BackgroundImage")));
            this.DisconnectBtn.BorderColor = System.Drawing.Color.Gray;
            this.DisconnectBtn.CornerRadius = 5;
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FillColor = System.Drawing.Color.Transparent;
            this.DisconnectBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DisconnectBtn.Location = new System.Drawing.Point(162, 378);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(363, 169);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 112;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(363, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 102;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // Plus2
            // 
            this.Plus2.Image = ((System.Drawing.Image)(resources.GetObject("Plus2.Image")));
            this.Plus2.Location = new System.Drawing.Point(421, 56);
            this.Plus2.Name = "Plus2";
            this.Plus2.Size = new System.Drawing.Size(25, 20);
            this.Plus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus2.TabIndex = 98;
            this.Plus2.TabStop = false;
            this.Plus2.Click += new System.EventHandler(this.Plus2_Click);
            // 
            // Minus2
            // 
            this.Minus2.Image = ((System.Drawing.Image)(resources.GetObject("Minus2.Image")));
            this.Minus2.Location = new System.Drawing.Point(364, 56);
            this.Minus2.Name = "Minus2";
            this.Minus2.Size = new System.Drawing.Size(20, 20);
            this.Minus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus2.TabIndex = 97;
            this.Minus2.TabStop = false;
            this.Minus2.Click += new System.EventHandler(this.Minus2_Click);
            // 
            // Plus1
            // 
            this.Plus1.Image = ((System.Drawing.Image)(resources.GetObject("Plus1.Image")));
            this.Plus1.Location = new System.Drawing.Point(185, 98);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(25, 20);
            this.Plus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus1.TabIndex = 95;
            this.Plus1.TabStop = false;
            this.Plus1.Click += new System.EventHandler(this.Plus1_Click);
            // 
            // Minus1
            // 
            this.Minus1.Image = ((System.Drawing.Image)(resources.GetObject("Minus1.Image")));
            this.Minus1.Location = new System.Drawing.Point(128, 98);
            this.Minus1.Name = "Minus1";
            this.Minus1.Size = new System.Drawing.Size(20, 20);
            this.Minus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus1.TabIndex = 94;
            this.Minus1.TabStop = false;
            this.Minus1.Click += new System.EventHandler(this.Minus1_Click);
            // 
            // radioHeat
            // 
            this.radioHeat.AutoSize = true;
            this.radioHeat.Checked = true;
            this.radioHeat.Location = new System.Drawing.Point(39, 169);
            this.radioHeat.Name = "radioHeat";
            this.radioHeat.Size = new System.Drawing.Size(48, 17);
            this.radioHeat.TabIndex = 118;
            this.radioHeat.TabStop = true;
            this.radioHeat.Text = "Heat";
            this.radioHeat.UseVisualStyleBackColor = true;
            // 
            // radioCold
            // 
            this.radioCold.AutoSize = true;
            this.radioCold.Location = new System.Drawing.Point(140, 169);
            this.radioCold.Name = "radioCold";
            this.radioCold.Size = new System.Drawing.Size(46, 17);
            this.radioCold.TabIndex = 119;
            this.radioCold.Text = "Cool";
            this.radioCold.UseVisualStyleBackColor = true;
            // 
            // radioDry
            // 
            this.radioDry.AutoSize = true;
            this.radioDry.Location = new System.Drawing.Point(246, 169);
            this.radioDry.Name = "radioDry";
            this.radioDry.Size = new System.Drawing.Size(41, 17);
            this.radioDry.TabIndex = 120;
            this.radioDry.Text = "Dry";
            this.radioDry.UseVisualStyleBackColor = true;
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
            this.cbOffTimer.Location = new System.Drawing.Point(106, 300);
            this.cbOffTimer.Name = "cbOffTimer";
            this.cbOffTimer.Size = new System.Drawing.Size(121, 21);
            this.cbOffTimer.TabIndex = 122;
            // 
            // cbStart
            // 
            this.cbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Items.AddRange(new object[] {
            "None",
            "1",
            "5",
            "10",
            "60",
            "120"});
            this.cbStart.Location = new System.Drawing.Point(106, 239);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(121, 21);
            this.cbStart.TabIndex = 123;
            // 
            // lvlOffTimer
            // 
            this.lvlOffTimer.AutoSize = true;
            this.lvlOffTimer.Location = new System.Drawing.Point(21, 303);
            this.lvlOffTimer.Name = "lvlOffTimer";
            this.lvlOffTimer.Size = new System.Drawing.Size(79, 13);
            this.lvlOffTimer.TabIndex = 124;
            this.lvlOffTimer.Text = "Set \'Off Timer\' :";
            // 
            // lblMin1
            // 
            this.lblMin1.AutoSize = true;
            this.lblMin1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMin1.Location = new System.Drawing.Point(182, 242);
            this.lblMin1.Name = "lblMin1";
            this.lblMin1.Size = new System.Drawing.Size(23, 13);
            this.lblMin1.TabIndex = 125;
            this.lblMin1.Text = "min";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblMin2
            // 
            this.lblMin2.AutoSize = true;
            this.lblMin2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMin2.Location = new System.Drawing.Point(182, 303);
            this.lblMin2.Name = "lblMin2";
            this.lblMin2.Size = new System.Drawing.Size(23, 13);
            this.lblMin2.TabIndex = 126;
            this.lblMin2.Text = "min";
            // 
            // gbFanDirection
            // 
            this.gbFanDirection.Controls.Add(this.radioSwing);
            this.gbFanDirection.Controls.Add(this.radioDown);
            this.gbFanDirection.Controls.Add(this.radioMid);
            this.gbFanDirection.Controls.Add(this.radioUp);
            this.gbFanDirection.Location = new System.Drawing.Point(370, 236);
            this.gbFanDirection.Name = "gbFanDirection";
            this.gbFanDirection.Size = new System.Drawing.Size(73, 108);
            this.gbFanDirection.TabIndex = 127;
            this.gbFanDirection.TabStop = false;
            // 
            // radioSwing
            // 
            this.radioSwing.AutoSize = true;
            this.radioSwing.Checked = true;
            this.radioSwing.Location = new System.Drawing.Point(6, 75);
            this.radioSwing.Name = "radioSwing";
            this.radioSwing.Size = new System.Drawing.Size(54, 17);
            this.radioSwing.TabIndex = 125;
            this.radioSwing.TabStop = true;
            this.radioSwing.Text = "Swing";
            this.radioSwing.UseVisualStyleBackColor = true;
            // 
            // radioDown
            // 
            this.radioDown.AutoSize = true;
            this.radioDown.Location = new System.Drawing.Point(6, 52);
            this.radioDown.Name = "radioDown";
            this.radioDown.Size = new System.Drawing.Size(53, 17);
            this.radioDown.TabIndex = 124;
            this.radioDown.Text = "Down";
            this.radioDown.UseVisualStyleBackColor = true;
            // 
            // radioMid
            // 
            this.radioMid.AutoSize = true;
            this.radioMid.Location = new System.Drawing.Point(6, 31);
            this.radioMid.Name = "radioMid";
            this.radioMid.Size = new System.Drawing.Size(56, 17);
            this.radioMid.TabIndex = 123;
            this.radioMid.Text = "Middle";
            this.radioMid.UseVisualStyleBackColor = true;
            // 
            // radioUp
            // 
            this.radioUp.AutoSize = true;
            this.radioUp.Location = new System.Drawing.Point(6, 9);
            this.radioUp.Name = "radioUp";
            this.radioUp.Size = new System.Drawing.Size(39, 17);
            this.radioUp.TabIndex = 122;
            this.radioUp.Text = "Up";
            this.radioUp.UseVisualStyleBackColor = true;
            // 
            // AirConPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFanDirection);
            this.Controls.Add(this.lblMin2);
            this.Controls.Add(this.lblMin1);
            this.Controls.Add(this.lvlOffTimer);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.cbOffTimer);
            this.Controls.Add(this.radioDry);
            this.Controls.Add(this.radioCold);
            this.Controls.Add(this.radioHeat);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.DelayStart);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Plus2);
            this.Controls.Add(this.Minus2);
            this.Controls.Add(this.Plus1);
            this.Controls.Add(this.infoPnl);
            this.Controls.Add(this.FanValue);
            this.Controls.Add(this.Minus1);
            this.Controls.Add(this.TemperatureValue);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "AirConPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.AirCondPanel_Load);
            this.infoPnl.ResumeLayout(false);
            this.infoPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirConPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus1)).EndInit();
            this.gbFanDirection.ResumeLayout(false);
            this.gbFanDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label DelayStart;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Plus2;
        private System.Windows.Forms.PictureBox Minus2;
        private System.Windows.Forms.PictureBox Plus1;
        private System.Windows.Forms.PictureBox AirConPictureBox;
        private System.Windows.Forms.Panel infoPnl;
        private System.Windows.Forms.Label modelAirCon;
        private System.Windows.Forms.Label DevConnected;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label DeviceConnected;
        private System.Windows.Forms.Label nameAirCon;
        private System.Windows.Forms.TextBox FanValue;
        private System.Windows.Forms.PictureBox Minus1;
        private System.Windows.Forms.TextBox TemperatureValue;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private System.Windows.Forms.Label timerTick;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Label lblOffT;
        private System.Windows.Forms.RadioButton radioHeat;
        private System.Windows.Forms.RadioButton radioCold;
        private System.Windows.Forms.RadioButton radioDry;
        private System.Windows.Forms.ComboBox cbOffTimer;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.Label lvlOffTimer;
        private System.Windows.Forms.Label lblMin1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape timerBtnStartStop;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape startStopbtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblMin2;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private System.Windows.Forms.GroupBox gbFanDirection;
        private System.Windows.Forms.RadioButton radioSwing;
        private System.Windows.Forms.RadioButton radioDown;
        private System.Windows.Forms.RadioButton radioMid;
        private System.Windows.Forms.RadioButton radioUp;
    }
}
