namespace Image_Effects
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileNameBtn01 = new System.Windows.Forms.Button();
            this.FileNameBtn02 = new System.Windows.Forms.Button();
            this.ImageDisplay = new System.Windows.Forms.PictureBox();
            this.ColorChangerPanel = new System.Windows.Forms.Panel();
            this.ChangeColorBtn = new System.Windows.Forms.Button();
            this.ColorThresholdLabel = new System.Windows.Forms.Label();
            this.ColorThreshold = new System.Windows.Forms.NumericUpDown();
            this.ChangeColorTo = new System.Windows.Forms.Label();
            this.ChangeTo = new System.Windows.Forms.ComboBox();
            this.Change_From = new System.Windows.Forms.Label();
            this.ChangeFrom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BlurWidth = new System.Windows.Forms.Label();
            this.BlurBtn = new System.Windows.Forms.Button();
            this.BlurBlockWidth = new System.Windows.Forms.NumericUpDown();
            this.BlurHeight = new System.Windows.Forms.Label();
            this.BlurBlockHeight = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplay)).BeginInit();
            this.ColorChangerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorThreshold)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlurBlockWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurBlockHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(100, 25);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "File Name";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Enabled = false;
            this.FileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameTextBox.Location = new System.Drawing.Point(118, 13);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(211, 23);
            this.FileNameTextBox.TabIndex = 1;
            // 
            // FileNameBtn01
            // 
            this.FileNameBtn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameBtn01.Location = new System.Drawing.Point(335, 9);
            this.FileNameBtn01.Name = "FileNameBtn01";
            this.FileNameBtn01.Size = new System.Drawing.Size(75, 30);
            this.FileNameBtn01.TabIndex = 2;
            this.FileNameBtn01.Text = "Open";
            this.FileNameBtn01.UseVisualStyleBackColor = true;
            this.FileNameBtn01.Click += new System.EventHandler(this.FileNameBtn01_Click);
            // 
            // FileNameBtn02
            // 
            this.FileNameBtn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameBtn02.Location = new System.Drawing.Point(416, 9);
            this.FileNameBtn02.Name = "FileNameBtn02";
            this.FileNameBtn02.Size = new System.Drawing.Size(75, 30);
            this.FileNameBtn02.TabIndex = 3;
            this.FileNameBtn02.Text = "Load";
            this.FileNameBtn02.UseVisualStyleBackColor = true;
            this.FileNameBtn02.Click += new System.EventHandler(this.FileNameBtn02_Click);
            // 
            // ImageDisplay
            // 
            this.ImageDisplay.BackColor = System.Drawing.SystemColors.GrayText;
            this.ImageDisplay.Location = new System.Drawing.Point(17, 54);
            this.ImageDisplay.Name = "ImageDisplay";
            this.ImageDisplay.Size = new System.Drawing.Size(474, 475);
            this.ImageDisplay.TabIndex = 4;
            this.ImageDisplay.TabStop = false;
            // 
            // ColorChangerPanel
            // 
            this.ColorChangerPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ColorChangerPanel.Controls.Add(this.ChangeColorBtn);
            this.ColorChangerPanel.Controls.Add(this.ColorThresholdLabel);
            this.ColorChangerPanel.Controls.Add(this.ColorThreshold);
            this.ColorChangerPanel.Controls.Add(this.ChangeColorTo);
            this.ColorChangerPanel.Controls.Add(this.ChangeTo);
            this.ColorChangerPanel.Controls.Add(this.Change_From);
            this.ColorChangerPanel.Controls.Add(this.ChangeFrom);
            this.ColorChangerPanel.Location = new System.Drawing.Point(497, 12);
            this.ColorChangerPanel.Name = "ColorChangerPanel";
            this.ColorChangerPanel.Size = new System.Drawing.Size(416, 94);
            this.ColorChangerPanel.TabIndex = 5;
            // 
            // ChangeColorBtn
            // 
            this.ChangeColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColorBtn.Location = new System.Drawing.Point(275, 53);
            this.ChangeColorBtn.Name = "ChangeColorBtn";
            this.ChangeColorBtn.Size = new System.Drawing.Size(120, 31);
            this.ChangeColorBtn.TabIndex = 0;
            this.ChangeColorBtn.Text = "Change Color";
            this.ChangeColorBtn.UseVisualStyleBackColor = true;
            this.ChangeColorBtn.Click += new System.EventHandler(this.ChangeColorBtn_Click);
            // 
            // ColorThresholdLabel
            // 
            this.ColorThresholdLabel.AutoSize = true;
            this.ColorThresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorThresholdLabel.Location = new System.Drawing.Point(272, 4);
            this.ColorThresholdLabel.Name = "ColorThresholdLabel";
            this.ColorThresholdLabel.Size = new System.Drawing.Size(109, 17);
            this.ColorThresholdLabel.TabIndex = 12;
            this.ColorThresholdLabel.Text = "Color Threshold";
            // 
            // ColorThreshold
            // 
            this.ColorThreshold.Location = new System.Drawing.Point(275, 25);
            this.ColorThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorThreshold.Name = "ColorThreshold";
            this.ColorThreshold.Size = new System.Drawing.Size(120, 22);
            this.ColorThreshold.TabIndex = 11;
            // 
            // ChangeColorTo
            // 
            this.ChangeColorTo.AutoSize = true;
            this.ChangeColorTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColorTo.Location = new System.Drawing.Point(139, 4);
            this.ChangeColorTo.Name = "ChangeColorTo";
            this.ChangeColorTo.Size = new System.Drawing.Size(115, 17);
            this.ChangeColorTo.TabIndex = 10;
            this.ChangeColorTo.Text = "Change Color To";
            // 
            // ChangeTo
            // 
            this.ChangeTo.FormattingEnabled = true;
            this.ChangeTo.Location = new System.Drawing.Point(142, 24);
            this.ChangeTo.Name = "ChangeTo";
            this.ChangeTo.Size = new System.Drawing.Size(127, 24);
            this.ChangeTo.TabIndex = 9;
            // 
            // Change_From
            // 
            this.Change_From.AutoSize = true;
            this.Change_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_From.Location = new System.Drawing.Point(3, 4);
            this.Change_From.Name = "Change_From";
            this.Change_From.Size = new System.Drawing.Size(130, 17);
            this.Change_From.TabIndex = 8;
            this.Change_From.Text = "Change Color From";
            // 
            // ChangeFrom
            // 
            this.ChangeFrom.FormattingEnabled = true;
            this.ChangeFrom.Location = new System.Drawing.Point(6, 24);
            this.ChangeFrom.Name = "ChangeFrom";
            this.ChangeFrom.Size = new System.Drawing.Size(127, 24);
            this.ChangeFrom.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.BlurHeight);
            this.panel1.Controls.Add(this.BlurBlockHeight);
            this.panel1.Controls.Add(this.BlurWidth);
            this.panel1.Controls.Add(this.BlurBtn);
            this.panel1.Controls.Add(this.BlurBlockWidth);
            this.panel1.Location = new System.Drawing.Point(497, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 94);
            this.panel1.TabIndex = 13;
            // 
            // BlurWidth
            // 
            this.BlurWidth.AutoSize = true;
            this.BlurWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurWidth.Location = new System.Drawing.Point(3, 9);
            this.BlurWidth.Name = "BlurWidth";
            this.BlurWidth.Size = new System.Drawing.Size(111, 17);
            this.BlurWidth.TabIndex = 14;
            this.BlurWidth.Text = "Blur Block Width";
            // 
            // BlurBtn
            // 
            this.BlurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurBtn.Location = new System.Drawing.Point(275, 22);
            this.BlurBtn.Name = "BlurBtn";
            this.BlurBtn.Size = new System.Drawing.Size(120, 30);
            this.BlurBtn.TabIndex = 13;
            this.BlurBtn.Text = "Blur";
            this.BlurBtn.UseVisualStyleBackColor = true;
            this.BlurBtn.Click += new System.EventHandler(this.BlurBtn_Click);
            // 
            // BlurBlockWidth
            // 
            this.BlurBlockWidth.Location = new System.Drawing.Point(6, 30);
            this.BlurBlockWidth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlurBlockWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BlurBlockWidth.Name = "BlurBlockWidth";
            this.BlurBlockWidth.Size = new System.Drawing.Size(120, 22);
            this.BlurBlockWidth.TabIndex = 13;
            this.BlurBlockWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // BlurHeight
            // 
            this.BlurHeight.AutoSize = true;
            this.BlurHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurHeight.Location = new System.Drawing.Point(139, 9);
            this.BlurHeight.Name = "BlurHeight";
            this.BlurHeight.Size = new System.Drawing.Size(116, 17);
            this.BlurHeight.TabIndex = 16;
            this.BlurHeight.Text = "Blur Block Height";
            // 
            // BlurBlockHeight
            // 
            this.BlurBlockHeight.Location = new System.Drawing.Point(142, 30);
            this.BlurBlockHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlurBlockHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BlurBlockHeight.Name = "BlurBlockHeight";
            this.BlurBlockHeight.Size = new System.Drawing.Size(120, 22);
            this.BlurBlockHeight.TabIndex = 15;
            this.BlurBlockHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(497, 214);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 541);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorChangerPanel);
            this.Controls.Add(this.ImageDisplay);
            this.Controls.Add(this.FileNameBtn02);
            this.Controls.Add(this.FileNameBtn01);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "Form1";
            this.Text = "Photo Effects";
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplay)).EndInit();
            this.ColorChangerPanel.ResumeLayout(false);
            this.ColorChangerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorThreshold)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlurBlockWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurBlockHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button FileNameBtn01;
        private System.Windows.Forms.Button FileNameBtn02;
        private System.Windows.Forms.PictureBox ImageDisplay;
        private System.Windows.Forms.Panel ColorChangerPanel;
        private System.Windows.Forms.ComboBox ChangeFrom;
        private System.Windows.Forms.Label ColorThresholdLabel;
        private System.Windows.Forms.NumericUpDown ColorThreshold;
        private System.Windows.Forms.Label ChangeColorTo;
        private System.Windows.Forms.ComboBox ChangeTo;
        private System.Windows.Forms.Label Change_From;
        private System.Windows.Forms.Button ChangeColorBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BlurBtn;
        private System.Windows.Forms.Label BlurWidth;
        private System.Windows.Forms.NumericUpDown BlurBlockWidth;
        private System.Windows.Forms.Label BlurHeight;
        private System.Windows.Forms.NumericUpDown BlurBlockHeight;
        private System.Windows.Forms.Button SaveBtn;
    }
}

