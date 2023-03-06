using System.Net.Http;
using TheGameMauiNET6.Data;

namespace TheGameMauiNET6.Views;

public partial class BattleDetailsPage : ContentPage
{
	ViewModels.BattleDetailsPageViewModel vm = new ViewModels.BattleDetailsPageViewModel();

	bool pageStarted = false;
	public BattleDetailsPage()
	{
		InitializeComponent();
		BindingContext = vm;
	}
	protected override async void OnAppearing()
	{
		HeroImage.Source = Data.ChosenHero.GetPlayableCharacter().HeroImageSource;
		//PhysAtt.BindingContext = Data.ChosenHero.GetPlayableCharacter().HeroPhysicalAttack;
		//vm.BattleDetail.ChosenHero = Data.ChosenHero.GetPlayableCharacter();
		//vm.BattleDetail.Monster = BattleDetailsPage.BindingContextProperty;
		base.OnAppearing();
		if (!pageStarted )
		{
			pageStarted = true;
		}
	}
    private void OnPhysicalAttackClicked(object sender, EventArgs e)
    {
		
    }
}