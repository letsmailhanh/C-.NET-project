using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteFAP.Models
{
    public partial class Students
    {
        public Students()
        {
            Applications = new HashSet<Applications>();
        }

        public string StudentId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? CampusId { get; set; }

        public virtual Campus Campus { get; set; }
        public virtual ICollection<Applications> Applications { get; set; }
    }
}
