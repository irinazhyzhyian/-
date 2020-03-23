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

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(rtbText);
            deleteForm.ShowDialog();
           /* btnClean.Enabled = false;
            btnFile.Enabled = false;
            btnShowForm.Enabled = false;*/
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            Stream inputFIle;
            OpenFileDialog fileDialog = new OpenFileDialog();
            
            fileDialog.InitialDirectory = Path.GetFullPath("../../../");
            fileDialog.Filter = "txt files (*.txt)|*.txt";
            fileDialog.RestoreDirectory = true;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFIle = fileDialog.OpenFile();
                StreamReader reader = new StreamReader(inputFIle);
                rtbText.Text = reader.ReadToEnd();
            }
        }
    }
}
