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
    public partial class adminView : ContentPage
    {
        private AdminViewVM adminVM = null;
        public adminView()
        {
            adminVM = ServiceContainer.Resolve<AdminViewVM>();
            this.BindingContext = adminVM;
            InitializeComponent();
        }
    }
}