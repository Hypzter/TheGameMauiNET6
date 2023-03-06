using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameMauiNET6.Models;

namespace TheGameMauiNET6.Data
{
    internal class ChosenHero
    {
        public string HeroName { get; set; }
        public int HeroLevel { get; set; }
        public int HeroHealthPoints { get; set; }
        public int HeroPhysicalAttack { get; set; }
        public int HeroMagicalAttack { get; set; }
        public int HeroCriticalChance { get; set; }
        public string HeroImageSource { get; set; }

        private static readonly ChosenHero _chosenHero = new ChosenHero();


        public static ChosenHero GetPlayableCharacter()
        {
            return _chosenHero;
        }
    }
}
