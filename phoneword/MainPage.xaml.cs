using Android.Telephony;
using Javax.Security.Auth;

namespace phoneword
{
    public partial class MainPage : ContentPage
    }
string translatedNumber;
Private void OnTranslate(object sender, EventArgs e)
    {
    string enteredNumber = PhoneNumberFormattingTextWatcher.Text;
translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);

if (!string.IsNullOrEmpty(translatedNumber))
{
    CallButton.IsEnabled = true;
    CallButton.Text = "Call" + translatedNumber;
}
else
{
    CallButton.IsEnabled = false;
    CallButton.Text = "Call";

}
public partial class MainPage : ContentPage
{
    async void OnCall(object, System.EventArgs e)
    {
        if (await this.DisplayAlert(
            "Dial a Number," +
            "Would you like to call"+translatedNumber + "?>",
            "yes",
            "no"))
            {
            //Todo
        }
    }
}

public MainPage()
        {
            InitializeComponent();
        }

}
