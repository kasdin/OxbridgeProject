using Newtonsoft.Json;
using OxbridgeProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
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
            GetMessages();
        }
        public async void GetMessages() {

            HttpClient client = new HttpClient();
            var uri = "http://192.168.1.245:3000/users/x/message";
            try {

                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode) {

                    string content = await response.Content.ReadAsStringAsync();
                    List<Message> messageList = JsonConvert.DeserializeObject<List<Message>>(content);
                    Messages = new ObservableCollection<Message>(messageList);
                }
            
            } catch (Exception ex) { 
            
            }



        }
    }
}
