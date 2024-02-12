 class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = null;

            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');

                if (tokens[0] == "create_parking_lot")
                {
                    int capacity = int.Parse(tokens[1]);
                    parkingLot = new ParkingLot(capacity);
                    Console.WriteLine($"Created a parking lot with {capacity} slots");
                }
                else if (tokens[0] == "park")
                {
                    parkingLot.ParkVehicle(tokens[1], tokens[2], tokens[3]);
                }
                else if (tokens[0] == "leave")
                {
                    int slotNumber = int.Parse(tokens[1]);
                    parkingLot.Leave(slotNumber);
                }
                else if (tokens[0] == "status")
                {
                    parkingLot.Status();
                }
                else if (tokens[0] == "type_of_vehicles")
                {
                    parkingLot.TypeOfVehicles(tokens[1]);
                }
                else if (tokens[0] == "registration_numbers_for_vehicles_with_color")
                {
                    parkingLot.RegistrationNumbersForVehiclesWithColor(tokens[1]);
                }
                else if (tokens[0] == "slot_numbers_for_vehicles_with_color")
                {
                    parkingLot.SlotNumbersForVehiclesWithColor(tokens[1]);
                }
                else if (tokens[0] == "slot_number_for_registration_number")
                {
                    parkingLot.SlotNumberForRegistrationNumber(tokens[1]);
                }
                else if (tokens[0] == "exit")
                {
                    break;
                }
            }
        }
    }