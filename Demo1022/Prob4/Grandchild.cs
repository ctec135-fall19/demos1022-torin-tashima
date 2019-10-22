﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Grandchild : Child
    {
        // Demonstrate overriding a base class method by a child
        public override void SomeMethod()
        {
            Console.WriteLine("Grandchild's SomeMethod");
        }

        // Demonstrate a child method calling the parent's method
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Grandchild.Method2");
        }

        public void SpecializedMethod()
        {
            Console.WriteLine("SpecializedMethod");
        }
    }
}
