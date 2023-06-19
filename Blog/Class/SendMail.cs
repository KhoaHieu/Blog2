using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Blog.Class
{
    public class SendMail
    {
        static NetworkCredential login;
        static SmtpClient client;
        static MailMessage msg;

        public static void config()
        {
            login = new NetworkCredential("nhapmonlaptrinhcsharp@gmail.com", "wvtdxbgadipbjqjm");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
        }

        public static void send(string to, string subject, string body)
        {
            config();
            msg = new MailMessage { From = new MailAddress("nhapmonlaptrinhcsharp@gmail.com", "Supperman", Encoding.UTF8) };
            msg.To.Add(to);
            msg.Subject = subject;
            msg.Body = body;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += Client_SendCompleted;
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }

        public static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("send canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (e.Error != null)
                MessageBox.Show(e.Error.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Mail already send, check your email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
