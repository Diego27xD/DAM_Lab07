using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DAM_Lab07.Droid.ImplementsInterface;
using DAM_Lab07.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


[assembly: Dependency(typeof(ImplementQRScannerService))]
namespace DAM_Lab07.Droid.ImplementsInterface
{
    public class ImplementQRScannerService : IQRScannerService
    {
        public async Task<string> ReadQrScanner()
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "Lectura de QR";
                scanner.BottomText = "Please Wait";
                var result = await scanner.Scan();
                return result.Text;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return e.Message;
            }
        }
    }
}