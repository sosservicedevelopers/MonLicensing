using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonLicensing.Models
{
    public class District
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Обязательное поле")]
        [Display(Name = "Район")]
        public string Name { get; set; }

        [Display(Name = "Область")]
        public int RegionId { get; set; }

        [Display(Name = "Область")]
        public Region Region { get; set; }
    }
}
