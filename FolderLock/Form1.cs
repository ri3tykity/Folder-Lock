using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;
using System.Reflection;

namespace FolderLock
{
    public partial class FolderLock : Form
    {
        string delPath = "";
        //string txtfilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        const string filename = @"d:\MyFolderText.bat";
        List<string> folderlist = new List<string>();
        public FolderLock()
        {
            InitializeComponent();
            StreamReader readfile = new StreamReader(filename);
            string line;
            while ((line = readfile.ReadLine()) != null)
            {
                folderList.Items.Add(line);
            }
            readfile.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FolderBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath.Text = FolderBrowseDialog.SelectedPath;
            }
            folderlist.Add(FolderPath.Text);
            if (FolderPath.Text != "")
            {
                string itm = FolderPath.Text;
                if (!(folderList.Items.Contains(itm)))
                {
                    folderList.Items.Add(itm);
                }
            }
        }

        private void folderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(folderList.SelectedItem.ToString());

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            folderList.MouseDown += new MouseEventHandler(folderList_MouseDown);
        }

        void folderList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (var itm in folderList.Items)
                {
                    if (delPath == itm.ToString())
                    {
                        folderList.Items.Remove(folderList.Items);
                    }
                }
                //folderList.SelectedItems.Remove(delPath);
                folderList.Refresh();
            }
            else
            {
                if (!(folderList.SelectedItem.ToString() == ""))
                {
                    FolderPath.Text = folderList.SelectedItem.ToString();
                    delPath = folderList.SelectedItem.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter writeFile = new StreamWriter(filename);
            string txt = "";
            foreach (var nam in folderList.Items)
            {
                txt = nam.ToString();
                writeFile.WriteLine(txt);
            }
            //writeFile.ToString();
            writeFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passtext.Text == passcode && passtext.Text != "")
            {
                try
                {
                    string path = FolderPath.Text;
                    string admin = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(path);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(admin, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(path, ds);
                    MessageBox.Show("Folder Locked");

                }
                catch
                {
                    MessageBox.Show("Lock Error");
                }
            }
            else
                MessageBox.Show("Lock Error !!!\nEnter correct password");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (passtext.Text == passcode && passtext.Text != "")
            {
                try
                {
                    string path = FolderPath.Text;
                    string admin = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(path);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(admin, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(fsa);
                    Directory.SetAccessControl(path, ds);
                    MessageBox.Show("Folder unLocked");

                }
                catch
                {
                    MessageBox.Show("unLock Error");
                }
            }
            else
                MessageBox.Show("Lock Error !!!\nEnter correct password");
        }
        String passcode = "";
        private void passtext_KeyUp(object sender, KeyEventArgs e)
        {
            if (passtext.Text == "rkity")
            {
                passcode = "krishnakity";
                passtext.Text = passcode;
            }
        }

    }
}
