namespace AttractionSimulator
{
    internal class RideVehicle
    {
        public int VehichleId { get; set; }
        public int Capacity { get; set; }
        public int PassangerCount { get; set; }
        public bool RestraintsEngaged { get; set; }

        public RideVehicle(int vehicleId, int capacity, int passangerCount)
        {
            VehichleId = vehicleId;
            Capacity = capacity;
            PassangerCount = passangerCount;
        }

        public void LoadPassangers(int number)
        {
            PassangerCount = PassangerCount + number;
            if (PassangerCount > Capacity)
            {
                Console.WriteLine("This part is too big to load. Please wait for the next train.");
                PassangerCount = PassangerCount - number;
            }
            else
            {
                Console.WriteLine($"Loaded! There are now {PassangerCount} on this train!");
            }
        }
    }
}
