using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;
using Realms;
using Core;
using System.Linq;
using Android.Views;

namespace BillTracker
{
	[Activity(Label = "Bill Tracker", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{

		RecyclerView mRecyclerView;
		MainRecyclerViewAdapter mAdapter;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			this.Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
			SetContentView(Resource.Layout.Main);

			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.main_toolbar);
			SetSupportActionBar(toolbar);

			var realm = Realm.GetInstance();
			realm.Write(() =>
			{
				var bill = realm.CreateObject<Bill>();
				bill.name = "Test!!!";
			});

			var bills = realm.All<Bill>().Where(b=>!b.deleted).ToList();

			mRecyclerView = FindViewById<RecyclerView>(Resource.Id.main_recyclerview);

			mRecyclerView.SetLayoutManager(new LinearLayoutManager(this));
			mAdapter = new MainRecyclerViewAdapter(bills);
			mRecyclerView.SetAdapter(mAdapter);

			FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
			fab.Click += delegate {
				StartActivity(typeof(AddOrEditBillActivity));
			};

		}
	}
}


