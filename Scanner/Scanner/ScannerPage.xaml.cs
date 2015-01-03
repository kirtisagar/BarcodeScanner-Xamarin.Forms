using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Scanner
{	
	public partial class ScannerPage : ContentPage
	{	
		public ScannerPage ()
		{
			InitializeComponent ();
		}
		async void onScanClicked(object sender, EventArgs e)
		{
			var data = await DependencyService.Get<IScanner> ().Scan ();

			DisplayAlert ("Scanner", data, "cancel");
		}
	}
}

