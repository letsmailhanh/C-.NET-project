using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteFAP.Models
{
    public partial class Applications
    {
        public int ApplicationId { get; set; }
        public string StudentId { get; set; }
        public int? TypeId { get; set; }
        public string Purpose { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? StatusId { get; set; }
        public string ProcessNote { get; set; }
        public DateTime? ChangeStatusTime { get; set; }
        public string FileUploaded { get; set; }

        public virtual Status Status { get; set; }
        public virtual Students Student { get; set; }
        public virtual ApplicationType Type { get; set; }
    }
}
