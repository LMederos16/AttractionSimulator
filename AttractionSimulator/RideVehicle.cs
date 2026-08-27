namespace AttractionSimulator
{
    internal class RideVehicle
    {
        public int VehicleId { get; set; }
        public int Capacity { get; set; }
        public int PassengerCount { get; set; }
        public bool RestraintsEngaged { get; private set; }

        public RideVehicle(int vehicleId, int capacity, int passengerCount)
        {
            VehicleId = vehicleId;
            Capacity = capacity;
            PassengerCount = passengerCount;
        }

        public void LoadPassengers(int number)
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

        public void ToggleRestraints()
        {
            RestraintsEngaged = !RestraintsEngaged;

            if (RestraintsEngaged)
            {
                Console.WriteLine("The restraints are engaged!");
            }
            else
            {
                Console.WriteLine("The restraints are disengaged!");
            }
        }
    }
}
