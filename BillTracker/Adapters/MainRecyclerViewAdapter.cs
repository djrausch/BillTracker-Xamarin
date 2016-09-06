using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Core;
using Realms;

namespace BillTracker
{
	public class MainRecyclerViewAdapter : RecyclerView.Adapter
	{
		public IList<Bill> bills;

		public MainRecyclerViewAdapter(IList<Bill> bills)
		{
			this.bills = bills;
		}

		public override int ItemCount
		{
			get
			{
				return bills.Count;
			}
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			MainViewHolder mvh = holder as MainViewHolder;
			Bill b = bills[position];

			mvh.Name.Text = b.name;

		}

		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			View billView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.BillRow, parent, false);

			MainViewHolder vh = new MainViewHolder(billView);
			return vh;
		}
	}

	
}

