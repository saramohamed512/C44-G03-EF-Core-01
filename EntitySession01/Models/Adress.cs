using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.Models
{
    //[Owned]
    internal class Adress
    {
        public  string? city { get; set; }
        public string? street { get; set; }
        public string? country { get; set; }
    }
}
