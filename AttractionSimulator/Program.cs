Console.WriteLine("Attraction Simulator Starting...");

string rideName = "CodeCoaster";
int vehicleCapacity = 16;
bool isOperating = true;

// Status right now only notices "status"
Console.Write("Enter a command:");
string? command = Console.ReadLine();

if(command == "status")
{
    Console.WriteLine("Showing attraction status");
    Console.WriteLine($"Attraction Name: {rideName}");
    Console.WriteLine($"Vehicle Capacity: {vehicleCapacity}");
    Console.WriteLine($"Currently Operating: {isOperating}");
}
else
{
    Console.WriteLine("Unknown command");
}