
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameMauiNET6.Models;


namespace TheGameMauiNET6.ViewModels
{
    internal partial class KnightPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public Models.Knight goKnight;

        public Data.ChosenHero ChosenHero { get; set; }

        [ObservableProperty]
        int healthPoints;

        [ObservableProperty]
        int level;

        public KnightPageViewModel()
        {
            GoKnight = Models.Knight.GetKnight();
            ChosenHero = Data.ChosenHero.GetPlayableCharacter();
        }
    }
}
