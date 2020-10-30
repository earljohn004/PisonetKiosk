using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using KioskBusinessLogic;
using KioskModel;

namespace PisonetKiosk.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        private KioskInputAutomation automate_;
        private UserAccount useraccount_;
        IWindowManager manager = new WindowManager();

        public ShellViewModel()
        {
            useraccount_ = new UserAccount();
            automate_ = new KioskInputAutomation(useraccount_);

        }

        public void LoadDeviceStatus()
        {
            ActivateItem(new DeviceStatusViewModel());
        }
        
        private async void AsyncCreateGuestUser()
        {
            await Task.Run(automate_.FunctionGuestTopUp);
        }

        public void CreateGuestUser()
        {
            //AsyncCreateGuestUser();
            //manager.ShowDialog(new CoinInsertViewModel(), null, null);
        }

        public void LoadTopUpScreen()
        {
            manager.ShowDialog(new TopUpViewModel(), null, null);
            //manager.ShowDialog(new CoinInsertViewModel(), null, null);
            //manager.ShowWindow(new TopUpViewModel(), null, null);
        }
    }
}
