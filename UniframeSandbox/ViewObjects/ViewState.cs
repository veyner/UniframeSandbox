using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.ViewObjects
{
    public class ViewState
    {
        public Guid FacilityID { get; set; }
        public ViewStateCommon Common { get; set; }
        public ViewStateConnection Connection { get; set; }
        public ViewStateAlarm Alarm { get; set; }
        public ViewStateSystem System { get; set; }
        public ViewStateDevice Device { get; set; }
        public List<ViewStateFacilityParameter> Parameters { get; set; }
    }
}
