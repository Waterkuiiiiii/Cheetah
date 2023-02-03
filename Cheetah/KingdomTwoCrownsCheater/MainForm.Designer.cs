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
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CoinsTextBox = new System.Windows.Forms.TextBox();
            this.SendCoinsButton = new System.Windows.Forms.Button();
            this.CoinsCoutLabel = new System.Windows.Forms.Label();
            this.CoinsCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedScrollBar = new System.Windows.Forms.HScrollBar();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SendSpeedButton = new System.Windows.Forms.Button();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.SpeedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcOpenLable
            // 
            this.ProcOpenLable.AutoSize = true;
            this.ProcOpenLable.Location = new System.Drawing.Point(55, 9);
            this.ProcOpenLable.Name = "ProcOpenLable";
            this.ProcOpenLable.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLable.TabIndex = 1;
            this.ProcOpenLable.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coins:";
            // 
            // CoinsTextBox
            // 
            this.CoinsTextBox.Location = new System.Drawing.Point(135, 36);
            this.CoinsTextBox.Name = "CoinsTextBox";
            this.CoinsTextBox.Size = new System.Drawing.Size(71, 20);
            this.CoinsTextBox.TabIndex = 3;
            // 
            // SendCoinsButton
            // 
            this.SendCoinsButton.Location = new System.Drawing.Point(211, 35);
            this.SendCoinsButton.Name = "SendCoinsButton";
            this.SendCoinsButton.Size = new System.Drawing.Size(48, 23);
            this.SendCoinsButton.TabIndex = 4;
            this.SendCoinsButton.Text = "Send";
            this.SendCoinsButton.UseVisualStyleBackColor = true;
            this.SendCoinsButton.Click += new System.EventHandler(this.SendCoinsButton_Click);
            // 
            // CoinsCoutLabel
            // 
            this.CoinsCoutLabel.AutoSize = true;
            this.CoinsCoutLabel.Location = new System.Drawing.Point(55, 40);
            this.CoinsCoutLabel.Name = "CoinsCoutLabel";
            this.CoinsCoutLabel.Size = new System.Drawing.Size(27, 13);
            this.CoinsCoutLabel.TabIndex = 5;
            this.CoinsCoutLabel.Text = "N/A";
            // 
            // CoinsCheckBox
            // 
            this.CoinsCheckBox.AutoSize = true;
            this.CoinsCheckBox.Location = new System.Drawing.Point(265, 40);
            this.CoinsCheckBox.Name = "CoinsCheckBox";
            this.CoinsCheckBox.Size = new System.Drawing.Size(58, 17);
            this.CoinsCheckBox.TabIndex = 6;
            this.CoinsCheckBox.Text = "Freeze";
            this.CoinsCheckBox.UseVisualStyleBackColor = true;
            this.CoinsCheckBox.CheckedChanged += new System.EventHandler(this.CoinsCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed:";
            // 
            // SpeedScrollBar
            // 
            this.SpeedScrollBar.LargeChange = 3;
            this.SpeedScrollBar.Location = new System.Drawing.Point(259, 66);
            this.SpeedScrollBar.Maximum = 29;
            this.SpeedScrollBar.Name = "SpeedScrollBar";
            this.SpeedScrollBar.Size = new System.Drawing.Size(104, 17);
            this.SpeedScrollBar.TabIndex = 8;
            this.SpeedScrollBar.Value = 1;
            this.SpeedScrollBar.ValueChanged += new System.EventHandler(this.SpeedScrollBar_ValueChanged);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(60, 68);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(27, 13);
            this.SpeedLabel.TabIndex = 9;
            this.SpeedLabel.Text = "N/A";
            // 
            // SendSpeedButton
            // 
            this.SendSpeedButton.Location = new System.Drawing.Point(211, 63);
            this.SendSpeedButton.Name = "SendSpeedButton";
            this.SendSpeedButton.Size = new System.Drawing.Size(48, 23);
            this.SendSpeedButton.TabIndex = 11;
            this.SendSpeedButton.Text = "Send";
            this.SendSpeedButton.UseVisualStyleBackColor = true;
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(135, 64);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(71, 20);
            this.SpeedTextBox.TabIndex = 10;
            // 
            // SpeedCheckBox
            // 
            this.SpeedCheckBox.AutoSize = true;
            this.SpeedCheckBox.Location = new System.Drawing.Point(369, 68);
            this.SpeedCheckBox.Name = "SpeedCheckBox";
            this.SpeedCheckBox.Size = new System.Drawing.Size(59, 17);
            this.SpeedCheckBox.TabIndex = 12;
            this.SpeedCheckBox.Text = "Enable";
            this.SpeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 340);
            this.Controls.Add(this.SpeedCheckBox);
            this.Controls.Add(this.SendSpeedButton);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.SpeedScrollBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoinsCheckBox);
            this.Controls.Add(this.CoinsCoutLabel);
            this.Controls.Add(this.SendCoinsButton);
            this.Controls.Add(this.CoinsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProcOpenLable);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Kingdom Two Crowns Cheater";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoinsTextBox;
        private System.Windows.Forms.Button SendCoinsButton;
        private System.Windows.Forms.Label CoinsCoutLabel;
        private System.Windows.Forms.CheckBox CoinsCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar SpeedScrollBar;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Button SendSpeedButton;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.CheckBox SpeedCheckBox;
    }
}

