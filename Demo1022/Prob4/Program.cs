using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region An array of the base class type is created and initialized
            // with a member of each class in the hierarchy
            Parent[] myArray = new Parent[3];
            myArray[0] = new Parent();
            myArray[1] = new Child();
            myArray[2] = new Grandchild();
            #endregion

            #region Show that a method belonging to the base class is called
            // from a child instance

            // create ParentMethod() in Parent and iterate through array
            // calling this method to demonstrate that all child classes
            // have access to it
            foreach (Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.ParentMethod();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate overriding a base class method by a child
            foreach (Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.SomeMethod();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate a child method calling the parent's method
            // create a virtual method in parent
            // override in child and call the parent as part of the implementation.
            foreach (Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.Method2();
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate use of "as" keyword
            // repeat class to SomeMethod
            foreach (object element in myArray)
            {
                //Parent p = element as Parent;
                Parent p = (Parent)element;
                Console.Write("{0}: ", p.GetType());
                p.SomeMethod();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate use of "is" keyword
            Console.WriteLine("Demo use of is");
            foreach (Parent element in myArray)
            {
                // note: order is important
                // Grandchild -> Child -> Parent = Grandchild -> Child -> Parent
                // Parent -> Child -> Grandchild = Parent -> Parent -> Parent
                if (element is Grandchild)
                {
                    Console.WriteLine("Grandchild");
                } else if (element is Child)
                {
                    Console.WriteLine("Child");
                } else if (element is Parent)
                {
                    Console.WriteLine("Parent");
                }
            }
            Console.WriteLine();
            #endregion

            #region switch
            Console.WriteLine("Demo switch");
            foreach (Parent element in myArray)
            {
                switch (element)
                {
                    case Grandchild gc:
                        Console.WriteLine("Grandchild");
                        break;
                    case Child c:
                        Console.WriteLine("Child");
                        break;
                    case Parent p:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            Console.WriteLine();
            #endregion

            #region Create an object of "object" type, but initialized of the
            // base class type, then cast it to the actual type so you can call
            // a method
            object obj = new Parent();
            ((Parent)obj).ParentMethod();

            Parent p2 = new Grandchild();
            ((Grandchild)p2).SpecializedMethod();
            #endregion
        }
    }
}
