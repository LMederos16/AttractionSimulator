using AttractionSimulator;

Console.WriteLine("Attraction Simulator Starting...");

Attraction attraction = new Attraction("CodeCoaster", 16, false);

while (true)
{
    Console.Write("Enter a command (status, start, stop, or exit): ");
    string? command = Console.ReadLine()?.Trim().ToLower();

    if (command == "status")
    {
        Console.WriteLine("Showing attraction status");
        Console.WriteLine($"Attraction Name: {attraction.Name}");
        Console.WriteLine($"Vehicle Capacity: {attraction.VehicleCapacity}");
        Console.WriteLine($"Currently Operating: {attraction.IsOperating}");
    }
    else if (command == "start")
    {
        Console.WriteLine("Attraction Started");
        attraction.IsOperating = true;
    }
    else if (command == "stop")
    {
        Console.WriteLine("Attraction Stopped");
        attraction.IsOperating = false;
    }
    else if (command == "exit")
    {
        Console.WriteLine("Exiting...");
        break;
    }
    else
    {
        Console.WriteLine("Unknown command");
    }
    // Creates spacing for different outputs
    Console.WriteLine();
}