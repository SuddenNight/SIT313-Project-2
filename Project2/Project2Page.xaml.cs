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
		async void OnClickHistory(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new History());
		}
		async void OnClickStartSite(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Web());
		}
		async void OnClickDev(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Dev());
		}
	}
}
