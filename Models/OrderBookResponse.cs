using System;
using System.Collections.Generic;

namespace iPhone.Models
{
	public class OrderBookResponse
	{
		public String PrimaryCurrencyCode { get; set;}
		public String SecondaryCurrencyCode { get; set;}

		public IList<BuyOrder> BuyOrders { get; set; }
		public IList<SellOrder> SellOrders { get; set; }

		public OrderBookResponse ()
		{
		}
	}
}