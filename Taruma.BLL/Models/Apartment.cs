﻿using System.ComponentModel.DataAnnotations;

namespace Taruma.BLL.Models
{
    public class Apartment
    {
        public int ApartmentId { get; set; }

        [StringLength(45, ErrorMessage = "Limit of caracter error!")]
        [Display(Name = "Number Apartment")]
        [Range(1, 1000, ErrorMessage = "Invalid option")]
        public int Number { get; set; }

        [StringLength(45, ErrorMessage = "Limit of caracter error!")]
        [Range(1, 10, ErrorMessage = "Invalid option!")]
        public int Floor { get; set; }

        public string Image { get; set; }

        [Display(Name = "Resident ID")]
        public string ResidentId { get; set; }
        public virtual User Resident { get; set; }

        [Display(Name = "Owner ID")]
        public string OwnerId { get; set; }
        public virtual User Owner { get; set; }

    }
}