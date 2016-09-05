
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace BillTracker
{
	[Activity(Label = "Bill Tracker", Theme="@style/AppTheme")]
	public class AddOrEditBillActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.AddOrEditBillActivity);

			// Create your application here
		}
	}
}

