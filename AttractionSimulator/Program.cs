using AttractionSimulator;

Console.WriteLine("Attraction Simulator Starting...");

Attraction attraction = new Attraction("CodeCoaster", 16, false);

while (true)
{
    Console.Write("Enter a command (status, start, stop, or exit): ");
    string? command = Console.ReadLine()?.Trim().ToLower();

    if (command == "status")
    {
        attraction.DisplayStatus();
    }
    else if (command == "start")
    {
        Console.WriteLine("Attraction Started");
        attraction.Start();
    }
    else if (command == "stop")
    {
        Console.WriteLine("Attraction Stopped");
        attraction.Stop();
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