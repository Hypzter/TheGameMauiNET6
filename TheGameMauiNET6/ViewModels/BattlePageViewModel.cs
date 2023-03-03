using TheGameMauiNET6.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameMauiNET6.ViewModels;


namespace TheGameMauiNET6.ViewModels
{
    internal partial class BattlePageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Models.Monster> monsters;

        [ObservableProperty]
        string name;

        [ObservableProperty]
        int healthPoints;

        [ObservableProperty]
        string imageSource;

        [ObservableProperty]
        int level;

        [ObservableProperty]
        int physicalAttack;

        [ObservableProperty]
        int magicalAttack;

        [ObservableProperty]
        int criticalChance;
        public BattlePageViewModel()
        {
            Monsters = new ObservableCollection<Models.Monster>();

            for (int i = 0; i < 10; i++)
            {
                Monsters.Add(new Models.Monster());
            }
        }
    }
}
