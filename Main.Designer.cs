namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation1 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Killrobllox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKillRoblox = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnRunFile = new System.Windows.Forms.Button();
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.ScriptBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Killrobllox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(641, 6);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 38);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(590, 6);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 38);
            this.siticoneControlBox2.TabIndex = 2;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Killrobllox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.siticoneControlBox2);
            this.panel1.Controls.Add(this.siticoneControlBox1);
            this.siticoneTransition1.SetDecoration(this.panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 48);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowMove);
            // 
            // Killrobllox
            // 
            this.siticoneTransition1.SetDecoration(this.Killrobllox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Killrobllox.Image = global::Loader.Properties.Resources.kill;
            this.Killrobllox.Location = new System.Drawing.Point(488, 6);
            this.Killrobllox.Name = "Killrobllox";
            this.Killrobllox.Size = new System.Drawing.Size(45, 38);
            this.Killrobllox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Killrobllox.TabIndex = 45;
            this.Killrobllox.TabStop = false;
            this.Killrobllox.Click += new System.EventHandler(this.Killrobllox_Click);
            // 
            // pictureBox1
            // 
            this.siticoneTransition1.SetDecoration(this.pictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Loader.Properties.Resources.Settings;
            this.pictureBox1.Location = new System.Drawing.Point(539, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Overtime Execute";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowMove);
            // 
            // btnKillRoblox
            // 
            this.btnKillRoblox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnKillRoblox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.btnKillRoblox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.btnKillRoblox.FlatAppearance.BorderSize = 0;
            this.btnKillRoblox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillRoblox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKillRoblox.ForeColor = System.Drawing.Color.White;
            this.btnKillRoblox.Location = new System.Drawing.Point(492, 330);
            this.btnKillRoblox.Name = "btnKillRoblox";
            this.btnKillRoblox.Size = new System.Drawing.Size(92, 41);
            this.btnKillRoblox.TabIndex = 44;
            this.btnKillRoblox.Text = "Script Hub";
            this.btnKillRoblox.UseVisualStyleBackColor = false;
            this.btnKillRoblox.Click += new System.EventHandler(this.btnKillRoblox_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRefreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.btnRefreshList, Siticone.UI.AnimatorNS.DecorationType.None);
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.ForeColor = System.Drawing.Color.White;
            this.btnRefreshList.Location = new System.Drawing.Point(590, 330);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(90, 41);
            this.btnRefreshList.TabIndex = 43;
            this.btnRefreshList.Text = "Refresh";
            this.btnRefreshList.UseVisualStyleBackColor = false;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.btnClear, Siticone.UI.AnimatorNS.DecorationType.None);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(396, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 41);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.btnSaveFile, Siticone.UI.AnimatorNS.DecorationType.None);
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Location = new System.Drawing.Point(300, 331);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(90, 41);
            this.btnSaveFile.TabIndex = 41;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.btnOpenFile, Siticone.UI.AnimatorNS.DecorationType.None);
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(204, 330);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(90, 41);
            this.btnOpenFile.TabIndex = 40;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnRunFile
            // 
            this.btnRunFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRunFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.btnRunFile, Siticone.UI.AnimatorNS.DecorationType.None);
            this.btnRunFile.FlatAppearance.BorderSize = 0;
            this.btnRunFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunFile.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunFile.ForeColor = System.Drawing.Color.White;
            this.btnRunFile.Location = new System.Drawing.Point(108, 330);
            this.btnRunFile.Name = "btnRunFile";
            this.btnRunFile.Size = new System.Drawing.Size(90, 41);
            this.btnRunFile.TabIndex = 39;
            this.btnRunFile.Text = "Attack";
            this.btnRunFile.UseVisualStyleBackColor = false;
            this.btnRunFile.Click += new System.EventHandler(this.btnRunFile_Click);
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.ScriptList, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ScriptList.ForeColor = System.Drawing.Color.White;
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.HorizontalScrollbar = true;
            this.ScriptList.Location = new System.Drawing.Point(549, 64);
            this.ScriptList.Margin = new System.Windows.Forms.Padding(2);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(131, 260);
            this.ScriptList.TabIndex = 37;
            this.ScriptList.SelectedIndexChanged += new System.EventHandler(this.exploitListScriptBox_SelectedIndexChanged);
            // 
            // ScriptBox
            // 
            this.ScriptBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.ScriptBox.AutoScrollMinSize = new System.Drawing.Size(0, 120);
            this.ScriptBox.BackBrush = null;
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ScriptBox.BookmarkColor = System.Drawing.Color.White;
            this.ScriptBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptBox.ChangedLineColor = System.Drawing.Color.White;
            this.ScriptBox.CharHeight = 15;
            this.ScriptBox.CharWidth = 7;
            this.ScriptBox.CommentPrefix = "--";
            this.ScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.ScriptBox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.ScriptBox.ForeColor = System.Drawing.Color.White;
            this.ScriptBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ScriptBox.IsReplaceMode = false;
            this.ScriptBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.ScriptBox.LeftBracket = '(';
            this.ScriptBox.LeftBracket2 = '{';
            this.ScriptBox.Location = new System.Drawing.Point(12, 63);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptBox.RightBracket = ')';
            this.ScriptBox.RightBracket2 = '}';
            this.ScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ScriptBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptBox.ServiceColors")));
            this.ScriptBox.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.ScriptBox.Size = new System.Drawing.Size(531, 261);
            this.ScriptBox.TabIndex = 36;
            this.ScriptBox.Text = "--[[\r\n\r\nMade by Overtime Gang\r\nDiscord : https://discord.gg/Ac3BDUDFCV\r\nYoutube :" +
    " https://www.youtube.com/@overtime8554/videos\r\n\r\nHAVE FUN :)\r\n]]--";
            this.ScriptBox.WordWrap = true;
            this.ScriptBox.Zoom = 100;
            this.ScriptBox.Load += new System.EventHandler(this.exploitScriptBox_Load);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.btnExecute, Siticone.UI.AnimatorNS.DecorationType.None);
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(12, 330);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(90, 41);
            this.btnExecute.TabIndex = 38;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // pictureBox2
            // 
            this.siticoneTransition1.SetDecoration(this.pictureBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Loader.Properties.Resources.rainbow_bar1;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 381);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(697, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 384);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnKillRoblox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnRunFile);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.panel1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Killrobllox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKillRoblox;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnRunFile;
        private System.Windows.Forms.ListBox ScriptList;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptBox;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Killrobllox;
    }
}
