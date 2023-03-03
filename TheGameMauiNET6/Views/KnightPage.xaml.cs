
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
				kpvm.GoKnight.Name = NameInput.Text;

				Data.PlayableCharacter.Name = kpvm.GoKnight.Name;
				Data.PlayableCharacter.HealthPoints = kpvm.GoKnight.HealthPoints;
				Data.PlayableCharacter.PhysicalAttack = kpvm.GoKnight.PhysicalAttack;
				Data.PlayableCharacter.MagicalAttack = kpvm.GoKnight.MagicalAttack;
				Data.PlayableCharacter.CriticalChance = kpvm.GoKnight.CriticalChance;
				Data.PlayableCharacter.ImageSource = kpvm.GoKnight.ImageSource;

				await Navigation.PushAsync(new BattlePage());
			}
			else
			{
				return;
			}
		}
    }
}