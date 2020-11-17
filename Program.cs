using System;
using ZXing;

namespace QRExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello QR Code!");
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    CharacterSet = "UTF-8",
                    Height = 400,
                    Width = 400
                }
            };
            string body = @"https://otiai10.hatenablog.com/";
            System.Drawing.Bitmap bitmap = writer.Write(body);
            bitmap.Save("./example.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
