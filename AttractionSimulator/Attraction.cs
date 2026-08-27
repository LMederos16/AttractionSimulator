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
        public void Status()
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


