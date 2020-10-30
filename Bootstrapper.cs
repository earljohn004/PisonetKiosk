using Caliburn.Micro;
using PisonetKiosk.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PisonetKiosk
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
            
            //DisplayRootViewFor<TopUpViewModel>();
            //DisplayRootViewFor<CoinInsertViewModel>();
        }

    }


}
