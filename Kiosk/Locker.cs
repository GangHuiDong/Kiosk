using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    internal class Locker
    {
        string locker_num;
        string use_state;

        public Locker(string locker_num, string use_state)
        {
            this.locker_num= locker_num;
            this.use_state= use_state;
        }
    }
}
