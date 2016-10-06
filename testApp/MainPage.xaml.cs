using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace testApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			taskText.Text = Helpers.Settings.GeneralSettings;
		}

		async void AddTaskButtonClicked(object sender, EventArgs e)
		{
			var text = taskText.Text;
			if (!string.IsNullOrWhiteSpace(text))
			{
				Helpers.Settings.GeneralSettings = text;
				ShowAlert("Success!", "Now go and do it!");
			}
			else
			{
				ShowAlert("Fail!", "Please type something!");
			}
		}

		void ShowAlert(String title, String message)
		{
			DisplayAlert(title, message, "OK");
		}
	}

	public class AdMobView : ContentView
	{
		public AdMobView() {}
	}
}
