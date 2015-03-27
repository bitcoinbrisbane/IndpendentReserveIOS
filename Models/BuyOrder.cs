using System;

namespace iPhone.Models
{
	public class BuyOrder
	{
		public String OrderType { get; set; }
		public Decimal Price { get; set; }
		public Decimal Volume { get; set;}

		public BuyOrder ()
		{
		}
	}
}

