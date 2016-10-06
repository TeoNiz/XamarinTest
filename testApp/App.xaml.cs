using Xamarin.Forms;

namespace testApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new MainPage();
			MainPage = new NavigationPage(new testApp.MainPage())
			{
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex("63ad72")
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
