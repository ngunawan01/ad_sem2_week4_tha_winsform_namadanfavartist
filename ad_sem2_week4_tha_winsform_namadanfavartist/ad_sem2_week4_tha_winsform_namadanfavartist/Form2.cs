using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ad_sem2_week4_tha_winsform_namadanfavartist
{
    public partial class formSecondWindowForm : Form
    {
        public static formSecondWindowForm instance;
        public Label labelHiTest;
        
        public formSecondWindowForm()
        {
            InitializeComponent();
            instance = this;
            labelHiTest = labelHi;
            buttonMagic.Enabled = false;
        }

        private void formSecondWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked == true && checkBoxAll.Checked == true)
            {
                buttonMagic.Enabled = true;
            }
            else
            {
                buttonMagic.Enabled = false;
            }
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked == true && checkBoxAll.Checked == true)
            {
                buttonMagic.Enabled = true;
            }
            else
            {
                buttonMagic.Enabled = false;
            }
        }

        private void buttonMagic_Click(object sender, EventArgs e)
        {
            if ((radioButtonRed.Checked == true || radioButtonGreen.Checked == true || radioButtonBlue.Checked == true || radioButtonYellow.Checked == true || radioButtonPurple.Checked == true) && (radioButtonBlack.Checked == true || radioButtonWhite.Checked == true || radioButtonGrey.Checked == true))
            {
                if (radioButtonRed.Checked == true)
                {
                    formMainWindowForm.instance.panel.BackColor = Color.Red;
                }
                if (radioButtonGreen.Checked == true)
                {
                    formMainWindowForm.instance.panel.BackColor = Color.Green;
                }
                if (radioButtonBlue.Checked == true)
                {
                    formMainWindowForm.instance.panel.BackColor = Color.Blue;
                }
                if (radioButtonYellow.Checked == true)
                {
                    formMainWindowForm.instance.panel.BackColor = Color.Yellow;
                }
                if (radioButtonPurple.Checked == true)
                {
                    formMainWindowForm.instance.panel.BackColor = Color.Purple;
                }
                if (radioButtonBlack.Checked == true)
                {
                    foreach (Control c in formMainWindowForm.instance.Controls)
                    {
                        c.ForeColor = Color.Black;
                    }
                }
                if (radioButtonWhite.Checked == true)
                {
                    foreach (Control c in formMainWindowForm.instance.Controls)
                    {
                        c.ForeColor = Color.White;
                    }
                }
                if (radioButtonGrey.Checked == true)
                {
                    foreach (Control c in formMainWindowForm.instance.Controls)
                    {
                        c.ForeColor = Color.Gray;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check the required radioboxes", "Error Message");
            }
             
        }
    }
}
