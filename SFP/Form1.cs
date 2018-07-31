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
            //DirectoryInfo di = new DirectoryInfo(@directory);

            //FileInfo[] fileArray = di.GetFiles();

            //string[] diNames = Directory.GetFiles(@directory, fileNameSearch);

            //foreach (string diName in diNames)
            //{
            //    textBoxActiveFile.Text = diName;
            //    string[] text = File.ReadAllLines(diName);
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        bool b = text[i].Contains(content);
            //        if (b)
            //        {
            //            richTextBoxOutPut.Text += diName + "\n";
            //            richTextBoxOutPut.Text += text[i] + "\n";
            //            break;
            //        }
            //    }
            //}

            string[] drives = Environment.GetLogicalDrives();

            foreach (string dr in drives)
            {
                DriveInfo di = new DriveInfo(dr);

                // Here we skip the drive if it is not ready to be read. This
                // is not necessarily the appropriate action in all scenarios.
                if (!di.IsReady)
                {
                    //Console.WriteLine("The drive {0} could not be read", di.Name);
                    continue;
                }
                DirectoryInfo rootDir = new DirectoryInfo(@directory);
                WalkDirectoryTree(rootDir, fileNameSearch);
            }
        }

        private void WalkDirectoryTree(DirectoryInfo root, string fileNameSearch)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles(fileNameSearch);
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (UnauthorizedAccessException e)
            {
                // This code just writes out the message and continues to recurse.
                // You may decide to do something different here. For example, you
                // can try to elevate your privileges and access the file again.
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
                    // In this example, we only access the existing FileInfo object. If we
                    // want to open, delete or modify the file, then
                    // a try-catch block is required here to handle the case
                    // where the file has been deleted since the call to TraverseTree().
                    richTextBoxOutPut.Text += fi.FullName + "\n";
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo, fileNameSearch);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string fileNameSearch = "*";
            if (textBoxFileNameTemplate.Text == null)
            {
                fileNameSearch = textBoxFileNameTemplate.Text;
            }
            Seasrh(textBoxStartDirectory.Text, textBoxText.Text, fileNameSearch);
        }
    }
}
