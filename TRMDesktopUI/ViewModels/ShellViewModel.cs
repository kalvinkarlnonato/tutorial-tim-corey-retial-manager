using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel
    {
        private ICalculations _calculations;
        //Bring registered interface in constructor
        public ShellViewModel(ICalculations calculations)
        {
            _calculations = calculations;
        }
    }
}
