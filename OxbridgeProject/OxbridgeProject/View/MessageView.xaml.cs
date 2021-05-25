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
    public partial class MessageView : ContentPage
    {
        private MessageViewVM messageVM = null;
        public MessageView()
        {

            messageVM = ServiceContainer.Resolve<MessageViewVM>();
            this.BindingContext = messageVM;


            InitializeComponent();
        }
    }
}