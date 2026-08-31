using AttractionSimulator;

Console.WriteLine("Attraction Simulator Starting...");

Attraction attraction = new Attraction("CodeCoaster");


while (true)
{
    // Asks user what command they want
    // Ride status, Start, Stop, Exit are attraction Commands
    // Vehicle status, load, retraints, check, dispatch, unload, and return are RideVehicle commands. (Attraction must be started)
    Console.Write("Enter a command (Ride status, Start, Stop, Exit, Vehicle status, Load, Restraints, Check, Dispatch, Return, Unload): ");
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
    // RideVehicle commands
    else if (attraction.IsOperating && (command == "vehicle status" 
                                     || command == "load" 
                                     || command == "restraints" 
                                     || command == "check" 
                                     || command == "dispatch" 
                                     || command == "unload" 
                                     || command == "return"))
    {
        
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Please enter a valid vehicle number!");
            Console.WriteLine();
            continue;
        }

        RideVehicle? vehicle = attraction.GetVehicle(num);

        if (vehicle == null)
        {
            Console.WriteLine("Vehicle is not currently on track!");
            Console.WriteLine();
            continue;
        }
        
        if (command == "vehicle status")
        {
            vehicle.DisplayStatus();
        }
        else if (command == "load")
        {
            Console.Write("How many passengers are loading? ");

            if (int.TryParse(Console.ReadLine(), out int partySize))
            {
                vehicle.LoadPassengers(partySize);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        else if (command == "restraints")
        {
            vehicle.ToggleRestraints();
        }
        else if (command == "check")
        {
            vehicle.CheckRestraints();
        }
        else if (command == "dispatch")
        {
            vehicle.Dispatch();
        }
        else if (command == "unload")
        {
            vehicle.UnloadPassengers();
        }
        else if(command == "return")
        {
            vehicle.ReturnToStation();
        }
    }
    else if (!attraction.IsOperating && (command == "vehicle status" || command == "load"|| command == "restraints" || command == "check" || command == "dispatch" || command == "unload" || command == "return"))
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