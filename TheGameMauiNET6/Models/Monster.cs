using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameMauiNET6.Models
{
    class Monster : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicalAttack { get; set; }
        public int CriticalChance { get; set; }
        public string ImageSource { get; set; }

        public Monster()
        {
            Random rnd = new Random();
            Name = GetRandomMonsterName();
            Level = rnd.Next(1, 10);
            HealthPoints = 50 + (Level * 3);
            PhysicalAttack = 10 + (Level * 2);
            MagicalAttack = 10 + (Level * 2);
            CriticalChance = 2 + (Level * 1);
            ImageSource = GetImage(Name);
        }
        internal string GetRandomMonsterName()
        {
            Random rnd = new Random();
            string[] names =
            {
                "Dragon",
                "Demon",
                "Medusa",
                "Jinn",
                "Baby Dragon",
                "Lizard"
            };
            return names[rnd.Next(0, names.Length)];
        }
        internal string GetImage(string name)
        {
            string image = null;
            if (name == "Dragon")
            {
                image = "dragon.png";
            }
            if (name == "Demon")
            {
                image = "demon.png";
            }
            if (name == "Medusa")
            {
                image = "medusa.png";
            }
            if (name == "Jinn")
            {
                image = "jinn.png";
            }
            if (name == "Lizard")
            {
                image = "lizard.png";
            }
            if (name == "Baby Dragon")
            {
                image = "babydragon.png";
            }
            return image;
        }
    }
}
