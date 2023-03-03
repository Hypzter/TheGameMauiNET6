using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameMauiNET6.Data
{
    internal static class PlayableCharacter
    {
        public static string Name { get; set; }
        public static int Level { get; set; }
        public static int HealthPoints { get; set; }
        public static int PhysicalAttack { get; set; }
        public static int MagicalAttack { get; set; }
        public static int CriticalChance { get; set; }
        public static string ImageSource { get; set; }
    }
}
