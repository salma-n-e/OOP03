using System;
using System.Collections.Generic;
using System.Text;
using OOP03;

namespace OOP03
{
    public struct DeliveryAddress
    {
        public string city;
        public string street;
        public int BuildingNumber;
        public DeliveryAddress(string City, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{city}, {street}, {BuildingNumber}";

        }
    }
}