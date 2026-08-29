namespace AttractionSimulator
{
    internal class Attraction
    {
        public string Name { get; }
        public int MaxVehicles { get; } = 6;
        public bool IsOperating { get; private set; }
        private List<RideVehicle> Vehicles { get; }

        public Attraction(string name)
        {
            Name = name;
            IsOperating = false;
            Vehicles = new List<RideVehicle>();

            for (int i = 1; i <= 3; i++)
            {
                Vehicles.Add(new RideVehicle(i));
            }
        }
        public void DisplayStatus()
        {
            Console.WriteLine("Showing attraction status");
            Console.WriteLine($"Attraction Name: {Name}");
            Console.WriteLine($"Vehicle Capacity: {MaxVehicles}");
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


