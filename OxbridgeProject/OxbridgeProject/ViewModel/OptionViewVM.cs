using OxbridgeProject.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OxbridgeProject.ViewModel
{
    class OptionViewVM : BaseViewModel
    {
        private string teamName;

        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }


        public ICommand goTeamInfoView => new Command(async () => {


            if (isBusy)
            {
                return;
            }
            isBusy = true;
            await App.Current.MainPage.Navigation.PushAsync(new TeamInfoView());
            isBusy = false;

        });
        public ICommand goMessageView => new Command(async () => {


            if (isBusy)
            {
                return;
            }
            isBusy = true;
            await App.Current.MainPage.Navigation.PushAsync(new MessageView());
            isBusy = false;

        });
        public OptionViewVM()
        {

        }
    }
}
