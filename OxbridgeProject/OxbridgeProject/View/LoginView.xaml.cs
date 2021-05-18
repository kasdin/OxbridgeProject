using OxbridgeProject.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OxbridgeProject
{
    public partial class LoginView : ContentPage
    {
        private loginViewVM loginVM = null;
        public LoginView()
        {
            loginVM = ServiceContainer.Resolve<loginViewVM>();
            this.BindingContext = loginVM;
            InitializeComponent();

        }
    }
}
