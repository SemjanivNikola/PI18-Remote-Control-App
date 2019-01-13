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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightsPanel));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.modelLights = new System.Windows.Forms.Label();
            this.DevConnected = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.LightscCnnected = new System.Windows.Forms.Label();
            this.nameLights = new System.Windows.Forms.Label();
            this.LightsPictureBox = new System.Windows.Forms.PictureBox();
            this.OnOff = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.DisconnectBtn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.LabelOnOff = new System.Windows.Forms.Label();
            this.BrightnessPictureBox = new System.Windows.Forms.PictureBox();
            this.BrightnessValue = new System.Windows.Forms.TextBox();
            this.BrightnessName = new System.Windows.Forms.Label();
            this.Minus = new System.Windows.Forms.PictureBox();
            this.Plus = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
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
            this.modelLights.Location = new System.Drawing.Point(67, 291);
            this.modelLights.Name = "modelLights";
            this.modelLights.Size = new System.Drawing.Size(12, 13);
            this.modelLights.TabIndex = 5;
            this.modelLights.Text = "/";
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
            this.Model.Size = new System.Drawing.Size(39, 13);
            this.Model.TabIndex = 3;
            this.Model.Text = "Model:";
            // 
            // LightscCnnected
            // 
            this.LightscCnnected.AutoSize = true;
            this.LightscCnnected.Location = new System.Drawing.Point(21, 261);
            this.LightscCnnected.Name = "LightscCnnected";
            this.LightscCnnected.Size = new System.Drawing.Size(99, 13);
            this.LightscCnnected.TabIndex = 2;
            this.LightscCnnected.Text = "Device Connected:";
            // 
            // nameLights
            // 
            this.nameLights.AutoSize = true;
            this.nameLights.Location = new System.Drawing.Point(100, 224);
            this.nameLights.Name = "nameLights";
            this.nameLights.Size = new System.Drawing.Size(12, 13);
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
            // OnOff
            // 
            this.OnOff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OnOff.CornerRadius = 5;
            this.OnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnOff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OnOff.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OnOff.Location = new System.Drawing.Point(25, 36);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(51, 17);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.DisconnectBtn,
            this.OnOff});
            this.shapeContainer1.Size = new System.Drawing.Size(736, 426);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisconnectBtn.BackgroundImage")));
            this.DisconnectBtn.BorderColor = System.Drawing.Color.Red;
            this.DisconnectBtn.CornerRadius = 5;
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FillColor = System.Drawing.Color.Red;
            this.DisconnectBtn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DisconnectBtn.Location = new System.Drawing.Point(170, 324);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(153, 28);
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
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
            this.LabelOnOff.Size = new System.Drawing.Size(30, 16);
            this.LabelOnOff.TabIndex = 8;
            this.LabelOnOff.Text = "ON";
            this.LabelOnOff.Click += new System.EventHandler(this.LabelOnOff_Click);
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
            this.BrightnessValue.Location = new System.Drawing.Point(226, 261);
            this.BrightnessValue.Name = "BrightnessValue";
            this.BrightnessValue.Size = new System.Drawing.Size(25, 20);
            this.BrightnessValue.TabIndex = 11;
            this.BrightnessValue.Text = "0";
            this.BrightnessValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BrightnessName
            // 
            this.BrightnessName.AutoSize = true;
            this.BrightnessName.Location = new System.Drawing.Point(213, 298);
            this.BrightnessName.Name = "BrightnessName";
            this.BrightnessName.Size = new System.Drawing.Size(56, 13);
            this.BrightnessName.TabIndex = 12;
            this.BrightnessName.Text = "Brightness";
            // 
            // Minus
            // 
            this.Minus.Image = ((System.Drawing.Image)(resources.GetObject("Minus.Image")));
            this.Minus.Location = new System.Drawing.Point(200, 261);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(20, 20);
            this.Minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minus.TabIndex = 13;
            this.Minus.TabStop = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Image = ((System.Drawing.Image)(resources.GetObject("Plus.Image")));
            this.Plus.Location = new System.Drawing.Point(257, 261);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(25, 20);
            this.Plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plus.TabIndex = 14;
            this.Plus.TabStop = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 365);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(503, 61);
            this.textBox.TabIndex = 43;
            this.textBox.Text = " . . . ";
            // 
            // LightsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.BrightnessName);
            this.Controls.Add(this.BrightnessValue);
            this.Controls.Add(this.BrightnessPictureBox);
            this.Controls.Add(this.LabelOnOff);
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
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OnOff;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label LabelOnOff;
        private System.Windows.Forms.PictureBox BrightnessPictureBox;
        private System.Windows.Forms.TextBox BrightnessValue;
        private System.Windows.Forms.Label BrightnessName;
        private System.Windows.Forms.PictureBox Minus;
        private System.Windows.Forms.PictureBox Plus;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape DisconnectBtn;
        private System.Windows.Forms.RichTextBox textBox;
    }
}
