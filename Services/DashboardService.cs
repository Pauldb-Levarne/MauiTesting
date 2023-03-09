using System;
namespace MAUIHamatTest.Services
{
	public partial class DashboardService
	{
		public DashboardService()
		{

		}


        public OrderItem GetOrderItem() => new()
        {
            ItemColor = "Red",
            Operator = "John",
            OrderLine = 1,
            LabelFormat = "A4",
            LayersOnPallet = 5,
            Quantity = 100,
            QuantityDone = 20
        };
    }
}

