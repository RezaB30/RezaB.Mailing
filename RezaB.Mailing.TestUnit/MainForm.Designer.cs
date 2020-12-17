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
            this.receiver_label = new System.Windows.Forms.Label();
            this.content_label = new System.Windows.Forms.Label();
            this.content_textbox = new System.Windows.Forms.TextBox();
            this.sendMail_button = new System.Windows.Forms.Button();
            this.subject_label = new System.Windows.Forms.Label();
            this.subject_textbox = new System.Windows.Forms.TextBox();
            this.MailGroupbox = new System.Windows.Forms.GroupBox();
            this.Receiver_Textbox = new System.Windows.Forms.TextBox();
            this.Cc_Textbox = new System.Windows.Forms.TextBox();
            this.Cc_Label = new System.Windows.Forms.Label();
            this.Bcc_Textbox = new System.Windows.Forms.TextBox();
            this.Bcc = new System.Windows.Forms.Label();
            this.AttachmentGroupbox = new System.Windows.Forms.GroupBox();
            this.RemoveAttachmentButton = new System.Windows.Forms.Button();
            this.AttachmentsListbox = new System.Windows.Forms.ListBox();
            this.AddAttachmentButton = new System.Windows.Forms.Button();
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
            this.DownloadAttachments_Button = new System.Windows.Forms.Button();
            this.DownloadAttachment_ListBox = new System.Windows.Forms.ListBox();
            this.Cc_Read_Textbox = new System.Windows.Forms.TextBox();
            this.CcLabel = new System.Windows.Forms.Label();
            this.Sender_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectRead_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContentRead_TextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Settings_Save_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pop3_Hostport_Textbox = new System.Windows.Forms.TextBox();
            this.Pop3_Hostname_Textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Pop3_Password_Textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Pop3_Username_Textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Smtp_Hostport_Textbox = new System.Windows.Forms.TextBox();
            this.Smtp_Hostname_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Smtp_Password_Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Smtp_Username_Textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MailGroupbox.SuspendLayout();
            this.AttachmentGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReadMail)).BeginInit();
            this.ReceiveGroupBox.SuspendLayout();
            this.MailTabControl.SuspendLayout();
            this.SendMailTabPage.SuspendLayout();
            this.ContentTypeGroupbox.SuspendLayout();
            this.ReadMailTabPage.SuspendLayout();
            this.ReceiveReadSingleMailGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.content_label.Location = new System.Drawing.Point(6, 155);
            this.content_label.Name = "content_label";
            this.content_label.Size = new System.Drawing.Size(47, 13);
            this.content_label.TabIndex = 4;
            this.content_label.Text = "Content:";
            // 
            // content_textbox
            // 
            this.content_textbox.Location = new System.Drawing.Point(71, 155);
            this.content_textbox.Multiline = true;
            this.content_textbox.Name = "content_textbox";
            this.content_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.content_textbox.Size = new System.Drawing.Size(282, 61);
            this.content_textbox.TabIndex = 5;
            // 
            // sendMail_button
            // 
            this.sendMail_button.Location = new System.Drawing.Point(393, 446);
            this.sendMail_button.Name = "sendMail_button";
            this.sendMail_button.Size = new System.Drawing.Size(81, 29);
            this.sendMail_button.TabIndex = 6;
            this.sendMail_button.Text = "Send";
            this.sendMail_button.UseVisualStyleBackColor = true;
            this.sendMail_button.Click += new System.EventHandler(this.sendMail_button_Click);
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(6, 119);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(46, 13);
            this.subject_label.TabIndex = 7;
            this.subject_label.Text = "Subject:";
            // 
            // subject_textbox
            // 
            this.subject_textbox.Location = new System.Drawing.Point(71, 119);
            this.subject_textbox.Name = "subject_textbox";
            this.subject_textbox.Size = new System.Drawing.Size(282, 20);
            this.subject_textbox.TabIndex = 8;
            // 
            // MailGroupbox
            // 
            this.MailGroupbox.Controls.Add(this.Receiver_Textbox);
            this.MailGroupbox.Controls.Add(this.Cc_Textbox);
            this.MailGroupbox.Controls.Add(this.Cc_Label);
            this.MailGroupbox.Controls.Add(this.Bcc_Textbox);
            this.MailGroupbox.Controls.Add(this.Bcc);
            this.MailGroupbox.Controls.Add(this.AttachmentGroupbox);
            this.MailGroupbox.Controls.Add(this.receiver_label);
            this.MailGroupbox.Controls.Add(this.subject_label);
            this.MailGroupbox.Controls.Add(this.subject_textbox);
            this.MailGroupbox.Controls.Add(this.content_label);
            this.MailGroupbox.Controls.Add(this.content_textbox);
            this.MailGroupbox.Location = new System.Drawing.Point(28, 131);
            this.MailGroupbox.Name = "MailGroupbox";
            this.MailGroupbox.Size = new System.Drawing.Size(455, 315);
            this.MailGroupbox.TabIndex = 13;
            this.MailGroupbox.TabStop = false;
            this.MailGroupbox.Text = "Mail";
            // 
            // Receiver_Textbox
            // 
            this.Receiver_Textbox.Location = new System.Drawing.Point(71, 19);
            this.Receiver_Textbox.Name = "Receiver_Textbox";
            this.Receiver_Textbox.Size = new System.Drawing.Size(282, 20);
            this.Receiver_Textbox.TabIndex = 19;
            // 
            // Cc_Textbox
            // 
            this.Cc_Textbox.Location = new System.Drawing.Point(71, 51);
            this.Cc_Textbox.Name = "Cc_Textbox";
            this.Cc_Textbox.Size = new System.Drawing.Size(282, 20);
            this.Cc_Textbox.TabIndex = 18;
            // 
            // Cc_Label
            // 
            this.Cc_Label.AutoSize = true;
            this.Cc_Label.Location = new System.Drawing.Point(6, 54);
            this.Cc_Label.Name = "Cc_Label";
            this.Cc_Label.Size = new System.Drawing.Size(20, 13);
            this.Cc_Label.TabIndex = 17;
            this.Cc_Label.Text = "Cc";
            // 
            // Bcc_Textbox
            // 
            this.Bcc_Textbox.Location = new System.Drawing.Point(71, 84);
            this.Bcc_Textbox.Name = "Bcc_Textbox";
            this.Bcc_Textbox.Size = new System.Drawing.Size(282, 20);
            this.Bcc_Textbox.TabIndex = 16;
            // 
            // Bcc
            // 
            this.Bcc.AutoSize = true;
            this.Bcc.Location = new System.Drawing.Point(6, 84);
            this.Bcc.Name = "Bcc";
            this.Bcc.Size = new System.Drawing.Size(26, 13);
            this.Bcc.TabIndex = 15;
            this.Bcc.Text = "Bcc";
            // 
            // AttachmentGroupbox
            // 
            this.AttachmentGroupbox.Controls.Add(this.RemoveAttachmentButton);
            this.AttachmentGroupbox.Controls.Add(this.AttachmentsListbox);
            this.AttachmentGroupbox.Controls.Add(this.AddAttachmentButton);
            this.AttachmentGroupbox.Location = new System.Drawing.Point(15, 222);
            this.AttachmentGroupbox.Name = "AttachmentGroupbox";
            this.AttachmentGroupbox.Size = new System.Drawing.Size(431, 87);
            this.AttachmentGroupbox.TabIndex = 14;
            this.AttachmentGroupbox.TabStop = false;
            this.AttachmentGroupbox.Text = "Attachment";
            // 
            // RemoveAttachmentButton
            // 
            this.RemoveAttachmentButton.Location = new System.Drawing.Point(347, 52);
            this.RemoveAttachmentButton.Name = "RemoveAttachmentButton";
            this.RemoveAttachmentButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveAttachmentButton.TabIndex = 16;
            this.RemoveAttachmentButton.Text = "Remove";
            this.RemoveAttachmentButton.UseVisualStyleBackColor = true;
            this.RemoveAttachmentButton.Click += new System.EventHandler(this.RemoveAttachmentButton_Click);
            // 
            // AttachmentsListbox
            // 
            this.AttachmentsListbox.FormattingEnabled = true;
            this.AttachmentsListbox.Location = new System.Drawing.Point(56, 19);
            this.AttachmentsListbox.Name = "AttachmentsListbox";
            this.AttachmentsListbox.Size = new System.Drawing.Size(285, 56);
            this.AttachmentsListbox.TabIndex = 15;
            // 
            // AddAttachmentButton
            // 
            this.AddAttachmentButton.Location = new System.Drawing.Point(347, 19);
            this.AddAttachmentButton.Name = "AddAttachmentButton";
            this.AddAttachmentButton.Size = new System.Drawing.Size(75, 23);
            this.AddAttachmentButton.TabIndex = 0;
            this.AddAttachmentButton.Text = "Add File";
            this.AddAttachmentButton.UseVisualStyleBackColor = true;
            this.AddAttachmentButton.Click += new System.EventHandler(this.HtmlAttachmentBrowseButton_Click);
            // 
            // OpenAttachmentDialog
            // 
            this.OpenAttachmentDialog.FileName = "OpenAttachmentDialog";
            // 
            // DataGridReadMail
            // 
            this.DataGridReadMail.AllowUserToAddRows = false;
            this.DataGridReadMail.AllowUserToDeleteRows = false;
            this.DataGridReadMail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridReadMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridReadMail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridReadMail.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridReadMail.Location = new System.Drawing.Point(19, 36);
            this.DataGridReadMail.MultiSelect = false;
            this.DataGridReadMail.Name = "DataGridReadMail";
            this.DataGridReadMail.ReadOnly = true;
            this.DataGridReadMail.RowHeadersWidth = 10;
            this.DataGridReadMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridReadMail.ShowEditingIcon = false;
            this.DataGridReadMail.Size = new System.Drawing.Size(422, 355);
            this.DataGridReadMail.TabIndex = 14;
            this.DataGridReadMail.SelectionChanged += new System.EventHandler(this.DataGridReadMail_SelectionChanged);
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
            this.MailTabControl.Controls.Add(this.tabPage1);
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
            this.SendMailTabPage.Controls.Add(this.sendMail_button);
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
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.DownloadAttachments_Button);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.DownloadAttachment_ListBox);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.Cc_Read_Textbox);
            this.ReceiveReadSingleMailGroupBox.Controls.Add(this.CcLabel);
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
            // DownloadAttachments_Button
            // 
            this.DownloadAttachments_Button.Location = new System.Drawing.Point(355, 409);
            this.DownloadAttachments_Button.Name = "DownloadAttachments_Button";
            this.DownloadAttachments_Button.Size = new System.Drawing.Size(75, 23);
            this.DownloadAttachments_Button.TabIndex = 21;
            this.DownloadAttachments_Button.Text = "Download";
            this.DownloadAttachments_Button.UseVisualStyleBackColor = true;
            this.DownloadAttachments_Button.Click += new System.EventHandler(this.DownloadAttachments_Button_Click);
            // 
            // DownloadAttachment_ListBox
            // 
            this.DownloadAttachment_ListBox.FormattingEnabled = true;
            this.DownloadAttachment_ListBox.Location = new System.Drawing.Point(112, 360);
            this.DownloadAttachment_ListBox.Name = "DownloadAttachment_ListBox";
            this.DownloadAttachment_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.DownloadAttachment_ListBox.Size = new System.Drawing.Size(318, 43);
            this.DownloadAttachment_ListBox.TabIndex = 20;
            // 
            // Cc_Read_Textbox
            // 
            this.Cc_Read_Textbox.Location = new System.Drawing.Point(112, 76);
            this.Cc_Read_Textbox.Name = "Cc_Read_Textbox";
            this.Cc_Read_Textbox.Size = new System.Drawing.Size(318, 20);
            this.Cc_Read_Textbox.TabIndex = 19;
            // 
            // CcLabel
            // 
            this.CcLabel.AutoSize = true;
            this.CcLabel.Location = new System.Drawing.Point(38, 76);
            this.CcLabel.Name = "CcLabel";
            this.CcLabel.Size = new System.Drawing.Size(20, 13);
            this.CcLabel.TabIndex = 17;
            this.CcLabel.Text = "Cc";
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
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subject:";
            // 
            // SubjectRead_TextBox
            // 
            this.SubjectRead_TextBox.Location = new System.Drawing.Point(112, 129);
            this.SubjectRead_TextBox.Name = "SubjectRead_TextBox";
            this.SubjectRead_TextBox.Size = new System.Drawing.Size(318, 20);
            this.SubjectRead_TextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Content:";
            // 
            // ContentRead_TextBox
            // 
            this.ContentRead_TextBox.Location = new System.Drawing.Point(112, 166);
            this.ContentRead_TextBox.Multiline = true;
            this.ContentRead_TextBox.Name = "ContentRead_TextBox";
            this.ContentRead_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentRead_TextBox.Size = new System.Drawing.Size(318, 189);
            this.ContentRead_TextBox.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Settings_Save_Button);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1049, 488);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Settings_Save_Button
            // 
            this.Settings_Save_Button.Location = new System.Drawing.Point(309, 439);
            this.Settings_Save_Button.Name = "Settings_Save_Button";
            this.Settings_Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Settings_Save_Button.TabIndex = 4;
            this.Settings_Save_Button.Text = "SAVE";
            this.Settings_Save_Button.UseVisualStyleBackColor = true;
            this.Settings_Save_Button.Click += new System.EventHandler(this.Settings_Save_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pop3_Hostport_Textbox);
            this.groupBox2.Controls.Add(this.Pop3_Hostname_Textbox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Pop3_Password_Textbox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Pop3_Username_Textbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(31, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "POP3";
            // 
            // Pop3_Hostport_Textbox
            // 
            this.Pop3_Hostport_Textbox.Location = new System.Drawing.Point(78, 49);
            this.Pop3_Hostport_Textbox.Name = "Pop3_Hostport_Textbox";
            this.Pop3_Hostport_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Pop3_Hostport_Textbox.TabIndex = 12;
            // 
            // Pop3_Hostname_Textbox
            // 
            this.Pop3_Hostname_Textbox.Location = new System.Drawing.Point(78, 19);
            this.Pop3_Hostname_Textbox.Name = "Pop3_Hostname_Textbox";
            this.Pop3_Hostname_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Pop3_Hostname_Textbox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "HostPort";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "HostName";
            // 
            // Pop3_Password_Textbox
            // 
            this.Pop3_Password_Textbox.Location = new System.Drawing.Point(78, 126);
            this.Pop3_Password_Textbox.Name = "Pop3_Password_Textbox";
            this.Pop3_Password_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Pop3_Password_Textbox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Password";
            // 
            // Pop3_Username_Textbox
            // 
            this.Pop3_Username_Textbox.Location = new System.Drawing.Point(78, 88);
            this.Pop3_Username_Textbox.Name = "Pop3_Username_Textbox";
            this.Pop3_Username_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Pop3_Username_Textbox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "UserName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Smtp_Hostport_Textbox);
            this.groupBox1.Controls.Add(this.Smtp_Hostname_Textbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Smtp_Password_Textbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Smtp_Username_Textbox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMTP";
            // 
            // Smtp_Hostport_Textbox
            // 
            this.Smtp_Hostport_Textbox.Location = new System.Drawing.Point(84, 55);
            this.Smtp_Hostport_Textbox.Name = "Smtp_Hostport_Textbox";
            this.Smtp_Hostport_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Smtp_Hostport_Textbox.TabIndex = 20;
            // 
            // Smtp_Hostname_Textbox
            // 
            this.Smtp_Hostname_Textbox.Location = new System.Drawing.Point(84, 25);
            this.Smtp_Hostname_Textbox.Name = "Smtp_Hostname_Textbox";
            this.Smtp_Hostname_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Smtp_Hostname_Textbox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "HostPort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "HostName";
            // 
            // Smtp_Password_Textbox
            // 
            this.Smtp_Password_Textbox.Location = new System.Drawing.Point(84, 132);
            this.Smtp_Password_Textbox.Name = "Smtp_Password_Textbox";
            this.Smtp_Password_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Smtp_Password_Textbox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // Smtp_Username_Textbox
            // 
            this.Smtp_Username_Textbox.Location = new System.Drawing.Point(84, 94);
            this.Smtp_Username_Textbox.Name = "Smtp_Username_Textbox";
            this.Smtp_Username_Textbox.Size = new System.Drawing.Size(245, 20);
            this.Smtp_Username_Textbox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "UserName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 513);
            this.Controls.Add(this.MailTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MailServiceForm";
            this.Load += new System.EventHandler(this.MailServiceForm_Load_1);
            this.MailGroupbox.ResumeLayout(false);
            this.MailGroupbox.PerformLayout();
            this.AttachmentGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReadMail)).EndInit();
            this.ReceiveGroupBox.ResumeLayout(false);
            this.MailTabControl.ResumeLayout(false);
            this.SendMailTabPage.ResumeLayout(false);
            this.ContentTypeGroupbox.ResumeLayout(false);
            this.ContentTypeGroupbox.PerformLayout();
            this.ReadMailTabPage.ResumeLayout(false);
            this.ReceiveReadSingleMailGroupBox.ResumeLayout(false);
            this.ReceiveReadSingleMailGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label receiver_label;
        private System.Windows.Forms.Label content_label;
        private System.Windows.Forms.TextBox content_textbox;
        private System.Windows.Forms.Button sendMail_button;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox subject_textbox;
        private System.Windows.Forms.GroupBox MailGroupbox;
        private System.Windows.Forms.GroupBox AttachmentGroupbox;
        private System.Windows.Forms.Button AddAttachmentButton;
        private System.Windows.Forms.OpenFileDialog OpenAttachmentDialog;
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
        private System.Windows.Forms.ListBox AttachmentsListbox;
        private System.Windows.Forms.Button RemoveAttachmentButton;
        private System.Windows.Forms.Label Bcc;
        private System.Windows.Forms.TextBox Cc_Textbox;
        private System.Windows.Forms.Label Cc_Label;
        private System.Windows.Forms.TextBox Bcc_Textbox;
        private System.Windows.Forms.TextBox Receiver_Textbox;
        private System.Windows.Forms.TextBox Cc_Read_Textbox;
        private System.Windows.Forms.Label CcLabel;
        private System.Windows.Forms.Button DownloadAttachments_Button;
        private System.Windows.Forms.ListBox DownloadAttachment_ListBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Pop3_Password_Textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Pop3_Username_Textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pop3_Hostport_Textbox;
        private System.Windows.Forms.TextBox Pop3_Hostname_Textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Settings_Save_Button;
        private System.Windows.Forms.TextBox Smtp_Hostport_Textbox;
        private System.Windows.Forms.TextBox Smtp_Hostname_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Smtp_Password_Textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Smtp_Username_Textbox;
        private System.Windows.Forms.Label label12;
    }
}

