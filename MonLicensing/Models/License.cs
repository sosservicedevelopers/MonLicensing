using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MonLicensing.Models
{
    //territirial_scope_internal
   
    public enum Period
    { unlimited, temporary
    }

    public class License
    {
        public int Id { get; set; }

        //срок выдачи лицензии (требование)
        public int IssuancePeriodRequirement { get; set; }
        //Территориальная сферя действия внутренняя  
        //Территориальная сферя действия внешняя
        public bool TerritirialScope { get; set; }
        //бумажная форма лицензии
        //элетронная форма лицензии
        public bool LicenceForm { get; set; }
        public string Number { get; set; }
        public string TitleKg { get; set; }
        public string TitleRu { get; set; }
        public string TitleEng { get; set; }
        public string ShortTitle { get; set; }
        public int LegalFormId { get; set; }
        public LegalForm LegalForm { get; set; }
        public string RegisteredAddress { get; set; }
        public string ActualAddress { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //устава юридического лица, согласованного с уполномоченным органом (МОиН)
        public string CharterNumber { get; set; }

        //номер свидетельства о государственной регистрации (перерегистрации) юридического лица, филиала (представительства);
        public string StateRegistrationCertificate { get; set; }
        //Вид документа, подтверждающего право собственности, оперативного управления или хозяйственного ведения зданиями, помещениями и оборудованием для осуществления заявленных образовательных программ
        public string CertificateOfTitleType { get; set; }
        //Номер документа, подтверждающего право собственности, оперативного управления или хозяйственного ведения зданиями, помещениями и оборудованием для осуществления заявленных образовательных программ
        public string CertificateOfTitleId { get; set; }
        //срок действия лицензии
        public Period Period { get; set; }
        //дата выдачи лицензии
        public DateTime IssiuanceDate { get; set; }
        //дата выдачи дубликата лицензии
        public DateTime? DuplicateIssiuanceDate { get; set; }
        //Дата переоформления лицензии
        public DateTime? ReissiuanceDate { get; set; }
        //Дата признания лицензии
        public DateTime? RecognitionDate { get; set; }
        //Дата приостановления лицензии
        public DateTime? SuspensionDate { get; set; }
        //Дата возобновления лицензии
        public DateTime? RenewalDate { get; set; }
        //Дата аннулирования лицензии
        public DateTime? CancellationDate { get; set; }

        //полномочия уполномоченного лица
        public string authorized_body_powers { get; set; }
        //Форма собственности юридического лица
        // ОКПО юридического лица
        //Акт(протокол) о решении предоставления
        public string TypeOfOwnership { get; set; }
        //Данные об оплате лицензионного сбора
        public bool PaymentConfirmation { get; set; }
        //Отказ в выдаче лицензии
        public int? DenialId { get; set; }
        public Denial Denial { get; set; }
        //Срок автоматической выдачи лицензии
        public string IssuancePeriodAuthomated { get; set; }
        //Переоформление лицензии
        public int? ReissuiningId { get; set; }
        public Reissuining Reissuining { get; set; }
        //Выдача дубликата лицензии
        public bool DublicateReason { get; set; }
        //срок выдачи дубликата лицензии (требование)
        public DateTime? DuplicateIssuancePeriod { get; set; }


        [Required(ErrorMessage ="Обязательное поле")]
        [MinLength(5,ErrorMessage ="Минимальная длина составляет 5 символов")]
        [StringLength(150,MinimumLength =5, ErrorMessage = "Минимальная длина составляет 5 символов")]
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
