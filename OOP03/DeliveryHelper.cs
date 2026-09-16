using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipmentDetails();
            }
        }
    }
}
