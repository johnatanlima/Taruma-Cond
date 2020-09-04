using System.Collections.Generic;

namespace Taruma.BLL.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        public string Name { get; set; }

        public decimal Cust { get; set; }

        public StatusService Status { get; set; }

        //Pertence
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<ApartmentService> ApartmentServices { get; set; }

    }

    public enum StatusService
    {
        Pending, Recused, Accepted
    }
}