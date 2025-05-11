using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Nuta.MobileApp.MAUI;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

#pragma warning disable CA1422
        if (OperatingSystem.IsAndroidVersionAtLeast(25))
            Window?.SetNavigationBarColor(Android.Graphics.Color.WhiteSmoke);
#pragma warning restore CA1422
    }
}