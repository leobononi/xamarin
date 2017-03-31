using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MobileApp.Android.Views
{
    [Activity(Label = "View for CalcViewModel")]
    public class CalcView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CalcView);
        }
    }
}
