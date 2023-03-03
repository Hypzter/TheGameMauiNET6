using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameMauiNET6.Models
{
    class Medusa : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicalAttack { get; set; }
        public int CriticalChance { get; set; }
        public string ImageSource { get; set; }

        public Medusa()
        {
            Random rnd = new Random();
            Name = "Medusa";
            Level = rnd.Next(1, 10);
            HealthPoints = 50 + (Level * 3);
            PhysicalAttack = 10 + (Level * 2);
            MagicalAttack = 10 + (Level * 2);
            CriticalChance = 2 + (Level * 1);
            ImageSource = "medusa.png";
        }
    }
}
