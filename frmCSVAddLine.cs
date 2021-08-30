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
    public partial class frmCSVAddLine : Form
    {
        public MBCsvLine CSVLine { get; set; }

        public frmCSVAddLine()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCSVLineID.Text) ||
                string.IsNullOrEmpty(txtCSVLineValue.Text))
            {
                MessageBox.Show("Please Input the suitable value!");
                return;
            }

            CSVLine = new MBCsvLine();
            CSVLine.ID = txtCSVLineID.Text;
            CSVLine.Value = txtCSVLineValue.Text;

            Close();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

            DialogResult = DialogResult.Cancel;
        }
    }
}
