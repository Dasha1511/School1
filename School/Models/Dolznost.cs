using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Dolznost
    {
        public long ID { get; set; }
        [Display(Name = "Код должности")]
        public long ID_Dolznost { get; set; }
        [Display(Name = "Наименование должности")]
        public string NaimenovanieDolznosti { get; set; }
        [Display(Name = "Оклад")]
        public int Oklad { get; set; }
        [Display(Name = "Обязанности")]
        public string Obyazannosti { get; set; }
        [Display(Name = "Требования")]
        public string Trebovaniya { get; set; }
    }
}