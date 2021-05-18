using OxbridgeProject.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace OxbridgeProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ServiceContainer.Register(() => new loginViewVM());
            ServiceContainer.Register(() => new OptionViewVM());
            setMainPage();
        }
        public void setMainPage() {

            var mainView = new NavigationPage(new LoginView());
            NavigationPage.SetHasBackButton(mainView, false);
            NavigationPage.SetHasNavigationBar(mainView, false);

            MainPage = mainView;
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
