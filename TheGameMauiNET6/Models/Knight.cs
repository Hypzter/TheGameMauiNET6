using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameMauiNET6.Models
{
    internal class Knight : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicalAttack { get; set; }
        public int CriticalChance { get; set; }
        public string ImageSource { get; set; }

        public Knight()
        {
            Level = 1; // SessionData.Level hämtar data från statisk klass
            HealthPoints = 100;
            PhysicalAttack = 10;
            MagicalAttack = 2;
            CriticalChance = 3;
            ImageSource = "knight.png";
        }
    }
}
