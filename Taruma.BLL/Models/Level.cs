using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taruma.BLL.Models
{
    public class Level : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}
