namespace AttractionSimulator
{
    internal class RideVehicle
    {
        public int VehicleId { get; set; }
        public int Capacity { get; set; }
        public int PassengerCount { get; set; }
        public bool RestraintsEngaged { get; private set; }
        public bool RestraintCheck { get; private set; }

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
                // Restraints must be checked again once disengaged.
                RestraintCheck = false;
                Console.WriteLine("The restraints are disengaged!");
            }
        }

        public void CheckRestraints()
        {
            RestraintCheck = true;
            Console.WriteLine("Restraints are checked!");
        }

        public void Dispatch()
        {
            if(RestraintsEngaged && RestraintCheck)
            {
                Console.WriteLine("Dispatching!");
            }
            else
            {
                Console.WriteLine("Cannot dispatch! Restraints not engaged or not checked!");
            }
        }
    }
}
