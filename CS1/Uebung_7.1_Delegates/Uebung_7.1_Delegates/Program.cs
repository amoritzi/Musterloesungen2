using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_7._1_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageManager messagemanager = new MessageManager();
            SMSSender smsSender = new SMSSender();
            EmailSender emailSender = new EmailSender();

            messagemanager.Senders += new SendHandler(smsSender.Send);
            messagemanager.Senders += new SendHandler(emailSender.Send);

            string text = "testmessage";
            messagemanager.Send(text);
        }
    }
}
