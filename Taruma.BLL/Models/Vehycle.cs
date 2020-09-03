using System.ComponentModel.DataAnnotations;

namespace Taruma.BLL.Models
{
    public class Vehycle
    {
        public int VehycleId { get; set; }

        [Required(ErrorMessage = "Warning! Insert value here!")]
        [StringLength(45, ErrorMessage = "Limit of caracter error!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Warning! Insert value here!")]
        [StringLength(45, ErrorMessage = "Limit of caracter error!")]
        public string Brand { get; set; }


        [Required(ErrorMessage = "Warning! Insert value here!")]
        [StringLength(45, ErrorMessage = "Limit of caracter error!")]
        public string Color { get; set; }


        [Required(ErrorMessage = "Warning! Insert value here!")]
        public string Plaque { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}