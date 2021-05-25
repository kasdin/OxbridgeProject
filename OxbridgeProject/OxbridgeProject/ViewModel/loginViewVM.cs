using OxbridgeProject.View;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

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
        private SecureString password;

        public SecureString Password
        {
            get { return password; }
            set { password = value; }
        }
        /*
         * GATHERING DATA
         * 
         */





        /**
         * COMMANDS 
         */
        public ICommand LogIn => new Command(async () => {

            if (login.Equals("admin"))
            {
                if (isBusy)
                {
                    return;
                }
                isBusy = true;
                await App.Current.MainPage.Navigation.PushAsync(new adminView());
                isBusy = false;


            }
            else
            {
                if (isBusy)
                {
                    return;
                }
                isBusy = true;
                await App.Current.MainPage.Navigation.PushAsync(new OptionView());
                isBusy = false;
            }
            });

        public loginViewVM()
        {

        }

    }
}

