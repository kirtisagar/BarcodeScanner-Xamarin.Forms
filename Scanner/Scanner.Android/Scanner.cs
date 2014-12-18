using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Scanner.Droid;

[assembly: Xamarin.Forms.Dependency (typeof (Scanner.Droid.Scanner))]

namespace Scanner.Droid
{
	public class Scanner: IScanner
	{
		#region IScanner implementation

		async public Task<string> Scan ()
		{
			//NOTE: On Android you MUST pass a Context into the Constructor!
			var scanner = new ZXing.Mobile.MobileBarcodeScanner(Xamarin.Forms.Forms.Context);
			var result = await scanner.Scan();

			//if (result != null)
				//Console.WriteLine("Scanned Barcode: " + result.Text);

			return result.Text;
		}

		#endregion


	}
}

