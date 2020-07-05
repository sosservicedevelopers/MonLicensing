using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonLicensing.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Обязательное поле")]
        [MinLength(5,ErrorMessage ="Минимальная длина составляет 5 символов")]
        [StringLength(150,MinimumLength =5, ErrorMessage = "Минимальная длина составляет 5 символов")]
        [Display(Name = "Полное наименование юридического лица")]
        public string Name { get; set; }
        [Display(Name = "Организационно-правовая форма")]
        public int? LegalFormId { get; set; }

        [Display(Name = "Организационно-правовая форма")]
        public LegalForm LegalForm { get; set; }

        [Display(Name = "Форма собственности ")]
        public int? SobsFormId { get; set; }

        [Display(Name = "Форма собственности ")]
        public  SobsForm SobsForm { get; set; }

        [Display(Name = "Область")]
        public int? RegionId { get; set; }

        [Display(Name = "Область")]
        public Region Region { get; set; }

        [Display(Name = "Район")]
        public int? DistrictId { get; set; }

        [Display(Name = "Район")]
        public District District { get; set; }

        [Display(Name = "Улица и т.д.")]
        public string Adres { get; set; }

        [Display(Name = "Идентификационный номер налогоплательщика (ИНН) ")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(maximumLength: 14, MinimumLength = 14, ErrorMessage = "Инн должен быть 14 знаков")]
        public string INN { get; set; }

        [Display(Name = "Код ОКПО юридического лица  ")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(maximumLength: 8, MinimumLength = 8, ErrorMessage = "Инн должен быть 8 знаков")]
        public string OKPO { get; set; }

        [Display(Name = "Дата регистрации (перерегистрации) юридического лица ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? RegistrationDate { get; set; }

        [Display(Name = "Номер телефона (факса) заявителя ")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Адрес электронной почты заявителя ")]
        public string Email { get; set; }

        [Display(Name = "Дата заполнения  ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? СompletionDate { get; set; }


    }
}
