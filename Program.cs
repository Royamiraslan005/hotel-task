using ConsoleApp20;

Hotel hotel = new Hotel("Green City Hotel");

while (true)
{
    Console.WriteLine("\n1. Create a room");
    Console.WriteLine("2. Add room");
    Console.WriteLine("3. Make reservation");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter room name: ");
            string name = Console.ReadLine();
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter person capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Room newRoom = new Room(name, price, capacity);
            Console.WriteLine($"Otaq {newRoom.Id} elave olundu!");
            break;

        case "2":
            if (newRoom != null)
            {
                hotel.AddRoom(newRoom);
                Console.WriteLine($"Room {newRoom.Id} added to the hotel!");
            }
            else
            {
                Console.WriteLine("No room created yet!");
            }
            break;

        case "3":
            Console.Write("Enter room ID to reserve: ");
            int roomId = Convert.ToInt32(Console.ReadLine());
            hotel.MakeReservation(roomId);
            break;

        case "0":
            Console.WriteLine("Exiting program...");
            return;

        default:
            Console.WriteLine("Invalid choice! Try again.");
            break;
    }
}
    
