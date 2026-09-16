using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 
            // a) Method Overloading : Allows a class to have multiple methods with the same name
            //  but different Parameters.
            //   Method Overriding :Allows a derived class to provide a specific implementation 
            //   of a method that is already defined in its base class.

            // b) Static Binding (Early Binding): The compiler determines which method to call
            // at compile time based on the reference type .

            //  Dynamic Binding(Late Binding): The runtime determines which
            //      method implementation to call at run time based
            //     on the actual object instance stored in memory.

            // 2 
            // a) Applying sealed to a class prevents other classes from inheriting from it.
            // b) Sealed Class: Prevents any class from inheriting from it.
            // Sealed Method: Prevents a derived class from further overriding that specific
            // A method can only be declared sealed if it is also modifying an inherited override method.
            // c) No. A sealed method cannot be overridden because the explicit purpose of the sealed modifier on
            // a method is to break the virtual inheritance chain and lock down the implementation so downstream
            // derived classes cannot modify it.
            
        }
    }
}
