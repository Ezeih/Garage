using Garage;
using Microsoft.Win32;
using System.Collections.Generic;

public class Program
{
   
    public static void Main()
    {
        GarageHandler garage = new GarageHandler();
        List<Vehicle> vehicles = new List<Vehicle>();
        var car1 = new vehicles("Ger", "Opel", 2020, "1234");





        Console.WriteLine("Vad skulle du vilja göra?");
        Console.WriteLine("1. Lägg till ett nytt fordon");
        Console.WriteLine("2. Ändra fordonsinformation");
        Console.WriteLine("3. Ta bort ett fordon");
        Console.WriteLine("اVälj det alternativnummer du önskar:");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                
                garage.AddVehicle(car1);
                garage.PrintVehicles();
                break;
            case 2:
                
                garage.UpdateVehicle();
                garage.PrintVehicles();
                break;
            case 3:
                
                garage.RemoveVehicle();
                garage.PrintVehicles();
                break;
                case 4:
            default:
                Console.WriteLine("Alternativnumret du valde är felaktigt.");
                break;
        }
        
    }
}
