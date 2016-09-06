
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
using Core.Util;
using BillTracker.Adapters;

namespace BillTracker
{
	[Activity(Label = "Bill Tracker", Theme="@style/AppTheme")]
	public class AddOrEditBillActivity : AppCompatActivity
	{
        public Spinner RepeatingSpinner;
        public EditText Name;
        public EditText PayUrl;
        public TextView DueDateSelect;

        private RepeatingItem mRepeatingItem;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            SetContentView(Resource.Layout.AddOrEditBillActivity);
            SetupViews();
            ConfigureRepeatingSpinner();
            

		}

        private void SetupViews()
        {
            RepeatingSpinner = FindViewById<Spinner>(Resource.Id.repeating_spinner);
            Name = FindViewById<EditText>(Resource.Id.name);
            PayUrl = FindViewById<EditText>(Resource.Id.pay_url);
            DueDateSelect = FindViewById<TextView>(Resource.Id.due_date_select);
        }

        private void ConfigureRepeatingSpinner()
        {
            mRepeatingItem = new RepeatingItem(RepeatingItem.ConvertCodeToString(RepeatingItem.CODE_MONTHLY), RepeatingItem.CODE_MONTHLY);

            RepeatingSpinnerAdapter repeatingSpinnerAdapter = new RepeatingSpinnerAdapter(this, Android.Resource.Layout.SimpleSpinnerItem);
            repeatingSpinnerAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

            RepeatingSpinner.Adapter = repeatingSpinnerAdapter;
            RepeatingSpinner.SetSelection(mRepeatingItem.Index);

            RepeatingSpinner.ItemSelected += (sender, args) =>
            {
                mRepeatingItem = repeatingSpinnerAdapter.GetItem(args.Position);
            };
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.AddMenu, menu);
            return base.OnPrepareOptionsMenu(menu);
        }
    }
}

