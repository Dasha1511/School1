using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Students
    {
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime Dr { get; set; }
        [Display(Name = "Пол")]
        public string Pol { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "ФИО отца")]
        public string FIOfather { get; set; }
        [Display(Name = "ФИО матери")]
        public string FIOmother { get; set; }
        [Display(Name = "Код класса")]
        public long? ClassID { get; set; }
        [Display(Name = "Класс")]
        public DbSet<Class> Class { get; set; }
        [Display(Name = "Дополнительная информация")]
        public string Dopinf { get; set; }
    }
}
