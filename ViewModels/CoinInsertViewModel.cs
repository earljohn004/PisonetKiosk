using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisonetKiosk.ViewModels
{
    public class CoinInsertViewModel : Screen
    {
        IWindowManager manager = new WindowManager();

        public CoinInsertViewModel()
        {
            manager.ShowWindow(new ShellViewModel(), null, null);
        }
    }
}
