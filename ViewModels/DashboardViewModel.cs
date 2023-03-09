using System;
using CommunityToolkit.Mvvm.ComponentModel;
using MAUIHamatTest.Services;
namespace MAUIHamatTest.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        public DashboardService _dashboardService;

        [ObservableProperty]
        private OrderItem orderItem;

        public DashboardViewModel()
        {
        }

        public void Load(DashboardService dashboardService)
        {
            _dashboardService = dashboardService;
            OrderItem = _dashboardService.GetOrderItem();
        }

    }

}


