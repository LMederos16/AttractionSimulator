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
        public bool IsOperating { get; private set; }

        public Attraction(string name, int vehicleCapacity, bool isOperating)
        {
            Name = name;
            VehicleCapacity = vehicleCapacity;
            IsOperating = isOperating;
        }
        public void Start()
        {
            IsOperating = true;
        }
        public void Stop()
        {
            IsOperating = false;
        }
    }
}


