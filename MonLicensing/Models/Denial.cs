using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonLicensing.Models
{
    public class Denial
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Обязательное поле")]
        [MinLength(5,ErrorMessage ="Минимальная длина составляет 5 символов")]
        [StringLength(150,MinimumLength =5, ErrorMessage = "Минимальная длина составляет 5 символов")]
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
