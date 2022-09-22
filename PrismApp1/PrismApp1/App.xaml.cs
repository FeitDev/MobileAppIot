using Firebase.Database;

namespace PrismApp1;

public partial class App : Application
{
    public static FirebaseClient firebasClient = new FirebaseClient("https://espmodule-16619-default-rtdb.firebaseio.com/");

    public App()
    {
        InitializeComponent();
    }
}
