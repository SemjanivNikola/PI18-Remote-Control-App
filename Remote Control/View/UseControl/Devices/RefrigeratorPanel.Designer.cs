﻿namespace Remote_Control
{
    partial class RefrigeratorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefrigeratorPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rtb = new System.Windows.Forms.RichTextBox();
            this.modelRefri = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.DeviceConnected = new System.Windows.Forms.Label();
            this.nameRefri = new System.Windows.Forms.Label();
            this.RefrigeratorPictureBox = new System.Windows.Forms.PictureBox();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DispenceWater = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DispenseIce = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.TempValue = new System.Windows.Forms.TextBox();
            this.CubedIce = new System.Windows.Forms.RadioButton();
            this.CrushedIce = new System.Windows.Forms.RadioButton();
            this.WaterPictureBox = new System.Windows.Forms.PictureBox();
            this.IcePictureBox = new System.Windows.Forms.PictureBox();
            this.TempPictureBox = new System.Windows.Forms.PictureBox();
            this.Plus = new System.Windows.Forms.PictureBox();
            this.Minus = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefrigeratorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Rtb);
            this.panel1.Controls.Add(this.modelRefri);
            this.panel1.Controls.Add(this.DevConnected);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.DeviceConnected);
            this.panel1.Controls.Add(this.nameRefri);
            this.panel1.Controls.Add(this.RefrigeratorPictureBox);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 2;
            // 
            // Rtb
            // 
            this.Rtb.Cursor = System.Windows.Forms.Cursors.No;
            this.Rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb.Location = new System.Drawing.Point(3, 357);
            this.Rtb.Name = "Rtb";
            this.Rtb.ReadOnly = true;
            this.Rtb.Size = new System.Drawing.Size(227, 66);
            this.Rtb.TabIndex = 23;
            this.Rtb.Text = " . . .";
            this.Rtb.TextChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // modelRefri
            // 
            this.modelRefri.AutoSize = true;
            this.modelRefri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelRefri.Location = new System.Drawing.Point(75, 291);
            this.modelRefri.Name = "modelRefri";
            this.modelRefri.Size = new System.Drawing.Size(10, 15);
            this.modelRefri.TabIndex = 5;
            this.modelRefri.Text = "/";
            // 
            // DevConnected
            // 
            this.DevConnected.AutoSize = true;
            this.DevConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevConnected.Location = new System.Drawing.Point(139, 261);
            this.DevConnected.Name = "DevConnected";
            this.DevConnected.Size = new System.Drawing.Size(10, 15);
            this.DevConnected.TabIndex = 4;
            this.DevConnected.Text = "/";
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
            // nameRefri
            // 
            this.nameRefri.AutoSize = true;
            this.nameRefri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRefri.Location = new System.Drawing.Point(85, 227);
            this.nameRefri.Name = "nameRefri";
            this.nameRefri.Size = new System.Drawing.Size(10, 15);
            this.nameRefri.TabIndex = 1;
            this.nameRefri.Text = "/";
            // 
            // RefrigeratorPictureBox
            // 
            this.RefrigeratorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RefrigeratorPictureBox.Image")));
            this.RefrigeratorPictureBox.Location = new System.Drawing.Point(21, 16);
            this.RefrigeratorPictureBox.Name = "RefrigeratorPictureBox";
            this.RefrigeratorPictureBox.Size = new System.Drawing.Size(191, 194);
            this.RefrigeratorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefrigeratorPictureBox.TabIndex = 0;
            this.RefrigeratorPictureBox.TabStop = false;
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.DisconnectBtn,
            this.DispenceWater,
            this.DispenseIce,
            this.OnOff});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisconnectBtn.BackgroundImage")));
            this.DisconnectBtn.BorderColor = System.Drawing.Color.Gray;
            this.DisconnectBtn.CornerRadius = 5;
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FillColor = System.Drawing.Color.Red;
            this.DisconnectBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DisconnectBtn.Location = new System.Drawing.Point(176, 377);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // DispenceWater
            // 
            this.DispenceWater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DispenceWater.BackgroundImage")));
            this.DispenceWater.BorderColor = System.Drawing.Color.Gray;
            this.DispenceWater.CornerRadius = 5;
            this.DispenceWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DispenceWater.FillColor = System.Drawing.Color.Transparent;
            this.DispenceWater.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DispenceWater.Location = new System.Drawing.Point(128, 276);
            this.DispenceWater.Name = "DispenceWater";
            this.DispenceWater.Size = new System.Drawing.Size(107, 24);
            this.DispenceWater.Click += new System.EventHandler(this.DispenceWater_Click);
            // 
            // DispenseIce
            // 
            this.DispenseIce.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DispenseIce.BackgroundImage")));
            this.DispenseIce.BorderColor = System.Drawing.Color.Gray;
            this.DispenseIce.CornerRadius = 5;
            this.DispenseIce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DispenseIce.FillColor = System.Drawing.Color.Transparent;
            this.DispenseIce.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DispenseIce.Location = new System.Drawing.Point(248, 192);
            this.DispenseIce.Name = "DispenseIce";
            this.DispenseIce.Size = new System.Drawing.Size(107, 26);
            this.DispenseIce.Click += new System.EventHandler(this.DispenseIce_Click);
            // 
            // TempValue
            // 
            this.TempValue.Location = new System.Drawing.Point(175, 112);
            this.TempValue.Name = "TempValue";
            this.TempValue.ReadOnly = true;
            this.TempValue.Size = new System.Drawing.Size(50, 20);
            this.TempValue.TabIndex = 15;
            this.TempValue.Text = "0";
            this.TempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CubedIce
            // 
            this.CubedIce.AutoSize = true;
            this.CubedIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CubedIce.Location = new System.Drawing.Point(128, 188);
            this.CubedIce.Name = "CubedIce";
            this.CubedIce.Size = new System.Drawing.Size(80, 19);
            this.CubedIce.TabIndex = 20;
            this.CubedIce.TabStop = true;
            this.CubedIce.Text = "Cubed Ice";
            this.CubedIce.UseVisualStyleBackColor = true;
            // 
            // CrushedIce
            // 
            this.CrushedIce.AutoSize = true;
            this.CrushedIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrushedIce.Location = new System.Drawing.Point(128, 213);
            this.CrushedIce.Name = "CrushedIce";
            this.CrushedIce.Size = new System.Drawing.Size(90, 19);
            this.CrushedIce.TabIndex = 21;
            this.CrushedIce.TabStop = true;
            this.CrushedIce.Text = "Crushed Ice";
            this.CrushedIce.UseVisualStyleBackColor = true;
            // 
            // WaterPictureBox
            // 
            this.WaterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WaterPictureBox.Image")));
            this.WaterPictureBox.Location = new System.Drawing.Point(43, 261);
            this.WaterPictureBox.Name = "WaterPictureBox";
            this.WaterPictureBox.Size = new System.Drawing.Size(53, 52);
            this.WaterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WaterPictureBox.TabIndex = 22;
            this.WaterPictureBox.TabStop = false;
            // 
            // IcePictureBox
            // 
            this.IcePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IcePictureBox.Image")));
            this.IcePictureBox.Location = new System.Drawing.Point(43, 179);
            this.IcePictureBox.Name = "IcePictureBox";
            this.IcePictureBox.Size = new System.Drawing.Size(53, 52);
            this.IcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcePictureBox.TabIndex = 19;
            this.IcePictureBox.TabStop = false;
            // 
            // TempPictureBox
            // 
            this.TempPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TempPictureBox.Image")));
            this.TempPictureBox.Location = new System.Drawing.Point(43, 94);
            this.TempPictureBox.Name = "TempPictureBox";
            this.TempPictureBox.Size = new System.Drawing.Size(53, 52);
            this.TempPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TempPictureBox.TabIndex = 18;
            this.TempPictureBox.TabStop = false;
            // 
            // Plus
            // 
            this.Plus.Image = ((System.Drawing.Image)(resources.GetObject("Plus.Image")));
            this.Plus.Location = new System.Drawing.Point(240, 105);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(51, 36);
            this.Plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus.TabIndex = 17;
            this.Plus.TabStop = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Image = ((System.Drawing.Image)(resources.GetObject("Minus.Image")));
            this.Minus.Location = new System.Drawing.Point(121, 102);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(42, 36);
            this.Minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus.TabIndex = 16;
            this.Minus.TabStop = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RefrigeratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.WaterPictureBox);
            this.Controls.Add(this.CrushedIce);
            this.Controls.Add(this.CubedIce);
            this.Controls.Add(this.IcePictureBox);
            this.Controls.Add(this.TempPictureBox);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.TempValue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "RefrigeratorPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.RefriPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefrigeratorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label modelRefri;
        private System.Windows.Forms.Label DevConnected;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label DeviceConnected;
        private System.Windows.Forms.Label nameRefri;
        private System.Windows.Forms.PictureBox RefrigeratorPictureBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox Plus;
        private System.Windows.Forms.PictureBox Minus;
        private System.Windows.Forms.TextBox TempValue;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DispenceWater;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DispenseIce;
        private System.Windows.Forms.PictureBox TempPictureBox;
        private System.Windows.Forms.PictureBox IcePictureBox;
        private System.Windows.Forms.RadioButton CubedIce;
        private System.Windows.Forms.RadioButton CrushedIce;
        private System.Windows.Forms.PictureBox WaterPictureBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox Rtb;
    }
}
