using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.ViewObjects
{
    public class ViewStateAlarm
    {
        public int ActiveAlarmCount { get; set; }
        public string Note { get; set; }
        public string LastActiveAlarmDate { get; set; }
    }
}
