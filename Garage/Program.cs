using Garage;
using Microsoft.Win32;
using System.Collections.Generic;

public class Program
{

    
        static void Main(string[] args)
        {
            UI ui = new UI();

            while (true)
            {
                ui.ShowMenu();
                Console.WriteLine("Ange ditt val:");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Felaktig input. ange ett nummer.");
                    continue;
                }

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Ange garagets kapacitete:");

                        int capacity;

                        if (!int.TryParse(Console.ReadLine(), out capacity))

                        {
                            Console.WriteLine("Felaktig! Ange ett nummer.");
                            break;
                        }

                        ui.CreateGarage(capacity);
                        break;
                    case 2:

                        ui.ListAllVehicles();
                        break;

                    case 3:

                        ui.ListVehicleTypesAndCounts();
                        break;

                    case 4:

                        Console.WriteLine("Ange registreringsnummer:");

                        string regNumber = Console.ReadLine();

                        Console.WriteLine("Ange fordonstyp:");
                        string type = Console.ReadLine();

                        Console.WriteLine("Ange fordonets färg:");
                        string color = Console.ReadLine();
                        ui.AddVehicle(regNumber, type, color);
                        break;

                    case 5:

                        Console.WriteLine("Ange registreringsnumret på det fordon som ska tas bort:");
                        string regNumToRemove = Console.ReadLine();
                        ui.RemoveVehicle(regNumToRemove);
                        break;

                    case 6:

                        Console.WriteLine("Ange registreringsnummer för att hitta:");
                        string regNumToFind = Console.ReadLine();
                        ui.FindVehicleByRegistrationNumber(regNumToFind);
                        break;


                
                case 7:
                    Console.WriteLine("Closing the application...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
            }
        }
    }
