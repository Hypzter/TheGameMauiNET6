using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameMauiNET6.Models
{
    class Lizard : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicalAttack { get; set; }
        public int CriticalChance { get; set; }
        public string ImageSource { get; set; }

        public Lizard()
        {
            Random rnd = new Random();
            Name = "Lizard";
            Level = rnd.Next(1, 10);
            HealthPoints = 50 + (Level * 3);
            PhysicalAttack = 10 + (Level * 2);
            MagicalAttack = 10 + (Level * 2);
            CriticalChance = 2 + (Level * 1);
            ImageSource = "lizard.png";
        }
    }
}
