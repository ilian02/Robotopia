using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Robotopia.Models
{
    public class AppUser : IdentityUser<int>
    {

        public DateTime CreationDate { get; set; }
        public int Level { get; set; }
        public int Currency { get; set; }
        public bool OnMission { get; set; }
        public int TotalHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TotalEnergyPoints { get; set; }
        public int CurrentEnergyPoints { get; set; }
        public int TotalCUPPowerPoints { get; set; }
        public int CurrentCUPPowerPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public int Speed { get; set; }
        public int Hacking { get; set; }
        public int Processing { get; set; }
        public int FireWall { get; set; }

    }
}

