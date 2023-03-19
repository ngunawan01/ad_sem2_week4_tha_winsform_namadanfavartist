namespace ad_sem2_week4_tha_winsform_namadanfavartist
{
    partial class formMainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenNextForm = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.panelMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenNextForm
            // 
            this.buttonOpenNextForm.Location = new System.Drawing.Point(34, 209);
            this.buttonOpenNextForm.Name = "buttonOpenNextForm";
            this.buttonOpenNextForm.Size = new System.Drawing.Size(174, 23);
            this.buttonOpenNextForm.TabIndex = 0;
            this.buttonOpenNextForm.Text = "Open Next Form";
            this.buttonOpenNextForm.UseVisualStyleBackColor = true;
            this.buttonOpenNextForm.Click += new System.EventHandler(this.buttonOpenNextForm_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 68);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(31, 106);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(116, 16);
            this.labelArtist.TabIndex = 3;
            this.labelArtist.Text = "My Favourite Artist";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(169, 100);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(100, 22);
            this.textBoxArtist.TabIndex = 4;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(34, 150);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(235, 20);
            this.checkBoxAll.TabIndex = 5;
            this.checkBoxAll.Text = "All of the content I put above is true!";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(251, 209);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // panelMainForm
            // 
            this.panelMainForm.Controls.Add(this.buttonSubmit);
            this.panelMainForm.Controls.Add(this.buttonOpenNextForm);
            this.panelMainForm.Controls.Add(this.checkBoxAll);
            this.panelMainForm.Controls.Add(this.labelName);
            this.panelMainForm.Controls.Add(this.textBoxArtist);
            this.panelMainForm.Controls.Add(this.textBoxName);
            this.panelMainForm.Controls.Add(this.labelArtist);
            this.panelMainForm.Location = new System.Drawing.Point(2, 3);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(797, 452);
            this.panelMainForm.TabIndex = 7;
            // 
            // formMainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainForm);
            this.Name = "formMainWindowForm";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainForm.ResumeLayout(false);
            this.panelMainForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenNextForm;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel panelMainForm;
    }
}

