using Android.App;
using Android.Content.PM;

[assembly: Shiny.ShinyApplication(
    ShinyStartupTypeName = "Scanizr.Sample.Forms.Startup",
    XamarinFormsAppTypeName = "Scanizr.Sample.Forms.App"
)]
namespace Scanizr.Sample.Forms.Droid
{
    [Activity(Theme = "@style/MainTheme", MainLauncher = true,
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public partial class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
    }
}

