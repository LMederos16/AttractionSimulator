using AttractionSimulator;

Console.WriteLine("Attraction Simulator Starting...");

Attraction attraction = new Attraction("CodeCoaster", 6, false);
RideVehicle rideVehicle = new RideVehicle(1, 24, 0);

while (true)
{
    Console.Write("Enter a command (Ride status, Start, Stop, Exit, Vehicle status, Load, Restraints, Check, Dispatch, Unload): ");
    string? command = Console.ReadLine()?.Trim().ToLower();

    if (command == "ride status")
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
    else if (attraction.IsOperating && (command == "vehicle status" || command == "load" || command == "restraints" || command == "check" || command == "dispatch" || command == "unload"))
    {
        if (command == "vehicle status")
        {
            rideVehicle.Status();
        }
        else if (command == "load")
        {
            rideVehicle.LoadPassengers();
        }
        else if (command == "restraints")
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
        else if (command == "unload")
        {
            rideVehicle.UnloadPassengers();
        }
    }
    else if (!attraction.IsOperating && (command == "vehicle status" || command == "load"|| command == "restraints" || command == "check" || command == "dispatch" || command == "unload"))
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