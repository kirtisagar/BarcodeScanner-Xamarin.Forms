using System;
using System.Threading.Tasks;
using Scanner;
using Scanner.WinPhone;
using Xamarin.Forms;

using ZXing.Mobile;
using App = Scanner.WinPhone.App;

[assembly: Xamarin.Forms.Dependency (typeof (Scanner.Wp.Scanner))]

namespace Scanner.Wp
{
	public class Scanner: IScanner
	{
		#region IScanner implementation

		async public Task<string> Scan ()
		{
			//NOTE: On Android you MUST pass a Context into the Constructor!
			var scanner = new ZXing.Mobile.MobileBarcodeScanner(WinPhone.App.RootFrame.Dispatcher);
			var result = await scanner.Scan();

			//if (result != null)
			//	Console.WriteLine("Scanned Barcode: " + result.Text);

		    return result.Text;
		}

		#endregion


	}
}

