namespace HomeCenter.Mobil.Views;

public partial class HolidaysPage : ContentPage 
{
	public HolidaysPage(HolidaysViewModel viewModel)
	{
		InitializeComponent();
    BindingContext = viewModel;
	}
}
