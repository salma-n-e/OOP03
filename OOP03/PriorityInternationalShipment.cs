using System;

namespace OOP03
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            
            Console.WriteLine($"[PRIORITY] Fast-track customs report generated for {TrackingCode}. Fee: {CustomsFeeproperty:C}");
        }

        
        public override void PrintShipmentDetails()
        {
            Console.WriteLine(" Priority International Shipment ");
            base.PrintShipmentDetails();
        }
    }
}