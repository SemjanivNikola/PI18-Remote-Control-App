using System;

namespace Remote_Control
{
    partial class DishwasherPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishwasherPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWashingTime = new System.Windows.Forms.Label();
            this.lvlWas = new System.Windows.Forms.Label();
            this.lblStartTimer = new System.Windows.Forms.Label();
            this.modelDW = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.lblDS = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameDW = new System.Windows.Forms.Label();
            this.DishWashPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrTemperatureLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnSetStop = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pauseBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.startStopbtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rbMetal = new System.Windows.Forms.RadioButton();
            this.rbKeramika = new System.Windows.Forms.RadioButton();
            this.rbPlastika = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inUse = new System.Windows.Forms.Timer(this.components);
            this.lblMin = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.DelayStart = new System.Windows.Forms.Label();
            this.pbIspisStupnjeva = new System.Windows.Forms.PictureBox();
            this.Keramika = new System.Windows.Forms.PictureBox();
            this.Plastika = new System.Windows.Forms.PictureBox();
            this.Metal = new System.Windows.Forms.PictureBox();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.washing = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DishWashPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIspisStupnjeva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keramika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblWashingTime);
            this.panel1.Controls.Add(this.lvlWas);
            this.panel1.Controls.Add(this.lblStartTimer);
            this.panel1.Controls.Add(this.modelDW);
            this.panel1.Controls.Add(this.DevConnected);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.lblDS);
            this.panel1.Controls.Add(this.DeviceConnected);
            this.panel1.Controls.Add(this.nameDW);
            this.panel1.Controls.Add(this.DishWashPictureBox);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 4;
            // 
            // lblWashingTime
            // 
            this.lblWashingTime.AutoSize = true;
            this.lblWashingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblWashingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWashingTime.Location = new System.Drawing.Point(98, 376);
            this.lblWashingTime.Name = "lblWashingTime";
            this.lblWashingTime.Size = new System.Drawing.Size(0, 15);
            this.lblWashingTime.TabIndex = 130;
            // 
            // lvlWas
            // 
            this.lvlWas.AutoSize = true;
            this.lvlWas.BackColor = System.Drawing.Color.Transparent;
            this.lvlWas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlWas.Location = new System.Drawing.Point(18, 376);
            this.lvlWas.Name = "lvlWas";
            this.lvlWas.Size = new System.Drawing.Size(87, 15);
            this.lvlWas.TabIndex = 129;
            this.lvlWas.Text = "Until finished : ";
            // 
            // lblStartTimer
            // 
            this.lblStartTimer.AutoSize = true;
            this.lblStartTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTimer.Location = new System.Drawing.Point(114, 331);
            this.lblStartTimer.Name = "lblStartTimer";
            this.lblStartTimer.Size = new System.Drawing.Size(0, 15);
            this.lblStartTimer.TabIndex = 128;
            // 
            // modelDW
            // 
            this.modelDW.AutoSize = true;
            this.modelDW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelDW.Location = new System.Drawing.Point(75, 291);
            this.modelDW.Name = "modelDW";
            this.modelDW.Size = new System.Drawing.Size(10, 15);
            this.modelDW.TabIndex = 5;
            this.modelDW.Text = "/";
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
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.BackColor = System.Drawing.Color.Transparent;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(18, 331);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(90, 15);
            this.lblDS.TabIndex = 127;
            this.lblDS.Text = "Delay start for : ";
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
            // nameDW
            // 
            this.nameDW.AutoSize = true;
            this.nameDW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDW.Location = new System.Drawing.Point(88, 226);
            this.nameDW.Name = "nameDW";
            this.nameDW.Size = new System.Drawing.Size(10, 15);
            this.nameDW.TabIndex = 1;
            this.nameDW.Text = "/";
            // 
            // DishWashPictureBox
            // 
            this.DishWashPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DishWashPictureBox.Image")));
            this.DishWashPictureBox.Location = new System.Drawing.Point(21, 16);
            this.DishWashPictureBox.Name = "DishWashPictureBox";
            this.DishWashPictureBox.Size = new System.Drawing.Size(191, 194);
            this.DishWashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DishWashPictureBox.TabIndex = 0;
            this.DishWashPictureBox.TabStop = false;
            // 
            // CurrTemperatureLabel
            // 
            this.CurrTemperatureLabel.AutoSize = true;
            this.CurrTemperatureLabel.Location = new System.Drawing.Point(14, 314);
            this.CurrTemperatureLabel.Name = "CurrTemperatureLabel";
            this.CurrTemperatureLabel.Size = new System.Drawing.Size(73, 13);
            this.CurrTemperatureLabel.TabIndex = 51;
            this.CurrTemperatureLabel.Text = "Temperature :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnSetStop,
            this.line2,
            this.pauseBtn,
            this.startStopbtn,
            this.OnOff,
            this.DisconnectBtn});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 52;
            this.shapeContainer1.TabStop = false;
            // 
            // btnSetStop
            // 
            this.btnSetStop.BackgroundImage = global::Remote_Control.Properties.Resources.set1;
            this.btnSetStop.BorderColor = System.Drawing.Color.Gray;
            this.btnSetStop.CornerRadius = 5;
            this.btnSetStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetStop.FillColor = System.Drawing.Color.Transparent;
            this.btnSetStop.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.btnSetStop.Location = new System.Drawing.Point(240, 238);
            this.btnSetStop.Name = "btnSetStop";
            this.btnSetStop.Size = new System.Drawing.Size(75, 22);
            this.btnSetStop.Click += new System.EventHandler(this.btnSetStop_Click);
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Name = "line2";
            this.line2.X1 = 8;
            this.line2.X2 = 494;
            this.line2.Y1 = 365;
            this.line2.Y2 = 365;
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImage = global::Remote_Control.Properties.Resources.pause;
            this.pauseBtn.BorderColor = System.Drawing.Color.Gray;
            this.pauseBtn.CornerRadius = 5;
            this.pauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseBtn.FillColor = System.Drawing.Color.Transparent;
            this.pauseBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.pauseBtn.Location = new System.Drawing.Point(378, 305);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(95, 22);
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // startStopbtn
            // 
            this.startStopbtn.BackgroundImage = global::Remote_Control.Properties.Resources.start;
            this.startStopbtn.BorderColor = System.Drawing.Color.Gray;
            this.startStopbtn.CornerRadius = 5;
            this.startStopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startStopbtn.FillColor = System.Drawing.Color.Transparent;
            this.startStopbtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.startStopbtn.Location = new System.Drawing.Point(388, 264);
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
            this.OnOff.Location = new System.Drawing.Point(32, 23);
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
            this.DisconnectBtn.Location = new System.Drawing.Point(138, 385);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // rbMetal
            // 
            this.rbMetal.AutoSize = true;
            this.rbMetal.Checked = true;
            this.rbMetal.Location = new System.Drawing.Point(163, 186);
            this.rbMetal.Name = "rbMetal";
            this.rbMetal.Size = new System.Drawing.Size(14, 13);
            this.rbMetal.TabIndex = 55;
            this.rbMetal.TabStop = true;
            this.rbMetal.UseVisualStyleBackColor = true;
            this.rbMetal.CheckedChanged += new System.EventHandler(this.rbMetal_CheckedChanged);
            // 
            // rbKeramika
            // 
            this.rbKeramika.AutoSize = true;
            this.rbKeramika.Location = new System.Drawing.Point(284, 186);
            this.rbKeramika.Name = "rbKeramika";
            this.rbKeramika.Size = new System.Drawing.Size(14, 13);
            this.rbKeramika.TabIndex = 56;
            this.rbKeramika.TabStop = true;
            this.rbKeramika.UseVisualStyleBackColor = true;
            this.rbKeramika.CheckedChanged += new System.EventHandler(this.rbKeramika_CheckedChanged);
            // 
            // rbPlastika
            // 
            this.rbPlastika.AutoSize = true;
            this.rbPlastika.Location = new System.Drawing.Point(402, 186);
            this.rbPlastika.Name = "rbPlastika";
            this.rbPlastika.Size = new System.Drawing.Size(14, 13);
            this.rbPlastika.TabIndex = 57;
            this.rbPlastika.TabStop = true;
            this.rbPlastika.UseVisualStyleBackColor = true;
            this.rbPlastika.CheckedChanged += new System.EventHandler(this.rbPlastika_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, -27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 58;
            // 
            // inUse
            // 
            this.inUse.Enabled = true;
            this.inUse.Interval = 1000;
            this.inUse.Tick += new System.EventHandler(this.inUse_Tick);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMin.Location = new System.Drawing.Point(173, 241);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(23, 13);
            this.lblMin.TabIndex = 129;
            this.lblMin.Text = "min";
            // 
            // cbStart
            // 
            this.cbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Items.AddRange(new object[] {
            "None",
            "2",
            "5",
            "10",
            "60",
            "120"});
            this.cbStart.Location = new System.Drawing.Point(97, 238);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(121, 21);
            this.cbStart.TabIndex = 128;
            // 
            // DelayStart
            // 
            this.DelayStart.AutoSize = true;
            this.DelayStart.Location = new System.Drawing.Point(14, 241);
            this.DelayStart.Name = "DelayStart";
            this.DelayStart.Size = new System.Drawing.Size(62, 13);
            this.DelayStart.TabIndex = 126;
            this.DelayStart.Text = "Delay Start:";
            // 
            // pbIspisStupnjeva
            // 
            this.pbIspisStupnjeva.Image = global::Remote_Control.Properties.Resources.eigdegree;
            this.pbIspisStupnjeva.Location = new System.Drawing.Point(97, 300);
            this.pbIspisStupnjeva.Name = "pbIspisStupnjeva";
            this.pbIspisStupnjeva.Size = new System.Drawing.Size(64, 41);
            this.pbIspisStupnjeva.TabIndex = 59;
            this.pbIspisStupnjeva.TabStop = false;
            // 
            // Keramika
            // 
            this.Keramika.Image = ((System.Drawing.Image)(resources.GetObject("Keramika.Image")));
            this.Keramika.Location = new System.Drawing.Point(230, 71);
            this.Keramika.Name = "Keramika";
            this.Keramika.Size = new System.Drawing.Size(122, 103);
            this.Keramika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Keramika.TabIndex = 47;
            this.Keramika.TabStop = false;
            // 
            // Plastika
            // 
            this.Plastika.Image = ((System.Drawing.Image)(resources.GetObject("Plastika.Image")));
            this.Plastika.Location = new System.Drawing.Point(347, 71);
            this.Plastika.Name = "Plastika";
            this.Plastika.Size = new System.Drawing.Size(122, 103);
            this.Plastika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plastika.TabIndex = 46;
            this.Plastika.TabStop = false;
            // 
            // Metal
            // 
            this.Metal.Image = global::Remote_Control.Properties.Resources.cutlery;
            this.Metal.Location = new System.Drawing.Point(109, 71);
            this.Metal.Name = "Metal";
            this.Metal.Size = new System.Drawing.Size(122, 103);
            this.Metal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Metal.TabIndex = 45;
            this.Metal.TabStop = false;
            // 
            // delay
            // 
            this.delay.Enabled = true;
            this.delay.Interval = 1000;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // washing
            // 
            this.washing.Enabled = true;
            this.washing.Interval = 1000;
            this.washing.Tick += new System.EventHandler(this.washing_Tick);
            // 
            // DishwasherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.DelayStart);
            this.Controls.Add(this.pbIspisStupnjeva);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbPlastika);
            this.Controls.Add(this.rbKeramika);
            this.Controls.Add(this.rbMetal);
            this.Controls.Add(this.CurrTemperatureLabel);
            this.Controls.Add(this.Keramika);
            this.Controls.Add(this.Plastika);
            this.Controls.Add(this.Metal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "DishwasherPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.DishwasherPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DishWashPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIspisStupnjeva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keramika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label modelDW;
        private System.Windows.Forms.Label DevConnected;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label DeviceConnected;
        private System.Windows.Forms.Label nameDW;
        private System.Windows.Forms.PictureBox DishWashPictureBox;
        private System.Windows.Forms.PictureBox Metal;
        private System.Windows.Forms.PictureBox Plastika;
        private System.Windows.Forms.PictureBox Keramika;
        private System.Windows.Forms.Label CurrTemperatureLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.RadioButton rbMetal;
        private System.Windows.Forms.RadioButton rbKeramika;
        private System.Windows.Forms.RadioButton rbPlastika;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbIspisStupnjeva;
        private System.Windows.Forms.Timer inUse;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape pauseBtn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape startStopbtn;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.Label DelayStart;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnSetStop;
        private System.Windows.Forms.Label lblStartTimer;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.Label lblWashingTime;
        private System.Windows.Forms.Label lvlWas;
        private System.Windows.Forms.Timer washing;

        public EventHandler DishWashPictureBox_Click { get; private set; }
    }
}
