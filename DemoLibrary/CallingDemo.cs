using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();

            /* CallingDemo is inside the same assembly: DemoLibrary
             * That's why we can access InternalDemo method here
            */
            demo.InternalDemo();
        }
    }
}
