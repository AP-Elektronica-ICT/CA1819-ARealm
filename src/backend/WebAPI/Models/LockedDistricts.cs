using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LockedDistricts
    {
        public long Id { get; set; }
        public List<District> Districts { get; set; }
    }
}
