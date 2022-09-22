using PrismApp1.Helpers;
using PrismApp1.Models;

namespace PrismApp1.Views;

public partial class DashboardDetails : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
	bool IsManual = false;
	Esp context=new Esp();
    public DashboardDetails()
	{
		InitializeComponent();

	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		context = (Esp)BindingContext;
		IsManual = context.Manual==1;
        LightSwitch.IsEnabled = IsManual;
    }

	private async void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		var manualMode = e.Value;
		IsManual = manualMode;
		LightSwitch.IsEnabled = IsManual;
		context.Manual = manualMode==true?1:0;
		await firebaseHelper.SwitchToManual("1",context);
	}

	private async void Switch_Toggled_1(object sender, ToggledEventArgs e)
	{
        var manualMode = e.Value;
        context.HasLight = manualMode == true ? 1 : 0;
        var manualLight = e.Value.ToString();
		await firebaseHelper.ManualSwitchLight("1", context);
	}
}
