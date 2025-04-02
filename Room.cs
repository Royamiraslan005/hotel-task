
namespace ConsoleApp20
{
        internal class Room
        {
            private static int _id = 1; 
            public int ID { get; } 
            public string Name { get; set; }
            public double Price { get; set; }
            public int PersonCapacity { get; set; }
            public bool IsAvailable { get; set; }

            public Room(string name, double price, int personCapacity)
            {
                if (string.IsNullOrWhiteSpace(name) || price <= 0 || personCapacity <= 0)
                    throw new ArgumentException("Yanlış otaq məlumatları daxil edilib!");

                ID = _id++;
                Name = name;
                Price = price;
                PersonCapacity = personCapacity;
                IsAvailable = true;

              public void ShowInfo()
        {
            Console.WriteLine($" NAME : {Name},PRICE : {Price} ID :{id} personamcapasity {PersonalCapasity}");
        }

        public override string ToString()
        {
            return $" MELUMAT {ID},{Name},{Price} {PersonalCapasity},{IsAvailable} ";
        }

        public void Reserve()
            {
                if (IsAvailable)
                {
                    IsAvailable = false;
                    Console.WriteLine($"Otaq {ID} uğurla rezerv edildi.");
                }
                else
                {
                    Console.WriteLine($"Otaq {ID} artıq doludur!");
                }
            }
        }
    }

