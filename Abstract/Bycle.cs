using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Bycle:Vehicle
    {
        public override void Drive(int km)
        {
            Millage = Millage + km;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo();
        }
    }
}
