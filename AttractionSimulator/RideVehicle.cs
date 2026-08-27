namespace AttractionSimulator
{
    internal class RideVehicle
    {
        public int VehichleId { get; set; }
        public int Capacity { get; set; }
        public int PassengerCount { get; set; }
        public bool RestraintsEngaged { get; set; }

        public RideVehicle(int vehicleId, int capacity, int passangerCount)
        {
            VehichleId = vehicleId;
            Capacity = capacity;
            PassengerCount = passangerCount;
        }

        public void LoadPassangers(int number)
        {
            if (PassengerCount + number > Capacity)
            {
                Console.WriteLine("This party is too big to load. Please wait for the next train.");
            }
            else
            {
                PassengerCount = PassengerCount + number;

                Console.WriteLine($"Loaded! There are now {PassengerCount} on this train!");
            }
        }
    }
}
