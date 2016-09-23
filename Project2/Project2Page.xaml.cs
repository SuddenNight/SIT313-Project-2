using System;
using Xamarin.Forms;

namespace Project2
{
	public partial class Project2Page : ContentPage
	{
		public Project2Page()
		{
			InitializeComponent();
		}
		async void OnClickStart(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ShoppingList());
		}
	}
}
