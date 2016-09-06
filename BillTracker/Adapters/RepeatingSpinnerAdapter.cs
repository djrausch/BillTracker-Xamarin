using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.Util;

namespace BillTracker.Adapters
{
    class RepeatingSpinnerAdapter : ArrayAdapter<RepeatingItem>
    {
        public RepeatingSpinnerAdapter(Context context, int resource) : base(context,resource,RepeatingItem.GetItems())
        {
            SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view;
            TextView text;

            if(convertView == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Android.Resource.Layout.SimpleSpinnerItem, parent, false);
            } else
            {
                view = convertView;
            }

            text = view as TextView;

            RepeatingItem item = GetItem(position);
            text.Text = item.Title;

            return view;
        }

        public override View GetDropDownView(int position, View convertView, ViewGroup parent)
        {
            View view;
            TextView text;

            if(convertView == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Android.Resource.Layout.SimpleSpinnerDropDownItem, parent, false);
            } else
            {
                view = convertView;
            }

            text = view as TextView;

            RepeatingItem item = GetItem(position);
            text.Text = item.Title;

            return text;
        }
    }
}