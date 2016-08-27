using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLemonWay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init Webservice
            WSLemonWay.WS_LemonWay ws = new WSLemonWay.WS_LemonWay();

            //Call method 
            Console.WriteLine(ws.Fibonacci(10));

            Console.ReadLine();
        }
    }
}
