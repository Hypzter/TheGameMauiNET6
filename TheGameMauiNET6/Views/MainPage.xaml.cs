namespace TheGameMauiNET6;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private async void OnKnightPicClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.KnightPage());
    }

    private async void OnWizardPicClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.WizardPage());
    }
}
//DisplayAlert

//Static class med props
