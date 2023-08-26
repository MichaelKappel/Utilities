using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeGeneration
{
    public partial class CopyFilesWithChangesForm : Form
    {

        private bool fileOpened = false;

        public CopyFilesWithChangesForm()
        {
            InitializeComponent();

            // Default to the My Documents folder.
            this.fbdFolder.RootFolder = Environment.SpecialFolder.Recent;

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = fbdFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSourceFolder.Text = fbdFolder.SelectedPath;
                if (!fileOpened)
                {
                    ofdOpen.InitialDirectory = txtSourceFolder.Text;
                    ofdOpen.FileName = null;
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            // If a file is not opened, then set the initial directory to the
            // FolderBrowserDialog.SelectedPath value.
            if (!fileOpened)
            {
                ofdOpen.InitialDirectory = fbdFolder.SelectedPath;
                ofdOpen.FileName = null;
            }

            // Display the openFile dialog.
            DialogResult result = ofdOpen.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                txtSelectedFile.Text = ofdOpen.FileName;
                try
                {
                    // Output the requested file in richTextBox1.
                    using (Stream s = ofdOpen.OpenFile())
                    {
                        using (StreamReader sr = new(s))
                        {
                            txtFileContent.Text = sr.ReadToEnd();
                        }
                        s.Close();
                    }

                    fileOpened = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is:"
                                    + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
                    fileOpened = false;
                }
                Invalidate();
            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = fbdFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestinationFolder.Text = fbdFolder.SelectedPath;
                if (!fileOpened)
                {
                    ofdOpen.InitialDirectory = txtDestinationFolder.Text;
                    ofdOpen.FileName = null;
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            txtFileContentTestResult.Text = this.ApplyChanges(txtFileContent.Text);
        }

        protected String ApplyChanges(String original)
        {

            Dictionary<String, String> replacements = new Dictionary<string, string>();
            if (!String.IsNullOrWhiteSpace(txtFrom1.Text))
            {
                replacements.Add(txtFrom1.Text, txtTo1.Text);
            }
            if (!String.IsNullOrWhiteSpace(txtFrom2.Text))
            {
                replacements.Add(txtFrom2.Text, txtTo2.Text);
            }
            if (!String.IsNullOrWhiteSpace(txtFrom3.Text))
            {
                replacements.Add(txtFrom3.Text, txtTo3.Text);
            }

            foreach (KeyValuePair<String, String> replacement in replacements)
            {
                original = original.Replace(replacement.Key, replacement.Value);
            }
            return original;
        }

    }
}
