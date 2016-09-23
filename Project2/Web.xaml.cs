using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace Project2
{
	
	public partial class Web : ContentPage
	{
		public Web()
		{
			InitializeComponent();

			var browser = new WebView
			{
				Source = "http://xamarin.com"
			};


	}

		void webOnNavigating(object sender, WebNavigatingEventArgs e)

		{
			LoadingLabel.IsVisible = true;
		}

		void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
		{
			LoadingLabel.IsVisible = false;
		}

	}
}

