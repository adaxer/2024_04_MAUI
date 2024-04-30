namespace HomeCenter.Mobil.Views;

public class BellNotificationPage : ContentPage
{
	public BellNotificationPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!" },
        new Button { Text = "Start Watching" }
				}
		};
	}
}
