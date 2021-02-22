using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robotopia.Models.ServiceModels
{
    public class ServiceAppUserModel
    {
        public string UserName { get; set; }
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


        public ServiceAppUserModel(AppUser user)
        {
            this.UserName = user.UserName;
            this.CreationDate = user.CreationDate;
            this.Level = user.Level;
            this.Currency = user.Currency;
            this.OnMission = user.OnMission;
            this.TotalHitPoints = user.TotalHitPoints;
            this.CurrentHitPoints = user.CurrentHitPoints;
            this.TotalEnergyPoints = user.TotalEnergyPoints;
            this.CurrentEnergyPoints = user.CurrentEnergyPoints;
            this.TotalCUPPowerPoints = user.TotalCUPPowerPoints;
            this.CurrentCUPPowerPoints = user.CurrentCUPPowerPoints;
            this.ExperiencePoints = user.ExperiencePoints;
            this.Strength = user.Strength;
            this.Agility = user.Agility;
            this.Vitality = user.Vitality;
            this.Speed = user.Speed;
            this.Hacking = user.Hacking;
            this.Processing = user.Processing;
            this.FireWall = user.FireWall;
        }


    }
}
