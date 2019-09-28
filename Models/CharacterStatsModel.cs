using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWoWArmory.Models
{
    public class CharacterStatsModel
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public PrimaryStatModel Intellect { get; set; }
        public PrimaryStatModel Strength { get; set; }
        public PrimaryStatModel Agility { get; set; }
        public SecondaryStatModel Mastery { get; set; }
        public float Versatility { get; set; }
        public PowerTypeModel Power_Type { get; set; }
    }
}
