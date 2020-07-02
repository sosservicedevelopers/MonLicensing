using MonLicensing.Data;
using MonLicensing.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonLicensing.Data
{
    public class DataSeeder
    {
        public static void SeedCountries(ApplicationDbContext context)
        {
            try
            {
                if (!context.EducationalPrograms.Any())
                {
                    context.EducationalPrograms.Add(new EducationalPrograms() { Name = "Общеобразовательные" });
                    context.EducationalPrograms.Add(new EducationalPrograms() { Name = "Профессиональные" });
                    context.EducationalPrograms.Add(new EducationalPrograms() { Name = "Послевузовское профессиональное образование" });
                    context.EducationalPrograms.Add(new EducationalPrograms() { Name = "Дополнительное профессиональное образование (курсы повышения квалификации специалистов)" });
                    context.EducationalPrograms.Add(new EducationalPrograms() { Name = "Дополнительное образование" });
                    context.SaveChanges(); 
                }
                if (!context.Conclusions.Any())
                {
                    context.Conclusions.Add(new Conclusions() { Name = "Заключение уполномоченного государственного органа в сфере обеспечения безопасности дорожного движения (для образовательных программ подготовки)" });
                    context.Conclusions.Add(new Conclusions() { Name = "Заключение уполномоченного государственного органа в сфере здравоохранения (для реализации программ по подготовке медицинских кадров)" });
                    context.Conclusions.Add(new Conclusions() { Name = "Заключение уполномоченного государственного органа по делам религий на образовательную деятельность религиозных организаций (объединений)" });
                    context.SaveChanges();
                }
                if (!context.LegalForm.Any())
                {
                    context.LegalForm.Add(new LegalForm() { Name = "Открытое акционерное общество " });
                    context.LegalForm.Add(new LegalForm() { Name = "Закрытое акционерное общество" });
                    context.LegalForm.Add(new LegalForm() { Name = "Общество с ограниченной ответственностью" });
                    context.LegalForm.Add(new LegalForm() { Name = "Общество с дополнительной ответственностью" });
                    context.LegalForm.Add(new LegalForm() { Name = "Коммандитное товарищество " });
                    context.LegalForm.Add(new LegalForm() { Name = "Полное товарищество" });
                    context.LegalForm.Add(new LegalForm() { Name = "Кооператив как коммерческая организация " });
                    context.SaveChanges();
                }
                if (!context.Reissuining.Any())
                {
                    context.Reissuining.Add(new Reissuining() { Name = "реорганизация юридического лица" });
                    context.Reissuining.Add(new Reissuining() { Name = "изменение наименования юридического лица" });
                    context.Reissuining.Add(new Reissuining() { Name = "изменение фамилии, имени, отчества физического лица" });
                    context.SaveChanges();
                }
                if (!context.ImpactMeasures.Any())
                {
                    context.ImpactMeasures.Add(new ImpactMeasures() { Name= "предупреждение" });
                    context.ImpactMeasures.Add(new ImpactMeasures() { Name = "штраф" });
                    context.ImpactMeasures.Add(new ImpactMeasures() { Name = "приостановление действия лицензии и (или) разрешения" });
                    context.ImpactMeasures.Add(new ImpactMeasures() { Name = "подача искового заявления в судебные органы для рассмотрения вопроса об аннулировании лицензии и (или) разрешения" });
                    context.ImpactMeasures.Add(new ImpactMeasures() { Name = "Очередность нарушения лицензионных требований " });
                    context.SaveChanges(); 
                }
                if (!context.Denial.Any())
                {
                    context.Denial.Add(new Denial() { Name = "Наличие запрета" });
                    context.Denial.Add(new Denial() { Name = "Наличие решения суда" });
                    context.Denial.Add(new Denial() { Name = "Представление заявителем недостоверной или неполной информации" });
                    context.Denial.Add(new Denial() { Name = "Несоответствие документов, представленных заявителем к  требованиям, установленным законодательством" });
                    context.Denial.Add(new Denial() { Name = "Невнесение лицензионного сбора" });
                    context.SaveChanges();

                }
                if (!context.Processes.Any())
                {
                    context.Processes.Add(new Processes() { Name = "Выдача лицензии" });
                    context.Processes.Add(new Processes() { Name = "Отказ в выдаче лицензии" });
                    context.Processes.Add(new Processes() { Name = "Переоформление лицензии" });
                    context.Processes.Add(new Processes() { Name = "Выдача дубликата лицензии" });
                    context.Processes.Add(new Processes() { Name = "Признание" });
                    context.Processes.Add(new Processes() { Name = "Приостановление" });
                    context.Processes.Add(new Processes() { Name = "Возобновление" });
                    context.Processes.Add(new Processes() { Name = "Аннулирование" });
                    context.SaveChanges();

                }
                if (!context.Processes.Any())
                {
                    context.LicenceType.Add(new LicenceType() { Name = "Медицинская деятельность" });
                    context.LicenceType.Add(new LicenceType() { Name = "Фармацевтическая деятельность" });
                    context.LicenceType.Add(new LicenceType() { Name = "Работа с микроорганизмами II группы патогенности" });
                    context.LicenceType.Add(new LicenceType() { Name = "Образовательная деятельность" });
                   
                    context.SaveChanges();

                }
                //if (!context.Hospitals.Any())
                //{
                //    Assembly assembly = Assembly.GetExecutingAssembly();
                //    string resourceName = "ExExPostAis.Data.ipu.csv";
                //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                //    {
                //        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                //        {
                //            CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
                //            //csvReader.Configuration.HeaderValidated = false;
                //            var departments = csvReader.GetRecords<Hospitals>().ToArray();
                //            //context.Departments.AddOrUpdate(c => c.Code, countries);
                //            foreach (Hospitals record in departments)
                //            {
                //                context.Hospitals.Add(record);
                //            }
                //            context.SaveChanges();
                //        }
                //    }

                //}




            }
            catch (Exception exp){
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .AddFilter("Microsoft", LogLevel.Warning)
                        .AddFilter("System", LogLevel.Warning)
                        .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                        .AddConsole()
                        .AddEventLog();
                });
                ILogger logger = loggerFactory.CreateLogger<Program>();
                logger.LogInformation("Example log message : "+exp.Message);
            }

            //if (!context.Users.Any())
            //{
            //    string user1 = "editor1@example.com";
            //    ApplicationUser editor1 = new ApplicationUser { Email = user1, UserName = user1 }; ;

            //    IdentityResult result = userManager.CreateAsync(editor1, "ASDfgh1!");

            //    if (result.Succeeded)
            //    {
            //        userManager.AddToRoleAsync(editor1, "АДМИНИСТРАТОР");
            //    }
            //}


            //if (!context.DictMediaControlResult.Any())
            //{
            //    context.DictMediaControlResult.Add(new DictMediaControlResult() { NameKyrg = "", NameRus = "", DictStatusId = 1, CreateDate = DateTime.Now });
            //    context.DictMediaControlResult.Add(new DictMediaControlResult() { NameKyrg = "", NameRus = "", DictStatusId = 1, CreateDate = DateTime.Now });
            //}


        }
    }
}
