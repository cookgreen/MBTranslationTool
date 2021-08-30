
namespace MBTranslationTool
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.csvContentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txtCSVLineID = new System.Windows.Forms.RichTextBox();
            this.txtCSVLineValue = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // csvContentList
            // 
            this.csvContentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.csvContentList.FullRowSelect = true;
            this.csvContentList.GridLines = true;
            this.csvContentList.HideSelection = false;
            this.csvContentList.Location = new System.Drawing.Point(12, 38);
            this.csvContentList.MultiSelect = false;
            this.csvContentList.Name = "csvContentList";
            this.csvContentList.Size = new System.Drawing.Size(763, 328);
            this.csvContentList.TabIndex = 0;
            this.csvContentList.UseCompatibleStateImageBehavior = false;
            this.csvContentList.View = System.Windows.Forms.View.Details;
            this.csvContentList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.csvContentList_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 400;
            // 
            // txtCSVLineID
            // 
            this.txtCSVLineID.Location = new System.Drawing.Point(14, 372);
            this.txtCSVLineID.Name = "txtCSVLineID";
            this.txtCSVLineID.Size = new System.Drawing.Size(350, 125);
            this.txtCSVLineID.TabIndex = 1;
            this.txtCSVLineID.Text = "";
            // 
            // txtCSVLineValue
            // 
            this.txtCSVLineValue.Location = new System.Drawing.Point(370, 372);
            this.txtCSVLineValue.Name = "txtCSVLineValue";
            this.txtCSVLineValue.Size = new System.Drawing.Size(405, 125);
            this.txtCSVLineValue.TabIndex = 2;
            this.txtCSVLineValue.Text = "";
            this.txtCSVLineValue.TextChanged += new System.EventHandler(this.txtCSVLineValue_TextChanged);
            this.txtCSVLineValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCSVLineValue_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileCreate,
            this.mnuFileOpen,
            this.toolStripSeparator1,
            this.mnuFileClose,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "File";
            // 
            // mnuFileCreate
            // 
            this.mnuFileCreate.Name = "mnuFileCreate";
            this.mnuFileCreate.Size = new System.Drawing.Size(121, 22);
            this.mnuFileCreate.Text = "New";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(121, 22);
            this.mnuFileOpen.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(121, 22);
            this.mnuFileClose.Text = "Close";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Enabled = false;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(121, 22);
            this.mnuFileSave.Text = "Save";
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Enabled = false;
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(121, 22);
            this.mnuFileSaveAs.Text = "Save As";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(121, 22);
            this.mnuExit.Text = "Exit";
            // 
            // btnAddLine
            // 
            this.btnAddLine.Enabled = false;
            this.btnAddLine.Location = new System.Drawing.Point(780, 38);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(42, 32);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "+";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Enabled = false;
            this.btnDeleteLine.Location = new System.Drawing.Point(781, 76);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(41, 33);
            this.btnDeleteLine.TabIndex = 5;
            this.btnDeleteLine.Text = "-";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 509);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.txtCSVLineValue);
            this.Controls.Add(this.txtCSVLineID);
            this.Controls.Add(this.csvContentList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mount & Blade Translation Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView csvContentList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RichTextBox txtCSVLineID;
        private System.Windows.Forms.RichTextBox txtCSVLineValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
    }
}

