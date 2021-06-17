
using OxbridgeProject.Model;
using OxbridgeProject.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Text.Json;
using Newtonsoft.Json;

namespace OxbridgeProject.ViewModel
{
    class loginViewVM : BaseViewModel
    {
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string pass;

        public string Password { 
       
            get { return pass; }
            set { pass = value; }
        }
        /*
         * GATHERING DATA
         * 
         */
        
        



        /**
         * COMMANDS 
         */
        public ICommand LogIn => new Command(async () => {

            HttpClient client = new HttpClient();
            var uri = "http://192.168.1.245:3000/users/login";
            var _user = new user() ;

            try
            {

                var jsonSer = new JsonSerializerOptions();
                var newUser = new user()
                {

                    emailUsername = login,
                    password = pass,

                };
                string json = System.Text.Json.JsonSerializer.Serialize<user>(newUser, jsonSer);
                StringContent log = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(uri, log);

                string content = await response.Content.ReadAsStringAsync();
                user user_ = JsonConvert.DeserializeObject<user>(content);
                var token = user_.token;
                _user = new user() {

                    firstname = user_.firstname,
                    lastname = user_.lastname,
                    role = user_.role,
                    emailUsername = user_.emailUsername,
                    token = user_.token
                };

                if (_user.role.Equals("admin"))
                {
                    if (isBusy)
                    {
                        return;
                    }
                    isBusy = true;
                    await App.Current.MainPage.Navigation.PushAsync(new adminView());
                    isBusy = false;


                }
                if (_user.role.Equals("user"))
                {
                    {
                        if (isBusy)
                        {
                            return;
                        }
                        isBusy = true;
                        await App.Current.MainPage.Navigation.PushAsync(new OptionView());
                        isBusy = false;
                    }
                }



                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Logged IN: "+ token);
                }

            }
            catch (Exception x)
            {
                Debug.WriteLine(@" Error {0}", x.Message);
              
            }

            
            });

        public loginViewVM()
        {

        }

    }
}

