using OxbridgeProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OxbridgeProject.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminMessageView : ContentPage
    {
        private AdminMessageViewVM adminVM = null;
        public AdminMessageView()
        {
            adminVM = ServiceContainer.Resolve<AdminMessageViewVM>();
            this.BindingContext = adminVM;
            InitializeComponent();
        }
    }
}