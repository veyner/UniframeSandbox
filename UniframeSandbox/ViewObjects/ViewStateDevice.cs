using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.ViewObjects
{
    public class ViewStateDevice
    {
        public string Note { get; set; }
        public int TotalDevicesCount { get; set; }
        public int OnlineDevicesCount { get; set; }
        public int DevicesInAlarmStateCount { get; set; }
    }
}
