using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Class
    {
        public long ID { get; set; }
        [Display(Name = "Код класса")]
        public long ID_class { get; set; }
        [Display(Name = "Код сотрудника-класного руководителя")]
        public long? StaffID { get; set; }
        [Display(Name = "Cотрудник-класный руководитель")]
        public DbSet<Staff> Staff { get; set; }
        [Display(Name = "Код вида")]
        public long? VidID { get; set; }
        [Display(Name = "Вид")]
        public DbSet<Vid> Vid { get; set; }
        [Display(Name = "Количество учеников")]
        public int Kolstu { get; set; }
        [Display(Name = "Буква")]
        public string Bukva { get; set; }
        [Display(Name = "Год обучения")]
        public DateTime Godobuch { get; set; }
        [Display(Name = "Год создания")]
        public DateTime Godsozd { get; set; }

    }
}