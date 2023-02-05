namespace KingdomTwoCrownsCheater
{
    partial class MainForm
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
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcOpenLable = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CoinsCoutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SpeedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CoinsTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SendCoinsButton = new MaterialSkin.Controls.MaterialButton();
            this.CoinsCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SpeedSlider = new MaterialSkin.Controls.MaterialSlider();
            this.SpeedCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcOpenLable
            // 
            this.ProcOpenLable.AutoSize = true;
            this.ProcOpenLable.Depth = 0;
            this.ProcOpenLable.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProcOpenLable.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.ProcOpenLable.Location = new System.Drawing.Point(160, 76);
            this.ProcOpenLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProcOpenLable.Name = "ProcOpenLable";
            this.ProcOpenLable.Size = new System.Drawing.Size(61, 41);
            this.ProcOpenLable.TabIndex = 14;
            this.ProcOpenLable.Text = "N/A";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(36, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 29);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Coins:";
            // 
            // CoinsCoutLabel
            // 
            this.CoinsCoutLabel.AutoSize = true;
            this.CoinsCoutLabel.Depth = 0;
            this.CoinsCoutLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CoinsCoutLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.CoinsCoutLabel.Location = new System.Drawing.Point(108, 132);
            this.CoinsCoutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoinsCoutLabel.Name = "CoinsCoutLabel";
            this.CoinsCoutLabel.Size = new System.Drawing.Size(44, 29);
            this.CoinsCoutLabel.TabIndex = 16;
            this.CoinsCoutLabel.Text = "N/A";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(30, 193);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(74, 29);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Speed:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Depth = 0;
            this.SpeedLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SpeedLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.SpeedLabel.Location = new System.Drawing.Point(110, 194);
            this.SpeedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(44, 29);
            this.SpeedLabel.TabIndex = 18;
            this.SpeedLabel.Text = "N/A";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(21, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 41);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Process:";
            // 
            // CoinsTextBox
            // 
            this.CoinsTextBox.AnimateReadOnly = false;
            this.CoinsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoinsTextBox.Depth = 0;
            this.CoinsTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CoinsTextBox.Hint = "Coins Count";
            this.CoinsTextBox.LeadingIcon = null;
            this.CoinsTextBox.Location = new System.Drawing.Point(247, 120);
            this.CoinsTextBox.MaxLength = 50;
            this.CoinsTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CoinsTextBox.Multiline = false;
            this.CoinsTextBox.Name = "CoinsTextBox";
            this.CoinsTextBox.Size = new System.Drawing.Size(152, 50);
            this.CoinsTextBox.TabIndex = 19;
            this.CoinsTextBox.Text = "";
            this.CoinsTextBox.TrailingIcon = null;
            this.CoinsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoinsTextBox_KeyDown);
            // 
            // SendCoinsButton
            // 
            this.SendCoinsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendCoinsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SendCoinsButton.Depth = 0;
            this.SendCoinsButton.HighEmphasis = true;
            this.SendCoinsButton.Icon = null;
            this.SendCoinsButton.Location = new System.Drawing.Point(406, 130);
            this.SendCoinsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SendCoinsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendCoinsButton.Name = "SendCoinsButton";
            this.SendCoinsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SendCoinsButton.Size = new System.Drawing.Size(64, 36);
            this.SendCoinsButton.TabIndex = 20;
            this.SendCoinsButton.Text = "SEND";
            this.SendCoinsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SendCoinsButton.UseAccentColor = false;
            this.SendCoinsButton.UseVisualStyleBackColor = true;
            this.SendCoinsButton.Click += new System.EventHandler(this.SendCoinsButton_Click);
            // 
            // CoinsCheckBox
            // 
            this.CoinsCheckBox.AutoSize = true;
            this.CoinsCheckBox.Depth = 0;
            this.CoinsCheckBox.Location = new System.Drawing.Point(474, 129);
            this.CoinsCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.CoinsCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CoinsCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoinsCheckBox.Name = "CoinsCheckBox";
            this.CoinsCheckBox.ReadOnly = false;
            this.CoinsCheckBox.Ripple = true;
            this.CoinsCheckBox.Size = new System.Drawing.Size(81, 37);
            this.CoinsCheckBox.TabIndex = 21;
            this.CoinsCheckBox.Text = "Freeze";
            this.CoinsCheckBox.UseVisualStyleBackColor = true;
            this.CoinsCheckBox.CheckedChanged += new System.EventHandler(this.CoinsCheckBox_CheckedChanged);
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.Depth = 0;
            this.SpeedSlider.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SpeedSlider.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.SpeedSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpeedSlider.Location = new System.Drawing.Point(220, 188);
            this.SpeedSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.RangeMax = 30;
            this.SpeedSlider.ShowText = false;
            this.SpeedSlider.Size = new System.Drawing.Size(250, 40);
            this.SpeedSlider.TabIndex = 24;
            this.SpeedSlider.Text = "materialSlider1";
            this.SpeedSlider.Value = 0;
            this.SpeedSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.SpeedSlider_onValueChanged);
            // 
            // SpeedCheckBox
            // 
            this.SpeedCheckBox.AutoSize = true;
            this.SpeedCheckBox.Depth = 0;
            this.SpeedCheckBox.Location = new System.Drawing.Point(474, 189);
            this.SpeedCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.SpeedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SpeedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SpeedCheckBox.Name = "SpeedCheckBox";
            this.SpeedCheckBox.ReadOnly = false;
            this.SpeedCheckBox.Ripple = true;
            this.SpeedCheckBox.Size = new System.Drawing.Size(83, 37);
            this.SpeedCheckBox.TabIndex = 25;
            this.SpeedCheckBox.Text = "Enable";
            this.SpeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 413);
            this.Controls.Add(this.SpeedCheckBox);
            this.Controls.Add(this.SpeedSlider);
            this.Controls.Add(this.CoinsCheckBox);
            this.Controls.Add(this.SendCoinsButton);
            this.Controls.Add(this.CoinsTextBox);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.CoinsCoutLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ProcOpenLable);
            this.Controls.Add(this.materialLabel1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kingdom Two Crowns Cheater";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private MaterialSkin.Controls.MaterialLabel ProcOpenLable;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel CoinsCoutLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel SpeedLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox CoinsTextBox;
        private MaterialSkin.Controls.MaterialButton SendCoinsButton;
        private MaterialSkin.Controls.MaterialCheckbox CoinsCheckBox;
        private MaterialSkin.Controls.MaterialSlider SpeedSlider;
        private MaterialSkin.Controls.MaterialCheckbox SpeedCheckBox;
    }
}

