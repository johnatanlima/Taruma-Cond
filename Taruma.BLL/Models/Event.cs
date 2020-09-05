using System;
using System.ComponentModel.DataAnnotations;

namespace Taruma.BLL.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Warning! Insert value here!")]
        [StringLength(45, ErrorMessage = "Limit of caracter error!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Warning! Insert value here!")]
        public DateTime Date { get; set; }

        [Display(Name = "User ID")]
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}