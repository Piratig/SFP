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
            DirectoryInfo di = new DirectoryInfo(@directory);

            FileInfo[] fileArray = di.GetFiles();

            string[] diNames = Directory.GetFiles(@directory, fileNameSearch);

            foreach (string diName in diNames)
            {
                //MessageBox.Show(diName);
                textBoxActiveFile.Text = diName;
                string[] text = File.ReadAllLines(diName);
                for (int i = 0; i < text.Length; i++)
                {
                    //sLine = 
                    if (text[i] == content)
                    {
                        richTextBoxOutPut.Text += diName + "\n";
                        richTextBoxOutPut.Text += text[i] + "\n";
                        break;
                    }
                }
                //text.Close();
                //textBoxActiveFile.Text = "";
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
