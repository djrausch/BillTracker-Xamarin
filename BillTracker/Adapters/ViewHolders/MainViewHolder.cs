using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;


namespace BillTracker
{

	public class MainViewHolder : RecyclerView.ViewHolder
	{
		public TextView Name { get; set; }
		public TextView DueInDays { get; set;}
		public TextView DueDate { get; set;}
		public TextView DueDateTopLabel { get; set; }
		public TextView DueDateBottomLabel { get; set;}

		public MainViewHolder(View itemView) : base (itemView)
    	{
			// Locate and cache view references:
			Name = itemView.FindViewById<TextView>(Resource.Id.name);
			DueInDays = itemView.FindViewById<TextView>(Resource.Id.due_in_days);
			DueDate = itemView.FindViewById<TextView>(Resource.Id.due_date);
			DueDateTopLabel = itemView.FindViewById<TextView>(Resource.Id.due_top_label);
			DueDateBottomLabel = itemView.FindViewById<TextView>(Resource.Id.due_bottom_label);
		}
	}
}
