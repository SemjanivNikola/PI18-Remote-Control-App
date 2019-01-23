namespace Remote_Control
{
    partial class LightsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightsPanel));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.modelLights = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.LightscCnnected = new System.Windows.Forms.Label();
            this.nameLights = new System.Windows.Forms.Label();
            this.LightsPictureBox = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.BrightnessPictureBox = new System.Windows.Forms.PictureBox();
            this.BrightnessValue = new System.Windows.Forms.TextBox();
            this.BrightnessName = new System.Windows.Forms.Label();
            this.Minus = new System.Windows.Forms.PictureBox();
            this.Plus = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoPanel.Controls.Add(this.modelLights);
            this.infoPanel.Controls.Add(this.DevConnected);
            this.infoPanel.Controls.Add(this.Model);
            this.infoPanel.Controls.Add(this.LightscCnnected);
            this.infoPanel.Controls.Add(this.nameLights);
            this.infoPanel.Controls.Add(this.LightsPictureBox);
            this.infoPanel.Location = new System.Drawing.Point(503, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(233, 426);
            this.infoPanel.TabIndex = 1;
            // 
            // modelLights
            // 
            this.modelLights.AutoSize = true;
            this.modelLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLights.Location = new System.Drawing.Point(67, 291);
            this.modelLights.Name = "modelLights";
            this.modelLights.Size = new System.Drawing.Size(10, 15);
            this.modelLights.TabIndex = 5;
            this.modelLights.Text = "/";
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
            // LightscCnnected
            // 
            this.LightscCnnected.AutoSize = true;
            this.LightscCnnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightscCnnected.Location = new System.Drawing.Point(21, 261);
            this.LightscCnnected.Name = "LightscCnnected";
            this.LightscCnnected.Size = new System.Drawing.Size(112, 15);
            this.LightscCnnected.TabIndex = 2;
            this.LightscCnnected.Text = "Device Connected :";
            // 
            // nameLights
            // 
            this.nameLights.AutoSize = true;
            this.nameLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLights.Location = new System.Drawing.Point(86, 224);
            this.nameLights.Name = "nameLights";
            this.nameLights.Size = new System.Drawing.Size(10, 15);
            this.nameLights.TabIndex = 1;
            this.nameLights.Text = "/";
            // 
            // LightsPictureBox
            // 
            this.LightsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LightsPictureBox.Image")));
            this.LightsPictureBox.Location = new System.Drawing.Point(21, 16);
            this.LightsPictureBox.Name = "LightsPictureBox";
            this.LightsPictureBox.Size = new System.Drawing.Size(191, 194);
            this.LightsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LightsPictureBox.TabIndex = 0;
            this.LightsPictureBox.TabStop = false;
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
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Name = "line2";
            this.line2.X1 = 7;
            this.line2.X2 = 493;
            this.line2.Y1 = 334;
            this.line2.Y2 = 334;
            // 
            // OnOff
            // 
            this.OnOff.BackgroundImage = global::Remote_Control.Properties.Resources.off;
            this.OnOff.BorderColor = System.Drawing.Color.Gray;
            this.OnOff.CornerRadius = 5;
            this.OnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnOff.FillColor = System.Drawing.Color.Transparent;
            this.OnOff.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OnOff.Location = new System.Drawing.Point(27, 27);
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
            this.DisconnectBtn.Location = new System.Drawing.Point(153, 361);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // BrightnessPictureBox
            // 
            this.BrightnessPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BrightnessPictureBox.Image")));
            this.BrightnessPictureBox.Location = new System.Drawing.Point(148, 53);
            this.BrightnessPictureBox.Name = "BrightnessPictureBox";
            this.BrightnessPictureBox.Size = new System.Drawing.Size(182, 177);
            this.BrightnessPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BrightnessPictureBox.TabIndex = 10;
            this.BrightnessPictureBox.TabStop = false;
            // 
            // BrightnessValue
            // 
            this.BrightnessValue.Location = new System.Drawing.Point(215, 256);
            this.BrightnessValue.Name = "BrightnessValue";
            this.BrightnessValue.ReadOnly = true;
            this.BrightnessValue.Size = new System.Drawing.Size(50, 20);
            this.BrightnessValue.TabIndex = 11;
            this.BrightnessValue.Text = "0";
            this.BrightnessValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BrightnessName
            // 
            this.BrightnessName.AutoSize = true;
            this.BrightnessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightnessName.Location = new System.Drawing.Point(207, 279);
            this.BrightnessName.Name = "BrightnessName";
            this.BrightnessName.Size = new System.Drawing.Size(65, 15);
            this.BrightnessName.TabIndex = 12;
            this.BrightnessName.Text = "Brightness";
            // 
            // Minus
            // 
            this.Minus.Image = ((System.Drawing.Image)(resources.GetObject("Minus.Image")));
            this.Minus.Location = new System.Drawing.Point(148, 247);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(39, 34);
            this.Minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus.TabIndex = 13;
            this.Minus.TabStop = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Image = ((System.Drawing.Image)(resources.GetObject("Plus.Image")));
            this.Plus.Location = new System.Drawing.Point(291, 247);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(39, 34);
            this.Plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus.TabIndex = 14;
            this.Plus.TabStop = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LightsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.BrightnessName);
            this.Controls.Add(this.BrightnessValue);
            this.Controls.Add(this.BrightnessPictureBox);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "LightsPanel";
            this.Size = new System.Drawing.Size(736, 426);
            this.Load += new System.EventHandler(this.LightsPanel_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label LightscCnnected;
        private System.Windows.Forms.Label nameLights;
        private System.Windows.Forms.PictureBox LightsPictureBox;
        private System.Windows.Forms.Label modelLights;
        private System.Windows.Forms.Label DevConnected;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox BrightnessPictureBox;
        private System.Windows.Forms.TextBox BrightnessValue;
        private System.Windows.Forms.Label BrightnessName;
        private System.Windows.Forms.PictureBox Minus;
        private System.Windows.Forms.PictureBox Plus;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private System.Windows.Forms.Timer timer1;
    }
}
