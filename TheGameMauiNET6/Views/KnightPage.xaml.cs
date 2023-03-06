
using TheGameMauiNET6.Models;
using TheGameMauiNET6.ViewModels;

namespace TheGameMauiNET6.Views;

public partial class KnightPage : ContentPage
{
	ViewModels.KnightPageViewModel kpvm = new ViewModels.KnightPageViewModel();
	public KnightPage()
	{
		InitializeComponent();
		BindingContext = kpvm;
	}

    private async void OnToBattleClicked(object sender, EventArgs e)
    {
		if (NameInput.Text == null)
		{
			await DisplayAlert("Alert!", "You must enter a name", "Ok");
		}
		else
		{
			bool answer = await DisplayAlert("Confirm", "Are you happy with your name?", "Yes", "Cancel");
			if (answer == true)
			{
				kpvm.ChosenHero.HeroName = NameInput.Text;
				kpvm.ChosenHero.HeroLevel = kpvm.GoKnight.Level;
				kpvm.ChosenHero.HeroPhysicalAttack = kpvm.GoKnight.PhysicalAttack;
				kpvm.ChosenHero.HeroMagicalAttack = kpvm.GoKnight.PhysicalAttack;
				kpvm.ChosenHero.HeroCriticalChance = kpvm.GoKnight.CriticalChance;
				kpvm.ChosenHero.HeroImageSource = kpvm.GoKnight.ImageSource;


				await Navigation.PushAsync(new BattlePage());
			}
			else
			{
				return;
			}
		}
    }
}