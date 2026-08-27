namespace AttractionSimulator
{
    internal class RideVehicle
    {
        public int VehichleId { get; set; }
        public int Capacity { get; set; }
        public int PassangerCount { get; set; }

        public RideVehicle(int vehicleId, int capacity, int passangerCount)
        {
            VehichleId = vehicleId;
            Capacity = capacity;
            PassangerCount = passangerCount;
        }
    }
}
