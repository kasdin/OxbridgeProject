using System;
using System.Collections.Generic;
using System.Text;

namespace OxbridgeProject.ViewModel
{
    class AdminViewVM : BaseViewModel
    {



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
        }
}
