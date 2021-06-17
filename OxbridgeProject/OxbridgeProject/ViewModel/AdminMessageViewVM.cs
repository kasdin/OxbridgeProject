using OxbridgeProject.Model;
using OxbridgeProject.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Input;
using Xamarin.Forms;

namespace OxbridgeProject.ViewModel
{
    class AdminMessageViewVM : BaseViewModel
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string msgbody;

        public string msgBody
        {

            get { return msgbody; }
            set
            {
                msgbody = value;
            }
        }

        public ICommand sendMessage => new Command(async () =>
        {
            HttpClient client = new HttpClient();
            var uri = "http://192.168.1.245:3000/users/x/brodcast";
            
            try
            {
                var jsonSerializer = new JsonSerializerOptions();
                var _message = new Message() { 
                
                    MsgTitle = title,
                    MsgBody = msgbody
                };

                string json = System.Text.Json.JsonSerializer.Serialize<Message>(_message, jsonSerializer);
                StringContent msg = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(uri, msg);

                if (response.IsSuccessStatusCode)
                {

                    Debug.WriteLine(" MESSAGES HAS BEEN SENDED!");
                    title = null;
                    msgbody = null;

                }
            }
            catch (Exception ex){

                Debug.WriteLine(ex.Message);
            }




        });

    }
}
