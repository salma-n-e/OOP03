using OOP03;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override void PrintShipmentDetails()
        {
            Console.WriteLine(" Standard Shipment Details ");
            base.PrintShipmentDetails();
        }

    }
}