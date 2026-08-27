Console.WriteLine("Attraction Simulator Starting...");

string rideName = "CodeCoaster";
int vehicleCapacity = 16;
bool isOperating = true;

while (true)
{
    // Command right now only notices "status", "start", "stop", and "exit" all lowercase for now
    Console.Write("Enter a command (status, start, stop, or exit): ");
    string? command = Console.ReadLine();

    if (command == "status")
    {
        Console.WriteLine("Showing attraction status");
        Console.WriteLine($"Attraction Name: {rideName}");
        Console.WriteLine($"Vehicle Capacity: {vehicleCapacity}");
        Console.WriteLine($"Currently Operating: {isOperating}");
    }
    else if (command == "start")
    {
        Console.WriteLine("Attraction Started");
        isOperating = true;
    }
    else if (command == "stop")
    {
        Console.WriteLine("Attraction Stopped");
        isOperating = false;
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