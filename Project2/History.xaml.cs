using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project2
{
	public partial class History : ContentPage
	{
		public History()
		{
			InitializeComponent();
		}

		async void OnClickGoHome(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Project2Page());
		}

	}
}
