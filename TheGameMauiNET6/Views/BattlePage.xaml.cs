namespace TheGameMauiNET6.Views;

public partial class BattlePage : ContentPage
{
	public BattlePage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.BattlePageViewModel();
	}

    private async void OnListViewMonsterSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var monster = ((ListView)sender).SelectedItem as Models.Monster;
        if (monster != null)
        {
            var page = new BattleDetailsPage();
            page.BindingContext = monster;
            await Navigation.PushAsync(page);
        }
    }
}