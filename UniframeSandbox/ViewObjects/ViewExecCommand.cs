using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.ViewObjects
{
    public class ViewExecCommand
    {
        public Guid FacilityId { get; set; }
        public Guid CommandId { get; set; }
        public string Note { get; set; }
    }
}
