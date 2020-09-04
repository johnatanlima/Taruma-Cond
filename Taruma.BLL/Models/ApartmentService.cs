using System;

namespace Taruma.BLL.Models
{
    public class ApartmentService
    {
        public int ApartmentServiceId { get; set; }

        public string Name { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        public DateTime DateExecution { get; set; }


    }
}