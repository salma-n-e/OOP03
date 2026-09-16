using OOP03;
using System;

namespace OOP03
{
    
    public sealed class CompletedShipment : Shipment
    {
        public DateTime CompletionDate { get; set; }

        public CompletedShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, DateTime completionDate)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CompletionDate = completionDate;
        }

        public override void PrintShipmentDetails()
        {
            Console.WriteLine(" Completed Shipment ");
            base.PrintShipmentDetails();
            Console.WriteLine($"Completion Date: {CompletionDate:yyyy-MM-dd}");
        }
    }
}