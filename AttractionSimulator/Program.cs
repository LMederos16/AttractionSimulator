using AttractionSimulator;

Console.WriteLine("Attraction Simulator Starting...");

Attraction attraction = new Attraction("CodeCoaster", 6, false);
RideVehicle rideVehicle = new RideVehicle(1, 24, 0);

while (true)
{
    Console.Write("Enter a command (Status, Start, Stop, Exit, Restraints, Check, Dispatch): ");
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
    else if (attraction.IsOperating && (command == "restraints" || command == "check" || command == "dispatch"))
    {
        if (command == "restraints")
        {
            rideVehicle.ToggleRestraints();
        }
        else if (command == "check")
        {
            rideVehicle.CheckRestraints();
        }
        else if (command == "dispatch")
        {
            rideVehicle.Dispatch();
        }
    }
    else if (!attraction.IsOperating && (command == "restraints" || command == "check" || command == "dispatch"))
    {
        Console.WriteLine("Attraction must be started first");
    }
    else
    {
        Console.WriteLine("Unknown command");
    }
    // Creates spacing for different outputs
    Console.WriteLine();
}