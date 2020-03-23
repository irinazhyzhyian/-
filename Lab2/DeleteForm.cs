using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab_2
{
    public partial class DeleteForm : Form
    {
    
        string mask;
        private RichTextBox richTxtBox;

        public DeleteForm()
        {
            InitializeComponent();
            
        }

        public DeleteForm(RichTextBox richTextBox)
        {
            InitializeComponent();
            this.richTxtBox = richTextBox;
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            mask = txtMask.Text;
            mask = new RegularCheck().optimiseMask(mask);
            MessageBox.Show(mask);

            /*string pattern = "\\^";
            string replacement = "[aoiuey]*";
            Regex rgx = new Regex(pattern);
            mask = rgx.Replace(mask, replacement);*/
            mask = new RegularCheck().getNewMask(mask);

            if (rbtnStart.Checked)
            {
                var matches = Regex.Matches(richTxtBox.Text, @"\b" + mask + @"\s*\b");
                if (matches.Count==0)
                {
                    MessageBox.Show("No matches!");
                    return;
                }
                int i = 0;
                foreach (Match m in matches)
                {
                    richTxtBox.Select(m.Index-i, m.Length);
                    richTxtBox.SelectionBackColor = Color.DeepSkyBlue;
                    string message = "Delete '" + m.ToString() + "'" + "?";

                    var result = MessageBox.Show(message, "Waring!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        i = m.Length+i;
                        richTxtBox.SelectedText = "";
                    }

                    if (result == DialogResult.No)
                    {
                        richTxtBox.SelectionBackColor = Color.White;
                    }
                  
                }
            }

            if (rbtnCursor.Checked)
            {
                Regex r = new Regex(@"\b" + mask + @"\s*\b");
                if (r.Matches(richTxtBox.Text, richTxtBox.SelectionStart).Count == 0)
                {
                    MessageBox.Show("No matches!");
                    return;
                }
                var matches = r.Matches(richTxtBox.Text, richTxtBox.SelectionStart);
                int i = 0;
                foreach (Match m in matches)
                {
                    richTxtBox.Select(m.Index - i, m.Length);
                    richTxtBox.SelectionBackColor = Color.Violet;
                    string message = "Delete '" + m.ToString() + "'" + "?";

                    var result = MessageBox.Show(message, "Waring!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                       i = m.Length+i;
                        richTxtBox.SelectedText = "";
                    }
                    if (result == DialogResult.No)
                    {
                        richTxtBox.SelectionBackColor = Color.White;
                    }

                }

            }

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            mask = txtMask.Text;
            mask = new RegularCheck().optimiseMask(mask);
            MessageBox.Show(mask);

            mask = new RegularCheck().getNewMask(mask);
            int startPos = 0;
            Regex r = new Regex(@"\b" + mask + @"\s*\b");
            if (rbtnCursor.Checked)
            {
                startPos = richTxtBox.SelectionStart; 
            }
            
            if (rbtnStart.Checked)
            {
                startPos = 0;
            }
                if (r.Matches(richTxtBox.Text, startPos).Count == 0)
                {
                    MessageBox.Show("No matches!");
                    return;
                }
                var matches = r.Matches(richTxtBox.Text, startPos);
                int i = 0;
                foreach (Match m in matches)
                {
                    richTxtBox.Select(m.Index - i, m.Length);
                    richTxtBox.SelectionBackColor = Color.Yellow;

                }
            
                                      
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            mask = txtMask.Text;
            mask = new RegularCheck().optimiseMask(mask);
            MessageBox.Show(mask);

            /*string pattern = "\\^";
            string replacement = "[aoiuey]*";
            Regex rgx = new Regex(pattern);
            mask = rgx.Replace(mask, replacement);*/
            mask = new RegularCheck().getNewMask(mask);

            var matches = Regex.Matches(richTxtBox.Text, @"\b" + mask + @"\s*\b");
            if (matches.Count == 0)
            {
                MessageBox.Show("Немає співпадінь");
                return;
            }
            
            int i = 0;
            foreach (Match m in matches)
            {
                richTxtBox.Select(m.Index - i, m.Length);
                richTxtBox.SelectionBackColor = Color.Gray;

            }
            string message = "Delete all?";

            var result = MessageBox.Show(message, "Waring!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string res = Regex.Replace(richTxtBox.Text, @"\b" + mask + @"\s*\b", "");
                richTxtBox.Text = res;
            }
            if (result == DialogResult.No)
            {
                richTxtBox.SelectionBackColor = Color.White;
            }

        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        } 

        private void btnSelOff_Click(object sender, EventArgs e)
        {
            richTxtBox.SelectAll();
            richTxtBox.SelectionBackColor = Color.White ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            richTxtBox.SelectAll();
            richTxtBox.SelectionBackColor = Color.White;
            this.Close();
            
        }
    }
}
