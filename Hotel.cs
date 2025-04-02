using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Hptel
    {
        public string Name { get; set; }
        private Room[] Rooms; 

        public Hotel(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Hotelin adı boş ola bilməz!");

            Name = name;
            Rooms = new Room[0]; 
        }

        public void AddRoom(Room room)
        {
            Room[] newRooms = new Room[Rooms.Length + 1];

            for (int i = 0; i < Rooms.Length; i++)
            {
                newRooms[i] = Rooms[i];
            }

            newRooms[Rooms.Length] = room;
            Rooms = newRooms;

            Console.WriteLine($"Otaq {room.Id} hotela əlavə olundu.");
        }

        public void MakeReservation(int roomId)
        {
            bool found = false;

            foreach (Room room in Rooms)
            {
                if (room.Id == roomId)
                {
                    found = true;

                    if (room.IsAvailable)
                    {
                        room.IsAvailable = false;
                        Console.WriteLine($"Otaq {roomId} uğurla rezerv edildi.");
                    }
                    else
                    {
                        Console.WriteLine("Bağışlayın, bu otaq artıq doludur.");
                    }
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Səhv ID daxil etdiniz, belə bir otaq mövcud deyil!");
            }
        }

        public void ShowAllRooms()
        {
            if (Rooms.Length == 0)
            {
                Console.WriteLine("Hazırda hoteldə heç bir otaq yoxdur.");
                return;
            }

            foreach (Room room in Rooms)
            {
                room.ShowInfo();
            }
        }
    }
}
