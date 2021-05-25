using OxbridgeProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OxbridgeProject.ViewModel
{
    class MessageViewVM
    {

        private ObservableCollection<Message> messages = new ObservableCollection<Message>();

        public ObservableCollection<Message> Messages
        {
            get { return messages; }
            set { messages = value; }
        }

        public MessageViewVM()
        {
            Messages.Add(new Message{ Author = "admin", msgBody = "NICE MESSAGE" });
            Console.WriteLine("message");
        }

    }
}
