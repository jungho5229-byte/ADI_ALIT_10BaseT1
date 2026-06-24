namespace LINMaster.Forms
{
    partial class FormCIE
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblFT4222Status = new System.Windows.Forms.Label();
            this.tabColor = new System.Windows.Forms.TabControl();
            this.tabCIE = new System.Windows.Forms.TabPage();
            this.pnlCIE = new System.Windows.Forms.Panel();
            this.pnlCIEBar = new System.Windows.Forms.Panel();
            this.lblModeL = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.lblCIEMode = new System.Windows.Forms.Label();
            this.lblSelXY = new System.Windows.Forms.Label();
            this.lblCursor = new System.Windows.Forms.Label();
            this.tabImg = new System.Windows.Forms.TabPage();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pnlImgBar = new System.Windows.Forms.Panel();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.lblImgInfo = new System.Windows.Forms.Label();
            this.lblImgColor = new System.Windows.Forms.Label();
            this.pnlColorPatch = new System.Windows.Forms.Panel();
            this.lblPatchL = new System.Windows.Forms.Label();
            this.grpFID = new System.Windows.Forms.GroupBox();
            this.lblFID = new System.Windows.Forms.Label();
            this.cmbFID = new System.Windows.Forms.ComboBox();
            this.txtManualFID = new System.Windows.Forms.TextBox();
            this.lblCS = new System.Windows.Forms.Label();
            this.cmbCS = new System.Windows.Forms.ComboBox();
            this.grpSF = new System.Windows.Forms.GroupBox();
            this.grpShift = new System.Windows.Forms.GroupBox();
            this.chkRGBWShift = new System.Windows.Forms.CheckBox();
            this.chkLedShift = new System.Windows.Forms.CheckBox();
            this.chkShiftStack = new System.Windows.Forms.CheckBox();
            this.chkLedShiftUp = new System.Windows.Forms.CheckBox();
            this.chkShiftStackUp = new System.Windows.Forms.CheckBox();
            this.chkMove = new System.Windows.Forms.CheckBox();
            this.chkEachControl = new System.Windows.Forms.CheckBox();
            this.nudShiftWidth = new System.Windows.Forms.NumericUpDown();
            this.lblShiftWidth = new System.Windows.Forms.Label();
            this.chkSF1 = new System.Windows.Forms.CheckBox();
            this.chkSF2 = new System.Windows.Forms.CheckBox();
            this.chkSF3 = new System.Windows.Forms.CheckBox();
            this.chkSF4 = new System.Windows.Forms.CheckBox();
            this.chkSF5 = new System.Windows.Forms.CheckBox();
            this.chkSF6 = new System.Windows.Forms.CheckBox();
            this.chkSF7 = new System.Windows.Forms.CheckBox();
            this.chkSF8 = new System.Windows.Forms.CheckBox();
            this.chkSF9 = new System.Windows.Forms.CheckBox();
            this.chkSF10 = new System.Windows.Forms.CheckBox();
            this.chkSF11 = new System.Windows.Forms.CheckBox();
            this.chkSF12 = new System.Windows.Forms.CheckBox();
            this.chkSF13 = new System.Windows.Forms.CheckBox();
            this.chkSF14 = new System.Windows.Forms.CheckBox();
            this.chkSF15 = new System.Windows.Forms.CheckBox();
            this.chkSF16 = new System.Windows.Forms.CheckBox();
            this.chkSF17 = new System.Windows.Forms.CheckBox();
            this.chkSF18 = new System.Windows.Forms.CheckBox();
            this.chkSF19 = new System.Windows.Forms.CheckBox();
            this.chkSF20 = new System.Windows.Forms.CheckBox();
            this.chkSF21 = new System.Windows.Forms.CheckBox();
            this.chkSF22 = new System.Windows.Forms.CheckBox();
            this.chkSF23 = new System.Windows.Forms.CheckBox();
            this.chkSF24 = new System.Windows.Forms.CheckBox();
            this.chkSF25 = new System.Windows.Forms.CheckBox();
            this.btnSFAll = new System.Windows.Forms.Button();
            this.btnSFNone = new System.Windows.Forms.Button();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.lblCX = new System.Windows.Forms.Label();
            this.nudColorX = new System.Windows.Forms.NumericUpDown();
            this.lblCY = new System.Windows.Forms.Label();
            this.nudColorY = new System.Windows.Forms.NumericUpDown();
            this.lblBr = new System.Windows.Forms.Label();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.grpFade = new System.Windows.Forms.GroupBox();
            this.lblFIN = new System.Windows.Forms.Label();
            this.nudFadeIn = new System.Windows.Forms.NumericUpDown();
            this.lblFOUT = new System.Windows.Forms.Label();
            this.nudFadeOut = new System.Windows.Forms.NumericUpDown();
            this.chkNoFade = new System.Windows.Forms.CheckBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.chkSOH = new System.Windows.Forms.CheckBox();
            this.chkLINErr = new System.Windows.Forms.CheckBox();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblD3 = new System.Windows.Forms.Label();
            this.lblD4 = new System.Windows.Forms.Label();
            this.lblD5 = new System.Windows.Forms.Label();
            this.lblD6 = new System.Windows.Forms.Label();
            this.lblD7 = new System.Windows.Forms.Label();
            this.lblD8 = new System.Windows.Forms.Label();
            this.grpTX = new System.Windows.Forms.GroupBox();
            this.lblIvL = new System.Windows.Forms.Label();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.lblMs = new System.Windows.Forms.Label();
            this.btnTxOnce = new System.Windows.Forms.Button();
            this.btnTxCycle = new System.Windows.Forms.Button();
            this.tabColor.SuspendLayout();
            this.tabCIE.SuspendLayout();
            this.pnlCIEBar.SuspendLayout();
            this.tabImg.SuspendLayout();
            this.pnlImgBar.SuspendLayout();
            this.grpFID.SuspendLayout();
            this.grpSF.SuspendLayout();
            this.grpShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftWidth)).BeginInit();
            this.grpColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            this.grpFade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeOut)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.grpTX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // txTimer
            // 
            this.txTimer.Interval = 10;
            this.txTimer.Tick += new System.EventHandler(this.TxTimer_Tick);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 10;
            this.fadeTimer.Tick += new System.EventHandler(this.FadeTimer_Tick);
            // 
            // lblFT4222Status
            // 
            this.lblFT4222Status.AutoSize = true;
            this.lblFT4222Status.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblFT4222Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.lblFT4222Status.Location = new System.Drawing.Point(6, 556);
            this.lblFT4222Status.Name = "lblFT4222Status";
            this.lblFT4222Status.Size = new System.Drawing.Size(113, 14);
            this.lblFT4222Status.TabIndex = 99;
            this.lblFT4222Status.Text = "● FT4222 연결 안됨";
            // 
            // tabColor
            // 
            this.tabColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabColor.Controls.Add(this.tabCIE);
            this.tabColor.Controls.Add(this.tabImg);
            this.tabColor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.tabColor.Location = new System.Drawing.Point(5, 5);
            this.tabColor.Name = "tabColor";
            this.tabColor.SelectedIndex = 0;
            this.tabColor.Size = new System.Drawing.Size(640, 747);
            this.tabColor.TabIndex = 0;
            // 
            // tabCIE
            // 
            this.tabCIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.tabCIE.Controls.Add(this.pnlCIE);
            this.tabCIE.Controls.Add(this.pnlCIEBar);
            this.tabCIE.Font = new System.Drawing.Font("Consolas", 9F);
            this.tabCIE.Location = new System.Drawing.Point(4, 23);
            this.tabCIE.Name = "tabCIE";
            this.tabCIE.Size = new System.Drawing.Size(632, 720);
            this.tabCIE.TabIndex = 0;
            this.tabCIE.Text = "  CIE 색도도  ";
            // 
            // pnlCIE
            // 
            this.pnlCIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(20)))));
            this.pnlCIE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCIE.Location = new System.Drawing.Point(0, 0);
            this.pnlCIE.Name = "pnlCIE";
            this.pnlCIE.Size = new System.Drawing.Size(632, 652);
            this.pnlCIE.TabIndex = 0;
            this.pnlCIE.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCIE_Paint);
            this.pnlCIE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCIE_MouseClick);
            this.pnlCIE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCIE_MouseMove);
            this.pnlCIE.Resize += new System.EventHandler(this.pnlCIE_Resize);
            // 
            // pnlCIEBar
            // 
            this.pnlCIEBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.pnlCIEBar.Controls.Add(this.lblModeL);
            this.pnlCIEBar.Controls.Add(this.cmbMode);
            this.pnlCIEBar.Controls.Add(this.lblCIEMode);
            this.pnlCIEBar.Controls.Add(this.lblSelXY);
            this.pnlCIEBar.Controls.Add(this.lblCursor);
            this.pnlCIEBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCIEBar.Location = new System.Drawing.Point(0, 652);
            this.pnlCIEBar.Name = "pnlCIEBar";
            this.pnlCIEBar.Size = new System.Drawing.Size(632, 68);
            this.pnlCIEBar.TabIndex = 1;
            // 
            // lblModeL
            // 
            this.lblModeL.AutoSize = true;
            this.lblModeL.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblModeL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblModeL.Location = new System.Drawing.Point(6, 8);
            this.lblModeL.Name = "lblModeL";
            this.lblModeL.Size = new System.Drawing.Size(42, 14);
            this.lblModeL.TabIndex = 0;
            this.lblModeL.Text = "Mode:";
            // 
            // cmbMode
            // 
            this.cmbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMode.Font = new System.Drawing.Font("Consolas", 9F);
            this.cmbMode.ForeColor = System.Drawing.Color.White;
            this.cmbMode.Items.AddRange(new object[] {
            "CIE1931 (xy)",
            "CIE1976 (u\'v\')"});
            this.cmbMode.Location = new System.Drawing.Point(50, 5);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(170, 22);
            this.cmbMode.TabIndex = 1;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // lblCIEMode
            // 
            this.lblCIEMode.AutoSize = true;
            this.lblCIEMode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblCIEMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.lblCIEMode.Location = new System.Drawing.Point(230, 8);
            this.lblCIEMode.Name = "lblCIEMode";
            this.lblCIEMode.Size = new System.Drawing.Size(56, 14);
            this.lblCIEMode.TabIndex = 2;
            this.lblCIEMode.Text = "CIE1931";
            // 
            // lblSelXY
            // 
            this.lblSelXY.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSelXY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(80)))));
            this.lblSelXY.Location = new System.Drawing.Point(6, 34);
            this.lblSelXY.Name = "lblSelXY";
            this.lblSelXY.Size = new System.Drawing.Size(620, 18);
            this.lblSelXY.TabIndex = 3;
            this.lblSelXY.Text = "색도도를 클릭하면 색상 좌표가 TX 데이터에 자동 반영됩니다";
            // 
            // lblCursor
            // 
            this.lblCursor.Font = new System.Drawing.Font("Consolas", 8F);
            this.lblCursor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.lblCursor.Location = new System.Drawing.Point(6, 50);
            this.lblCursor.Name = "lblCursor";
            this.lblCursor.Size = new System.Drawing.Size(400, 16);
            this.lblCursor.TabIndex = 4;
            this.lblCursor.Text = "Cursor: -";
            // 
            // tabImg
            // 
            this.tabImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.tabImg.Controls.Add(this.pnlImage);
            this.tabImg.Controls.Add(this.pnlImgBar);
            this.tabImg.Font = new System.Drawing.Font("Consolas", 9F);
            this.tabImg.Location = new System.Drawing.Point(4, 23);
            this.tabImg.Name = "tabImg";
            this.tabImg.Size = new System.Drawing.Size(632, 720);
            this.tabImg.TabIndex = 1;
            this.tabImg.Text = "  이미지 색상 선택  ";
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(632, 652);
            this.pnlImage.TabIndex = 0;
            this.pnlImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImage_Paint);
            this.pnlImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlImage_MouseClick);
            this.pnlImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlImage_MouseMove);
            // 
            // pnlImgBar
            // 
            this.pnlImgBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.pnlImgBar.Controls.Add(this.btnLoadImg);
            this.pnlImgBar.Controls.Add(this.lblImgInfo);
            this.pnlImgBar.Controls.Add(this.lblImgColor);
            this.pnlImgBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlImgBar.Location = new System.Drawing.Point(0, 652);
            this.pnlImgBar.Name = "pnlImgBar";
            this.pnlImgBar.Size = new System.Drawing.Size(632, 68);
            this.pnlImgBar.TabIndex = 1;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.btnLoadImg.FlatAppearance.BorderSize = 0;
            this.btnLoadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImg.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadImg.ForeColor = System.Drawing.Color.White;
            this.btnLoadImg.Location = new System.Drawing.Point(6, 8);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(120, 26);
            this.btnLoadImg.TabIndex = 0;
            this.btnLoadImg.Text = "이미지 로드";
            this.btnLoadImg.UseVisualStyleBackColor = false;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // lblImgInfo
            // 
            this.lblImgInfo.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblImgInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblImgInfo.Location = new System.Drawing.Point(134, 11);
            this.lblImgInfo.Name = "lblImgInfo";
            this.lblImgInfo.Size = new System.Drawing.Size(490, 18);
            this.lblImgInfo.TabIndex = 1;
            this.lblImgInfo.Text = "PNG / JPG / BMP 지원 – 클릭하면 해당 색상이 TX에 자동 반영";
            // 
            // lblImgColor
            // 
            this.lblImgColor.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblImgColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(80)))));
            this.lblImgColor.Location = new System.Drawing.Point(6, 44);
            this.lblImgColor.Name = "lblImgColor";
            this.lblImgColor.Size = new System.Drawing.Size(620, 18);
            this.lblImgColor.TabIndex = 2;
            // 
            // pnlColorPatch
            // 
            this.pnlColorPatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlColorPatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorPatch.Location = new System.Drawing.Point(650, 6);
            this.pnlColorPatch.Name = "pnlColorPatch";
            this.pnlColorPatch.Size = new System.Drawing.Size(68, 48);
            this.pnlColorPatch.TabIndex = 10;
            // 
            // lblPatchL
            // 
            this.lblPatchL.AutoSize = true;
            this.lblPatchL.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblPatchL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblPatchL.Location = new System.Drawing.Point(724, 18);
            this.lblPatchL.Name = "lblPatchL";
            this.lblPatchL.Size = new System.Drawing.Size(169, 28);
            this.lblPatchL.TabIndex = 11;
            this.lblPatchL.Text = "선택된 색상 미리보기\n(CIE 또는 이미지 클릭으로 갱신)";
            // 
            // grpFID
            // 
            this.grpFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.grpFID.Controls.Add(this.lblFID);
            this.grpFID.Controls.Add(this.cmbFID);
            this.grpFID.Controls.Add(this.txtManualFID);
            this.grpFID.Controls.Add(this.lblCS);
            this.grpFID.Controls.Add(this.cmbCS);
            this.grpFID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.grpFID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpFID.Location = new System.Drawing.Point(658, 62);
            this.grpFID.Name = "grpFID";
            this.grpFID.Size = new System.Drawing.Size(540, 60);
            this.grpFID.TabIndex = 12;
            this.grpFID.TabStop = false;
            this.grpFID.Text = "[ Frame ID / Checksum ]";
            // 
            // lblFID
            // 
            this.lblFID.AutoSize = true;
            this.lblFID.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblFID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblFID.Location = new System.Drawing.Point(8, 28);
            this.lblFID.Name = "lblFID";
            this.lblFID.Size = new System.Drawing.Size(42, 14);
            this.lblFID.TabIndex = 0;
            this.lblFID.Text = "FID :";
            // 
            // cmbFID
            // 
            this.cmbFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmbFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFID.Font = new System.Drawing.Font("Consolas", 9F);
            this.cmbFID.ForeColor = System.Drawing.Color.White;
            this.cmbFID.Items.AddRange(new object[] {
            "Broadcast (0x00)",
            "MLMM1  (0x01)",
            "MLMM2  (0x02)",
            "MLMM3  (0x03)",
            "MLMM4  (0x04)",
            "MLMM5  (0x05)",
            "MLMM6  (0x06)",
            "MLMM7  (0x07)",
            "MLMM8  (0x08)",
            "Manual"});
            this.cmbFID.Location = new System.Drawing.Point(70, 24);
            this.cmbFID.Name = "cmbFID";
            this.cmbFID.Size = new System.Drawing.Size(160, 22);
            this.cmbFID.TabIndex = 1;
            this.cmbFID.SelectedIndexChanged += new System.EventHandler(this.cmbFID_SelectedIndexChanged);
            // 
            // txtManualFID
            // 
            this.txtManualFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtManualFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManualFID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtManualFID.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtManualFID.ForeColor = System.Drawing.Color.White;
            this.txtManualFID.Location = new System.Drawing.Point(238, 25);
            this.txtManualFID.Name = "txtManualFID";
            this.txtManualFID.Size = new System.Drawing.Size(56, 22);
            this.txtManualFID.TabIndex = 2;
            this.txtManualFID.Text = "01";
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblCS.Location = new System.Drawing.Point(302, 28);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(28, 14);
            this.lblCS.TabIndex = 3;
            this.lblCS.Text = "CS:";
            // 
            // cmbCS
            // 
            this.cmbCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmbCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCS.Font = new System.Drawing.Font("Consolas", 9F);
            this.cmbCS.ForeColor = System.Drawing.Color.White;
            this.cmbCS.Items.AddRange(new object[] {
            "Classic",
            "Enhanced"});
            this.cmbCS.Location = new System.Drawing.Point(330, 24);
            this.cmbCS.Name = "cmbCS";
            this.cmbCS.Size = new System.Drawing.Size(120, 22);
            this.cmbCS.TabIndex = 4;
            // 
            // grpSF
            // 
            this.grpSF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.grpSF.Controls.Add(this.grpShift);
            this.grpSF.Controls.Add(this.chkSF1);
            this.grpSF.Controls.Add(this.chkSF2);
            this.grpSF.Controls.Add(this.chkSF3);
            this.grpSF.Controls.Add(this.chkSF4);
            this.grpSF.Controls.Add(this.chkSF5);
            this.grpSF.Controls.Add(this.chkSF6);
            this.grpSF.Controls.Add(this.chkSF7);
            this.grpSF.Controls.Add(this.chkSF8);
            this.grpSF.Controls.Add(this.chkSF9);
            this.grpSF.Controls.Add(this.chkSF10);
            this.grpSF.Controls.Add(this.chkSF11);
            this.grpSF.Controls.Add(this.chkSF12);
            this.grpSF.Controls.Add(this.chkSF13);
            this.grpSF.Controls.Add(this.chkSF14);
            this.grpSF.Controls.Add(this.chkSF15);
            this.grpSF.Controls.Add(this.chkSF16);
            this.grpSF.Controls.Add(this.chkSF17);
            this.grpSF.Controls.Add(this.chkSF18);
            this.grpSF.Controls.Add(this.chkSF19);
            this.grpSF.Controls.Add(this.chkSF20);
            this.grpSF.Controls.Add(this.chkSF21);
            this.grpSF.Controls.Add(this.chkSF22);
            this.grpSF.Controls.Add(this.chkSF23);
            this.grpSF.Controls.Add(this.chkSF24);
            this.grpSF.Controls.Add(this.chkSF25);
            this.grpSF.Controls.Add(this.btnSFAll);
            this.grpSF.Controls.Add(this.btnSFNone);
            this.grpSF.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.grpSF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpSF.Location = new System.Drawing.Point(659, 128);
            this.grpSF.Name = "grpSF";
            this.grpSF.Size = new System.Drawing.Size(540, 158);
            this.grpSF.TabIndex = 13;
            this.grpSF.TabStop = false;
            this.grpSF.Text = "[ DATA1/2  SlaveFlag  (LED 1~12 체크된 LED만 변경) ]";
            // 
            // grpShift
            // 
            this.grpShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.grpShift.Controls.Add(this.chkRGBWShift);
            this.grpShift.Controls.Add(this.chkLedShift);
            this.grpShift.Controls.Add(this.chkShiftStack);
            this.grpShift.Controls.Add(this.chkLedShiftUp);
            this.grpShift.Controls.Add(this.chkShiftStackUp);
            this.grpShift.Controls.Add(this.chkMove);
            this.grpShift.Controls.Add(this.chkEachControl);
            this.grpShift.Controls.Add(this.nudShiftWidth);
            this.grpShift.Controls.Add(this.lblShiftWidth);
            this.grpShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpShift.Location = new System.Drawing.Point(11, 96);
            this.grpShift.Name = "grpShift";
            this.grpShift.Size = new System.Drawing.Size(523, 58);
            this.grpShift.TabIndex = 20;
            this.grpShift.TabStop = false;
            this.grpShift.Text = "[ Shift Mode ]";
            // 
            // chkRGBWShift
            // 
            this.chkRGBWShift.AutoSize = true;
            this.chkRGBWShift.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkRGBWShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.chkRGBWShift.Location = new System.Drawing.Point(8, 16);
            this.chkRGBWShift.Name = "chkRGBWShift";
            this.chkRGBWShift.Size = new System.Drawing.Size(96, 18);
            this.chkRGBWShift.TabIndex = 17;
            this.chkRGBWShift.Text = "RGBW_Shift";
            this.chkRGBWShift.UseVisualStyleBackColor = false;
            this.chkRGBWShift.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkLedShift
            // 
            this.chkLedShift.AutoSize = true;
            this.chkLedShift.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkLedShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.chkLedShift.Location = new System.Drawing.Point(7, 35);
            this.chkLedShift.Name = "chkLedShift";
            this.chkLedShift.Size = new System.Drawing.Size(61, 18);
            this.chkLedShift.TabIndex = 18;
            this.chkLedShift.Text = "Shift";
            this.chkLedShift.UseVisualStyleBackColor = false;
            // 
            // chkShiftStack
            // 
            this.chkShiftStack.AutoSize = true;
            this.chkShiftStack.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkShiftStack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.chkShiftStack.Location = new System.Drawing.Point(69, 35);
            this.chkShiftStack.Name = "chkShiftStack";
            this.chkShiftStack.Size = new System.Drawing.Size(103, 18);
            this.chkShiftStack.TabIndex = 22;
            this.chkShiftStack.Text = "Shift Stack";
            this.chkShiftStack.UseVisualStyleBackColor = false;
            // 
            // chkLedShiftUp
            // 
            this.chkLedShiftUp.AutoSize = true;
            this.chkLedShiftUp.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkLedShiftUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.chkLedShiftUp.Location = new System.Drawing.Point(173, 35);
            this.chkLedShiftUp.Name = "chkLedShiftUp";
            this.chkLedShiftUp.Size = new System.Drawing.Size(82, 18);
            this.chkLedShiftUp.TabIndex = 21;
            this.chkLedShiftUp.Text = "Shift Up";
            this.chkLedShiftUp.UseVisualStyleBackColor = false;
            // 
            // chkShiftStackUp
            // 
            this.chkShiftStackUp.AutoSize = true;
            this.chkShiftStackUp.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkShiftStackUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.chkShiftStackUp.Location = new System.Drawing.Point(256, 35);
            this.chkShiftStackUp.Name = "chkShiftStackUp";
            this.chkShiftStackUp.Size = new System.Drawing.Size(124, 18);
            this.chkShiftStackUp.TabIndex = 23;
            this.chkShiftStackUp.Text = "Shift Stack Up";
            this.chkShiftStackUp.UseVisualStyleBackColor = false;
            // 
            // chkMove
            // 
            this.chkMove.AutoSize = true;
            this.chkMove.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkMove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.chkMove.Location = new System.Drawing.Point(109, 16);
            this.chkMove.Name = "chkMove";
            this.chkMove.Size = new System.Drawing.Size(54, 18);
            this.chkMove.TabIndex = 24;
            this.chkMove.Text = "Move";
            this.chkMove.UseVisualStyleBackColor = false;
            // 
            // chkEachControl
            // 
            this.chkEachControl.AutoSize = true;
            this.chkEachControl.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkEachControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.chkEachControl.Location = new System.Drawing.Point(174, 16);
            this.chkEachControl.Name = "chkEachControl";
            this.chkEachControl.Size = new System.Drawing.Size(110, 18);
            this.chkEachControl.TabIndex = 25;
            this.chkEachControl.Text = "Each Control";
            this.chkEachControl.UseVisualStyleBackColor = false;
            // 
            // nudShiftWidth
            // 
            this.nudShiftWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.nudShiftWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudShiftWidth.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.nudShiftWidth.ForeColor = System.Drawing.Color.White;
            this.nudShiftWidth.Location = new System.Drawing.Point(469, 31);
            this.nudShiftWidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudShiftWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShiftWidth.Name = "nudShiftWidth";
            this.nudShiftWidth.Size = new System.Drawing.Size(48, 21);
            this.nudShiftWidth.TabIndex = 19;
            this.nudShiftWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblShiftWidth
            // 
            this.lblShiftWidth.AutoSize = true;
            this.lblShiftWidth.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblShiftWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblShiftWidth.Location = new System.Drawing.Point(424, 35);
            this.lblShiftWidth.Name = "lblShiftWidth";
            this.lblShiftWidth.Size = new System.Drawing.Size(49, 14);
            this.lblShiftWidth.TabIndex = 20;
            this.lblShiftWidth.Text = "Width:";
            // 
            // chkSF1
            // 
            this.chkSF1.AutoSize = true;
            this.chkSF1.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF1.Location = new System.Drawing.Point(8, 28);
            this.chkSF1.Name = "chkSF1";
            this.chkSF1.Size = new System.Drawing.Size(47, 18);
            this.chkSF1.TabIndex = 0;
            this.chkSF1.Text = "SF1";
            this.chkSF1.UseVisualStyleBackColor = false;
            this.chkSF1.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF2
            // 
            this.chkSF2.AutoSize = true;
            this.chkSF2.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF2.Location = new System.Drawing.Point(64, 28);
            this.chkSF2.Name = "chkSF2";
            this.chkSF2.Size = new System.Drawing.Size(47, 18);
            this.chkSF2.TabIndex = 1;
            this.chkSF2.Text = "SF2";
            this.chkSF2.UseVisualStyleBackColor = false;
            this.chkSF2.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF3
            // 
            this.chkSF3.AutoSize = true;
            this.chkSF3.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF3.Location = new System.Drawing.Point(120, 28);
            this.chkSF3.Name = "chkSF3";
            this.chkSF3.Size = new System.Drawing.Size(47, 18);
            this.chkSF3.TabIndex = 2;
            this.chkSF3.Text = "SF3";
            this.chkSF3.UseVisualStyleBackColor = false;
            this.chkSF3.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF4
            // 
            this.chkSF4.AutoSize = true;
            this.chkSF4.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF4.Location = new System.Drawing.Point(176, 28);
            this.chkSF4.Name = "chkSF4";
            this.chkSF4.Size = new System.Drawing.Size(47, 18);
            this.chkSF4.TabIndex = 3;
            this.chkSF4.Text = "SF4";
            this.chkSF4.UseVisualStyleBackColor = false;
            this.chkSF4.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF5
            // 
            this.chkSF5.AutoSize = true;
            this.chkSF5.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF5.Location = new System.Drawing.Point(232, 28);
            this.chkSF5.Name = "chkSF5";
            this.chkSF5.Size = new System.Drawing.Size(47, 18);
            this.chkSF5.TabIndex = 4;
            this.chkSF5.Text = "SF5";
            this.chkSF5.UseVisualStyleBackColor = false;
            this.chkSF5.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF6
            // 
            this.chkSF6.AutoSize = true;
            this.chkSF6.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF6.Location = new System.Drawing.Point(288, 28);
            this.chkSF6.Name = "chkSF6";
            this.chkSF6.Size = new System.Drawing.Size(47, 18);
            this.chkSF6.TabIndex = 5;
            this.chkSF6.Text = "SF6";
            this.chkSF6.UseVisualStyleBackColor = false;
            this.chkSF6.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF7
            // 
            this.chkSF7.AutoSize = true;
            this.chkSF7.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF7.Location = new System.Drawing.Point(344, 28);
            this.chkSF7.Name = "chkSF7";
            this.chkSF7.Size = new System.Drawing.Size(47, 18);
            this.chkSF7.TabIndex = 6;
            this.chkSF7.Text = "SF7";
            this.chkSF7.UseVisualStyleBackColor = false;
            this.chkSF7.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF8
            // 
            this.chkSF8.AutoSize = true;
            this.chkSF8.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF8.Location = new System.Drawing.Point(400, 28);
            this.chkSF8.Name = "chkSF8";
            this.chkSF8.Size = new System.Drawing.Size(47, 18);
            this.chkSF8.TabIndex = 7;
            this.chkSF8.Text = "SF8";
            this.chkSF8.UseVisualStyleBackColor = false;
            this.chkSF8.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF9
            // 
            this.chkSF9.AutoSize = true;
            this.chkSF9.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF9.Location = new System.Drawing.Point(8, 52);
            this.chkSF9.Name = "chkSF9";
            this.chkSF9.Size = new System.Drawing.Size(47, 18);
            this.chkSF9.TabIndex = 10;
            this.chkSF9.Text = "SF9";
            this.chkSF9.UseVisualStyleBackColor = false;
            this.chkSF9.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF10
            // 
            this.chkSF10.AutoSize = true;
            this.chkSF10.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF10.Location = new System.Drawing.Point(64, 52);
            this.chkSF10.Name = "chkSF10";
            this.chkSF10.Size = new System.Drawing.Size(54, 18);
            this.chkSF10.TabIndex = 11;
            this.chkSF10.Text = "SF10";
            this.chkSF10.UseVisualStyleBackColor = false;
            this.chkSF10.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF11
            // 
            this.chkSF11.AutoSize = true;
            this.chkSF11.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF11.Location = new System.Drawing.Point(120, 52);
            this.chkSF11.Name = "chkSF11";
            this.chkSF11.Size = new System.Drawing.Size(54, 18);
            this.chkSF11.TabIndex = 12;
            this.chkSF11.Text = "SF11";
            this.chkSF11.UseVisualStyleBackColor = false;
            this.chkSF11.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF12
            // 
            this.chkSF12.AutoSize = true;
            this.chkSF12.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF12.Location = new System.Drawing.Point(176, 52);
            this.chkSF12.Name = "chkSF12";
            this.chkSF12.Size = new System.Drawing.Size(54, 18);
            this.chkSF12.TabIndex = 13;
            this.chkSF12.Text = "SF12";
            this.chkSF12.UseVisualStyleBackColor = false;
            this.chkSF12.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF13
            // 
            this.chkSF13.AutoSize = true;
            this.chkSF13.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF13.Location = new System.Drawing.Point(232, 52);
            this.chkSF13.Name = "chkSF13";
            this.chkSF13.Size = new System.Drawing.Size(54, 18);
            this.chkSF13.TabIndex = 43;
            this.chkSF13.Text = "SF13";
            this.chkSF13.UseVisualStyleBackColor = false;
            this.chkSF13.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF14
            // 
            this.chkSF14.AutoSize = true;
            this.chkSF14.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF14.Location = new System.Drawing.Point(288, 52);
            this.chkSF14.Name = "chkSF14";
            this.chkSF14.Size = new System.Drawing.Size(54, 18);
            this.chkSF14.TabIndex = 44;
            this.chkSF14.Text = "SF14";
            this.chkSF14.UseVisualStyleBackColor = false;
            this.chkSF14.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF15
            // 
            this.chkSF15.AutoSize = true;
            this.chkSF15.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF15.Location = new System.Drawing.Point(344, 52);
            this.chkSF15.Name = "chkSF15";
            this.chkSF15.Size = new System.Drawing.Size(54, 18);
            this.chkSF15.TabIndex = 45;
            this.chkSF15.Text = "SF15";
            this.chkSF15.UseVisualStyleBackColor = false;
            this.chkSF15.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF16
            // 
            this.chkSF16.AutoSize = true;
            this.chkSF16.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF16.Location = new System.Drawing.Point(400, 52);
            this.chkSF16.Name = "chkSF16";
            this.chkSF16.Size = new System.Drawing.Size(54, 18);
            this.chkSF16.TabIndex = 46;
            this.chkSF16.Text = "SF16";
            this.chkSF16.UseVisualStyleBackColor = false;
            this.chkSF16.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF17
            // 
            this.chkSF17.AutoSize = true;
            this.chkSF17.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF17.Location = new System.Drawing.Point(8, 76);
            this.chkSF17.Name = "chkSF17";
            this.chkSF17.Size = new System.Drawing.Size(54, 18);
            this.chkSF17.TabIndex = 47;
            this.chkSF17.Text = "SF17";
            this.chkSF17.UseVisualStyleBackColor = false;
            this.chkSF17.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF18
            // 
            this.chkSF18.AutoSize = true;
            this.chkSF18.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF18.Location = new System.Drawing.Point(64, 76);
            this.chkSF18.Name = "chkSF18";
            this.chkSF18.Size = new System.Drawing.Size(54, 18);
            this.chkSF18.TabIndex = 48;
            this.chkSF18.Text = "SF18";
            this.chkSF18.UseVisualStyleBackColor = false;
            this.chkSF18.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF19
            // 
            this.chkSF19.AutoSize = true;
            this.chkSF19.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF19.Location = new System.Drawing.Point(120, 76);
            this.chkSF19.Name = "chkSF19";
            this.chkSF19.Size = new System.Drawing.Size(54, 18);
            this.chkSF19.TabIndex = 49;
            this.chkSF19.Text = "SF19";
            this.chkSF19.UseVisualStyleBackColor = false;
            this.chkSF19.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF20
            // 
            this.chkSF20.AutoSize = true;
            this.chkSF20.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF20.Location = new System.Drawing.Point(176, 76);
            this.chkSF20.Name = "chkSF20";
            this.chkSF20.Size = new System.Drawing.Size(54, 18);
            this.chkSF20.TabIndex = 50;
            this.chkSF20.Text = "SF20";
            this.chkSF20.UseVisualStyleBackColor = false;
            this.chkSF20.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF21
            // 
            this.chkSF21.AutoSize = true;
            this.chkSF21.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF21.Location = new System.Drawing.Point(232, 76);
            this.chkSF21.Name = "chkSF21";
            this.chkSF21.Size = new System.Drawing.Size(54, 18);
            this.chkSF21.TabIndex = 51;
            this.chkSF21.Text = "SF21";
            this.chkSF21.UseVisualStyleBackColor = false;
            this.chkSF21.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF22
            // 
            this.chkSF22.AutoSize = true;
            this.chkSF22.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF22.Location = new System.Drawing.Point(288, 76);
            this.chkSF22.Name = "chkSF22";
            this.chkSF22.Size = new System.Drawing.Size(54, 18);
            this.chkSF22.TabIndex = 52;
            this.chkSF22.Text = "SF22";
            this.chkSF22.UseVisualStyleBackColor = false;
            this.chkSF22.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF23
            // 
            this.chkSF23.AutoSize = true;
            this.chkSF23.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF23.Location = new System.Drawing.Point(344, 76);
            this.chkSF23.Name = "chkSF23";
            this.chkSF23.Size = new System.Drawing.Size(54, 18);
            this.chkSF23.TabIndex = 53;
            this.chkSF23.Text = "SF23";
            this.chkSF23.UseVisualStyleBackColor = false;
            this.chkSF23.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF24
            // 
            this.chkSF24.AutoSize = true;
            this.chkSF24.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF24.Location = new System.Drawing.Point(400, 76);
            this.chkSF24.Name = "chkSF24";
            this.chkSF24.Size = new System.Drawing.Size(54, 18);
            this.chkSF24.TabIndex = 54;
            this.chkSF24.Text = "SF24";
            this.chkSF24.UseVisualStyleBackColor = false;
            this.chkSF24.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkSF25
            // 
            this.chkSF25.AutoSize = true;
            this.chkSF25.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.chkSF25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkSF25.Location = new System.Drawing.Point(458, 76);
            this.chkSF25.Name = "chkSF25";
            this.chkSF25.Size = new System.Drawing.Size(54, 18);
            this.chkSF25.TabIndex = 55;
            this.chkSF25.Text = "SF25";
            this.chkSF25.UseVisualStyleBackColor = false;
            this.chkSF25.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // btnSFAll
            // 
            this.btnSFAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnSFAll.FlatAppearance.BorderSize = 0;
            this.btnSFAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSFAll.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnSFAll.ForeColor = System.Drawing.Color.White;
            this.btnSFAll.Location = new System.Drawing.Point(458, 24);
            this.btnSFAll.Name = "btnSFAll";
            this.btnSFAll.Size = new System.Drawing.Size(36, 22);
            this.btnSFAll.TabIndex = 14;
            this.btnSFAll.Text = "ALL";
            this.btnSFAll.UseVisualStyleBackColor = false;
            this.btnSFAll.Click += new System.EventHandler(this.btnSFAll_Click);
            // 
            // btnSFNone
            // 
            this.btnSFNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSFNone.FlatAppearance.BorderSize = 0;
            this.btnSFNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSFNone.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnSFNone.ForeColor = System.Drawing.Color.White;
            this.btnSFNone.Location = new System.Drawing.Point(498, 24);
            this.btnSFNone.Name = "btnSFNone";
            this.btnSFNone.Size = new System.Drawing.Size(36, 22);
            this.btnSFNone.TabIndex = 15;
            this.btnSFNone.Text = "CLR";
            this.btnSFNone.UseVisualStyleBackColor = false;
            this.btnSFNone.Click += new System.EventHandler(this.btnSFNone_Click);
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.grpColor.Controls.Add(this.lblCX);
            this.grpColor.Controls.Add(this.nudColorX);
            this.grpColor.Controls.Add(this.lblCY);
            this.grpColor.Controls.Add(this.nudColorY);
            this.grpColor.Controls.Add(this.lblBr);
            this.grpColor.Controls.Add(this.nudBrightness);
            this.grpColor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.grpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpColor.Location = new System.Drawing.Point(658, 288);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(540, 47);
            this.grpColor.TabIndex = 14;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "[ DATA2/3/4  ColorX / ColorY / Brightness  (0x00~0xFA = 0~100%) ]";
            // 
            // lblCX
            // 
            this.lblCX.AutoSize = true;
            this.lblCX.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblCX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblCX.Location = new System.Drawing.Point(9, 18);
            this.lblCX.Name = "lblCX";
            this.lblCX.Size = new System.Drawing.Size(77, 14);
            this.lblCX.TabIndex = 0;
            this.lblCX.Text = "D2 ColorX:";
            // 
            // nudColorX
            // 
            this.nudColorX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.nudColorX.Font = new System.Drawing.Font("Consolas", 9F);
            this.nudColorX.ForeColor = System.Drawing.Color.White;
            this.nudColorX.Hexadecimal = true;
            this.nudColorX.Location = new System.Drawing.Point(89, 15);
            this.nudColorX.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudColorX.Name = "nudColorX";
            this.nudColorX.Size = new System.Drawing.Size(64, 22);
            this.nudColorX.TabIndex = 1;
            this.nudColorX.ValueChanged += new System.EventHandler(this.nudColorX_ValueChanged);
            // 
            // lblCY
            // 
            this.lblCY.AutoSize = true;
            this.lblCY.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblCY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblCY.Location = new System.Drawing.Point(163, 18);
            this.lblCY.Name = "lblCY";
            this.lblCY.Size = new System.Drawing.Size(77, 14);
            this.lblCY.TabIndex = 2;
            this.lblCY.Text = "D3 ColorY:";
            // 
            // nudColorY
            // 
            this.nudColorY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.nudColorY.Font = new System.Drawing.Font("Consolas", 9F);
            this.nudColorY.ForeColor = System.Drawing.Color.White;
            this.nudColorY.Hexadecimal = true;
            this.nudColorY.Location = new System.Drawing.Point(243, 15);
            this.nudColorY.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudColorY.Name = "nudColorY";
            this.nudColorY.Size = new System.Drawing.Size(64, 22);
            this.nudColorY.TabIndex = 3;
            this.nudColorY.ValueChanged += new System.EventHandler(this.nudColorY_ValueChanged);
            // 
            // lblBr
            // 
            this.lblBr.AutoSize = true;
            this.lblBr.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblBr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblBr.Location = new System.Drawing.Point(317, 18);
            this.lblBr.Name = "lblBr";
            this.lblBr.Size = new System.Drawing.Size(77, 14);
            this.lblBr.TabIndex = 4;
            this.lblBr.Text = "D4 Bright:";
            // 
            // nudBrightness
            // 
            this.nudBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.nudBrightness.Font = new System.Drawing.Font("Consolas", 9F);
            this.nudBrightness.ForeColor = System.Drawing.Color.White;
            this.nudBrightness.Hexadecimal = true;
            this.nudBrightness.Location = new System.Drawing.Point(395, 15);
            this.nudBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.Size = new System.Drawing.Size(64, 22);
            this.nudBrightness.TabIndex = 5;
            this.nudBrightness.ValueChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // grpFade
            // 
            this.grpFade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.grpFade.Controls.Add(this.lblFIN);
            this.grpFade.Controls.Add(this.nudFadeIn);
            this.grpFade.Controls.Add(this.lblFOUT);
            this.grpFade.Controls.Add(this.nudFadeOut);
            this.grpFade.Controls.Add(this.chkNoFade);
            this.grpFade.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.grpFade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpFade.Location = new System.Drawing.Point(658, 341);
            this.grpFade.Name = "grpFade";
            this.grpFade.Size = new System.Drawing.Size(540, 62);
            this.grpFade.TabIndex = 15;
            this.grpFade.TabStop = false;
            this.grpFade.Text = "[ DATA5/6/7  FadeInTime / FadeOutTime / NoFadeFlag (×10ms) ]";
            // 
            // lblFIN
            // 
            this.lblFIN.AutoSize = true;
            this.lblFIN.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblFIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblFIN.Location = new System.Drawing.Point(8, 28);
            this.lblFIN.Name = "lblFIN";
            this.lblFIN.Size = new System.Drawing.Size(77, 14);
            this.lblFIN.TabIndex = 0;
            this.lblFIN.Text = "D5 FadeIn:";
            // 
            // nudFadeIn
            // 
            this.nudFadeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.nudFadeIn.Font = new System.Drawing.Font("Consolas", 9F);
            this.nudFadeIn.ForeColor = System.Drawing.Color.White;
            this.nudFadeIn.Location = new System.Drawing.Point(88, 25);
            this.nudFadeIn.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudFadeIn.Name = "nudFadeIn";
            this.nudFadeIn.Size = new System.Drawing.Size(64, 22);
            this.nudFadeIn.TabIndex = 1;
            this.nudFadeIn.ValueChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // lblFOUT
            // 
            this.lblFOUT.AutoSize = true;
            this.lblFOUT.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblFOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblFOUT.Location = new System.Drawing.Point(162, 28);
            this.lblFOUT.Name = "lblFOUT";
            this.lblFOUT.Size = new System.Drawing.Size(84, 14);
            this.lblFOUT.TabIndex = 2;
            this.lblFOUT.Text = "D6 FadeOut:";
            // 
            // nudFadeOut
            // 
            this.nudFadeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.nudFadeOut.Font = new System.Drawing.Font("Consolas", 9F);
            this.nudFadeOut.ForeColor = System.Drawing.Color.White;
            this.nudFadeOut.Location = new System.Drawing.Point(248, 25);
            this.nudFadeOut.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudFadeOut.Name = "nudFadeOut";
            this.nudFadeOut.Size = new System.Drawing.Size(64, 22);
            this.nudFadeOut.TabIndex = 3;
            this.nudFadeOut.ValueChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkNoFade
            // 
            this.chkNoFade.AutoSize = true;
            this.chkNoFade.Font = new System.Drawing.Font("Consolas", 9F);
            this.chkNoFade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.chkNoFade.Location = new System.Drawing.Point(326, 28);
            this.chkNoFade.Name = "chkNoFade";
            this.chkNoFade.Size = new System.Drawing.Size(187, 18);
            this.chkNoFade.TabIndex = 4;
            this.chkNoFade.Text = "D7 bit7 NoFadeInOutFlag";
            this.chkNoFade.UseVisualStyleBackColor = false;
            this.chkNoFade.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // grpStatus
            // 
            this.grpStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.grpStatus.Controls.Add(this.chkSOH);
            this.grpStatus.Controls.Add(this.chkLINErr);
            this.grpStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.grpStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpStatus.Location = new System.Drawing.Point(658, 409);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(540, 50);
            this.grpStatus.TabIndex = 16;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "[ DATA8  LIN_MLMMnSOH / LIN_MLMMnLINError ]";
            // 
            // chkSOH
            // 
            this.chkSOH.AutoSize = true;
            this.chkSOH.Font = new System.Drawing.Font("Consolas", 9F);
            this.chkSOH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(240)))), ((int)(((byte)(140)))));
            this.chkSOH.Location = new System.Drawing.Point(8, 24);
            this.chkSOH.Name = "chkSOH";
            this.chkSOH.Size = new System.Drawing.Size(152, 18);
            this.chkSOH.TabIndex = 0;
            this.chkSOH.Text = "bit0 SOH=OK (0x01)";
            this.chkSOH.UseVisualStyleBackColor = false;
            this.chkSOH.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // chkLINErr
            // 
            this.chkLINErr.AutoSize = true;
            this.chkLINErr.Font = new System.Drawing.Font("Consolas", 9F);
            this.chkLINErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.chkLINErr.Location = new System.Drawing.Point(230, 24);
            this.chkLINErr.Name = "chkLINErr";
            this.chkLINErr.Size = new System.Drawing.Size(131, 18);
            this.chkLINErr.TabIndex = 1;
            this.chkLINErr.Text = "bit7 LINError=1";
            this.chkLINErr.UseVisualStyleBackColor = false;
            this.chkLINErr.CheckedChanged += new System.EventHandler(this.AnyField_Changed);
            // 
            // grpPreview
            // 
            this.grpPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.grpPreview.Controls.Add(this.txtPreview);
            this.grpPreview.Controls.Add(this.lblD1);
            this.grpPreview.Controls.Add(this.lblD2);
            this.grpPreview.Controls.Add(this.lblD3);
            this.grpPreview.Controls.Add(this.lblD4);
            this.grpPreview.Controls.Add(this.lblD5);
            this.grpPreview.Controls.Add(this.lblD6);
            this.grpPreview.Controls.Add(this.lblD7);
            this.grpPreview.Controls.Add(this.lblD8);
            this.grpPreview.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.grpPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpPreview.Location = new System.Drawing.Point(658, 465);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(540, 208);
            this.grpPreview.TabIndex = 17;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "[ 패킷 미리보기 (8 Bytes) ]";
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(240)))), ((int)(((byte)(130)))));
            this.txtPreview.Location = new System.Drawing.Point(8, 22);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(522, 16);
            this.txtPreview.TabIndex = 0;
            // 
            // lblD1
            // 
            this.lblD1.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD1.Location = new System.Drawing.Point(8, 46);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(522, 18);
            this.lblD1.TabIndex = 1;
            this.lblD1.Text = "D1=";
            // 
            // lblD2
            // 
            this.lblD2.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD2.Location = new System.Drawing.Point(8, 65);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(522, 18);
            this.lblD2.TabIndex = 2;
            this.lblD2.Text = "D2=";
            // 
            // lblD3
            // 
            this.lblD3.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD3.Location = new System.Drawing.Point(8, 84);
            this.lblD3.Name = "lblD3";
            this.lblD3.Size = new System.Drawing.Size(522, 18);
            this.lblD3.TabIndex = 3;
            this.lblD3.Text = "D3=";
            // 
            // lblD4
            // 
            this.lblD4.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD4.Location = new System.Drawing.Point(8, 103);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(522, 18);
            this.lblD4.TabIndex = 4;
            this.lblD4.Text = "D4=";
            // 
            // lblD5
            // 
            this.lblD5.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD5.Location = new System.Drawing.Point(8, 122);
            this.lblD5.Name = "lblD5";
            this.lblD5.Size = new System.Drawing.Size(522, 18);
            this.lblD5.TabIndex = 5;
            this.lblD5.Text = "D5=";
            // 
            // lblD6
            // 
            this.lblD6.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD6.Location = new System.Drawing.Point(8, 141);
            this.lblD6.Name = "lblD6";
            this.lblD6.Size = new System.Drawing.Size(522, 18);
            this.lblD6.TabIndex = 6;
            this.lblD6.Text = "D6=";
            // 
            // lblD7
            // 
            this.lblD7.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD7.Location = new System.Drawing.Point(8, 160);
            this.lblD7.Name = "lblD7";
            this.lblD7.Size = new System.Drawing.Size(522, 18);
            this.lblD7.TabIndex = 7;
            this.lblD7.Text = "D7=";
            // 
            // lblD8
            // 
            this.lblD8.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblD8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.lblD8.Location = new System.Drawing.Point(8, 179);
            this.lblD8.Name = "lblD8";
            this.lblD8.Size = new System.Drawing.Size(522, 18);
            this.lblD8.TabIndex = 8;
            this.lblD8.Text = "D8=";
            // 
            // grpTX
            // 
            this.grpTX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.grpTX.Controls.Add(this.lblIvL);
            this.grpTX.Controls.Add(this.nudInterval);
            this.grpTX.Controls.Add(this.lblMs);
            this.grpTX.Controls.Add(this.btnTxOnce);
            this.grpTX.Controls.Add(this.btnTxCycle);
            this.grpTX.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.grpTX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.grpTX.Location = new System.Drawing.Point(659, 679);
            this.grpTX.Name = "grpTX";
            this.grpTX.Size = new System.Drawing.Size(540, 64);
            this.grpTX.TabIndex = 18;
            this.grpTX.TabStop = false;
            this.grpTX.Text = "[ TX ]";
            // 
            // lblIvL
            // 
            this.lblIvL.AutoSize = true;
            this.lblIvL.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblIvL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblIvL.Location = new System.Drawing.Point(8, 21);
            this.lblIvL.Name = "lblIvL";
            this.lblIvL.Size = new System.Drawing.Size(60, 14);
            this.lblIvL.TabIndex = 0;
            this.lblIvL.Text = "주기(ms):";
            // 
            // nudInterval
            // 
            this.nudInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.nudInterval.Font = new System.Drawing.Font("Consolas", 9F);
            this.nudInterval.ForeColor = System.Drawing.Color.White;
            this.nudInterval.Location = new System.Drawing.Point(78, 18);
            this.nudInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(80, 22);
            this.nudInterval.TabIndex = 1;
            this.nudInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblMs
            // 
            this.lblMs.AutoSize = true;
            this.lblMs.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblMs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblMs.Location = new System.Drawing.Point(162, 21);
            this.lblMs.Name = "lblMs";
            this.lblMs.Size = new System.Drawing.Size(21, 14);
            this.lblMs.TabIndex = 2;
            this.lblMs.Text = "ms";
            // 
            // btnTxOnce
            // 
            this.btnTxOnce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnTxOnce.FlatAppearance.BorderSize = 0;
            this.btnTxOnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxOnce.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnTxOnce.ForeColor = System.Drawing.Color.White;
            this.btnTxOnce.Location = new System.Drawing.Point(194, 13);
            this.btnTxOnce.Name = "btnTxOnce";
            this.btnTxOnce.Size = new System.Drawing.Size(100, 36);
            this.btnTxOnce.TabIndex = 3;
            this.btnTxOnce.Text = "1회 TX";
            this.btnTxOnce.UseVisualStyleBackColor = false;
            this.btnTxOnce.Click += new System.EventHandler(this.btnTxOnce_Click);
            // 
            // btnTxCycle
            // 
            this.btnTxCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnTxCycle.FlatAppearance.BorderSize = 0;
            this.btnTxCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxCycle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnTxCycle.ForeColor = System.Drawing.Color.White;
            this.btnTxCycle.Location = new System.Drawing.Point(300, 13);
            this.btnTxCycle.Name = "btnTxCycle";
            this.btnTxCycle.Size = new System.Drawing.Size(234, 36);
            this.btnTxCycle.TabIndex = 4;
            this.btnTxCycle.Text = "▶ 주기 TX 시작";
            this.btnTxCycle.UseVisualStyleBackColor = false;
            this.btnTxCycle.Click += new System.EventHandler(this.btnTxCycle_Click);
            // 
            // FormCIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1220, 747);
            this.Controls.Add(this.tabColor);
            this.Controls.Add(this.pnlColorPatch);
            this.Controls.Add(this.lblPatchL);
            this.Controls.Add(this.grpFID);
            this.Controls.Add(this.grpSF);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpFade);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.grpTX);
            this.Controls.Add(this.lblFT4222Status);
            this.Font = new System.Drawing.Font("Consolas", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "FormCIE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mood Lamp LIN TX  (MLMMn_Comm1)  |  IndieMicro LIN Gateway V2.0";
            this.tabColor.ResumeLayout(false);
            this.tabCIE.ResumeLayout(false);
            this.pnlCIEBar.ResumeLayout(false);
            this.pnlCIEBar.PerformLayout();
            this.tabImg.ResumeLayout(false);
            this.pnlImgBar.ResumeLayout(false);
            this.grpFID.ResumeLayout(false);
            this.grpFID.PerformLayout();
            this.grpSF.ResumeLayout(false);
            this.grpSF.PerformLayout();
            this.grpShift.ResumeLayout(false);
            this.grpShift.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShiftWidth)).EndInit();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            this.grpFade.ResumeLayout(false);
            this.grpFade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeOut)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpPreview.ResumeLayout(false);
            this.grpPreview.PerformLayout();
            this.grpTX.ResumeLayout(false);
            this.grpTX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TabControl     tabColor;
        private System.Windows.Forms.TabPage        tabCIE;
        private System.Windows.Forms.TabPage        tabImg;
        private System.Windows.Forms.Panel          pnlCIE;
        private System.Windows.Forms.Panel          pnlCIEBar;
        private System.Windows.Forms.Label          lblModeL;
        private System.Windows.Forms.ComboBox       cmbMode;
        private System.Windows.Forms.Label          lblCIEMode;
        private System.Windows.Forms.Label          lblSelXY;
        private System.Windows.Forms.Label          lblCursor;
        private System.Windows.Forms.Panel          pnlImage;
        private System.Windows.Forms.Panel          pnlImgBar;
        private System.Windows.Forms.Button         btnLoadImg;
        private System.Windows.Forms.Label          lblImgInfo;
        private System.Windows.Forms.Label          lblImgColor;
        private System.Windows.Forms.Panel          pnlColorPatch;
        private System.Windows.Forms.Label          lblPatchL;
        private System.Windows.Forms.GroupBox       grpFID;
        private System.Windows.Forms.Label          lblFID;
        private System.Windows.Forms.ComboBox       cmbFID;
        private System.Windows.Forms.TextBox        txtManualFID;
        private System.Windows.Forms.Label          lblCS;
        private System.Windows.Forms.ComboBox       cmbCS;
        private System.Windows.Forms.GroupBox       grpSF;
        private System.Windows.Forms.CheckBox       chkSF1, chkSF2, chkSF3, chkSF4;
        private System.Windows.Forms.CheckBox       chkSF5, chkSF6, chkSF7, chkSF8;
        private System.Windows.Forms.CheckBox       chkSF9,  chkSF10, chkSF11, chkSF12;
        private System.Windows.Forms.CheckBox       chkSF13, chkSF14, chkSF15, chkSF16;
        private System.Windows.Forms.CheckBox       chkSF17, chkSF18, chkSF19, chkSF20;
        private System.Windows.Forms.CheckBox       chkSF21, chkSF22, chkSF23, chkSF24, chkSF25;
        private System.Windows.Forms.Button         btnSFAll;
        private System.Windows.Forms.Button         btnSFNone;
        private System.Windows.Forms.CheckBox       chkRGBWShift;
        private System.Windows.Forms.CheckBox       chkLedShift;
        private System.Windows.Forms.CheckBox       chkShiftStack;
        private System.Windows.Forms.CheckBox       chkLedShiftUp;
        private System.Windows.Forms.CheckBox       chkShiftStackUp;
        private System.Windows.Forms.CheckBox       chkMove;
        private System.Windows.Forms.CheckBox       chkEachControl;
        private System.Windows.Forms.GroupBox       grpShift;
        private System.Windows.Forms.NumericUpDown  nudShiftWidth;
        private System.Windows.Forms.Label          lblShiftWidth;
        private System.Windows.Forms.GroupBox       grpColor;
        private System.Windows.Forms.Label          lblCX;
        private System.Windows.Forms.NumericUpDown  nudColorX;
        private System.Windows.Forms.Label          lblCY;
        private System.Windows.Forms.NumericUpDown  nudColorY;
        private System.Windows.Forms.Label          lblBr;
        private System.Windows.Forms.NumericUpDown  nudBrightness;
        private System.Windows.Forms.GroupBox       grpFade;
        private System.Windows.Forms.Label          lblFIN;
        private System.Windows.Forms.NumericUpDown  nudFadeIn;
        private System.Windows.Forms.Label          lblFOUT;
        private System.Windows.Forms.NumericUpDown  nudFadeOut;
        private System.Windows.Forms.CheckBox       chkNoFade;
        private System.Windows.Forms.GroupBox       grpStatus;
        private System.Windows.Forms.CheckBox       chkSOH;
        private System.Windows.Forms.CheckBox       chkLINErr;
        private System.Windows.Forms.GroupBox       grpPreview;
        private System.Windows.Forms.TextBox        txtPreview;
        private System.Windows.Forms.Label          lblD1, lblD2, lblD3, lblD4;
        private System.Windows.Forms.Label          lblD5, lblD6, lblD7, lblD8;
        private System.Windows.Forms.GroupBox       grpTX;
        private System.Windows.Forms.Label          lblIvL;
        private System.Windows.Forms.NumericUpDown  nudInterval;
        private System.Windows.Forms.Label          lblMs;
        private System.Windows.Forms.Button         btnTxOnce;
        private System.Windows.Forms.Button         btnTxCycle;

        // ── Designer 구성 요소 트레이 (도구상자에서 드래그한 비-UI 컴포넌트) ──
        internal System.Windows.Forms.Timer         txTimer;   // 주기 TX 타이머
        internal System.Windows.Forms.Timer         fadeTimer; // Fade In/Out 타이머

        // ── FT4222 상태 레이블 ─────────────────────────────────────────
        internal System.Windows.Forms.Label         lblFT4222Status;
    }
}
