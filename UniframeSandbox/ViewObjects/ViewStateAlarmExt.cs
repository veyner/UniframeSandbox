using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.ViewObjects
{
    public class ViewStateAlarmExt
    {
        public Guid AlarmId { get; set; }
        public string Name { get; set; }
        public string AlarmType { get; set; }
        public string AlarmState { get; set; }
        public string DateCreate { get; set; }
        public string ConfirmationDate { get; set; }
        public string CloseDate { get; set; }
        public string SourceName { get; set; }
        public string Note { get; set; }
    }
}
