using System;

namespace Remote_Control
{
    partial class DisWasherPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisWasherPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.modelDW = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameDW = new System.Windows.Forms.Label();
            this.DishWashPictureBox = new System.Windows.Forms.PictureBox();
            this.DelayStart = new System.Windows.Forms.Label();
            this.SetTimerLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Label();
            this.CurrTemperatureLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SetDelayS = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.LabelOnOff = new System.Windows.Forms.Label();
            this.CurrProgramLabel = new System.Windows.Forms.Label();
            this.rbMetal = new System.Windows.Forms.RadioButton();
            this.rbKeramika = new System.Windows.Forms.RadioButton();
            this.rbPlastika = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbIspisStupnjeva = new System.Windows.Forms.PictureBox();
            this.Keramika = new System.Windows.Forms.PictureBox();
            this.Plastika = new System.Windows.Forms.PictureBox();
            this.Metal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DishWashPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIspisStupnjeva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keramika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.modelDW);
            this.panel1.Controls.Add(this.DevConnected);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.DeviceConnected);
            this.panel1.Controls.Add(this.nameDW);
            this.panel1.Controls.Add(this.DishWashPictureBox);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 4;
            // 
            // modelDW
            // 
            this.modelDW.AutoSize = true;
            this.modelDW.Location = new System.Drawing.Point(69, 291);
            this.modelDW.Name = "modelDW";
            this.modelDW.Size = new System.Drawing.Size(12, 13);
            this.modelDW.TabIndex = 5;
            this.modelDW.Text = "/";
            // 
            // DevConnected
            // 
            this.DevConnected.AutoSize = true;
            this.DevConnected.Location = new System.Drawing.Point(129, 261);
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
            // nameDW
            // 
            this.nameDW.AutoSize = true;
            this.nameDW.Location = new System.Drawing.Point(100, 224);
            this.nameDW.Name = "nameDW";
            this.nameDW.Size = new System.Drawing.Size(12, 13);
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
            // DelayStart
            // 
            this.DelayStart.AutoSize = true;
            this.DelayStart.Location = new System.Drawing.Point(197, 50);
            this.DelayStart.Name = "DelayStart";
            this.DelayStart.Size = new System.Drawing.Size(62, 13);
            this.DelayStart.TabIndex = 39;
            this.DelayStart.Text = "Delay Start:";
            // 
            // SetTimerLabel
            // 
            this.SetTimerLabel.AutoSize = true;
            this.SetTimerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SetTimerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimerLabel.ForeColor = System.Drawing.Color.White;
            this.SetTimerLabel.Location = new System.Drawing.Point(431, 110);
            this.SetTimerLabel.Name = "SetTimerLabel";
            this.SetTimerLabel.Size = new System.Drawing.Size(38, 16);
            this.SetTimerLabel.TabIndex = 41;
            this.SetTimerLabel.Text = "SET";
            this.SetTimerLabel.Click += new System.EventHandler(this.SetTimerLabel_Click);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(248, 270);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(59, 16);
            this.Start.TabIndex = 42;
            this.Start.Text = "START";
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.BackColor = System.Drawing.Color.Gray;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.Color.White;
            this.Pause.Location = new System.Drawing.Point(322, 270);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(59, 16);
            this.Pause.TabIndex = 43;
            this.Pause.Text = "PAUSE";
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(413, 270);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(49, 16);
            this.Stop.TabIndex = 44;
            this.Stop.Text = "STOP";
            // 
            // CurrTemperatureLabel
            // 
            this.CurrTemperatureLabel.AutoSize = true;
            this.CurrTemperatureLabel.Location = new System.Drawing.Point(34, 285);
            this.CurrTemperatureLabel.Name = "CurrTemperatureLabel";
            this.CurrTemperatureLabel.Size = new System.Drawing.Size(70, 26);
            this.CurrTemperatureLabel.TabIndex = 51;
            this.CurrTemperatureLabel.Text = "Current \r\nTemperature:";
            this.CurrTemperatureLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.DisconnectBtn,
            this.SetDelayS,
            this.OnOff});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 52;
            this.shapeContainer1.TabStop = false;
            // 
            // SetDelayS
            // 
            this.SetDelayS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SetDelayS.CornerRadius = 5;
            this.SetDelayS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetDelayS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SetDelayS.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.SetDelayS.Location = new System.Drawing.Point(427, 109);
            this.SetDelayS.Name = "SetDelayS";
            this.SetDelayS.Size = new System.Drawing.Size(45, 17);
            // 
            // OnOff
            // 
            this.OnOff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OnOff.CornerRadius = 5;
            this.OnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnOff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OnOff.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OnOff.Location = new System.Drawing.Point(53, 41);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(51, 17);
            // 
            // LabelOnOff
            // 
            this.LabelOnOff.AutoSize = true;
            this.LabelOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOnOff.ForeColor = System.Drawing.Color.White;
            this.LabelOnOff.Location = new System.Drawing.Point(66, 43);
            this.LabelOnOff.Name = "LabelOnOff";
            this.LabelOnOff.Size = new System.Drawing.Size(30, 16);
            this.LabelOnOff.TabIndex = 53;
            this.LabelOnOff.Text = "ON";
            // 
            // CurrProgramLabel
            // 
            this.CurrProgramLabel.AutoSize = true;
            this.CurrProgramLabel.Location = new System.Drawing.Point(34, 129);
            this.CurrProgramLabel.Name = "CurrProgramLabel";
            this.CurrProgramLabel.Size = new System.Drawing.Size(49, 26);
            this.CurrProgramLabel.TabIndex = 54;
            this.CurrProgramLabel.Text = "Current \r\nProgram:";
            // 
            // rbMetal
            // 
            this.rbMetal.AutoSize = true;
            this.rbMetal.Location = new System.Drawing.Point(174, 238);
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
            this.rbKeramika.Location = new System.Drawing.Point(284, 238);
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
            this.rbPlastika.Location = new System.Drawing.Point(402, 238);
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
            // pbIspisStupnjeva
            // 
            this.pbIspisStupnjeva.Image = global::Remote_Control.Properties.Resources.eigdegree;
            this.pbIspisStupnjeva.Location = new System.Drawing.Point(124, 270);
            this.pbIspisStupnjeva.Name = "pbIspisStupnjeva";
            this.pbIspisStupnjeva.Size = new System.Drawing.Size(64, 41);
            this.pbIspisStupnjeva.TabIndex = 59;
            this.pbIspisStupnjeva.TabStop = false;
            // 
            // Keramika
            // 
            this.Keramika.Image = ((System.Drawing.Image)(resources.GetObject("Keramika.Image")));
            this.Keramika.Location = new System.Drawing.Point(230, 129);
            this.Keramika.Name = "Keramika";
            this.Keramika.Size = new System.Drawing.Size(122, 103);
            this.Keramika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Keramika.TabIndex = 47;
            this.Keramika.TabStop = false;
            // 
            // Plastika
            // 
            this.Plastika.Image = ((System.Drawing.Image)(resources.GetObject("Plastika.Image")));
            this.Plastika.Location = new System.Drawing.Point(347, 129);
            this.Plastika.Name = "Plastika";
            this.Plastika.Size = new System.Drawing.Size(122, 103);
            this.Plastika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plastika.TabIndex = 46;
            this.Plastika.TabStop = false;
            // 
            // Metal
            // 
            this.Metal.Image = global::Remote_Control.Properties.Resources.cutlery;
            this.Metal.Location = new System.Drawing.Point(109, 129);
            this.Metal.Name = "Metal";
            this.Metal.Size = new System.Drawing.Size(122, 103);
            this.Metal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Metal.TabIndex = 45;
            this.Metal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Seconds";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(272, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 63;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(272, 69);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 64;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(272, 95);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
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
            this.DisconnectBtn.Location = new System.Drawing.Point(276, 312);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // DisWasherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbIspisStupnjeva);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbPlastika);
            this.Controls.Add(this.rbKeramika);
            this.Controls.Add(this.rbMetal);
            this.Controls.Add(this.CurrProgramLabel);
            this.Controls.Add(this.LabelOnOff);
            this.Controls.Add(this.CurrTemperatureLabel);
            this.Controls.Add(this.Keramika);
            this.Controls.Add(this.Plastika);
            this.Controls.Add(this.Metal);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SetTimerLabel);
            this.Controls.Add(this.DelayStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "DisWasherPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DishWashPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIspisStupnjeva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keramika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.Label DelayStart;
        private System.Windows.Forms.Label SetTimerLabel;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.Label Stop;
        private System.Windows.Forms.PictureBox Metal;
        private System.Windows.Forms.PictureBox Plastika;
        private System.Windows.Forms.PictureBox Keramika;
        private System.Windows.Forms.Label CurrTemperatureLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private System.Windows.Forms.Label LabelOnOff;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape SetDelayS;
        private System.Windows.Forms.Label CurrProgramLabel;
        private System.Windows.Forms.RadioButton rbMetal;
        private System.Windows.Forms.RadioButton rbKeramika;
        private System.Windows.Forms.RadioButton rbPlastika;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbIspisStupnjeva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox textBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;

        public EventHandler DishWashPictureBox_Click { get; private set; }
    }
}
