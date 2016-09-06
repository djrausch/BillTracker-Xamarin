using System;
using Realms;

namespace Core
{
	public class Bill : RealmObject
	{
		public Bill()
		{
		}

		public String uuid { get; set; }
		public String name { get; set; }
		public String description { get; set; }
		public int repeatingType { get; set; } = 0;
		public DateTimeOffset dueDate { get; set; }
		public String payUrl { get; set; }
		public RealmList<BillPaid> paidDates { get; set; }
		public Boolean deleted { get; set; } = false;
	}
}

