﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.ViewObjects
{
    public class ViewFacility
    {
        public Guid FacilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ViewFacilityCoordinates FacilityCoordinates { get; set; }
    }
}
