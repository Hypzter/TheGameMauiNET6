namespace TheGameMauiNET6.Views;

public partial class WizardPage : ContentPage
{
    ViewModels.WizardPageViewModel wpvm = new ViewModels.WizardPageViewModel();
	public WizardPage()
	{
		InitializeComponent();
        BindingContext = wpvm;
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
                wpvm.GoWizard.Name = NameInput.Text;
                
                //Data.ChosenHero.Name = wpvm.GoWizard.Name;
                //Data.ChosenHero.HealthPoints = wpvm.GoWizard.HealthPoints;
                //Data.ChosenHero.PhysicalAttack = wpvm.GoWizard.PhysicalAttack;
                //Data.ChosenHero.MagicalAttack = wpvm.GoWizard.MagicalAttack;
                //Data.ChosenHero.CriticalChance = wpvm.GoWizard.CriticalChance;
                //Data.ChosenHero.ImageSource = wpvm.GoWizard.ImageSource;

                await Navigation.PushAsync(new BattlePage());
            }
            else
            {
                return;
            }
        }
    }
}