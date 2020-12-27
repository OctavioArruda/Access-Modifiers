using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class InheritFromAccess : AccessDemo
    {
        public void Test()
        {
            /* It is possible to call protected methods in this class
             * because InheritFromAccess class iherit from AccessDemo class
             * Proctected modifiers allows to access code from it's owner class and the ones
             * who inherit from the owner class.
             * */
            ProtectedDemo();

            /* Same assembly, we can access InternalDemo method
             * inside the InheritFromAccess method
             * */
            InternalDemo();
        }
    }
}
