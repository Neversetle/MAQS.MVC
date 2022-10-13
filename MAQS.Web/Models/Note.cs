using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class Note
    {
        public long Noteid { get; set; }
        public Guid Corpid { get; set; }
        public DateTime Created { get; set; }
        public string Createdby { get; set; } = null!;
        public string Source { get; set; } = null!;
        public string Notepad { get; set; } = null!;
        public bool Incrm { get; set; }
    }
}
