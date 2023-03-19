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

namespace ad_sem2_week4_tha_winsform_namadanfavartist
{
    public partial class formMainWindowForm : Form
    {
        public static formMainWindowForm instance;
        public int openForm2Dectetor = 0;
        bool submitChecker = false;
        public Panel panel;

        public formMainWindowForm()
        {
            InitializeComponent();
            instance = this;
            panel = panelMainForm;
            buttonSubmit.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked) { submitChecker = true; }
            else { submitChecker = false; }
            if (openForm2Dectetor > 0 & submitChecker == true)
            {
                buttonSubmit.Enabled = true;
            }
            else
            {
                buttonSubmit.Enabled = false;
            }
        }

        private void buttonOpenNextForm_Click(object sender, EventArgs e)
        {
            openForm2Dectetor++;
            formSecondWindowForm abc = new formSecondWindowForm();
            abc.Show();
            if (openForm2Dectetor > 0 & submitChecker == true)
            {
                buttonSubmit.Enabled = true;
            }
            else
            {
                buttonSubmit.Enabled = false;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxArtist.Text == "")
            {
                MessageBox.Show("Please enter the input requirements", "Error Message");
            }
            else
            {
                formSecondWindowForm.instance.labelHiTest.Text = "Hi, my name is " + textBoxName.Text + " My favourite artist is " + textBoxArtist.Text;
            }
            
     
        }
    }
}
