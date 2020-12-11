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

namespace RezaB.Mailing.TestUnit
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;
            InitializeComponent();
        }


        private void MailServiceForm_Load_1(object sender, EventArgs e)
        {

            //var temp = Enum.GetValues(typeof(ContentType)).Cast<int>();

            //content_type_combobox.DisplayMember = "Name";
            //content_type_combobox.ValueMember = "Value";
            //content_type_combobox.DataSource = temp.Select(t => new { Name = Enum.GetName(typeof(ContentType), t), Value = (int)t }).ToList();

            var temp = Enum.GetValues(typeof(MailBodyType)).Cast<int>();

            content_type_combobox.DisplayMember = "Name";
            content_type_combobox.ValueMember = "Value";
            content_type_combobox.DataSource = temp.Select(t => new { Name = Enum.GetName(typeof(MailBodyType), t), Value = (int)t }).ToList();

            filterContentType();

        }

        private object GetMails()
        {
            throw new NotImplementedException();
        }

        private void sendMail_button_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            //MailService.MailServiceClient client = new MailService.MailServiceClient();
            MainForm client = new MainForm();

            MailClient mailClient = new MailClient("elif.findik@netspeed.com.tr", 110, false, "mail.netspeed.com.tr", "FQgb65L0");

            mailClient.SendMail(receiver_textbox.Text, subject_textbox.Text, content_textbox.Text, (MailBodyType)content_type_combobox.SelectedValue, Attachment_Textbox.Text);
            //MailServiceClient client = new MailServiceClient("no-reply@netspeed.com.tr", "JUpc47E0", 587, "mail.netspeed.com.tr", false);
            //client.SendMailMessage(receiver_textbox.Text, subject_textbox.Text, content_textbox.Text, (ContentType)content_type_combobox.SelectedValue, Attachment_Textbox.Text);
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
                directory = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            string path = ofd.FileName.ToString();
            Attachment_Textbox.Text = path;
        }



        private void ReceiveMail_Button_Click(object sender, EventArgs e)
        {
            MailClient client = new MailClient("elif.findik@netspeed.com.tr", 110, false, "mail.netspeed.com.tr", "FQgb65L0");
            var mailList = client.GetAllInboxMessages();

            DataGridReadMail.DataSource = mailList; /*<3*/


        }

        public void DataGridReadMail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MailClient client = new MailClient("elif.findik@netspeed.com.tr", 110, false, "mail.netspeed.com.tr", "FQgb65L0");

            MainForm.ActiveForm.Width = 1100;
            
            ReceiveReadSingleMailGroupBox.Visible = true;

            int rowindex = e.RowIndex;
            DataGridViewRow row = this.DataGridReadMail.Rows[rowindex];
            //client.ReadMail(e.RowIndex);
            
            Sender_TextBox.Text= row.Cells[0].Value.ToString();
            SubjectRead_TextBox.Text= row.Cells[2].Value.ToString();
            ContentRead_TextBox.Text = row.Cells[3].Value.ToString();
            LinkLabelAttachment.Text= row.Cells[4].Value.ToString();
            //DataGridReadSingleMail.DataSource = this.DataGridReadMail.Rows[rowindex];
        }

        private void LinkLabelAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       
    }
}

