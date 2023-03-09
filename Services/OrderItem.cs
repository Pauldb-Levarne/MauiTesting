using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUIHamatTest.Services
{
    public partial class OrderItem : ObservableObject
    {

        public OrderItem()
        {

        }
        [ObservableProperty]
        string itemColor;

        [ObservableProperty]
        string _operator;

        [ObservableProperty]
        int orderLine;

        [ObservableProperty]
        string labelFormat;

        [ObservableProperty]
        int layersOnPallet;

        [ObservableProperty]
        int quantity;

        [ObservableProperty]
        int quantityDone;


        public int QuantityRemaining => Quantity - QuantityDone;


    }

}

