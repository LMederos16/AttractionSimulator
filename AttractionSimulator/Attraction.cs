using AttractionSimulator;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttractionSimulator
{
    internal class Attraction
    {
        public string Name { get; set; }
        public int VehicleCapacity { get; set; }
        public bool IsOperating { get; set; }

        public Attraction(string name, int vehicleCapacity, bool isOperating)
        {
            Name = name;
            VehicleCapacity = vehicleCapacity;
            IsOperating = isOperating;
        }
    }
}


