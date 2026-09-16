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



           
            Driver driver = new Driver(1, "Ahmed Hassan", "01012345678");

            
            DeliveryCenter center = new DeliveryCenter("Cairo Main Center", 5, driver);

            DeliveryAddress address = new DeliveryAddress("El Shorouk", "Cairo", 15);

            
            StandardShipment std = new StandardShipment("STD101", "Books", 2.0, 30, address);

            
            ExpressShipment exp = new ExpressShipment("EXP202", "Electronics", 1.5, 40, address, 25);

            
            InternationalShipment inter = new InternationalShipment("INT303", "Documents", 0.5, 100, address, "UAE", 50);

           
            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(inter);

           
          
            Console.WriteLine(" PrintAllShipments Output ");
            center.PrintAllShipments();

            
            
            Console.WriteLine(" DeliveryHelper Output ");
           
            DeliveryHelper.PrintShipmentDetails(std);
           
            DeliveryHelper.PrintShipmentDetails(exp);
            
            DeliveryHelper.PrintShipmentDetails(inter);

            
           
            Console.WriteLine(" Overloading UpdateWeight ");
            
            std.UpdateWeight(3.5); 
            Console.WriteLine($"Updated Weight (v1): {std.Weight} kg");

            std.UpdateWeight(3.5, 0.5); 
            Console.WriteLine($"Updated Weight (v2 with extra packing): {std.Weight} kg");

            
            Console.WriteLine("Mixed Shipment Array Loop ");
           
            Shipment[] mixedShipments = new Shipment[]
            {
                std,
                exp,
                inter,
                new PriorityInternationalShipment("PRI404", "Medical Supplies", 5.0, 200, address, "USA", 150),
                new CompletedShipment("COM505", "Clothing", 1.2, 20, address, DateTime.Now)
            };

            foreach (Shipment s in mixedShipments)
            {
                s.PrintShipmentDetails();
              
            }

       
            Console.WriteLine(" Sealed Class & Method Demo ");

           
            PriorityInternationalShipment priority = new PriorityInternationalShipment("PRI404", "Medical Supplies", 5.0, 200, address, "USA", 150);
            priority.GenerateCustomsReport();

            
            CompletedShipment completed = new CompletedShipment("COM505", "Clothing", 1.2, 20, address, DateTime.Now);
            completed.PrintShipmentDetails();

        
        }
    }
}

