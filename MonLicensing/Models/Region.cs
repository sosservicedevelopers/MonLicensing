using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonLicensing.Models
{
    public class Region
    {
        public int Id { get; set; }

        [Display(Name = "Область")]
        public string Name { get; set; }
       
    }
}
