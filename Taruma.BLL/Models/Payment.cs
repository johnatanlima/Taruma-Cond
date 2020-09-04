using System;

namespace Taruma.BLL.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public string UsuarioId { get; set; }
        public virtual User User { get; set; }

        public int RentalId { get; set; }
        public virtual Rental Rental { get; set; }

        public DateTime? PaymentDate{ get; set; }

        public StatusPayment Status { get; set; }

    }

    public enum StatusPayment
    {
        Paid, Pending, Late
    }

}