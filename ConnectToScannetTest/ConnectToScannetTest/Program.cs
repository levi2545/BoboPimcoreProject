using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ScannetOnline;

namespace ConnectToScannetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = test();
            Console.WriteLine(c.Length);
            foreach (ScannetOnline.Product item in c)
            {
                Console.WriteLine("ItemNumber: " + item.Id);
            }
            Console.ReadLine();
        }

        private static Product[] test()
        {
            ScannetOnline.WebServicePortClient client = new WebServicePortClient();

            client.Solution_Connect("api@boboonline.dk", "Bobo8902");
            client.Solution_SetLanguage("DK");
            var result = client.Product_GetAll();
            return result;
        }
    }
}