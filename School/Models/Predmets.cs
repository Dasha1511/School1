using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Predmets
    {
        public long ID { get; set; }
        [Display(Name = "Код предмета")]
        public long ID_Predmets { get; set; }
        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }
        [Display(Name = "Описание")]
        public string Opisanie { get; set; }
        [Display(Name = "Код сотрудника-класного учителя")]
        public long? StaffID { get; set; }
        [Display(Name = "Cотрудника-класного учителя")]
        public DbSet<Staff> Staff { get; set; }

    }
}
