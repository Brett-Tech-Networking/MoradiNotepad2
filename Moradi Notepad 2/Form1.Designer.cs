namespace Moradi_Notepad_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.LineCount = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.website = new System.Windows.Forms.ToolStripMenuItem();
            this.welcome = new MetroFramework.Controls.MetroLabel();
            this.LineCounter = new MetroFramework.Controls.MetroLabel();
            this.LineCounterStatus = new System.Windows.Forms.Timer(this.components);
            this.spellchecker = new System.Windows.Forms.Timer(this.components);
            this.language = new System.Windows.Forms.ToolStripMenuItem();
            this.HTML = new System.Windows.Forms.ToolStripMenuItem();
            this.cSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.quicklauncher = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.newtextfilebutton = new System.Windows.Forms.ToolStripButton();
            this.SaveTextFile = new System.Windows.Forms.ToolStripButton();
            this.ActivateMic = new System.Windows.Forms.ToolStripButton();
            this.MuteMic = new System.Windows.Forms.ToolStripButton();
            this.LeftAlign = new System.Windows.Forms.ToolStripButton();
            this.CenterAlign = new System.Windows.Forms.ToolStripButton();
            this.RighAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.quicklauncher.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.Lime;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(23, 112);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ShowLineNumbers = false;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(1183, 561);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.TextAreaBorderColor = System.Drawing.Color.Transparent;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.view,
            this.Format,
            this.language,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.toolStripSeparator1,
            this.Save,
            this.SaveAs,
            this.toolStripSeparator2,
            this.Exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(123, 22);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(123, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(123, 22);
            this.SaveAs.Text = "Save As...";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Find,
            this.Replace,
            this.toolStripSeparator3,
            this.Cut,
            this.Copy,
            this.Paste,
            this.toolStripSeparator4,
            this.Undo,
            this.Redo});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(39, 20);
            this.edit.Text = "Edit";
            // 
            // Find
            // 
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(115, 22);
            this.Find.Text = "Find";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Replace
            // 
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(115, 22);
            this.Replace.Text = "Replace";
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(112, 6);
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(115, 22);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(115, 22);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(115, 22);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(112, 6);
            // 
            // Undo
            // 
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(115, 22);
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(115, 22);
            this.Redo.Text = "Redo";
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // view
            // 
            this.view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineCount,
            this.QuickLaunch});
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(44, 20);
            this.view.Text = "View";
            // 
            // LineCount
            // 
            this.LineCount.CheckOnClick = true;
            this.LineCount.Name = "LineCount";
            this.LineCount.Size = new System.Drawing.Size(157, 22);
            this.LineCount.Text = "Line Count";
            this.LineCount.Click += new System.EventHandler(this.LineCount_Click);
            // 
            // QuickLaunch
            // 
            this.QuickLaunch.Checked = true;
            this.QuickLaunch.CheckOnClick = true;
            this.QuickLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.QuickLaunch.Name = "QuickLaunch";
            this.QuickLaunch.Size = new System.Drawing.Size(157, 22);
            this.QuickLaunch.Text = "Quick Launcher";
            this.QuickLaunch.Click += new System.EventHandler(this.QuickLaunch_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Font});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(57, 20);
            this.Format.Text = "Format";
            // 
            // Font
            // 
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(98, 22);
            this.Font.Text = "Font";
            this.Font.Click += new System.EventHandler(this.Font_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.website});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(116, 22);
            this.About.Text = "About";
            // 
            // website
            // 
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(116, 22);
            this.website.Text = "Website";
            // 
            // welcome
            // 
            this.welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome.AutoSize = true;
            this.welcome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.welcome.Location = new System.Drawing.Point(1022, 676);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(71, 19);
            this.welcome.Style = MetroFramework.MetroColorStyle.Yellow;
            this.welcome.TabIndex = 3;
            this.welcome.Text = "Welcome, ";
            this.welcome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.welcome.UseStyleColors = true;
            // 
            // LineCounter
            // 
            this.LineCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LineCounter.AutoSize = true;
            this.LineCounter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LineCounter.Location = new System.Drawing.Point(23, 676);
            this.LineCounter.Name = "LineCounter";
            this.LineCounter.Size = new System.Drawing.Size(43, 19);
            this.LineCounter.Style = MetroFramework.MetroColorStyle.Yellow;
            this.LineCounter.TabIndex = 4;
            this.LineCounter.Text = "Lines:";
            this.LineCounter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LineCounter.UseStyleColors = true;
            // 
            // LineCounterStatus
            // 
            this.LineCounterStatus.Enabled = true;
            this.LineCounterStatus.Interval = 1;
            this.LineCounterStatus.Tick += new System.EventHandler(this.LineCounterStatus_Tick);
            // 
            // spellchecker
            // 
            this.spellchecker.Enabled = true;
            this.spellchecker.Interval = 1;
            this.spellchecker.Tick += new System.EventHandler(this.Spellchecker_Tick);
            // 
            // language
            // 
            this.language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HTML,
            this.cSharp});
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(71, 20);
            this.language.Text = "Language";
            // 
            // HTML
            // 
            this.HTML.CheckOnClick = true;
            this.HTML.Name = "HTML";
            this.HTML.Size = new System.Drawing.Size(110, 22);
            this.HTML.Text = "HTML";
            this.HTML.Click += new System.EventHandler(this.HTML_Click);
            // 
            // cSharp
            // 
            this.cSharp.CheckOnClick = true;
            this.cSharp.Name = "cSharp";
            this.cSharp.Size = new System.Drawing.Size(110, 22);
            this.cSharp.Text = "cSharp";
            this.cSharp.Click += new System.EventHandler(this.CSharp_Click);
            // 
            // quicklauncher
            // 
            this.quicklauncher.BackColor = System.Drawing.Color.White;
            this.quicklauncher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quicklauncher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtextfilebutton,
            this.SaveTextFile,
            this.ActivateMic,
            this.MuteMic,
            this.toolStripSeparator5,
            this.LeftAlign,
            this.CenterAlign,
            this.RighAlign,
            this.toolStripSeparator6});
            this.quicklauncher.Location = new System.Drawing.Point(20, 84);
            this.quicklauncher.Name = "quicklauncher";
            this.quicklauncher.Size = new System.Drawing.Size(1189, 25);
            this.quicklauncher.Stretch = true;
            this.quicklauncher.TabIndex = 1;
            this.quicklauncher.Text = "QuickLauncher";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // newtextfilebutton
            // 
            this.newtextfilebutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newtextfilebutton.Image = global::Moradi_Notepad_2.Properties.Resources._new;
            this.newtextfilebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newtextfilebutton.Name = "newtextfilebutton";
            this.newtextfilebutton.Size = new System.Drawing.Size(23, 22);
            this.newtextfilebutton.Text = "toolStripButton1";
            this.newtextfilebutton.ToolTipText = "New Text File";
            this.newtextfilebutton.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // SaveTextFile
            // 
            this.SaveTextFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveTextFile.Image = global::Moradi_Notepad_2.Properties.Resources.save;
            this.SaveTextFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTextFile.Name = "SaveTextFile";
            this.SaveTextFile.Size = new System.Drawing.Size(23, 22);
            this.SaveTextFile.ToolTipText = "Save Text File";
            this.SaveTextFile.Click += new System.EventHandler(this.SaveTextFile_Click);
            // 
            // ActivateMic
            // 
            this.ActivateMic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ActivateMic.Enabled = false;
            this.ActivateMic.Image = global::Moradi_Notepad_2.Properties.Resources.mic;
            this.ActivateMic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActivateMic.Name = "ActivateMic";
            this.ActivateMic.Size = new System.Drawing.Size(23, 22);
            this.ActivateMic.ToolTipText = "Activate Mic";
            // 
            // MuteMic
            // 
            this.MuteMic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MuteMic.Enabled = false;
            this.MuteMic.Image = global::Moradi_Notepad_2.Properties.Resources.mic_muted;
            this.MuteMic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MuteMic.Name = "MuteMic";
            this.MuteMic.Size = new System.Drawing.Size(23, 22);
            this.MuteMic.ToolTipText = "Mute Mic";
            // 
            // LeftAlign
            // 
            this.LeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeftAlign.Image = global::Moradi_Notepad_2.Properties.Resources.icon_left_text_theme_action_alignment_align;
            this.LeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftAlign.Name = "LeftAlign";
            this.LeftAlign.Size = new System.Drawing.Size(23, 22);
            this.LeftAlign.Text = "toolStripButton1";
            this.LeftAlign.ToolTipText = "Left Align";
            this.LeftAlign.Click += new System.EventHandler(this.LeftAlign_Click);
            // 
            // CenterAlign
            // 
            this.CenterAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterAlign.Image = global::Moradi_Notepad_2.Properties.Resources.center;
            this.CenterAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterAlign.Name = "CenterAlign";
            this.CenterAlign.Size = new System.Drawing.Size(23, 22);
            this.CenterAlign.Text = "toolStripButton2";
            this.CenterAlign.ToolTipText = "Center Align";
            // 
            // RighAlign
            // 
            this.RighAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RighAlign.Image = global::Moradi_Notepad_2.Properties.Resources.text_27924_960_720;
            this.RighAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RighAlign.Name = "RighAlign";
            this.RighAlign.Size = new System.Drawing.Size(23, 22);
            this.RighAlign.Text = "toolStripButton3";
            this.RighAlign.ToolTipText = "Right Align";
            this.RighAlign.Click += new System.EventHandler(this.RighAlign_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 711);
            this.Controls.Add(this.LineCounter);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.quicklauncher);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.fastColoredTextBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Moradi Notepad 2";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.quicklauncher.ResumeLayout(false);
            this.quicklauncher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem view;
        private System.Windows.Forms.ToolStripMenuItem LineCount;
        private System.Windows.Forms.ToolStripMenuItem Find;
        private System.Windows.Forms.ToolStripMenuItem Replace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Undo;
        private System.Windows.Forms.ToolStripMenuItem Redo;
        private System.Windows.Forms.ToolStripMenuItem help;
        private MetroFramework.Controls.MetroLabel welcome;
        private MetroFramework.Controls.MetroLabel LineCounter;
        private System.Windows.Forms.Timer LineCounterStatus;
        private System.Windows.Forms.ToolStripMenuItem QuickLaunch;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem website;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem Font;
        private System.Windows.Forms.Timer spellchecker;
        private System.Windows.Forms.ToolStripMenuItem language;
        private System.Windows.Forms.ToolStripMenuItem HTML;
        private System.Windows.Forms.ToolStripMenuItem cSharp;
        private System.Windows.Forms.ToolStripButton newtextfilebutton;
        private System.Windows.Forms.ToolStripButton SaveTextFile;
        private System.Windows.Forms.ToolStripButton ActivateMic;
        private System.Windows.Forms.ToolStrip quicklauncher;
        private System.Windows.Forms.ToolStripButton MuteMic;
        private System.Windows.Forms.ToolStripButton LeftAlign;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton CenterAlign;
        private System.Windows.Forms.ToolStripButton RighAlign;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

