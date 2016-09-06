using System;
using Realms;

namespace Core
{
	public class BillPaid : RealmObject
	{
		public BillPaid()
		{
		}

		public String uuid { get; set;}
		public DateTimeOffset date { get; set;}
	}
}

