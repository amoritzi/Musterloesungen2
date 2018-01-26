using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_7._1_Delegates
{
    public delegate void SendHandler(string word);
    class MessageManager
    {
        public SendHandler Senders;

        public void Send(string word)
        {
            if (Senders != null)
            {
                Senders(word);
            }
        }
    }
}
