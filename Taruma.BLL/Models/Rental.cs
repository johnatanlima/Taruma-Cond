using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taruma.BLL.Models
{
    public class Rental
    {
        public int RentalId { get; set; }


        [Required(ErrorMessage = "Warning! Insert value here!")]
        [Range(0, int.MaxValue, ErrorMessage = "Value invalid!")]
        public decimal Value { get; set; }

        [Display(Name = "Month")]
        public int MonthId { get; set; }

        public Month Month { get; set; }

        [Required(ErrorMessage = "Warning! Insert value here!")]
        [Range(2020, 2030, ErrorMessage = "Value invalid!")]
        public int Year { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}