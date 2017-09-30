namespace caseman
{
    namespace dismodel
    {
        partial class frmMain
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
                this.splitContainerMain = new System.Windows.Forms.SplitContainer();
                this.listViewContactList = new System.Windows.Forms.ListView();
                this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
                this.maskedTextBoxUtcOffset = new System.Windows.Forms.MaskedTextBox();
                this.label4 = new System.Windows.Forms.Label();
                this.buttonSaveContact = new System.Windows.Forms.Button();
                this.buttonDeleteContact = new System.Windows.Forms.Button();
                this.buttonNewContact = new System.Windows.Forms.Button();
                this.label3 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.textBoxLastName = new System.Windows.Forms.TextBox();
                this.textBoxPreferredName = new System.Windows.Forms.TextBox();
                this.textBoxFirstName = new System.Windows.Forms.TextBox();
                this.splitContainerMain.Panel1.SuspendLayout();
                this.splitContainerMain.Panel2.SuspendLayout();
                this.splitContainerMain.SuspendLayout();
                this.groupBoxUserInfo.SuspendLayout();
                this.SuspendLayout();
                // 
                // splitContainerMain
                // 
                this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
                this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
                this.splitContainerMain.Name = "splitContainerMain";
                // 
                // splitContainerMain.Panel1
                // 
                this.splitContainerMain.Panel1.Controls.Add(this.listViewContactList);
                // 
                // splitContainerMain.Panel2
                // 
                this.splitContainerMain.Panel2.Controls.Add(this.groupBoxUserInfo);
                this.splitContainerMain.Size = new System.Drawing.Size(492, 423);
                this.splitContainerMain.SplitterDistance = 140;
                this.splitContainerMain.TabIndex = 0;
                // 
                // listViewContactList
                // 
                this.listViewContactList.Dock = System.Windows.Forms.DockStyle.Fill;
                this.listViewContactList.Location = new System.Drawing.Point(0, 0);
                this.listViewContactList.Name = "listViewContactList";
                this.listViewContactList.Size = new System.Drawing.Size(140, 423);
                this.listViewContactList.TabIndex = 0;
                this.listViewContactList.UseCompatibleStateImageBehavior = false;
                // 
                // groupBoxUserInfo
                // 
                this.groupBoxUserInfo.Controls.Add(this.maskedTextBoxUtcOffset);
                this.groupBoxUserInfo.Controls.Add(this.label4);
                this.groupBoxUserInfo.Controls.Add(this.buttonSaveContact);
                this.groupBoxUserInfo.Controls.Add(this.buttonDeleteContact);
                this.groupBoxUserInfo.Controls.Add(this.buttonNewContact);
                this.groupBoxUserInfo.Controls.Add(this.label3);
                this.groupBoxUserInfo.Controls.Add(this.label2);
                this.groupBoxUserInfo.Controls.Add(this.label1);
                this.groupBoxUserInfo.Controls.Add(this.textBoxLastName);
                this.groupBoxUserInfo.Controls.Add(this.textBoxPreferredName);
                this.groupBoxUserInfo.Controls.Add(this.textBoxFirstName);
                this.groupBoxUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
                this.groupBoxUserInfo.Location = new System.Drawing.Point(0, 0);
                this.groupBoxUserInfo.MinimumSize = new System.Drawing.Size(348, 423);
                this.groupBoxUserInfo.Name = "groupBoxUserInfo";
                this.groupBoxUserInfo.Size = new System.Drawing.Size(348, 423);
                this.groupBoxUserInfo.TabIndex = 0;
                this.groupBoxUserInfo.TabStop = false;
                this.groupBoxUserInfo.Text = "User Information";
                // 
                // maskedTextBoxUtcOffset
                // 
                this.maskedTextBoxUtcOffset.Location = new System.Drawing.Point(7, 161);
                this.maskedTextBoxUtcOffset.Mask = "##";
                this.maskedTextBoxUtcOffset.Name = "maskedTextBoxUtcOffset";
                this.maskedTextBoxUtcOffset.Size = new System.Drawing.Size(82, 20);
                this.maskedTextBoxUtcOffset.TabIndex = 9;
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(7, 145);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(60, 13);
                this.label4.TabIndex = 8;
                this.label4.Text = "UTC Offset";
                // 
                // buttonSaveContact
                // 
                this.buttonSaveContact.Location = new System.Drawing.Point(99, 196);
                this.buttonSaveContact.Name = "buttonSaveContact";
                this.buttonSaveContact.Size = new System.Drawing.Size(83, 33);
                this.buttonSaveContact.TabIndex = 0;
                this.buttonSaveContact.Text = "Save";
                this.buttonSaveContact.UseVisualStyleBackColor = true;
                this.buttonSaveContact.Click += new System.EventHandler(this.buttonSaveContact_Click);
                // 
                // buttonDeleteContact
                // 
                this.buttonDeleteContact.Location = new System.Drawing.Point(215, 196);
                this.buttonDeleteContact.Name = "buttonDeleteContact";
                this.buttonDeleteContact.Size = new System.Drawing.Size(83, 33);
                this.buttonDeleteContact.TabIndex = 7;
                this.buttonDeleteContact.Text = "Delete";
                this.buttonDeleteContact.UseVisualStyleBackColor = true;
                // 
                // buttonNewContact
                // 
                this.buttonNewContact.Location = new System.Drawing.Point(7, 196);
                this.buttonNewContact.Name = "buttonNewContact";
                this.buttonNewContact.Size = new System.Drawing.Size(83, 33);
                this.buttonNewContact.TabIndex = 6;
                this.buttonNewContact.Text = "New";
                this.buttonNewContact.UseVisualStyleBackColor = true;
                this.buttonNewContact.Click += new System.EventHandler(this.buttonNewContact_Click);
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(7, 63);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(58, 13);
                this.label3.TabIndex = 5;
                this.label3.Text = "Last Name";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(7, 104);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(81, 13);
                this.label2.TabIndex = 4;
                this.label2.Text = "Preferred Name";
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(7, 22);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(57, 13);
                this.label1.TabIndex = 3;
                this.label1.Text = "First Name";
                // 
                // textBoxLastName
                // 
                this.textBoxLastName.Location = new System.Drawing.Point(7, 80);
                this.textBoxLastName.Name = "textBoxLastName";
                this.textBoxLastName.Size = new System.Drawing.Size(291, 20);
                this.textBoxLastName.TabIndex = 1;
                // 
                // textBoxPreferredName
                // 
                this.textBoxPreferredName.Location = new System.Drawing.Point(7, 121);
                this.textBoxPreferredName.Name = "textBoxPreferredName";
                this.textBoxPreferredName.Size = new System.Drawing.Size(291, 20);
                this.textBoxPreferredName.TabIndex = 2;
                // 
                // textBoxFirstName
                // 
                this.textBoxFirstName.Location = new System.Drawing.Point(7, 39);
                this.textBoxFirstName.Name = "textBoxFirstName";
                this.textBoxFirstName.Size = new System.Drawing.Size(291, 20);
                this.textBoxFirstName.TabIndex = 0;
                // 
                // frmMain
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(492, 423);
                this.Controls.Add(this.splitContainerMain);
                //this.MaximumSize = new System.Drawing.Size(516, 488);
                this.MinimumSize = new System.Drawing.Size(516, 488);
                this.Name = "frmMain";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Contact Manager";
                this.Load += new System.EventHandler(this.frmMain_Load);
                this.splitContainerMain.Panel1.ResumeLayout(false);
                this.splitContainerMain.Panel2.ResumeLayout(false);
                this.splitContainerMain.ResumeLayout(false);
                this.groupBoxUserInfo.ResumeLayout(false);
                this.groupBoxUserInfo.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.SplitContainer splitContainerMain;
            private System.Windows.Forms.ListView listViewContactList;
            private System.Windows.Forms.GroupBox groupBoxUserInfo;
            private System.Windows.Forms.Button buttonSaveContact;
            private System.Windows.Forms.Button buttonDeleteContact;
            private System.Windows.Forms.Button buttonNewContact;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox textBoxLastName;
            private System.Windows.Forms.TextBox textBoxPreferredName;
            private System.Windows.Forms.TextBox textBoxFirstName;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.MaskedTextBox maskedTextBoxUtcOffset;
        }
    }
}

