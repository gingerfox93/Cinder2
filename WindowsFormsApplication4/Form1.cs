using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ScintillaNET;
using static Cinder.SQLParser;

namespace Cinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Line Numbers
            txtMain.Margins[0].Width = 16;

            //Styling
            txtMain.CaretForeColor = Color.White;
            txtMain.StyleResetDefault();
            txtMain.Styles[Style.Default].Font = "Tahoma";
            txtMain.Styles[Style.Default].Size = 10;
            txtMain.Styles[Style.Default].BackColor = Color.FromArgb(41, 49, 52);
            txtMain.IndentationGuides = IndentView.LookBoth;
            txtMain.Styles[Style.BraceLight].BackColor = Color.LightGray;
            txtMain.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            txtMain.Styles[Style.BraceBad].ForeColor = Color.Red;
            txtMain.StyleClearAll();

            
            //Syntax Highlighting
            txtMain.Lexer = Lexer.Sql;

            txtMain.Styles[Style.Sql.Word].ForeColor = Color.FromArgb(147, 199, 99);
            txtMain.Styles[Style.Sql.Word].Bold = true;
            txtMain.Styles[Style.Sql.Identifier].ForeColor = Color.FromArgb(255, 255, 255);
            txtMain.Styles[Style.Sql.Character].ForeColor = Color.FromArgb(236, 118, 0);
            txtMain.Styles[Style.Sql.Number].ForeColor = Color.FromArgb(255, 205, 34);
            txtMain.Styles[Style.Sql.Operator].ForeColor = Color.FromArgb(232, 226, 183);
            txtMain.Styles[Style.Sql.Comment].ForeColor = Color.FromArgb(102, 116, 123);
            txtMain.Styles[Style.Sql.CommentLine].ForeColor = Color.FromArgb(102, 116, 123);
            txtMain.Styles[Style.Sql.String].ForeColor = Color.FromArgb(255, 204, 204);

            txtMain.SetKeywords(0, "add external procedure all fetch public alter file raiserror and fillfactor read any for readtext as foreign reconfigure asc freetext references authorization freetexttable replication backup from restore begin full restrict between function return break goto revert browse grant revoke bulk group right by having rollback cascade holdlock rowcount case identity rowguidcol check identity_insert rule checkpoint identitycol save close if schema clustered in securityaudit coalesce index select collate inner semantickeyphrasetable column insert semanticsimilaritydetailstable commit intersect semanticsimilaritytable compute into session_user constraint is set contains join setuser containstable key shutdown continue kill some convert left statistics create like system_user cross lineno table current load tablesample current_date merge textsize current_time national then current_timestamp nocheck to current_user nonclustered top cursor not tran database null transaction dbcc nullif trigger deallocate of truncate declare off try_convert default offsets tsequal delete on union deny open unique desc opendatasource unpivot disk openquery update distinct openrowset updatetext distributed openxml use double option user drop or values dump order varying else outer view end over waitfor errlvl percent when escape pivot where except plan while exec precision with execute primary within group exists print writetext exit proc");

            //Code folding
            //txtMain.SetProperty("fold", "1");
            //txtMain.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            //txtMain.Margins[2].Type = MarginType.Symbol;
            //txtMain.Margins[2].Mask = Marker.MaskFolders;
            //txtMain.Margins[2].Sensitive = true;
            //txtMain.Margins[2].Width = 20;

            //for (int i = 25; i <= 31; i++)
            //{
                //txtMain.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                //txtMain.Markers[i].SetBackColor(SystemColors.ControlDark);
            //}

            //txtMain.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            //txtMain.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            //txtMain.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            //txtMain.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            //txtMain.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            //txtMain.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            //txtMain.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            //txtMain.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);


            // Configure a margin to display folding symbols
            txtMain.Margins[BOOKMARK_MARGIN].Type = MarginType.Symbol;
            txtMain.Margins[BOOKMARK_MARGIN].Mask = Marker.MaskAll;
            txtMain.Margins[BOOKMARK_MARGIN].Sensitive = true;
            txtMain.Margins[BOOKMARK_MARGIN].Width = 15;
            txtMain.Margins[BOOKMARK_MARGIN].Cursor = MarginCursor.Arrow;


            var marker = txtMain.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Bookmark;
            marker.SetBackColor(Color.DeepSkyBlue);
            marker.SetForeColor(Color.Black);

            //Set up statementstoparse checkbox
            checkboxList_StatementsToParse.Items.Add("SELECT");
            checkboxList_StatementsToParse.Items.Add("INSERT");
            checkboxList_StatementsToParse.Items.Add("UPDATE");
            checkboxList_StatementsToParse.Items.Add("DELETE");
            checkboxList_StatementsToParse.Items.Add("MERGE");
            checkboxList_StatementsToParse.Items.Add("EXECPROC");

            for (int i = 0; i < checkboxList_StatementsToParse.Items.Count; i++)
            {
                checkboxList_StatementsToParse.SetItemChecked(i, true);
            }

            //Form Loaded
            appendToApplicationLog("Application loaded");

        }


        private const int BOOKMARK_MARGIN = 1; // Conventionally the symbol margin
        private const int BOOKMARK_MARKER = 4; // Arbitrary. Any valid index would work.
        private int BOOKMARK_COUNTER = 0;

        private void txtMain_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (e.Margin == BOOKMARK_MARGIN)
            {
                // Do we have a marker for this line?
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = txtMain.Lines[txtMain.LineFromPosition(e.Position)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    // Remove existing bookmark
                    line.MarkerDelete(BOOKMARK_MARKER);
                    --BOOKMARK_COUNTER;
                }
                else
                {
                    // Add bookmark
                    line.MarkerAdd(BOOKMARK_MARKER);
                    ++BOOKMARK_COUNTER;
                }

                menu_BookmarkCount.Text = BOOKMARK_COUNTER.ToString() + " Bookmarks";

            }
        }

        private int maxLineNumberCharLength;

        private void txtMain_TextChanged(object sender, EventArgs e)
        {
            reset_gui("Partial");
            //appendToApplicationLog("GUI Reset - Text changed");
            var maxLineNumberCharLength = txtMain.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            txtMain.Margins[0].Width = txtMain.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        int lastCaretPos = 0;

        private static bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '<':
                case '>':
                    return true;
            }

            return false;
        }

        private void scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            // Has the caret changed position?
            var caretPos = txtMain.CurrentPosition;
            if (lastCaretPos != caretPos)
            {
                lastCaretPos = caretPos;
                var bracePos1 = -1;
                var bracePos2 = -1;

                // Is there a brace to the left or right?
                if (caretPos > 0 && IsBrace(txtMain.GetCharAt(caretPos - 1)))
                    bracePos1 = (caretPos - 1);
                else if (IsBrace(txtMain.GetCharAt(caretPos)))
                    bracePos1 = caretPos;

                if (bracePos1 >= 0)
                {
                    // Find the matching brace
                    bracePos2 = txtMain.BraceMatch(bracePos1);
                    if (bracePos2 == Scintilla.InvalidPosition)
                    {
                        txtMain.BraceBadLight(bracePos1);
                        txtMain.HighlightGuide = 0;
                    }
                    else
                    {
                        txtMain.BraceHighlight(bracePos1, bracePos2);
                        txtMain.HighlightGuide = txtMain.GetColumn(bracePos1);
                    }
                }
                else
                {
                    // Turn off brace matching
                    txtMain.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition);
                    txtMain.HighlightGuide = 0;
                }
            }
        }

        private void txtMain_CharAdded(object sender, CharAddedEventArgs e)
        {
            // Find the word start
            var currentPos = txtMain.CurrentPosition;
            var wordStartPos = txtMain.WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
            {
                txtMain.AutoCShow(lenEntered, "ADD EXTERNAL PROCEDURE ALL FETCH PUBLIC ALTER FILE RAISERROR AND FILLFACTOR READ ANY FOR READTEXT AS FOREIGN RECONFIGURE ASC FREETEXT REFERENCES AUTHORIZATION FREETEXTTABLE REPLICATION BACKUP FROM RESTORE BEGIN FULL RESTRICT BETWEEN FUNCTION RETURN BREAK GOTO REVERT BROWSE GRANT REVOKE BULK GROUP RIGHT BY HAVING ROLLBACK CASCADE HOLDLOCK ROWCOUNT CASE IDENTITY ROWGUIDCOL CHECK IDENTITY_INSERT RULE CHECKPOINT IDENTITYCOL SAVE CLOSE IF SCHEMA CLUSTERED IN SECURITYAUDIT COALESCE INDEX SELECT COLLATE INNER SEMANTICKEYPHRASETABLE COLUMN INSERT SEMANTICSIMILARITYDETAILSTABLE COMMIT INTERSECT SEMANTICSIMILARITYTABLE COMPUTE INTO SESSION_USER CONSTRAINT IS SET CONTAINS JOIN SETUSER CONTAINSTABLE KEY SHUTDOWN CONTINUE KILL SOME CONVERT LEFT STATISTICS CREATE LIKE SYSTEM_USER CROSS LINENO TABLE CURRENT LOAD TABLESAMPLE CURRENT_DATE MERGE TEXTSIZE CURRENT_TIME NATIONAL THEN CURRENT_TIMESTAMP NOCHECK TO CURRENT_USER NONCLUSTERED TOP CURSOR NOT TRAN DATABASE NULL TRANSACTION DBCC NULLIF TRIGGER DEALLOCATE OF TRUNCATE DECLARE OFF TRY_CONVERT DEFAULT OFFSETS TSEQUAL DELETE ON UNION DENY OPEN UNIQUE DESC OPENDATASOURCE UNPIVOT DISK OPENQUERY UPDATE DISTINCT OPENROWSET UPDATETEXT DISTRIBUTED OPENXML USE DOUBLE OPTION USER DROP OR VALUES DUMP ORDER VARYING ELSE OUTER VIEW END OVER WAITFOR ERRLVL PERCENT WHEN ESCAPE PIVOT WHERE EXCEPT PLAN WHILE EXEC PRECISION WITH EXECUTE PRIMARY WITHIN GROUP EXISTS PRINT WRITETEXT EXIT PROC add external procedure all fetch public alter file raiserror and fillfactor read any for readtext as foreign reconfigure asc freetext references authorization freetexttable replication backup from restore begin full restrict between function return break goto revert browse grant revoke bulk group right by having rollback cascade holdlock rowcount case identity rowguidcol check identity_insert rule checkpoint identitycol save close if schema clustered in securityaudit coalesce index select collate inner semantickeyphrasetable column insert semanticsimilaritydetailstable commit intersect semanticsimilaritytable compute into session_user constraint is set contains join setuser containstable key shutdown continue kill some convert left statistics create like system_user cross lineno table current load tablesample current_date merge textsize current_time national then current_timestamp nocheck to current_user nonclustered top cursor not tran database null transaction dbcc nullif trigger deallocate of truncate declare off try_convert default offsets tsequal delete on union deny open unique desc opendatasource unpivot disk openquery update distinct openrowset updatetext distributed openxml use double option user drop or values dump order varying else outer view end over waitfor errlvl percent when escape pivot where except plan while exec precision with execute primary within group exists print writetext exit proc");
            }
        }

        private void buttonBookmarkPrevious_Click(object sender, EventArgs e)
        {
            var line = txtMain.LineFromPosition(txtMain.CurrentPosition);
            var prevLine = txtMain.Lines[--line].MarkerPrevious(1 << BOOKMARK_MARKER);
            if (prevLine != -1)
            {
                txtMain.Lines[prevLine].Goto();
            }
                
        }

        private void buttonBookmarkNext_Click(object sender, EventArgs e)
        {
            var line = txtMain.LineFromPosition(txtMain.CurrentPosition);
            var nextLine = txtMain.Lines[++line].MarkerNext(1 << BOOKMARK_MARKER);
            if (nextLine != -1)
            {
                txtMain.Lines[nextLine].Goto();
                //txtMain.Lines[nextLine].d
            }
                
        }

        private void menu_open_file_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "File containing SQL code";
            openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "SQL|*.sql|PRC|*.prc|VIW|*.viw|UDF|*.udf";
            openFileDialog.ShowDialog();

            string Chosen_File = "";
            Chosen_File = openFileDialog.FileName;

            if(Chosen_File.Length > 0)
            {

                string Chosen_File_Text = System.IO.File.ReadAllText(Chosen_File);
                txtMain.Text = Chosen_File_Text;
            } else
            {
                //if (MessageBox.Show("Please select a valid file", "Please select a valid file1", MessageBoxButtons.OK) == DialogResult.OK);
            }

        }

        private void menu_new_Click(object sender, EventArgs e)
        {
            reset_gui("Full");
        }

        private void reset_gui(string type)
        {
            if (type == "Full")
            {
                txtMain.Text = "";
                TextBox_ApplicationLog.Text = "";
                menu_BookmarkCount.Text = "0 Bookmarks";
            }
            

            button_ParseSQL.BackColor = Color.LightGray;

            buttonViewTableInformation.BackColor = Color.LightGray;
            buttonViewTableInformation.Enabled = false;

            buttonViewProcInformation.BackColor = Color.LightGray;
            buttonViewProcInformation.Enabled = false;

            buttonViewComposition.BackColor = Color.LightGray;
            buttonViewComposition.Enabled = false;
            
        }

        private void menu_quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menu_search_go_to_line_Click(object sender, EventArgs e)
        {
            using (var form = new GoTo())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int lineNumber = form.ReturnValue;            
                    txtMain.Lines[lineNumber - 1].Goto();
                }
            }
        }



        private void button_ParseSQL_Click(object sender, EventArgs e)
        {
            if(txtMain.TextLength == 0)
            {
                appendToApplicationLog("No code found");
                button_ParseSQL.BackColor = Color.LightGoldenrodYellow;
                return;
            }

            SQLParser SQLParser = new SQLParser();

            List<string> LoggingErrors = SQLParser.Parse(txtMain.Text);

            int errorCounter = 0;

            foreach (var error in LoggingErrors)
            {
                appendToApplicationLog(error);
                ++errorCounter;
            }

            if(errorCounter == 0)
            {
               
                StatementInformation = SQLParser.ExtractStatementInfo(txtMain.Text);

                Dictionary<string, int> StatementStatistics = (Dictionary<string, int>)StatementInformation["StatementStatistics"];
                Dictionary<string, object> TableReferences = (Dictionary<string, object>)StatementInformation["TableReferences"];
                //Dictionary<string, object> ProcRefernces = (Dictionary<string, object>)StatementInformation["ProcedureReferences"];

                appendToApplicationLog("TSQL Parsed OK");

                button_ParseSQL.BackColor = Color.LightGreen;
                buttonViewTableInformation.Enabled = true;
                buttonViewProcInformation.Enabled = true;
                buttonViewComposition.Enabled = true;

            } else
            {
                button_ParseSQL.BackColor = Color.LightSalmon;
            }

            
        }

        private void appendToApplicationLog(string message)
        {
            DateTime currentDateTime = DateTime.Now;
            TextBox_ApplicationLog.AppendText(currentDateTime.ToString() + " - " + message + Environment.NewLine);
            TextBox_ApplicationLog.ScrollToCaret();
        }

        public static Dictionary<string, object> StatementInformation { get; set; }

        private void button_ExtractStatementInfo_Click(object sender, EventArgs e)
        {
           
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Settings = new Settings();
            Settings.Show();
        }

        //View table information
        private void buttonViewTableInformation_Click(object sender, EventArgs e)
        {
            Dictionary<string,object> TableReferences = (Dictionary<string, object>)StatementInformation["TableReferences"];

            if(comboBox_selectedServer.Text.Length == 0 || comboBox_selectedDatabase.Text.Length == 0)
            {
                appendToApplicationLog("Please specify a server and database before viewing table information");
                buttonViewTableInformation.BackColor = Color.LightGoldenrodYellow;
                return;
            }

            if (TableReferences.Count == 0)
                MessageBox.Show("No tables found");
            else
            {
                Form TableInformation = new TableInformation();
                buttonViewTableInformation.BackColor = Color.LightGray;
                TableInformation.Show();
            }
               
        }

        private void buttonViewProcInformation_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> ProcedureReferences = (Dictionary<string, object>)StatementInformation["ExecutableProcedureReferences"];

            if (comboBox_selectedServer.Text.Length == 0 || comboBox_selectedDatabase.Text.Length == 0)
            {
                appendToApplicationLog("Please specify a server and database before viewing proc information");
                buttonViewProcInformation.BackColor = Color.LightGoldenrodYellow;
                return;
            }

            if (ProcedureReferences.Count == 0)
                MessageBox.Show("No procs found");
            else
            {
                Form ProcInformation = new ProcInformation();
                buttonViewProcInformation.BackColor = Color.LightGray;
                ProcInformation.Show();
            }
        }

        //Clear application log
        private void button_ClearApplicationLog_Click(object sender, EventArgs e)
        {
            TextBox_ApplicationLog.Text = "";
            appendToApplicationLog("Log cleared");
        }

        //Statements to parse
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            reset_gui("Partial");
            string logEntry = "";

            for (int i = 0; i <= (checkboxList_StatementsToParse.Items.Count - 1); i++) { 

                if (checkboxList_StatementsToParse.GetItemChecked(i)) { 
                    logEntry = logEntry + ", " + checkboxList_StatementsToParse.Items[i].ToString();
                    Variables.statementsToParse[checkboxList_StatementsToParse.Items[i].ToString()] = 1;
                }
                else
                    Variables.statementsToParse[checkboxList_StatementsToParse.Items[i].ToString()] = 0;
            }

            if (logEntry.Length > 0)
                appendToApplicationLog("Only extracting information for" + logEntry.Substring(1) + " statements");
            else
                appendToApplicationLog("Please make sure one type of statement is selected");

        }

        private void comboBox_selectedServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (Variables.selectedServer != comboBox_selectedServer.Text)
            {
                Variables.selectedServer = comboBox_selectedServer.Text;
                appendToApplicationLog("Intended target changed to " + comboBox_selectedServer.Text + "." + comboBox_selectedDatabase.Text);
            }
                
        }

        private void comboBox_selectedDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(Variables.selectedDatabase != comboBox_selectedDatabase.Text)
            {
                Variables.selectedDatabase = comboBox_selectedDatabase.Text;
                appendToApplicationLog("Intended target changed to " + comboBox_selectedServer.Text + "." + comboBox_selectedDatabase.Text);
            }
                
        }

        private void documentaionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutCinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form About = new AboutBox1();
            About.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(txtMain.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(txtMain.SelectedText);

            //txtMain.SelectedText = string.Empty;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string xx = Clipboard.GetText();

            //txtMain.Text = txtMain.Text.Insert(txtMain.SelectionStart, xx);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(txtMain.Text);
        }

        private void buttonViewComposition_Click(object sender, EventArgs e)
        {
            //appendToApplicationLog("View composition");

            Dictionary<string, int> StatementStatistics = (Dictionary<string, int>)StatementInformation["StatementStatistics"];

            foreach (KeyValuePair<string, int> entry in StatementStatistics)
                appendToApplicationLog("Statement Statistics - " + entry.Value + " " + entry.Key + " found");

            if(StatementStatistics.Count == 0)
            {
                appendToApplicationLog("Nothing found");
            }

        }

        private void example1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Text = @"




            ";
            reset_gui("Full");
        }

        private void example2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Text = @"




            ";
            reset_gui("Full");
        }

        private void example3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Text = @"PRINT 'Begin CreateXLS script at '+RTRIM(CONVERT(varchar(24),GETDATE(),121))+' '
PRINT ''
GO

SET NOCOUNT ON
DECLARE @Conn int -- ADO Connection object to create XLS
      , @hr int -- OLE return value
      , @src varchar(255) -- OLE Error Source
      , @desc varchar(255) -- OLE Error Description
      , @Path varchar(255) -- Drive or UNC path for XLS
      , @Connect varchar(255) -- OLE DB Connection string for Jet 4 Excel ISAM
      , @WKS_Created bit -- Whether the XLS Worksheet exists
      , @WKS_Name varchar(128) -- Name of the XLS Worksheet (table)
      , @ServerName nvarchar(128) -- Linked Server name for XLS
      , @DDL varchar(8000) -- Jet4 DDL for the XLS WKS table creation
      , @SQL varchar(8000) -- INSERT INTO XLS T-SQL
      , @Recs int -- Number of records added to XLS
      , @Log bit -- Whether to log process detail
 
SELECT @Recs = 0 
   , @Log = 1 

SET @Path = 'E:\Rahul\'+CONVERT(varchar(10),GETDATE(),112)+'.xls'
SET @Path = 'E:\Rahul\RecordsHistory_MobDW.xls'
SET @Connect = 'Provider=Microsoft.Jet.OLEDB.4.0;Data Source='+@Path+';Extended Properties=Excel 8.0'
SET @ServerName = 'EXCEL_TEST'
SET @WKS_Name = CONVERT(varchar(10),GETDATE(),112)


SET @DDL = 'CREATE TABLE '+@WKS_Name+' (TableName nvarchar, RowsCount int)'
SET @SQL = 'INSERT INTO '+@ServerName+'...'+@WKS_Name+' (TableName, RowsCount) '

SET @SQL = @SQL+'SELECT au_id AS SSN'
SET @SQL = @SQL+', LTRIM(RTRIM(ISNULL(au_fname,'''')+'' ''+ISNULL(au_lname,''''))) AS Name'
SET @SQL = @SQL+', phone AS Phone '
SET @SQL = @SQL+'FROM Rahul.dbo.Dim_Date_Test'

IF @Log = 1 PRINT 'Created OLE ADODB.Connection object'

-- Create the Conn object
EXEC @hr = sp_OACreate 'ADODB.Connection', @Conn OUT IF @hr <> 0 BEGIN
      EXEC sp_OAGetErrorInfo @Conn, @src OUT, @desc OUT 
      SELECT Error=convert(varbinary(4),@hr), Source=@src, Description=@desc
      RETURN
END

 

IF @Log = 1 PRINT char(9)+'Assigned ConnectionString property'
 EXEC @hr = sp_OASetProperty @Conn, 'ConnectionString', @Connect IF @hr <> 0 BEGIN
      EXEC sp_OAGetErrorInfo @Conn, @src OUT, @desc OUT 
      SELECT Error=convert(varbinary(4),@hr), Source=@src, Description=@desc
      RETURN
END

IF @Log = 1 PRINT char(9)+'Open Connection to XLS, for file Create or Append'

-- Call the Open method to create the XLS if it does not exist, can't use parameters

EXEC @hr = sp_OAMethod @Conn, 'Open'
IF @hr <> 0
BEGIN
       EXEC sp_OAGetErrorInfo @Conn, @src OUT, @desc OUT 
      SELECT Error=convert(varbinary(4),@hr), Source=@src, Description=@desc
      RETURN
END

 

-- %%% This section could be repeated for multiple Worksheets (Tables)

IF @Log = 1 PRINT char(9)+'Execute DDL to create '''+@WKS_Name+''' worksheet'
 EXEC @hr = sp_OAMethod @Conn, 'Execute', NULL, @DDL, NULL, 129 -- adCmdText + adExecuteNoRecords

-- 0x80040E14 for table exists in ADO

IF @hr = 0x80040E14 
   OR @hr = 0x80042732
BEGIN
      IF @hr = 0x80040E14
      BEGIN
            PRINT char(9)+''''+@WKS_Name+''' Worksheet exists for append'
            SET @WKS_Created = 0
      END
      SET @hr = 0 -- ignore these errors END

IF @hr <> 0
BEGIN
      -- Return OLE error
      EXEC sp_OAGetErrorInfo @Conn, @src OUT, @desc OUT 
      SELECT Error=convert(varbinary(4),@hr), Source=@src, Description=@desc
      RETURN
END

 

IF @Log = 1 PRINT 'Destroyed OLE ADODB.Connection object'
-- Destroy the Conn object, +++ important to not leak memory +++ EXEC @hr = sp_OADestroy @Conn IF @hr <> 0 BEGIN
      -- Return OLE error
      EXEC sp_OAGetErrorInfo @Conn, @src OUT, @desc OUT 
      SELECT Error=convert(varbinary(4),@hr), Source=@src, Description=@desc
      RETURN
END

 

-- Linked Server allows T-SQL to access the XLS worksheet (Table)
--   This must be performed after the ADO stuff as the XLS must exist
--   and contain the schema for the table, or worksheet

IF NOT EXISTS(SELECT srvname from master.dbo.sysservers where srvname = @ServerName) BEGIN
      IF @Log = 1 PRINT 'Created Linked Server '''+@ServerName+''' and Login'
      EXEC sp_addlinkedserver @server = @ServerName
            , @srvproduct = 'Microsoft Excel Workbook'
            , @provider = 'Microsoft.Jet.OLEDB.4.0'
            , @datasrc = @Path
            , @provstr = 'Excel 8.0' 
      EXEC sp_addlinkedsrvlogin @ServerName, 'false' 
END


EXEC (@SQL)
PRINT char(9)+'Populated '''+@WKS_Name+''' table with '+CONVERT(varchar,@@ROWCOUNT)+' Rows'

 IF EXISTS(SELECT srvname from master.dbo.sysservers where srvname = @ServerName) BEGIN
      IF @Log = 1 PRINT 'Deleted Linked Server '''+@ServerName+''' and Login'
      EXEC sp_dropserver @ServerName, 'droplogins'
END
GO

 

SET NOCOUNT OFF
PRINT ''
PRINT 'Finished CreateXLS script at '+RTRIM(CONVERT(varchar(24),GETDATE(),121))+' '
GO
            ";
       
        }
    }
}
