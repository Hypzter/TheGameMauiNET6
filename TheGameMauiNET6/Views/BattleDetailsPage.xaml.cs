using System.Net.Http;

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
		base.OnAppearing();
		if (!pageStarted )
		{
			pageStarted = true;
		}
	}
}