using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;

namespace BillTracker
{
	[Activity(Label = "Bill Tracker", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.main_toolbar);
			SetSupportActionBar(toolbar);

			FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
			fab.Click += delegate {
				StartActivity(typeof(AddOrEditBillActivity));
			};

		}
	}
}


