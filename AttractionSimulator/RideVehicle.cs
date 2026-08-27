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

        public void DisplayStatus()
        {
            Console.WriteLine($"Vehicle Number: {VehicleId}\n" +
                $"Vehicle Capacity: {Capacity}\n" +
                $"Passengers On Vechile: {PassengerCount}\n" +
                $"Restraints Engaged: {RestraintsEngaged}\n" +
                $"Restraint Checked: {RestraintCheck}");
        }
        public void LoadPassengers(int number)
        {
            if (PassengerCount + number > Capacity)
            {
                Console.WriteLine("This party is too big to load. Please wait for the next train.");
            }
            else if (number <= 0)
            {
                Console.WriteLine("Number cannot be negative!");
            }
            else
            {
                PassengerCount = PassengerCount + number;

                Console.WriteLine($"Loaded! There are now {PassengerCount}  passengers on this train!");
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
            if (RestraintsEngaged)
            {
                RestraintCheck = true;
                Console.WriteLine("Checking restraints!");
            }
            else
            {
                Console.WriteLine("Restraints must be engaged!");
            }
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

        public void LoadPassengers()
        {
            if (!RestraintsEngaged)
            {
                Console.Write("How many passengers are loading? ");
                
                if (int.TryParse(Console.ReadLine(), out int partySize))
                {
                    LoadPassengers(partySize);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("The restraints are still engaged! Cannot load!");
            }
        }
        
        public void UnloadPassengers()
        {
            if (!RestraintsEngaged)
            {
                PassengerCount = 0;
                Console.WriteLine("Unloading Passengers.");
            }
            else
            {
                Console.WriteLine("You need to disengage the restraints!");
            }
        }
    }
}
