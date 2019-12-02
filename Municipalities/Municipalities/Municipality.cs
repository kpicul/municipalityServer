using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Municipalities
{
    public class Municipality
    {
        public int OB_ID { get; set; }
        public string OB_NAME { get; set; }
        public string OB_UNAME { get; set; }
    }
}