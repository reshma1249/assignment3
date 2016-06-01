using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class movies : Form
    {
        List<String> comedyList;
        List<String> horrorList;
        List<String> romanceList;
        public movies()
        {
            InitializeComponent();
        }

        private void movies_Load(object sender, EventArgs e)
        {
            comedyList = new List<string>();
            horrorList = new List<string>();
            romanceList = new List<string>();

        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            frmAuthor authorForm = new frmAuthor();
            authorForm.ShowDialog();
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = txtEntry.Text;
            if (text.Length > 0)
            {
                if (rb1.Checked)
                {
                    comedyList.Add(text);
                    updateDisplay(comedyList);
                }
                else if (rb2.Checked)
                {
                    horrorList.Add(text);
                    updateDisplay(horrorList);
                }
                else if (rb3.Checked)
                {
                    romanceList.Add(text);
                    updateDisplay(romanceList);
                }
                else
                {
                    MessageBox.Show("Please select a category");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input!!!");
            }

        }
        private void updateDisplay(List<String> list)
        {
            listChoices.Text = "";
            foreach (string item in list)
            {
                
                listChoices.AppendText(item);
                listChoices.AppendText(Environment.NewLine);
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
                updateDisplay(comedyList);
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
                updateDisplay(horrorList);
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
                updateDisplay(romanceList);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                comedyList.Sort();
                updateDisplay(comedyList);
            }
            else if (rb2.Checked)
            {
                horrorList.Sort();
                updateDisplay(horrorList);
            }
            else if (rb3.Checked)
            {
                romanceList.Sort();
                updateDisplay(romanceList);
            }
            else
            {
                MessageBox.Show("Please select a category");
            }
        }

     

        
    }
}
