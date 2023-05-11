using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{

    public class Message
    {
        //properties
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }

        public void SendMessage(IMessageSend sender, bool isHTML)
        {
            if (isHTML)
                Body = ConvertBodyToHTML(Body);

            sender.SendMessage(this);
        }

        private string ConvertBodyToHTML(string plainText)
        {
            return "<html><body>" + plainText + "</body></html>";
        }
    }
}