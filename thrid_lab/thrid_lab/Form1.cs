using System;
using System.IO;            
using System.Linq;          
using System.Text.RegularExpressions; 
using System.Windows.Forms;





namespace thrid_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All files | *.*";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string fullPathName = openFileDialog.FileName;
            FileInfo src = new FileInfo(fullPathName);
            filename.Text = src.FullName;

        }

        private void filename_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
