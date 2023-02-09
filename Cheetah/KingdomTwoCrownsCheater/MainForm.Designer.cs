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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.speedCheckBox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.speedCheckBox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.gemsSendButton1 = new MaterialSkin.Controls.MaterialButton();
            this.gemsCheckBox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.coinsCountLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.gemsTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.gemsCountLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.speedLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.coinsTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.coinsSendButton1 = new MaterialSkin.Controls.MaterialButton();
            this.speedSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.coinsCheckBox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.procOpenLable1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.coinsCountLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.speedSlider2 = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.gemsCheckBox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.speedLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.gemsSendButton2 = new MaterialSkin.Controls.MaterialButton();
            this.coinsTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.gemsTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.coinsSendButton2 = new MaterialSkin.Controls.MaterialButton();
            this.gemsCountLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.coinsCheckBox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.procOpenLable2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.aboutButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.langComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.blueGreyRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.pinkRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.greenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.redRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.blueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.darkModeSwtich = new MaterialSkin.Controls.MaterialSwitch();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // speedCheckBox1
            // 
            resources.ApplyResources(this.speedCheckBox1, "speedCheckBox1");
            this.speedCheckBox1.Depth = 0;
            this.speedCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.speedCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedCheckBox1.Name = "speedCheckBox1";
            this.speedCheckBox1.ReadOnly = false;
            this.speedCheckBox1.Ripple = true;
            this.toolTip.SetToolTip(this.speedCheckBox1, resources.GetString("speedCheckBox1.ToolTip"));
            this.speedCheckBox1.UseVisualStyleBackColor = true;
            // 
            // speedCheckBox2
            // 
            resources.ApplyResources(this.speedCheckBox2, "speedCheckBox2");
            this.speedCheckBox2.Depth = 0;
            this.speedCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.speedCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedCheckBox2.Name = "speedCheckBox2";
            this.speedCheckBox2.ReadOnly = false;
            this.speedCheckBox2.Ripple = true;
            this.toolTip.SetToolTip(this.speedCheckBox2, resources.GetString("speedCheckBox2.ToolTip"));
            this.speedCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.toolTip.SetToolTip(this.materialLabel1, resources.GetString("materialLabel1.ToolTip"));
            // 
            // materialTabControl1
            // 
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.toolTip.SetToolTip(this.materialTabControl1, resources.GetString("materialTabControl1.ToolTip"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.procOpenLable1);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Name = "tabPage1";
            this.toolTip.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            // 
            // materialCard1
            // 
            resources.ApplyResources(this.materialCard1, "materialCard1");
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.gemsSendButton1);
            this.materialCard1.Controls.Add(this.gemsCheckBox1);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.coinsCountLabel1);
            this.materialCard1.Controls.Add(this.gemsTextBox1);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.gemsCountLabel1);
            this.materialCard1.Controls.Add(this.speedLabel1);
            this.materialCard1.Controls.Add(this.materialLabel11);
            this.materialCard1.Controls.Add(this.coinsTextBox1);
            this.materialCard1.Controls.Add(this.speedCheckBox1);
            this.materialCard1.Controls.Add(this.coinsSendButton1);
            this.materialCard1.Controls.Add(this.speedSlider1);
            this.materialCard1.Controls.Add(this.coinsCheckBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.toolTip.SetToolTip(this.materialCard1, resources.GetString("materialCard1.ToolTip"));
            // 
            // gemsSendButton1
            // 
            resources.ApplyResources(this.gemsSendButton1, "gemsSendButton1");
            this.gemsSendButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gemsSendButton1.Depth = 0;
            this.gemsSendButton1.HighEmphasis = true;
            this.gemsSendButton1.Icon = null;
            this.gemsSendButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.gemsSendButton1.Name = "gemsSendButton1";
            this.gemsSendButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.toolTip.SetToolTip(this.gemsSendButton1, resources.GetString("gemsSendButton1.ToolTip"));
            this.gemsSendButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gemsSendButton1.UseAccentColor = false;
            this.gemsSendButton1.UseVisualStyleBackColor = true;
            this.gemsSendButton1.Click += new System.EventHandler(this.gemsSendButton1_Click);
            // 
            // gemsCheckBox1
            // 
            resources.ApplyResources(this.gemsCheckBox1, "gemsCheckBox1");
            this.gemsCheckBox1.Depth = 0;
            this.gemsCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gemsCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.gemsCheckBox1.Name = "gemsCheckBox1";
            this.gemsCheckBox1.ReadOnly = false;
            this.gemsCheckBox1.Ripple = true;
            this.toolTip.SetToolTip(this.gemsCheckBox1, resources.GetString("gemsCheckBox1.ToolTip"));
            this.gemsCheckBox1.UseVisualStyleBackColor = true;
            this.gemsCheckBox1.CheckedChanged += new System.EventHandler(this.gemsCheckBox1_CheckedChanged);
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.toolTip.SetToolTip(this.materialLabel2, resources.GetString("materialLabel2.ToolTip"));
            // 
            // coinsCountLabel1
            // 
            resources.ApplyResources(this.coinsCountLabel1, "coinsCountLabel1");
            this.coinsCountLabel1.Depth = 0;
            this.coinsCountLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.coinsCountLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.coinsCountLabel1.Name = "coinsCountLabel1";
            this.toolTip.SetToolTip(this.coinsCountLabel1, resources.GetString("coinsCountLabel1.ToolTip"));
            // 
            // gemsTextBox1
            // 
            resources.ApplyResources(this.gemsTextBox1, "gemsTextBox1");
            this.gemsTextBox1.AnimateReadOnly = false;
            this.gemsTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gemsTextBox1.Depth = 0;
            this.gemsTextBox1.LeadingIcon = null;
            this.gemsTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.gemsTextBox1.Name = "gemsTextBox1";
            this.toolTip.SetToolTip(this.gemsTextBox1, resources.GetString("gemsTextBox1.ToolTip"));
            this.gemsTextBox1.TrailingIcon = null;
            this.gemsTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gemsTextBox1_KeyDown);
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.toolTip.SetToolTip(this.materialLabel3, resources.GetString("materialLabel3.ToolTip"));
            // 
            // gemsCountLabel1
            // 
            resources.ApplyResources(this.gemsCountLabel1, "gemsCountLabel1");
            this.gemsCountLabel1.Depth = 0;
            this.gemsCountLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.gemsCountLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.gemsCountLabel1.Name = "gemsCountLabel1";
            this.toolTip.SetToolTip(this.gemsCountLabel1, resources.GetString("gemsCountLabel1.ToolTip"));
            // 
            // speedLabel1
            // 
            resources.ApplyResources(this.speedLabel1, "speedLabel1");
            this.speedLabel1.Depth = 0;
            this.speedLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.speedLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedLabel1.Name = "speedLabel1";
            this.toolTip.SetToolTip(this.speedLabel1, resources.GetString("speedLabel1.ToolTip"));
            // 
            // materialLabel11
            // 
            resources.ApplyResources(this.materialLabel11, "materialLabel11");
            this.materialLabel11.Depth = 0;
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.toolTip.SetToolTip(this.materialLabel11, resources.GetString("materialLabel11.ToolTip"));
            // 
            // coinsTextBox1
            // 
            resources.ApplyResources(this.coinsTextBox1, "coinsTextBox1");
            this.coinsTextBox1.AnimateReadOnly = false;
            this.coinsTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coinsTextBox1.Depth = 0;
            this.coinsTextBox1.LeadingIcon = null;
            this.coinsTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.coinsTextBox1.Name = "coinsTextBox1";
            this.toolTip.SetToolTip(this.coinsTextBox1, resources.GetString("coinsTextBox1.ToolTip"));
            this.coinsTextBox1.TrailingIcon = null;
            this.coinsTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coinsTextBox1_KeyDown);
            // 
            // coinsSendButton1
            // 
            resources.ApplyResources(this.coinsSendButton1, "coinsSendButton1");
            this.coinsSendButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.coinsSendButton1.Depth = 0;
            this.coinsSendButton1.HighEmphasis = true;
            this.coinsSendButton1.Icon = null;
            this.coinsSendButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.coinsSendButton1.Name = "coinsSendButton1";
            this.coinsSendButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.toolTip.SetToolTip(this.coinsSendButton1, resources.GetString("coinsSendButton1.ToolTip"));
            this.coinsSendButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.coinsSendButton1.UseAccentColor = false;
            this.coinsSendButton1.UseVisualStyleBackColor = true;
            this.coinsSendButton1.Click += new System.EventHandler(this.coinsSendButton1_Click);
            // 
            // speedSlider1
            // 
            resources.ApplyResources(this.speedSlider1, "speedSlider1");
            this.speedSlider1.Depth = 0;
            this.speedSlider1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.speedSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedSlider1.Name = "speedSlider1";
            this.speedSlider1.RangeMax = 30;
            this.speedSlider1.ShowText = false;
            this.toolTip.SetToolTip(this.speedSlider1, resources.GetString("speedSlider1.ToolTip"));
            this.speedSlider1.Value = 0;
            this.speedSlider1.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.speedSlider1_onValueChanged);
            // 
            // coinsCheckBox1
            // 
            resources.ApplyResources(this.coinsCheckBox1, "coinsCheckBox1");
            this.coinsCheckBox1.Depth = 0;
            this.coinsCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.coinsCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.coinsCheckBox1.Name = "coinsCheckBox1";
            this.coinsCheckBox1.ReadOnly = false;
            this.coinsCheckBox1.Ripple = true;
            this.toolTip.SetToolTip(this.coinsCheckBox1, resources.GetString("coinsCheckBox1.ToolTip"));
            this.coinsCheckBox1.UseVisualStyleBackColor = true;
            this.coinsCheckBox1.CheckedChanged += new System.EventHandler(this.coinsCheckBox1_CheckedChanged);
            // 
            // procOpenLable1
            // 
            resources.ApplyResources(this.procOpenLable1, "procOpenLable1");
            this.procOpenLable1.Depth = 0;
            this.procOpenLable1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.procOpenLable1.MouseState = MaterialSkin.MouseState.HOVER;
            this.procOpenLable1.Name = "procOpenLable1";
            this.toolTip.SetToolTip(this.procOpenLable1, resources.GetString("procOpenLable1.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Controls.Add(this.procOpenLable2);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Name = "tabPage2";
            this.toolTip.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            // 
            // materialCard2
            // 
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.speedCheckBox2);
            this.materialCard2.Controls.Add(this.coinsCountLabel2);
            this.materialCard2.Controls.Add(this.speedSlider2);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.gemsCheckBox2);
            this.materialCard2.Controls.Add(this.speedLabel2);
            this.materialCard2.Controls.Add(this.gemsSendButton2);
            this.materialCard2.Controls.Add(this.coinsTextBox2);
            this.materialCard2.Controls.Add(this.gemsTextBox2);
            this.materialCard2.Controls.Add(this.coinsSendButton2);
            this.materialCard2.Controls.Add(this.gemsCountLabel2);
            this.materialCard2.Controls.Add(this.coinsCheckBox2);
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.toolTip.SetToolTip(this.materialCard2, resources.GetString("materialCard2.ToolTip"));
            // 
            // materialLabel8
            // 
            resources.ApplyResources(this.materialLabel8, "materialLabel8");
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.toolTip.SetToolTip(this.materialLabel8, resources.GetString("materialLabel8.ToolTip"));
            // 
            // coinsCountLabel2
            // 
            resources.ApplyResources(this.coinsCountLabel2, "coinsCountLabel2");
            this.coinsCountLabel2.Depth = 0;
            this.coinsCountLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.coinsCountLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.coinsCountLabel2.Name = "coinsCountLabel2";
            this.toolTip.SetToolTip(this.coinsCountLabel2, resources.GetString("coinsCountLabel2.ToolTip"));
            // 
            // speedSlider2
            // 
            resources.ApplyResources(this.speedSlider2, "speedSlider2");
            this.speedSlider2.Depth = 0;
            this.speedSlider2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.speedSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedSlider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedSlider2.Name = "speedSlider2";
            this.speedSlider2.RangeMax = 30;
            this.speedSlider2.ShowText = false;
            this.toolTip.SetToolTip(this.speedSlider2, resources.GetString("speedSlider2.ToolTip"));
            this.speedSlider2.Value = 0;
            this.speedSlider2.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.speedSlider2_onValueChanged);
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.toolTip.SetToolTip(this.materialLabel6, resources.GetString("materialLabel6.ToolTip"));
            // 
            // gemsCheckBox2
            // 
            resources.ApplyResources(this.gemsCheckBox2, "gemsCheckBox2");
            this.gemsCheckBox2.Depth = 0;
            this.gemsCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gemsCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.gemsCheckBox2.Name = "gemsCheckBox2";
            this.gemsCheckBox2.ReadOnly = false;
            this.gemsCheckBox2.Ripple = true;
            this.toolTip.SetToolTip(this.gemsCheckBox2, resources.GetString("gemsCheckBox2.ToolTip"));
            this.gemsCheckBox2.UseVisualStyleBackColor = true;
            this.gemsCheckBox2.CheckedChanged += new System.EventHandler(this.gemsCheckBox2_CheckedChanged);
            // 
            // speedLabel2
            // 
            resources.ApplyResources(this.speedLabel2, "speedLabel2");
            this.speedLabel2.Depth = 0;
            this.speedLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.speedLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedLabel2.Name = "speedLabel2";
            this.toolTip.SetToolTip(this.speedLabel2, resources.GetString("speedLabel2.ToolTip"));
            // 
            // gemsSendButton2
            // 
            resources.ApplyResources(this.gemsSendButton2, "gemsSendButton2");
            this.gemsSendButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gemsSendButton2.Depth = 0;
            this.gemsSendButton2.HighEmphasis = true;
            this.gemsSendButton2.Icon = null;
            this.gemsSendButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.gemsSendButton2.Name = "gemsSendButton2";
            this.gemsSendButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.toolTip.SetToolTip(this.gemsSendButton2, resources.GetString("gemsSendButton2.ToolTip"));
            this.gemsSendButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gemsSendButton2.UseAccentColor = false;
            this.gemsSendButton2.UseVisualStyleBackColor = true;
            this.gemsSendButton2.Click += new System.EventHandler(this.gemsSendButton2_Click);
            // 
            // coinsTextBox2
            // 
            resources.ApplyResources(this.coinsTextBox2, "coinsTextBox2");
            this.coinsTextBox2.AnimateReadOnly = false;
            this.coinsTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coinsTextBox2.Depth = 0;
            this.coinsTextBox2.LeadingIcon = null;
            this.coinsTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.coinsTextBox2.Name = "coinsTextBox2";
            this.toolTip.SetToolTip(this.coinsTextBox2, resources.GetString("coinsTextBox2.ToolTip"));
            this.coinsTextBox2.TrailingIcon = null;
            this.coinsTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coinsTextBox2_KeyDown);
            // 
            // gemsTextBox2
            // 
            resources.ApplyResources(this.gemsTextBox2, "gemsTextBox2");
            this.gemsTextBox2.AnimateReadOnly = false;
            this.gemsTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gemsTextBox2.Depth = 0;
            this.gemsTextBox2.LeadingIcon = null;
            this.gemsTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.gemsTextBox2.Name = "gemsTextBox2";
            this.toolTip.SetToolTip(this.gemsTextBox2, resources.GetString("gemsTextBox2.ToolTip"));
            this.gemsTextBox2.TrailingIcon = null;
            this.gemsTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gemsTextBox2_KeyDown);
            // 
            // coinsSendButton2
            // 
            resources.ApplyResources(this.coinsSendButton2, "coinsSendButton2");
            this.coinsSendButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.coinsSendButton2.Depth = 0;
            this.coinsSendButton2.HighEmphasis = true;
            this.coinsSendButton2.Icon = null;
            this.coinsSendButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.coinsSendButton2.Name = "coinsSendButton2";
            this.coinsSendButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.toolTip.SetToolTip(this.coinsSendButton2, resources.GetString("coinsSendButton2.ToolTip"));
            this.coinsSendButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.coinsSendButton2.UseAccentColor = false;
            this.coinsSendButton2.UseVisualStyleBackColor = true;
            this.coinsSendButton2.Click += new System.EventHandler(this.coinsSendButton2_Click);
            // 
            // gemsCountLabel2
            // 
            resources.ApplyResources(this.gemsCountLabel2, "gemsCountLabel2");
            this.gemsCountLabel2.Depth = 0;
            this.gemsCountLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.gemsCountLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.gemsCountLabel2.Name = "gemsCountLabel2";
            this.toolTip.SetToolTip(this.gemsCountLabel2, resources.GetString("gemsCountLabel2.ToolTip"));
            // 
            // coinsCheckBox2
            // 
            resources.ApplyResources(this.coinsCheckBox2, "coinsCheckBox2");
            this.coinsCheckBox2.Depth = 0;
            this.coinsCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.coinsCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.coinsCheckBox2.Name = "coinsCheckBox2";
            this.coinsCheckBox2.ReadOnly = false;
            this.coinsCheckBox2.Ripple = true;
            this.toolTip.SetToolTip(this.coinsCheckBox2, resources.GetString("coinsCheckBox2.ToolTip"));
            this.coinsCheckBox2.UseVisualStyleBackColor = true;
            this.coinsCheckBox2.CheckedChanged += new System.EventHandler(this.coinsCheckBox2_CheckedChanged);
            // 
            // materialLabel9
            // 
            resources.ApplyResources(this.materialLabel9, "materialLabel9");
            this.materialLabel9.Depth = 0;
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.toolTip.SetToolTip(this.materialLabel9, resources.GetString("materialLabel9.ToolTip"));
            // 
            // procOpenLable2
            // 
            resources.ApplyResources(this.procOpenLable2, "procOpenLable2");
            this.procOpenLable2.Depth = 0;
            this.procOpenLable2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.procOpenLable2.MouseState = MaterialSkin.MouseState.HOVER;
            this.procOpenLable2.Name = "procOpenLable2";
            this.toolTip.SetToolTip(this.procOpenLable2, resources.GetString("procOpenLable2.ToolTip"));
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.toolTip.SetToolTip(this.materialLabel5, resources.GetString("materialLabel5.ToolTip"));
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialLabel13);
            this.tabPage3.Controls.Add(this.materialCard6);
            this.tabPage3.Controls.Add(this.materialLabel10);
            this.tabPage3.Controls.Add(this.materialCard5);
            this.tabPage3.Controls.Add(this.materialLabel7);
            this.tabPage3.Controls.Add(this.materialCard4);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.materialCard3);
            this.tabPage3.Name = "tabPage3";
            this.toolTip.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
            // 
            // materialLabel13
            // 
            resources.ApplyResources(this.materialLabel13, "materialLabel13");
            this.materialLabel13.Depth = 0;
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.toolTip.SetToolTip(this.materialLabel13, resources.GetString("materialLabel13.ToolTip"));
            // 
            // materialCard6
            // 
            resources.ApplyResources(this.materialCard6, "materialCard6");
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialLabel15);
            this.materialCard6.Controls.Add(this.materialLabel14);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.toolTip.SetToolTip(this.materialCard6, resources.GetString("materialCard6.ToolTip"));
            // 
            // materialLabel15
            // 
            resources.ApplyResources(this.materialLabel15, "materialLabel15");
            this.materialLabel15.Depth = 0;
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.toolTip.SetToolTip(this.materialLabel15, resources.GetString("materialLabel15.ToolTip"));
            // 
            // materialLabel14
            // 
            resources.ApplyResources(this.materialLabel14, "materialLabel14");
            this.materialLabel14.Depth = 0;
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.toolTip.SetToolTip(this.materialLabel14, resources.GetString("materialLabel14.ToolTip"));
            // 
            // materialLabel10
            // 
            resources.ApplyResources(this.materialLabel10, "materialLabel10");
            this.materialLabel10.Depth = 0;
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.toolTip.SetToolTip(this.materialLabel10, resources.GetString("materialLabel10.ToolTip"));
            // 
            // materialCard5
            // 
            resources.ApplyResources(this.materialCard5, "materialCard5");
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.aboutButton);
            this.materialCard5.Controls.Add(this.materialLabel12);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.toolTip.SetToolTip(this.materialCard5, resources.GetString("materialCard5.ToolTip"));
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.aboutButton.Depth = 0;
            this.aboutButton.HighEmphasis = true;
            this.aboutButton.Icon = null;
            this.aboutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.toolTip.SetToolTip(this.aboutButton, resources.GetString("aboutButton.ToolTip"));
            this.aboutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.aboutButton.UseAccentColor = false;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // materialLabel12
            // 
            resources.ApplyResources(this.materialLabel12, "materialLabel12");
            this.materialLabel12.Depth = 0;
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.toolTip.SetToolTip(this.materialLabel12, resources.GetString("materialLabel12.ToolTip"));
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.toolTip.SetToolTip(this.materialLabel7, resources.GetString("materialLabel7.ToolTip"));
            // 
            // materialCard4
            // 
            resources.ApplyResources(this.materialCard4, "materialCard4");
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.langComboBox);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.toolTip.SetToolTip(this.materialCard4, resources.GetString("materialCard4.ToolTip"));
            // 
            // langComboBox
            // 
            resources.ApplyResources(this.langComboBox, "langComboBox");
            this.langComboBox.AutoResize = false;
            this.langComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langComboBox.Depth = 0;
            this.langComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.langComboBox.DropDownHeight = 174;
            this.langComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langComboBox.DropDownWidth = 121;
            this.langComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.Items.AddRange(new object[] {
            resources.GetString("langComboBox.Items"),
            resources.GetString("langComboBox.Items1"),
            resources.GetString("langComboBox.Items2")});
            this.langComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.StartIndex = 0;
            this.toolTip.SetToolTip(this.langComboBox, resources.GetString("langComboBox.ToolTip"));
            this.langComboBox.SelectedIndexChanged += new System.EventHandler(this.langComboBox_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.toolTip.SetToolTip(this.materialLabel4, resources.GetString("materialLabel4.ToolTip"));
            // 
            // materialCard3
            // 
            resources.ApplyResources(this.materialCard3, "materialCard3");
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.blueGreyRadioButton);
            this.materialCard3.Controls.Add(this.pinkRadioButton);
            this.materialCard3.Controls.Add(this.greenRadioButton);
            this.materialCard3.Controls.Add(this.redRadioButton);
            this.materialCard3.Controls.Add(this.blueRadioButton);
            this.materialCard3.Controls.Add(this.darkModeSwtich);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.toolTip.SetToolTip(this.materialCard3, resources.GetString("materialCard3.ToolTip"));
            // 
            // blueGreyRadioButton
            // 
            resources.ApplyResources(this.blueGreyRadioButton, "blueGreyRadioButton");
            this.blueGreyRadioButton.Depth = 0;
            this.blueGreyRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.blueGreyRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.blueGreyRadioButton.Name = "blueGreyRadioButton";
            this.blueGreyRadioButton.Ripple = true;
            this.blueGreyRadioButton.TabStop = true;
            this.toolTip.SetToolTip(this.blueGreyRadioButton, resources.GetString("blueGreyRadioButton.ToolTip"));
            this.blueGreyRadioButton.UseVisualStyleBackColor = true;
            this.blueGreyRadioButton.CheckedChanged += new System.EventHandler(this.blueGreyRadioButton_CheckedChanged);
            // 
            // pinkRadioButton
            // 
            resources.ApplyResources(this.pinkRadioButton, "pinkRadioButton");
            this.pinkRadioButton.Depth = 0;
            this.pinkRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pinkRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pinkRadioButton.Name = "pinkRadioButton";
            this.pinkRadioButton.Ripple = true;
            this.pinkRadioButton.TabStop = true;
            this.toolTip.SetToolTip(this.pinkRadioButton, resources.GetString("pinkRadioButton.ToolTip"));
            this.pinkRadioButton.UseVisualStyleBackColor = true;
            this.pinkRadioButton.CheckedChanged += new System.EventHandler(this.pinkRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            resources.ApplyResources(this.greenRadioButton, "greenRadioButton");
            this.greenRadioButton.Depth = 0;
            this.greenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.greenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Ripple = true;
            this.greenRadioButton.TabStop = true;
            this.toolTip.SetToolTip(this.greenRadioButton, resources.GetString("greenRadioButton.ToolTip"));
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            resources.ApplyResources(this.redRadioButton, "redRadioButton");
            this.redRadioButton.Depth = 0;
            this.redRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.redRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Ripple = true;
            this.redRadioButton.TabStop = true;
            this.toolTip.SetToolTip(this.redRadioButton, resources.GetString("redRadioButton.ToolTip"));
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            resources.ApplyResources(this.blueRadioButton, "blueRadioButton");
            this.blueRadioButton.Depth = 0;
            this.blueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.blueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Ripple = true;
            this.blueRadioButton.TabStop = true;
            this.toolTip.SetToolTip(this.blueRadioButton, resources.GetString("blueRadioButton.ToolTip"));
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
            // 
            // darkModeSwtich
            // 
            resources.ApplyResources(this.darkModeSwtich, "darkModeSwtich");
            this.darkModeSwtich.Depth = 0;
            this.darkModeSwtich.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkModeSwtich.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkModeSwtich.Name = "darkModeSwtich";
            this.darkModeSwtich.Ripple = true;
            this.toolTip.SetToolTip(this.darkModeSwtich, resources.GetString("darkModeSwtich.ToolTip"));
            this.darkModeSwtich.UseVisualStyleBackColor = true;
            this.darkModeSwtich.CheckedChanged += new System.EventHandler(this.darkModeSwtich_CheckedChanged);
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "SinglePlayer.png");
            this.menuIconList.Images.SetKeyName(1, "SingleWoplayer.png");
            this.menuIconList.Images.SetKeyName(2, "Gear.png");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ToolTip toolTip;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialCheckbox speedCheckBox1;
        private MaterialSkin.Controls.MaterialSlider speedSlider1;
        private MaterialSkin.Controls.MaterialCheckbox coinsCheckBox1;
        private MaterialSkin.Controls.MaterialButton coinsSendButton1;
        private MaterialSkin.Controls.MaterialTextBox coinsTextBox1;
        private MaterialSkin.Controls.MaterialLabel speedLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel coinsCountLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel procOpenLable1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList menuIconList;
        private MaterialSkin.Controls.MaterialLabel procOpenLable2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCheckbox coinsCheckBox2;
        private MaterialSkin.Controls.MaterialButton coinsSendButton2;
        private MaterialSkin.Controls.MaterialTextBox coinsTextBox2;
        private MaterialSkin.Controls.MaterialLabel speedLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel coinsCountLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCheckbox gemsCheckBox1;
        private MaterialSkin.Controls.MaterialButton gemsSendButton1;
        private MaterialSkin.Controls.MaterialTextBox gemsTextBox1;
        private MaterialSkin.Controls.MaterialLabel gemsCountLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialCheckbox gemsCheckBox2;
        private MaterialSkin.Controls.MaterialButton gemsSendButton2;
        private MaterialSkin.Controls.MaterialTextBox gemsTextBox2;
        private MaterialSkin.Controls.MaterialLabel gemsCountLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSlider speedSlider2;
        private MaterialSkin.Controls.MaterialCheckbox speedCheckBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton blueRadioButton;
        private MaterialSkin.Controls.MaterialSwitch darkModeSwtich;
        private MaterialSkin.Controls.MaterialRadioButton pinkRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton greenRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton redRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton blueGreyRadioButton;
        private MaterialSkin.Controls.MaterialComboBox langComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton aboutButton;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
    }
}

