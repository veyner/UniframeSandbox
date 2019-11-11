using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.ViewObjects
{
    public class ViewFacilityCommand
    {
        public Guid CommandId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public Guid FacilityId { get; set; }
    }
}
