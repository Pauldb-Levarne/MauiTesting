using MAUIHamatTest.Services;
using MAUIHamatTest.ViewModels;

namespace MAUIHamatTest
{
    public partial class MainPage : ContentPage
    {
        private DashboardViewModel viewModel;

        public MainPage(DashboardViewModel dashboardViewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel = dashboardViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.Load(new DashboardService());
        }
    }
}
