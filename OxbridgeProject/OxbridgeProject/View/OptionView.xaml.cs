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
    public partial class OptionView : ContentPage
    {
        private OptionViewVM optionVM = null;

        public OptionView()
        {
            optionVM = ServiceContainer.Resolve<OptionViewVM>();
            this.BindingContext = optionVM;
            InitializeComponent();
        }
    }
}