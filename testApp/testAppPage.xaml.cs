using Xamarin.Forms;

namespace testApp
{
	public partial class testAppPage : ContentPage
	{
		public testAppPage()
		{
			InitializeComponent();
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Children ={
					new Label{HorizontalTextAlignment=TextAlignment.Center, Text="Wircomen"},
					new Button{Text="Klik meh"},
					new Label{Text="0"}
				}

			};
		}
	}
}
