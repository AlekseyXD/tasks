using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacDelegate
{
    public delegate void Message(Person person);
    public class MessageServer
    {
        public Message MesHand;

        public void SendMessage(Person person)
        {
            MesHand?.Invoke(person);
        }
       
    }
}
