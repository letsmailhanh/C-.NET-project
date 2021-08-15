using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteFAP.Models
{
    public partial class Campus
    {
        public Campus()
        {
            Students = new HashSet<Students>();
        }

        public int CampusId { get; set; }
        public string CampusName { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
