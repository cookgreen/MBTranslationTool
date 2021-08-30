using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBTranslationTool
{
    public partial class frmMain : Form
    {
        private string windowText;
        private MBCsvLoader loader;
        private MBCsv currentFile;
        private int lastListViewSelectionIndex;

        public frmMain()
        {
            InitializeComponent();
            mnuFile.DropDownItemClicked += MnuFile_DropDownItemClicked;
            loader = new MBCsvLoader();
            windowText = Text;
        }

        private void MnuFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuFileCreate":
                    FileCreate();
                    break;
                case "mnuFileOpen":
                    FileOpen();
                    break;
                case "mnuFileSave":
                    FileSave();
                    break;
                case "mnuFileSaveAs":
                    FileSaveAs();
                    break;
                case "mnuFileClose":
                    ClearCSVFile();
                    break;
                case "mnuExit":
                    Application.Exit();
                    break;
            }
        }

        private void FileCreate()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "M&B Translation File|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = loader.Read(dialog.FileName);

                mnuFileCreate.Enabled = false;
                mnuFileOpen.Enabled = false;
                mnuFileSave.Enabled = true;
                mnuFileSaveAs.Enabled = true;
                mnuFileClose.Enabled = true;
                btnAddLine.Enabled = true;
                btnDeleteLine.Enabled = true;

                Text = windowText + " - " + dialog.FileName;

                LoadCSVFile();
            }
        }

        private void FileOpen()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "M&B Translation File|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = loader.Read(dialog.FileName);

                mnuFileCreate.Enabled = false;
                mnuFileOpen.Enabled = false;
                mnuFileSave.Enabled = true;
                mnuFileSaveAs.Enabled = true;
                mnuFileClose.Enabled = true;
                btnAddLine.Enabled = true;
                btnDeleteLine.Enabled = true;

                Text = windowText + " - " + dialog.FileName;

                LoadCSVFile();
            }
        }

        private void FileSave()
        {
            loader.Save(currentFile, currentFile.FileName);
        }

        private void FileSaveAs()
        {

        }

        private void LoadCSVFile()
        {
            csvContentList.Items.Clear();
            foreach(var csvLine in currentFile.Lines)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = csvLine.ID;
                lvi.SubItems.Add(csvLine.Value);
                csvContentList.Items.Add(lvi);
            }
        }

        private void ClearCSVFile()
        {
            csvContentList.Items.Clear();
            currentFile = null;
            Text = windowText;
            txtCSVLineID.Text = string.Empty;
            txtCSVLineValue.Text = string.Empty;
            btnAddLine.Enabled = false;
            btnDeleteLine.Enabled = false;
        }

        private void csvContentList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;

            if (item != null)
            {
                txtCSVLineID.Text = item.Text;
                txtCSVLineValue.Text = item.SubItems[1].Text;
                btnDeleteLine.Enabled = true;
            }
            else
            {
                txtCSVLineID.Text = string.Empty;
                txtCSVLineValue.Text = string.Empty;
                btnDeleteLine.Enabled = false;
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            frmCSVAddLine csvAddLineWin = new frmCSVAddLine();
            if (csvAddLineWin.ShowDialog() == DialogResult.OK)
            {
                currentFile.Lines.Add(csvAddLineWin.CSVLine);
            }
        }

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {

        }

        private void txtCSVLineValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var currentIndex = csvContentList.SelectedIndices[0];

                var subItems = csvContentList.Items[currentIndex].SubItems;
                subItems[0].Text = txtCSVLineID.Text;
                subItems[1].Text = txtCSVLineValue.Text;

                var csvLine = currentFile.Lines[currentIndex];
                csvLine.ID = txtCSVLineID.Text;
                csvLine.Value = txtCSVLineValue.Text;

                if (currentIndex != csvContentList.Items.Count - 1)
                {
                    csvContentList.Items[currentIndex + 1].Selected = true;
                }
            }
        }

        private void txtCSVLineValue_TextChanged(object sender, EventArgs e)
        {
            if (txtCSVLineValue.Text.StartsWith("\n"))
            {
                txtCSVLineValue.Text = txtCSVLineValue.Text.Replace("\n", "");
            }
        }
    }
}
