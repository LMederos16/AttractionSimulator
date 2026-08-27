using System;
using System.Collections.Generic;
using System.Text;

namespace AttractionSimulator
{
    internal class RideVehicle
    {
        int VehichleId { get; set; }
        int Capacity { get; set; }
        int PassangerCount { get; set; }

        public RideVehicle(int vehicleId, int capacity, int passangerCount)
        {
            VehichleId = vehicleId;
            Capacity = capacity;
            PassangerCount = passangerCount;
        }
    }
}
