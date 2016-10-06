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
			CheckDatabasePopulated();
			//taskText.Text = Helpers.Settings.GeneralSettings;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = GetToDoList();
		}

		public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			((ListView)sender).SelectedItem = null;

			var todoEditPage = new ToDoEditPage((ToDoListItem)e.SelectedItem);
			await Navigation.PushAsync(todoEditPage);
		}

		List<ToDoListItem> GetToDoList()
		{
			var items = new Database().GetTodoItems();
			return items;
		}

		void CheckDatabasePopulated()
		{
			if (new Database().GetTodoItems().Count < 1)
			{
				var items = new List<ToDoListItem>();
				for (int i = 0; i < 10; i++)
				{
					items.Add(
						new ToDoListItem()
						{
							title = "Task " + (i + 1).ToString(),
							content = "Description - Tap to edit",
							alpha = (1 - ((double)(i+1) / 20)).ToString()
						}
					);
				}
				new Database().AddTodoItems(items);
			}
		}
	}
}
