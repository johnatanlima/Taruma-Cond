using System;
using System.Collections.Generic;
using System.Text;

namespace Taruma.BLL.Models
{
    public class Month
    {
        public int MonthId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual ICollection<RecourseHistoric> Historics { get; set; }
    }
}
