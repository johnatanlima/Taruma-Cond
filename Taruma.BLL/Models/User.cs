using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Taruma.BLL.Models
{
    public class User : IdentityUser<string>
    {
        public string CPF { get; set; }

        public string Photo { get; set; }

        public bool FirstAccess { get; set; }

        public StatusAccount Status { get; set; }

        public virtual ICollection<Apartment> Residents { get; set; }

        public virtual ICollection<Apartment> OwnersApartment { get; set; }

        public virtual ICollection<Vehycle> Vehicles { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        
    }
    
    public enum StatusAccount
    {
        Analisando, Aprovado, Reprovado
    }

}
