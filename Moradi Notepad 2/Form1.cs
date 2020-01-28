using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradi_Notepad_2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string currentFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            welcome.Text = "Welcome, " + System.Environment.UserName;
            
        }

        private void LineCount_Click(object sender, EventArgs e)
        {
            if (LineCount.Checked == true)
            {
                fastColoredTextBox1.ShowLineNumbers = true;
            }
            else if (LineCount.Checked == false)
            {
                fastColoredTextBox1.ShowLineNumbers = false;
            }
        }

        private void LineCounterStatus_Tick(object sender, EventArgs e)
        {
            // Lines
            LineCounter.Text = "Lines: " + (fastColoredTextBox1.LinesCount.ToString());

           

        }

        private void Find_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void QuickLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                if (QuickLaunch.Checked == true)
                {
                    quicklauncher.Visible = true;
                }
                else if (QuickLaunch.Checked == false)
                {
                    quicklauncher.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to delete current code? and Exit", "EXIT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = fd.Font;
            }
        }

        private void Spellchecker_Tick(object sender, EventArgs e)
        {
           
        }

        private void HTML_Click(object sender, EventArgs e)
        {
            if (HTML.Checked == true)
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            }
            else if (HTML.Checked == false)
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
            }
        }

        private void CSharp_Click(object sender, EventArgs e)
        {
            if (cSharp.Checked == true)
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            }
            else if (cSharp.Checked == false)
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to delete current code?", "new", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //delete all code
                fastColoredTextBox1.Clear();
                //set current file to nothing
                currentFile = null;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to delete current code?", "OPEN", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //open menu with file choosing
                OpenFileDialog op = new OpenFileDialog();

                //filter
                op.Filter = "Text File|*.txt|HTML File|*.html|CSS File|*.css|Any File|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    // Read selected file
                    StreamReader sr = new StreamReader(op.FileName);
                    // set current file to selected
                    currentFile = op.FileName;
                    // Read text set code editor
                    fastColoredTextBox1.Text = sr.ReadToEnd();
                    // Stop reading File
                    sr.Close();
                }
            }
    }

        private void Save_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                //write text to file
                StreamWriter sw = new StreamWriter(currentFile);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            //Save as 
            SaveFileDialog op = new SaveFileDialog();

            //filter
            op.Filter = "Text File|*.txt|HTML File|*.html|CSS File|*.css|Any File|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                // save selected file
                StreamWriter sr = new StreamWriter(op.FileName);
                // set current file to selected
                currentFile = op.FileName;
                // write code to file 
                sr.Write(fastColoredTextBox1.Text);
                // Stop reading File
                sr.Close();
            }
        
    }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to delete current code?", "new", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //delete all code
                fastColoredTextBox1.Clear();
                //set current file to nothing
                currentFile = null;
            }
        }

        private void SaveTextFile_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                //write text to file
                StreamWriter sw = new StreamWriter(currentFile);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        
    }

        private void LeftAlign_Click(object sender, EventArgs e)
        {
            // Left alignment for text location
            fastColoredTextBox1.Text = HorizontalAlignment.Left.ToString();
        }

        private void RighAlign_Click(object sender, EventArgs e)
        {

        }
    }
    }
