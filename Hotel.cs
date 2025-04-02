using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms;

        public Hotel(string ad)
        {
            Name=Name;
            Rooms= new Room[0];
        }

        public void AddRoom(Room room)
        {
            {
                Array.Resize(ref Rooms, Rooms.Length + 1);
                Rooms[Rooms.Length - 1] = room;
                Console.WriteLine($"Otaq {room.Id} elave olundu!");
            }


        public void RezervEt(int roomID)
        {
            bool tapildi = false;
            foreach (Otaq otaq in Otaqlar)
            {
                if (otaq.ID == otaqID)
                {
                    tapildi = true;
                    if (otaq.RezerveEdileBiler)
                    {
                        otaq.RezerveEdileBiler = false;
                        Console.WriteLine($"Otaq {otaqID} uğurla rezerv edildi.");
                    }
                    else
                    {
                        Console.WriteLine("Bağışlayın, bu otaq artıq doludur.");
                    }
                    break;
                }
            }

            if (!tapildi)
            {
                Console.WriteLine("Səhv ID daxil etdiniz, belə bir otaq mövcud deyil!");
            }
        }

        public void ButunOtaqlariGoster()
        {
            if (Otaqlar.Length == 0)
            {
                Console.WriteLine("Hazırda hoteldə heç bir otaq yoxdur.");
                return;
            }

            foreach (Otaq otaq in Otaqlar)
            {
                otaq.MelumatGoster();
            }
        }
    }
}