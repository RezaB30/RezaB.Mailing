namespace RezaB.Mailing.TestUnit
{
    partial class MainForm
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
            this.receiver_textbox = new System.Windows.Forms.TextBox();
            this.receiver_label = new System.Windows.Forms.Label();
            this.content_label = new System.Windows.Forms.Label();
            this.content_textbox = new System.Windows.Forms.TextBox();
            this.sendMail_button = new System.Windows.Forms.Button();
            this.subject_label = new System.Windows.Forms.Label();
            this.subject_textbox = new System.Windows.Forms.TextBox();
            this.MailGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Attachment_Textbox = new System.Windows.Forms.TextBox();
            this.HtmlAttachmentBrowseButton = new System.Windows.Forms.Button();
            this.OpenAttachmentDialog = new System.Windows.Forms.OpenFileDialog();
            this.DataGridReadMail = new System.Windows.Forms.DataGridView();
            this.ReceiveGroupBox = new System.Windows.Forms.GroupBox();
            this.ReceiveMail_Button = new System.Windows.Forms.Button();
            this.MailTabControl = new System.Windows.Forms.TabControl();
            this.SendMailTabPage = new System.Windows.Forms.TabPage();
            this.ContentTypeGroupbox = new System.Windows.Forms.GroupBox();
            this.HtmlFileBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HtmlFileTextbox = new System.Windows.Forms.TextBox();
            this.contentType_label = new System.Windows.Forms.Label();
            this.content_type_combobox = new System.Windows.Forms.ComboBox();
            this.ReadMailTabPage = new System.Windows.Forms.TabPage();
            this.ReceiveReadSingleMailGroupBox = new System.Windows.Forms.GroupBox();
            this.LinkLabelAttachment = new System.Windows.Forms.LinkLabel();
            this.Sender_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectRead_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContentRead_TextBox = new System.Windows.Forms.TextBox();
            this.MailGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReadMail)).BeginInit();
            this.ReceiveGroupBox.SuspendLayout();
            this.MailTabControl.SuspendLayout();
            this.SendMailTabPage.SuspendLayout();
            this.ContentTypeGroupbox.SuspendLayout();
            this.ReadMailTabPage.SuspendLayout();
            this.ReceiveReadSingleMailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // receiver_textbox
            // 
            this.receiver_textbox.Location = new System.Drawing.Point(83, 19);
            this.receiver_textbox.Name = "receiver_textbox";
            this.receiver_textbox.Size = new System.Drawing.Size(282, 20);
            this.receiver_textbox.TabIndex = 0;
            this.receiver_textbox.Text = "elif.findik@netspeed.com.tr";
            // 
            // receiver_label
            // 
            this.receiver_label.AutoSize = true;
            this.receiver_label.Location = new System.Drawing.Point(6, 22);
            this.receiver_label.Name = "receiver_label";
            this.receiver_label.Size = new System.Drawing.Size(23, 13);
            this.receiver_label.TabIndex = 1;
            this.receiver_label.Text = "To:";
            // 
            // content_label
            // 
            this.content_label.AutoSize = true;
            this.content_label.Location = new System.Drawing.Point(8, 74);
            this.content_label.Name = "content_label";
            this.content_label.Size = new System.Drawing.Size(47, 13);
            this.content_label.TabIndex = 4;
            this.content_label.Text = "Content:";
            // 
            // content_textbox
            // 
            this.content_textbox.Location = new System.Drawing.Point(83, 71);
            this.content_textbox.Multiline = true;
            this.content_textbox.Name = "content_textbox";
            this.content_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.content_textbox.Size = new System.Drawing.Size(282, 109);
            this.content_textbox.TabIndex = 5;
            // 
            // sendMail_button
            // 
            this.sendMail_button.Location = new System.Drawing.Point(365, 270);
            this.sendMail_button.Name = "sendMail_button";
            this.sendMail_button.Size = new System.Drawing.Size(75, 29);
            this.sendMail_button.TabIndex = 6;
            this.sendMail_button.Text = "Send";
            this.sendMail_button.UseVisualStyleBackColor = true;
            this.sendMail_button.Click += new System.EventHandler(this.sendMail_button_Click);
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(8, 48);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(46, 13);
            this.subject_label.TabIndex = 7;
            this.subject_label.Text = "Subject:";
            // 
            // subject_textbox
            // 
            this.subject_textbox.Location = new System.Drawing.Point(83, 45);
            this.subject_textbox.Name = "subject_textbox";
            this.subject_textbox.Size = new System.Drawing.Size(282, 20);
            this.subject_textbox.TabIndex = 8;
            // 
            // MailGroupbox
            // 
            this.MailGroupbox.Controls.Add(this.groupBox1);
            this.MailGroupbox.Controls.Add(this.receiver_label);
            this.MailGroupbox.Controls.Add(this.receiver_textbox);
            this.MailGroupbox.Controls.Add(this.subject_label);
            this.MailGroupbox.Controls.Add(this.subject_textbox);
            this.MailGroupbox.Controls.Add(this.content_label);
            this.MailGroupbox.Controls.Add(this.sendMail_button);
            this.MailGroupbox.Controls.Add(this.content_textbox);
            this.MailGroupbox.Location = new System.Drawing.Point(28, 131);
            this.MailGroupbox.Name = "MailGroupbox";
            this.MailGroupbox.Size = new System.Drawing.Size(455, 315);
            this.MailGroupbox.TabIndex = 13;
            this.MailGroupbox.TabStop = false;
            this.MailGroupbox.Text = "Mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Attachment_Textbox);
            this.groupBox1.Controls.Add(this.HtmlAttachmentBrowseButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 49);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attachment";
            // 
            // Attachment_Textbox
            // 
            this.Attachment_Textbox.Location = new System.Drawing.Point(68, 20);
            this.Attachment_Textbox.Name = "Attachment_Textbox";
            this.Attachment_Textbox.ReadOnly = true;
            this.Attachment_Textbox.Size = new System.Drawing.Size(282, 20);
            this.Attachment_Textbox.TabIndex = 1;
            // 
            // HtmlAttachmentBrowseButton
            // 
            this.HtmlAttachmentBrowseButton.Location = new System.Drawing.Point(350, 19);
            this.HtmlAttachmentBrowseButton.Name = "HtmlAttachmentBrowseButton";
            this.HtmlAttachmentBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.HtmlAttachmentBrowseButton.TabIndex = 0;
            this.HtmlAttachmentBrowseButton.Text = "Add File";
            this.HtmlAttachmentBrowseButton.UseVisualStyleBackColor = true;
            this.HtmlAttachmentBrowseButton.Click += new System.EventHandler(this.HtmlAttachmentBrowseButton_Click);
            // 
            // OpenAttachmentDialog
            // 
            this.OpenAttachmentDialog.FileName = "OpenAttachmentDialog";
            // 
            // DataGridReadMail
            // 
            this.DataGridReadMail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridReadMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridReadMail.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridReadMail.Location = new System.Drawing.Point(19, 36);
            this.DataGridReadMail.Name = "DataGridReadMail";
            this.DataGridReadMail.RowHeadersWidth = 10;
            this.DataGridReadMail.Size = new System.Drawing.Size(422, 355);
            this.DataGridReadMail.TabIndex = 14;
            this.DataGridReadMail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridReadMail_CellContentClick);
            // 
            // ReceiveGroupBox
            // 
            this.ReceiveGroupBox.Controls.Add(this.ReceiveMail_Button);
            this.ReceiveGroupBox.Controls.Add(this.DataGridReadMail);
            this.ReceiveGroupBox.Location = new System.Drawing.Point(29, 17);
            this.ReceiveGroupBox.Name = "ReceiveGroupBox";
            this.ReceiveGroupBox.Size = new System.Drawing.Size(463, 450);
            this.ReceiveGroupBox.TabIndex = 15;
            this.ReceiveGroupBox.TabStop = false;
            this.ReceiveGroupBox.Text = "Receive Mail";
            // 
            // ReceiveMail_Button
            // 
            this.ReceiveMail_Button.Location = new System.Drawing.Point(366, 406);
            this.ReceiveMail_Button.Name = "ReceiveMail_Button";
            this.ReceiveMail_Button.Size = new System.Drawing.Size(75, 23);
            this.ReceiveMail_Button.TabIndex = 15;
            this.ReceiveMail_Button.Text = "Receive Mail";
            this.ReceiveMail_Button.UseVisualStyleBackColor = true;
            this.ReceiveMail_Button.Click += new System.EventHandler(this.ReceiveMail_Button_Click);
            // 
            // MailTabControl
            // 
            this.MailTabControl.Controls.Add(this.SendMailTabPage);
            this.MailTabControl.Controls.Add(this.ReadMailTabPage);
            this.MailTabControl.Location = new System.Drawing.Point(2, 0);
            this.MailTabControl.Name = "MailTabControl";
            this.MailTabControl.SelectedIndex = 0;
            this.MailTabControl.Size = new System.Drawing.Size(1057, 514);
            this.MailTabControl.TabIndex = 16;
            // 
            // SendMailTabPage
            // 
            this.SendMailTabPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SendMailTabPage.Controls.Add(this.ContentTypeGroupbox);
            this.SendMailTabPage.Controls.Add(this.MailGroupbox);
            this.SendMailTabPage.Location = new System.Drawing.Point(4, 22);
            this.SendMailTabPage.Name = "SendMailTabPage";
            this.SendMailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SendMailTabPage.Size = new System.Drawing.Size(1049, 488);
            this.SendMailTabPage.TabIndex = 0;
            this.SendMailTabPage.Text = "Send Mail";
            // 
            // ContentTypeGroupbox
            // 
            this.ContentTypeGroupbox.Controls.Add(this.HtmlFileBrowseButton);
            this.ContentTypeGroupbox.Controls.Add(this.label1);
            this.ContentTypeGroupbox.Controls.Add(this.HtmlFileTextbox);
            this.ContentTypeGroupbox.Controls.Add(this.contentType_label);
            this.ContentTypeGroupbox.Controls.Add(this.content_type_combobox);
            this.ContentTypeGroupbox.Location = new System.Drawing.Point(28, 10);
            this.ContentTypeGroupbox.Name = "ContentTypeGroupbox";
            this.ContentTypeGroupbox.Size = new System.Drawing.Size(455, 106);
            this.ContentTypeGroupbox.TabIndex = 13;
            this.ContentTypeGroupbox.TabStop = false;
            this.ContentTypeGroupbox.Text = "Content Type";
            // 
            // HtmlFileBrowseButton
            // 
            this.HtmlFileBrowseButton.Location = new System.Drawing.Point(371, 45);
            this.HtmlFileBrowseButton.Name = "HtmlFileBrowseButton";
            this.HtmlFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.HtmlFileBrowseButton.TabIndex = 6;
            this.HtmlFileBrowseButton.Text = "Browse";
            this.HtmlFileBrowseButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Html File:";
            // 
            // HtmlFileTextbox
            // 
            this.HtmlFileTextbox.Location = new System.Drawing.Point(83, 47);
            this.HtmlFileTextbox.Name = "HtmlFileTextbox";
            this.HtmlFileTextbox.ReadOnly = true;
            this.HtmlFileTextbox.Size = new System.Drawing.Size(282, 20);
            this.HtmlFileTextbox.TabIndex = 4;
            // 
            // contentType_label
            // 
            this.contentType_label.AutoSize = true;
            this.contentType_label.Location = new System.Drawing.Point(6, 22);
            this.contentType_label.Name = "contentType_label";
            this.contentType_label.Size = new System.Drawing.Size(71, 13);
            this.contentType_label.TabIndex = 2;
            this.contentType_label.Text = "Content Type";
            // 
            // content_type_combobox
            // 
            this.content_type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.content_type_combobox.FormattingEnabled = true;
            this.content_type_combobox.Location = new System.Drawing.Point(83, 19);
            this.content_type_combobox.Name = "content_type_combobox";
            this.content_type_combobox.Size = new System.Drawing.Size(117, 21);
            this.content_type_combobox.TabIndex = 3;
            // 
            // ReadMailTabPage
            // 
            this.ReadMailTabPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReadMailTabPage.Controls.Add(this.ReceiveReadSingleMailGroupBox);
            this.ReadMailTabPage.Controls.Add(this.ReceiveGroupBox);
            this.ReadMailTabPage.Location = new System.Drawing.Point(4, 22);
            this.ReadMailTabPage.Name = "ReadMailTabPage";
            this.ReadMailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReadMailTabPage.Size = new System.Drawing.Size(1049, 488);
            this.ReadMailTabPage.TabIndex = 1;
            this.ReadMailTabPage.Text = "Read Mail";
            // 
            // ReceiveReadSingleMailGroupBox
            // 
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.LinkLabelAttachment);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.Sender_TextBox);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.label2);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.label3);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.SubjectRead_TextBox);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.label4);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.ContentRead_TextBox);
            this.ReceiveReadSingleMailGroupBox.Location = new System.Drawing.Point(524, 17);
            this.ReceiveReadSingleMailGroupBox.Name = "ReceiveReadSingleMailGroupBox";
            this.ReceiveReadSingleMailGroupBox.Size = new System.Drawing.Size(463, 462);
            this.ReceiveReadSingleMailGroupBox.TabIndex = 17;
            this.ReceiveReadSingleMailGroupBox.TabStop = false;
            this.ReceiveReadSingleMailGroupBox.Text = "Read Mail";
            this.ReceiveReadSingleMailGroupBox.Visible = false;
            // 
            // LinkLabelAttachment
            // 
            this.LinkLabelAttachment.AutoSize = true;
            this.LinkLabelAttachment.Location = new System.Drawing.Point(109, 364);
            this.LinkLabelAttachment.Name = "LinkLabelAttachment";
            this.LinkLabelAttachment.Size = new System.Drawing.Size(61, 13);
            this.LinkLabelAttachment.TabIndex = 16;
            this.LinkLabelAttachment.TabStop = true;
            this.LinkLabelAttachment.Text = "Attachment";
            this.LinkLabelAttachment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAttachment_LinkClicked);
            // 
            // Sender_TextBox
            // 
            this.Sender_TextBox.Location = new System.Drawing.Point(112, 48);
            this.Sender_TextBox.Name = "Sender_TextBox";
            this.Sender_TextBox.Size = new System.Drawing.Size(318, 20);
            this.Sender_TextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subject:";
            // 
            // SubjectRead_TextBox
            // 
            this.SubjectRead_TextBox.Location = new System.Drawing.Point(112, 71);
            this.SubjectRead_TextBox.Name = "SubjectRead_TextBox";
            this.SubjectRead_TextBox.Size = new System.Drawing.Size(318, 20);
            this.SubjectRead_TextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Content:";
            // 
            // ContentRead_TextBox
            // 
            this.ContentRead_TextBox.Location = new System.Drawing.Point(112, 97);
            this.ContentRead_TextBox.Multiline = true;
            this.ContentRead_TextBox.Name = "ContentRead_TextBox";
            this.ContentRead_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentRead_TextBox.Size = new System.Drawing.Size(318, 247);
            this.ContentRead_TextBox.TabIndex = 12;
            // 
            // MailServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 513);
            this.Controls.Add(this.MailTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MailServiceForm";
            this.Text = "MailServiceForm";
            this.Load += new System.EventHandler(this.MailServiceForm_Load_1);
            this.MailGroupbox.ResumeLayout(false);
            this.MailGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReadMail)).EndInit();
            this.ReceiveGroupBox.ResumeLayout(false);
            this.MailTabControl.ResumeLayout(false);
            this.SendMailTabPage.ResumeLayout(false);
            this.ContentTypeGroupbox.ResumeLayout(false);
            this.ContentTypeGroupbox.PerformLayout();
            this.ReadMailTabPage.ResumeLayout(false);
            this.ReceiveReadSingleMailGroupBox.ResumeLayout(false);
            this.ReceiveReadSingleMailGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox receiver_textbox;
        private System.Windows.Forms.Label receiver_label;
        private System.Windows.Forms.Label content_label;
        private System.Windows.Forms.TextBox content_textbox;
        private System.Windows.Forms.Button sendMail_button;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox subject_textbox;
        private System.Windows.Forms.GroupBox MailGroupbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button HtmlAttachmentBrowseButton;
        private System.Windows.Forms.OpenFileDialog OpenAttachmentDialog;
        private System.Windows.Forms.TextBox Attachment_Textbox;
        private System.Windows.Forms.DataGridView DataGridReadMail;
        private System.Windows.Forms.GroupBox ReceiveGroupBox;
        private System.Windows.Forms.TabControl MailTabControl;
        private System.Windows.Forms.TabPage SendMailTabPage;
        private System.Windows.Forms.GroupBox ContentTypeGroupbox;
        private System.Windows.Forms.Button HtmlFileBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HtmlFileTextbox;
        private System.Windows.Forms.Label contentType_label;
        private System.Windows.Forms.ComboBox content_type_combobox;
        private System.Windows.Forms.TabPage ReadMailTabPage;
        private System.Windows.Forms.Button ReceiveMail_Button;
        private System.Windows.Forms.GroupBox ReceiveReadSingleMailGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectRead_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContentRead_TextBox;
        private System.Windows.Forms.TextBox Sender_TextBox;
        private System.Windows.Forms.LinkLabel LinkLabelAttachment;
    }
}

