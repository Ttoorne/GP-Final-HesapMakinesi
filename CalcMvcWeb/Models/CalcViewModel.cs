using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalcMvcWeb.Models
{
    public class CalcViewModel
    {
        [Display(Name = "1 Numara")]
        public int Number1 { get; set; }
        [Display(Name = "2 Numara")]
        public int Number2 { get; set; }
        public double Result { get; set; }
    }
}
