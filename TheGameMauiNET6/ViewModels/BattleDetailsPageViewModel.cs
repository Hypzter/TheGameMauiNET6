using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        public Data.ChosenHero ChosenHero { get; set; }

        public Models.BattleDetail BattleDetail { get; set; }

        [ObservableProperty]
        public string imageSource;

        [ObservableProperty]
        public int healthPoints;

        [ObservableProperty]
        public string heroImageSource;

        [ObservableProperty]
        public int heroHealthPoints;

        [ObservableProperty]
        public string heroName;

        [ObservableProperty]
        public int heroPhysicalAttack;


        
        public BattleDetailsPageViewModel()
        {
            ChosenHero = Data.ChosenHero.GetPlayableCharacter();

            HeroImageSource = ChosenHero.HeroImageSource;
            HeroHealthPoints = ChosenHero.HeroHealthPoints;
            HeroName = ChosenHero.HeroName;
            HeroPhysicalAttack = ChosenHero.HeroPhysicalAttack;
        }

        [RelayCommand]
        public void PhysicalAttack()
        {
            HealthPoints = HealthPoints - HeroPhysicalAttack;
        }

        public void CounterAttack()
        {

        }
    }
}
