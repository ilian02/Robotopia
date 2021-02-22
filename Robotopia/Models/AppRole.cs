using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robotopia.Models
{
    public class AppRole : IdentityRole<int>
    {
        public string Description { get; set; }

        public AppRole() { }

        public AppRole(string name)
        {
            Name = name;
        }

    }
}
