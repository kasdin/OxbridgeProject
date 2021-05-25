using OxbridgeProject.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OxbridgeProject.ViewModel
{
    class AdminViewVM : BaseViewModel
    {



        public ICommand goMessageView => new Command(async () =>
        {


            if (isBusy)
            {
                return;
            }
            isBusy = true;
            await App.Current.MainPage.Navigation.PushAsync(new AdminMessageView());
            isBusy = false;



        });
    }
}
