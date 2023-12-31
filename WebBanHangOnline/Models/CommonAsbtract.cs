using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models
{
    public class CommonAsbtract
    {
        public string Category { get; set; }    

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiledDate { get; set; }

        public string Modifiledby { get; set; }
    }
}