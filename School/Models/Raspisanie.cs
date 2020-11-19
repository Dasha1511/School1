using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Raspisanie
    {
        public long ID { get; set; }
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        [Display(Name = "День недели")]
        public string Dennedely { get; set; }
        [Display(Name = "Код класса")]
        public long? ClassID { get; set; }
        [Display(Name = "Класс")]
        public DbSet<Class> Class { get; set; }
        [Display(Name = "Код предмета")]
        public long? PredmetsID { get; set; }
        [Display(Name = "Предмет")]
        public DbSet<Predmets> Predmets { get; set; }
        [Display(Name = "Время начала")]
        public DateTime Vremanachala { get; set; }
        [Display(Name = "Время окончания")]
        public DateTime Vremaokonch { get; set; }
    }
}
