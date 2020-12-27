using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo();

            /* PublicDemo is accessible here since it's public.
             * Public access modifiers make code accessible for all clases, anywhere.
             * */
            demo.PublicDemo();
        }
    }
}
