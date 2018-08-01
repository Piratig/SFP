using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SFP
{
    public partial class Form1 : Form
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStartDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdStartDirectory = new FolderBrowserDialog();
            if (fbdStartDirectory.ShowDialog() == DialogResult.OK)
            {
                textBoxStartDirectory.Text = fbdStartDirectory.SelectedPath;
            }
        }

        private void Seasrh(string directory, string content, string fileNameSearch)
        {
            string[] drives = Environment.GetLogicalDrives();

            foreach (string dr in drives)
            {
                DriveInfo di = new DriveInfo(dr);

                if (!di.IsReady)
                {
                    continue;
                }
                DirectoryInfo rootDir = new DirectoryInfo(@directory);
                WalkDirectoryTree(rootDir, fileNameSearch, content);
                break;
            }
        }

        private void WalkDirectoryTree(DirectoryInfo root, string fileNameSearch, string content)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles(fileNameSearch);
            }
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    label6.Text = fi.FullName;
                    string[] text = File.ReadAllLines(fi.FullName);
                    for (int i = 0; i < text.Length; i++)
                    {
                        bool b = text[i].Contains(content);
                        if (b)
                        {
                            label4.Visible = true;
                            richTextBoxOutPut.Text += fi.FullName + "\n";
                            index++;
                            label4.Text = Convert.ToString(index);
                            break;
                        }
                    }
                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo, fileNameSearch, content);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            richTextBoxOutPut.Clear();
            string fileNameSearch = "*";
            if (textBoxFileNameTemplate.Text != "")
            {
                fileNameSearch = textBoxFileNameTemplate.Text;
            }
            Seasrh(textBoxStartDirectory.Text, textBoxText.Text, fileNameSearch);
            index = 0;
        }
    }
}
