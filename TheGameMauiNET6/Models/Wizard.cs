using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameMauiNET6.Models
{
    internal class Wizard : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicalAttack { get; set; }
        public int CriticalChance { get; set; }
        public string ImageSource { get; set; }
        public Wizard()
        {
            Level = 1;
            HealthPoints = 80;
            PhysicalAttack = 2;
            MagicalAttack = 15;
            CriticalChance = 5;
            ImageSource = "wizardidle.png";
        }
    }

}
