namespace AttractionSimulator
{
    internal class Attraction
    {
        public string Name { get; }
        public int VehicleCapacity { get; }
        public bool IsOperating { get; private set; }

        public Attraction(string name, int vehicleCapacity)
        {
            Name = name;
            VehicleCapacity = vehicleCapacity;
            IsOperating = false;
        }
        public void DisplayStatus()
        {
            Console.WriteLine("Showing attraction status");
            Console.WriteLine($"Attraction Name: {Name}");
            Console.WriteLine($"Vehicle Capacity: {VehicleCapacity}");
            Console.WriteLine($"Currently Operating: {IsOperating}");
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


