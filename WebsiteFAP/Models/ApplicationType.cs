using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteFAP.Models
{
    public partial class ApplicationType
    {
        public ApplicationType()
        {
            Applications = new HashSet<Applications>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Applications> Applications { get; set; }
    }
}
