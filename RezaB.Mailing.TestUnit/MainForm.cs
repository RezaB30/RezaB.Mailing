using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using RezaB.Mailing;
using RezaB.Mailing.Client;
using System.Collections;
using System.Text.RegularExpressions;
using System.Web;




namespace RezaB.Mailing.TestUnit
{

    public partial class MainForm : Form
    {

        DataTable mailListDataSource;

        public MainForm()
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;
            InitializeComponent();
            mailListDataSource = new DataTable();
            mailListDataSource.Columns.Add("UUID");
            mailListDataSource.Columns.Add("From");
            mailListDataSource.Columns.Add("Subject");
            DataGridReadMail.DataSource = mailListDataSource;
        }


        private void MailServiceForm_Load_1(object sender, EventArgs e)
        {
            var temp = Enum.GetValues(typeof(MailBodyType)).Cast<int>();

            content_type_combobox.DisplayMember = "Name";
            content_type_combobox.ValueMember = "Value";
            content_type_combobox.DataSource = temp.Select(t => new { Name = Enum.GetName(typeof(MailBodyType), t), Value = (int)t }).ToList();

            filterContentType();

            try
            {
                LoadSettings();
            }
            catch (Exception)
            {

                MessageBox.Show("Check the Settings");
            }

        }

        private object GetMails()
        {
            throw new NotImplementedException();
        }

        private void sendMail_button_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            MainForm client = new MainForm();



            MailClient mailClient = new MailClient(Smtp_Hostname_Textbox.Text, Convert.ToInt32(Smtp_Hostport_Textbox.Text), false, Smtp_Username_Textbox.Text, Smtp_Password_Textbox.Text);

            // read and prepare attachment files (using)

            var mailTo = string.IsNullOrWhiteSpace(Receiver_Textbox.Text) ? null : Receiver_Textbox.Text.Split(';');
            var mailCc = string.IsNullOrWhiteSpace(Cc_Textbox.Text) ? null : Cc_Textbox.Text.Split(';');
            var mailBc = string.IsNullOrWhiteSpace(Bcc_Textbox.Text) ? null : Bcc_Textbox.Text.Split(';');

            var mailAttachmentItem = AttachmentsListbox.Items.Cast<AttachmentListItem>().Select(listItem => new MailFileAttachment()
            {
                FileName = listItem.DisplayName,
                Content = File.OpenRead(listItem.FilePath)
            });
            var mailAttachment = string.IsNullOrWhiteSpace(mailAttachmentItem.ToString()) ? null : mailAttachmentItem;

            var mailMessage = new StandardMailMessage(mailClient.Username, mailTo, mailCc, mailBc, subject_textbox.Text, content_textbox.Text, null, mailAttachment);

            mailClient.SendMail(mailMessage);
        }




        private void HtmlFileBrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.CheckFileExists = dialog.CheckPathExists = true;
            dialog.Filter = "Html Files (*.html,*.htm)|*.html;*.htm";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                HtmlFileTextbox.Text = dialog.FileName;
                content_textbox.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void content_type_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterContentType();
        }

        private void filterContentType()
        {
            if ((int)content_type_combobox.SelectedValue == (int)MailBodyType.HTML)
            {
                content_textbox.ReadOnly = true;
                HtmlFileBrowseButton.Enabled = true;
            }
            else
            {
                content_textbox.ReadOnly = false;
                HtmlFileBrowseButton.Enabled = false;
            }
        }

        private void HtmlAttachmentBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string directory = string.Empty;
            string fileName = string.Empty;
            ofd.Filter = "All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var listItem = new AttachmentListItem()
                {
                    DisplayName = ofd.SafeFileName,
                    FilePath = ofd.FileName
                };
                AttachmentsListbox.Items.Add(listItem);
            }
        }



        private void ReceiveMail_Button_Click(object sender, EventArgs e)
        {
            DataGridReadMail.SelectionChanged -= DataGridReadMail_SelectionChanged;
            MailClient client = new MailClient(Pop3_Hostname_Textbox.Text, Convert.ToInt32(Pop3_Hostport_Textbox.Text), false, Pop3_Username_Textbox.Text, Pop3_Password_Textbox.Text);
            var mailList = client.GetAllInboxMessages();
            mailListDataSource.Rows.Clear();
            foreach (var item in mailList)
            {
                mailListDataSource.Rows.Add(item.UUID, item.From, item.Subject);
            }
            DataGridReadMail.AutoResizeColumns();
            DataGridReadMail.SelectionChanged += DataGridReadMail_SelectionChanged;
            DataGridReadMail.ClearSelection();
        }

        private void RemoveAttachmentButton_Click(object sender, EventArgs e)
        {
            AttachmentsListbox.Items.Remove(AttachmentsListbox.SelectedItem);
        }

        private void DataGridReadMail_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridReadMail.SelectedRows.Count > 0)
            {
                MailClient client = new MailClient(Pop3_Hostname_Textbox.Text, Convert.ToInt32(Pop3_Hostport_Textbox.Text), false, Pop3_Username_Textbox.Text, Pop3_Password_Textbox.Text);

                Width = 1100;
                ReceiveReadSingleMailGroupBox.Visible = true;
                int rowIndex = DataGridReadMail.SelectedRows[0].Index;
                var selectedUUID = mailListDataSource.Rows[rowIndex].ItemArray[0] as string;
                using (var selectedMailMessage = client.GetInboxMessageById(selectedUUID))
                {
                    DownloadAttachment_ListBox.Items.Clear();
                    Sender_TextBox.Text = selectedMailMessage.From;
                    Cc_Read_Textbox.Text = selectedMailMessage.Cc.ToString();
                    SubjectRead_TextBox.Text = selectedMailMessage.Subject;
                    ContentRead_TextBox.Text = selectedMailMessage.Body;

                    if (selectedMailMessage.Attachments != null)
                    {
                        foreach (var mailAttachment in selectedMailMessage.Attachments)
                        {
                            var listItem = new AttachmentListItem();
                            using (BinaryReader reader = new BinaryReader(mailAttachment.Content))
                            {
                                if (reader.BaseStream.CanSeek)
                                    reader.BaseStream.Seek(0, SeekOrigin.Begin);
                                DownloadAttachment_ListBox.Items.Add(new DownloadedAttachment()
                                {
                                    FileName = mailAttachment.FileName,
                                    Data = reader.ReadBytes((int)reader.BaseStream.Length)
                                });
                            }
                        }
                    }
                }
            }
        }

        private void DownloadAttachments_Button_Click(object sender, EventArgs e)
        {
            if (DownloadAttachment_ListBox.SelectedItems.Count != 0)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var directory = fbd.SelectedPath;

                    foreach (var attachmentItem in DownloadAttachment_ListBox.Items.Cast<DownloadedAttachment>())
                    {
                        File.WriteAllBytes($"{directory}\\{attachmentItem.FileName}", attachmentItem.Data);
                    }
                    MessageBox.Show("File(s) saved.");
                }
            }
        }

        private void Settings_Save_Button_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            builder.AppendLine($"SMTP_Hostname\t{Smtp_Hostname_Textbox.Text}");
            builder.AppendLine($"SMTP_Hostport\t{Smtp_Hostport_Textbox.Text}");
            builder.AppendLine($"SMTP_Username\t{Smtp_Username_Textbox.Text}");
            builder.AppendLine($"SMTP_Password\t{Smtp_Password_Textbox.Text}");

            builder.AppendLine($"POP3_Hostname\t{Pop3_Hostname_Textbox.Text}");
            builder.AppendLine($"POP3_Hostport\t{Pop3_Hostport_Textbox.Text}");
            builder.AppendLine($"POP3_Username\t{Pop3_Username_Textbox.Text}");
            builder.AppendLine($"POP3_Password\t{Pop3_Password_Textbox.Text}");

            var contents = builder.ToString();

            File.WriteAllText("setting.ini", contents);

            MessageBox.Show("Settings saved.");
        }

        private void LoadSettings()
        {

            var readSetting = File.ReadAllLines("setting.ini");

            foreach (var item in readSetting)
            {
                var parts = item.Split('\t');

                switch (parts[0])
                {
                    // SMTP
                    case "SMTP_Hostname":
                        Smtp_Hostname_Textbox.Text = parts[1];
                        break;

                    case "SMTP_Hostport":
                        Smtp_Hostport_Textbox.Text = parts[1];
                        break;

                    case "SMTP_Username":
                        Smtp_Username_Textbox.Text = parts[1];
                        break;

                    case "SMTP_Password":
                        Smtp_Password_Textbox.Text = parts[1];
                        break;

                    // POP3
                    case "POP3_Hostname":
                        Pop3_Hostname_Textbox.Text = parts[1];
                        break;

                    case "POP3_Hostport":
                        Pop3_Hostport_Textbox.Text = parts[1];
                        break;

                    case "POP3_Username":
                        Pop3_Username_Textbox.Text = parts[1];
                        break;

                    case "POP3_Password":
                        Pop3_Password_Textbox.Text = parts[1];
                        break;
                }
            }
        }
    }
}

