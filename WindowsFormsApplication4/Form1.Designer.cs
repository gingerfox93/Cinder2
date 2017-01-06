namespace Cinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMain = new ScintillaNET.Scintilla();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open_file = new System.Windows.Forms.ToolStripMenuItem();
            this.accurevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.bookmarksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.previousBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_BookmarkCount = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutCinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_ParseSQL = new System.Windows.Forms.Button();
            this.TextBox_ApplicationLog = new System.Windows.Forms.RichTextBox();
            this.buttonViewTableInformation = new System.Windows.Forms.Button();
            this.checkboxList_StatementsToParse = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_selectedDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_selectedServer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonViewProcInformation = new System.Windows.Forms.Button();
            this.buttonViewComposition = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain.AutoCIgnoreCase = true;
            this.txtMain.AutoCOrder = ScintillaNET.Order.PerformSort;
            this.txtMain.AutoCTypeSeparator = ' ';
            this.txtMain.Lexer = ScintillaNET.Lexer.Sql;
            this.txtMain.Location = new System.Drawing.Point(12, 27);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(1360, 600);
            this.txtMain.TabIndex = 0;
            this.txtMain.Text = resources.GetString("txtMain.Text");
            this.txtMain.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.txtMain_CharAdded);
            this.txtMain.MarginClick += new System.EventHandler<ScintillaNET.MarginClickEventArgs>(this.txtMain_MarginClick);
            this.txtMain.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintilla_UpdateUI);
            this.txtMain.TextChanged += new System.EventHandler(this.txtMain_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new,
            this.menu_open,
            this.toolStripMenuItem5,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.menu_quit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_new
            // 
            this.menu_new.Name = "menu_new";
            this.menu_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_new.Size = new System.Drawing.Size(141, 22);
            this.menu_new.Text = "&New";
            this.menu_new.Click += new System.EventHandler(this.menu_new_Click);
            // 
            // menu_open
            // 
            this.menu_open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_open_file,
            this.accurevToolStripMenuItem,
            this.releasePackageToolStripMenuItem});
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(141, 22);
            this.menu_open.Text = "&Open ";
            // 
            // menu_open_file
            // 
            this.menu_open_file.Name = "menu_open_file";
            this.menu_open_file.Size = new System.Drawing.Size(169, 22);
            this.menu_open_file.Text = "File...";
            this.menu_open_file.Click += new System.EventHandler(this.menu_open_file_Click);
            // 
            // accurevToolStripMenuItem
            // 
            this.accurevToolStripMenuItem.Enabled = false;
            this.accurevToolStripMenuItem.Name = "accurevToolStripMenuItem";
            this.accurevToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.accurevToolStripMenuItem.Text = "Accurev...";
            // 
            // releasePackageToolStripMenuItem
            // 
            this.releasePackageToolStripMenuItem.Enabled = false;
            this.releasePackageToolStripMenuItem.Name = "releasePackageToolStripMenuItem";
            this.releasePackageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.releasePackageToolStripMenuItem.Text = "Release Package...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(138, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // menu_quit
            // 
            this.menu_quit.Name = "menu_quit";
            this.menu_quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menu_quit.Size = new System.Drawing.Size(141, 22);
            this.menu_quit.Text = "&Exit";
            this.menu_quit.Click += new System.EventHandler(this.menu_quit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem8,
            this.selectAllToolStripMenuItem,
            this.toolStripMenuItem9,
            this.goToToolStripMenuItem,
            this.toolStripMenuItem7,
            this.bookmarksToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(161, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(161, 6);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.goToToolStripMenuItem.Text = "Go To...";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.menu_search_go_to_line_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(161, 6);
            // 
            // bookmarksToolStripMenuItem1
            // 
            this.bookmarksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousBookmarkToolStripMenuItem,
            this.nextBookmarkToolStripMenuItem,
            this.toolStripMenuItem10,
            this.menu_BookmarkCount});
            this.bookmarksToolStripMenuItem1.Name = "bookmarksToolStripMenuItem1";
            this.bookmarksToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.bookmarksToolStripMenuItem1.Text = "Bookmarks";
            // 
            // previousBookmarkToolStripMenuItem
            // 
            this.previousBookmarkToolStripMenuItem.Name = "previousBookmarkToolStripMenuItem";
            this.previousBookmarkToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.previousBookmarkToolStripMenuItem.Text = "Previous Bookmark";
            this.previousBookmarkToolStripMenuItem.Click += new System.EventHandler(this.buttonBookmarkPrevious_Click);
            // 
            // nextBookmarkToolStripMenuItem
            // 
            this.nextBookmarkToolStripMenuItem.Name = "nextBookmarkToolStripMenuItem";
            this.nextBookmarkToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nextBookmarkToolStripMenuItem.Text = "Next Bookmark";
            this.nextBookmarkToolStripMenuItem.Click += new System.EventHandler(this.buttonBookmarkNext_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(173, 6);
            // 
            // menu_BookmarkCount
            // 
            this.menu_BookmarkCount.Enabled = false;
            this.menu_BookmarkCount.Name = "menu_BookmarkCount";
            this.menu_BookmarkCount.Size = new System.Drawing.Size(176, 22);
            this.menu_BookmarkCount.Text = "0 Bookmarks";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentaionToolStripMenuItem,
            this.toolStripMenuItem3,
            this.examplesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutCinderToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentaionToolStripMenuItem
            // 
            this.documentaionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comingSoonToolStripMenuItem});
            this.documentaionToolStripMenuItem.Name = "documentaionToolStripMenuItem";
            this.documentaionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentaionToolStripMenuItem.Text = "Documentation";
            this.documentaionToolStripMenuItem.Click += new System.EventHandler(this.documentaionToolStripMenuItem_Click);
            // 
            // comingSoonToolStripMenuItem
            // 
            this.comingSoonToolStripMenuItem.Enabled = false;
            this.comingSoonToolStripMenuItem.Name = "comingSoonToolStripMenuItem";
            this.comingSoonToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.comingSoonToolStripMenuItem.Text = "Coming Soon";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 6);
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.example1ToolStripMenuItem,
            this.example2ToolStripMenuItem,
            this.example3ToolStripMenuItem});
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.examplesToolStripMenuItem.Text = "SQL Examples";
            // 
            // example1ToolStripMenuItem
            // 
            this.example1ToolStripMenuItem.Name = "example1ToolStripMenuItem";
            this.example1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.example1ToolStripMenuItem.Text = "Example 1";
            this.example1ToolStripMenuItem.Click += new System.EventHandler(this.example1ToolStripMenuItem_Click);
            // 
            // example2ToolStripMenuItem
            // 
            this.example2ToolStripMenuItem.Name = "example2ToolStripMenuItem";
            this.example2ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.example2ToolStripMenuItem.Text = "Example 2";
            this.example2ToolStripMenuItem.Click += new System.EventHandler(this.example2ToolStripMenuItem_Click);
            // 
            // example3ToolStripMenuItem
            // 
            this.example3ToolStripMenuItem.Name = "example3ToolStripMenuItem";
            this.example3ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.example3ToolStripMenuItem.Text = "Example 3";
            this.example3ToolStripMenuItem.Click += new System.EventHandler(this.example3ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(154, 6);
            // 
            // aboutCinderToolStripMenuItem
            // 
            this.aboutCinderToolStripMenuItem.Name = "aboutCinderToolStripMenuItem";
            this.aboutCinderToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutCinderToolStripMenuItem.Text = "About Cinder";
            this.aboutCinderToolStripMenuItem.Click += new System.EventHandler(this.aboutCinderToolStripMenuItem_Click);
            // 
            // button_ParseSQL
            // 
            this.button_ParseSQL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ParseSQL.Location = new System.Drawing.Point(12, 634);
            this.button_ParseSQL.Name = "button_ParseSQL";
            this.button_ParseSQL.Size = new System.Drawing.Size(135, 48);
            this.button_ParseSQL.TabIndex = 5;
            this.button_ParseSQL.Text = "Parse SQL";
            this.button_ParseSQL.UseVisualStyleBackColor = true;
            this.button_ParseSQL.Click += new System.EventHandler(this.button_ParseSQL_Click);
            // 
            // TextBox_ApplicationLog
            // 
            this.TextBox_ApplicationLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox_ApplicationLog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ApplicationLog.Location = new System.Drawing.Point(6, 19);
            this.TextBox_ApplicationLog.Name = "TextBox_ApplicationLog";
            this.TextBox_ApplicationLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextBox_ApplicationLog.Size = new System.Drawing.Size(788, 136);
            this.TextBox_ApplicationLog.TabIndex = 9;
            this.TextBox_ApplicationLog.Text = "";
            this.TextBox_ApplicationLog.WordWrap = false;
            // 
            // buttonViewTableInformation
            // 
            this.buttonViewTableInformation.Enabled = false;
            this.buttonViewTableInformation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTableInformation.Location = new System.Drawing.Point(294, 633);
            this.buttonViewTableInformation.Name = "buttonViewTableInformation";
            this.buttonViewTableInformation.Size = new System.Drawing.Size(135, 48);
            this.buttonViewTableInformation.TabIndex = 10;
            this.buttonViewTableInformation.Text = "View Table Information";
            this.buttonViewTableInformation.UseVisualStyleBackColor = true;
            this.buttonViewTableInformation.Click += new System.EventHandler(this.buttonViewTableInformation_Click);
            // 
            // checkboxList_StatementsToParse
            // 
            this.checkboxList_StatementsToParse.BackColor = System.Drawing.SystemColors.Control;
            this.checkboxList_StatementsToParse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkboxList_StatementsToParse.CheckOnClick = true;
            this.checkboxList_StatementsToParse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxList_StatementsToParse.FormattingEnabled = true;
            this.checkboxList_StatementsToParse.Location = new System.Drawing.Point(6, 19);
            this.checkboxList_StatementsToParse.Name = "checkboxList_StatementsToParse";
            this.checkboxList_StatementsToParse.Size = new System.Drawing.Size(131, 108);
            this.checkboxList_StatementsToParse.TabIndex = 12;
            this.checkboxList_StatementsToParse.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkboxList_StatementsToParse);
            this.groupBox1.Location = new System.Drawing.Point(1083, 703);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 148);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statements To Parse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_selectedDatabase);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_selectedServer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(818, 703);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 148);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intended Target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Please note this does not connect";
            // 
            // comboBox_selectedDatabase
            // 
            this.comboBox_selectedDatabase.FormattingEnabled = true;
            this.comboBox_selectedDatabase.Items.AddRange(new object[] {
            "Backhouse",
            "Webdb_V4",
            "TraderInput",
            "TraderInput_Logical"});
            this.comboBox_selectedDatabase.Location = new System.Drawing.Point(73, 46);
            this.comboBox_selectedDatabase.Name = "comboBox_selectedDatabase";
            this.comboBox_selectedDatabase.Size = new System.Drawing.Size(175, 21);
            this.comboBox_selectedDatabase.TabIndex = 17;
            this.comboBox_selectedDatabase.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectedDatabase_SelectedIndexChanged);
            this.comboBox_selectedDatabase.TextChanged += new System.EventHandler(this.comboBox_selectedDatabase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Database";
            // 
            // comboBox_selectedServer
            // 
            this.comboBox_selectedServer.FormattingEnabled = true;
            this.comboBox_selectedServer.Items.AddRange(new object[] {
            "BILBO",
            "BOROMIR",
            "GANDALF",
            "THRAIN"});
            this.comboBox_selectedServer.Location = new System.Drawing.Point(73, 19);
            this.comboBox_selectedServer.Name = "comboBox_selectedServer";
            this.comboBox_selectedServer.Size = new System.Drawing.Size(175, 21);
            this.comboBox_selectedServer.TabIndex = 16;
            this.comboBox_selectedServer.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectedServer_SelectedIndexChanged);
            this.comboBox_selectedServer.TextChanged += new System.EventHandler(this.comboBox_selectedServer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Server";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBox_ApplicationLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 688);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 161);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Log";
            // 
            // buttonViewProcInformation
            // 
            this.buttonViewProcInformation.Enabled = false;
            this.buttonViewProcInformation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProcInformation.Location = new System.Drawing.Point(435, 633);
            this.buttonViewProcInformation.Name = "buttonViewProcInformation";
            this.buttonViewProcInformation.Size = new System.Drawing.Size(135, 48);
            this.buttonViewProcInformation.TabIndex = 17;
            this.buttonViewProcInformation.Text = "View Proc Information";
            this.buttonViewProcInformation.UseVisualStyleBackColor = true;
            this.buttonViewProcInformation.Click += new System.EventHandler(this.buttonViewProcInformation_Click);
            // 
            // buttonViewComposition
            // 
            this.buttonViewComposition.Enabled = false;
            this.buttonViewComposition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewComposition.Location = new System.Drawing.Point(153, 633);
            this.buttonViewComposition.Name = "buttonViewComposition";
            this.buttonViewComposition.Size = new System.Drawing.Size(135, 48);
            this.buttonViewComposition.TabIndex = 18;
            this.buttonViewComposition.Text = "View Composition";
            this.buttonViewComposition.UseVisualStyleBackColor = true;
            this.buttonViewComposition.Click += new System.EventHandler(this.buttonViewComposition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.buttonViewComposition);
            this.Controls.Add(this.buttonViewProcInformation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonViewTableInformation);
            this.Controls.Add(this.button_ParseSQL);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_quit;
        private System.Windows.Forms.ToolStripMenuItem menu_open_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public ScintillaNET.Scintilla txtMain;
        private System.Windows.Forms.Button button_ParseSQL;
        private System.Windows.Forms.RichTextBox TextBox_ApplicationLog;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button buttonViewTableInformation;
        private System.Windows.Forms.CheckedListBox checkboxList_StatementsToParse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_selectedDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_selectedServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonViewProcInformation;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comingSoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aboutCinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accurevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasePackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem previousBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem menu_BookmarkCount;
        private System.Windows.Forms.Button buttonViewComposition;
    }
}

