using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.Navigation;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace SampleApp;
//@style/Maui.SplashTheme"
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
    {

        Window.SetNavigationBarColor(Android.Graphics.Color.Pink);
        base.OnCreate(savedInstanceState);
    }
  
}
