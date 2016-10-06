using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace testApp
{
	public partial class ToDoEditPage : ContentPage
	{
		public ToDoListItem Model
		{
			get { return (ToDoListItem)BindingContext;}
			set
			{
				BindingContext = value;
				OnPropertyChanged();
			}
		}

		public ToDoEditPage(ToDoListItem _model)
		{
			Model = _model;
			Title = "Edit";
			InitializeComponent();
		}

		public void OnSave(object sender, EventArgs e)
		{
			if (!CheckName())
				return;

			new Database().EditItem(Model);
			Navigation.PopAsync();
		}

		public bool CheckName()
		{
			if (String.IsNullOrEmpty(Model.title))
			{
				DisplayAlert("Error", "Titile can not be empty!","OK");
				return false;
			}
			return true;
		}

	}
	public class AdMobView : ContentView
	{
		public AdMobView() { }
	}
}
