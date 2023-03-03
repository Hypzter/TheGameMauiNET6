
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameMauiNET6.Data;

namespace TheGameMauiNET6.ViewModels
{
    internal partial class BattleDetailsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string imageSource;

        [ObservableProperty]
        public int healthPoints;

        [ObservableProperty]
        public string heroImageSource;

        [ObservableProperty]
        public int heroHealthPoints;

        

        public BattleDetailsPageViewModel()
        {

            HeroImageSource = Data.PlayableCharacter.ImageSource;
            HeroHealthPoints = Data.PlayableCharacter.HealthPoints;
        }
    }
}
