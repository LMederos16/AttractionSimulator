namespace AttractionSimulator
{
    enum VehicleState
    {
        Empty,
        Loading,
        SafetyChecks,
        Ready,
        Dispatched,
        Unloading
    }
    internal class RideVehicle
    {
        public int VehicleId { get; set; }
        public int Capacity { get; set; }
        public int PassengerCount { get; set; }
        public bool RestraintsEngaged { get; private set; }
        public bool RestraintCheck { get; private set; }
        public VehicleState State { get; private set; }

        public RideVehicle(int vehicleId, int capacity, int passengerCount)
        {
            VehicleId = vehicleId;
            Capacity = capacity;
            PassengerCount = passengerCount;
            State = VehicleState.Empty;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Vehicle Number: {VehicleId}\n" +
                $"Vehicle State : {State}\n" +
                $"Vehicle Capacity: {Capacity}\n" +
                $"Passengers On Vehicle: {PassengerCount}\n" +
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
                Console.WriteLine("Number must be greater than 0!");
            }
            else
            {
                State = VehicleState.Loading;
                PassengerCount = PassengerCount + number;

                Console.WriteLine($"Loaded! There are now {PassengerCount}  passengers on this train!");
            }
        }

        public void LoadPassengers()
        {
            if (State == VehicleState.Empty || State == VehicleState.Loading)
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
            else
            {
                Console.WriteLine("Vehicle must be empty or loading!");
            }
        }

        public void ToggleRestraints()
        {
            if (State == VehicleState.Loading || State == VehicleState.SafetyChecks)
            {
                if (!RestraintsEngaged)
                {
                    RestraintsEngaged = true;
                    Console.WriteLine("The restraints are engaged!");
                    State = VehicleState.SafetyChecks;
                }
                else
                {
                    // Restraints must be checked again once disengaged.
                    RestraintsEngaged = false;
                    RestraintCheck = false;
                    Console.WriteLine("The restraints are disengaged!");
                    State = VehicleState.Loading;
                }
            }
            else
            {
                Console.WriteLine("Restraints can only be changed while loading or performing safety checks!");
            }
        }

        public void CheckRestraints()
        {
            if (State == VehicleState.SafetyChecks)
            {
                if (RestraintsEngaged)
                {
                    RestraintCheck = true;
                    Console.WriteLine("Restraint check passed!");
                    State = VehicleState.Ready;
                }
                else
                {
                    Console.WriteLine("Restraints must be engaged!");
                }
            }
            else
            {
                Console.WriteLine("Vehicle must be in the safety check phase!");
            }
        }

        public void Dispatch()
        {
            if (State == VehicleState.Ready)
            {
                if (RestraintsEngaged && RestraintCheck)
                {
                    Console.WriteLine("Dispatching!");
                    State = VehicleState.Dispatched;
                }
                else
                {
                    Console.WriteLine("Cannot dispatch! Restraints not engaged or not checked!");
                }
            }
            else
            {
                Console.WriteLine("Vehicle must be ready for dispatch!");
            }
        }

        public void ReturnToStation()
        {
            if (State == VehicleState.Dispatched)
            {
                RestraintsEngaged = false;
                RestraintCheck = false;
                Console.WriteLine("Vehicle has returned to station.");
                State = VehicleState.Unloading;
            }
            else
            {
                Console.WriteLine("Vehicle must be dispatched!");
            }
        }
        
        public void UnloadPassengers()
        {
            if (State == VehicleState.Unloading)
            {
                if (!RestraintsEngaged)
                {
                    PassengerCount = 0;
                    Console.WriteLine("Unloading Passengers.");
                    State = VehicleState.Empty;
                }
                else
                {
                    Console.WriteLine("You need to disengage the restraints!");
                }
            }
            else
            {
                Console.WriteLine("Vehicle must be in unloading phase");
            }
        }
    }
}
