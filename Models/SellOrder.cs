using System;

namespace iPhone.Models
{
	public class SellOrder
	{
		public String OrderType { get; set; }
		public Decimal Price { get; set; }
		public Decimal Volume { get; set;}

		public SellOrder ()
		{
		}
	}
}

