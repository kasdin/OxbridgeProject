using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OxbridgeProject.ViewModel
{
    public abstract class BaseViewModel : BindableViewModel
    {
        public bool isBusy = false;
        public bool isLogged = false;

        public BaseViewModel()
        {

        }
        public virtual Task InitializeAsync(object navigationData) {
            return Task.FromResult(false);
        }
    }
}
