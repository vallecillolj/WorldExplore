using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Xml.Serialization;

namespace GroupLineGameAssignment
{
    class World
    {
        public Location mountains = new Location("Mountains");
        public Location Cave = new Location("Cave");
        public Location AHardPlace = new Location("A Hard Place");
        public Location PawnShop = new Location("Pawn shop");
        public List<Location> Locations = new List<Location>();
        public Person playerOne =new Person("Name");
        public World() 
        {
            Console.WriteLine("Welcome travler please type in your name \n");
            playerOne.changeName(Console.ReadLine());
            Console.WriteLine($"Hello {playerOne.Name}");
            SetuP();
            Start();
        }

        public void Start() 
        {
            Console.WriteLine("Where do you want to look for rocks \n");
            
            for (int i = 0; i < Locations.Count; i++) 
            {
                Console.Write(i +1 + " ");
                Console.WriteLine(Locations[i].getname());

            }
            int choice = 0;
            try
            {
                choice = int.Parse (Console.ReadLine());

            }
           catch(System.FormatException)
            {
                Console.WriteLine("Please enter a number" );
                Start();
                return;
            }

            switch (choice) 
            {
                case 1: mountain();
                    break;
                case 2: cave();
                    break;
                case 3: Hardestplace();
                    break;
                case 4: int j = 0;
                    for (int i = 0; i < playerOne.Inventory.Count; i++) 
                    {
                        if (playerOne.Inventory[i].name.Equals("MoonRock"))
                        {
                            j++;
                            
                            


                        }
                       
                    
                    }
                    if (j > 0)
                    {
                        pawnS();
                    }
                    else 
                    {
                        Console.WriteLine("You dont have anything to sell.");
                        Start();
                    }

                    break;
                default: Start();
                    break;
            
            }

        }

        public void mountain() 
        {
            Console.WriteLine("Your in the mountains, There are rocks everywhere lets see what you get?"); // look around/leave
            Console.WriteLine("1. Look around?\n2. Leave?\n");

            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number");
                mountain();
                return;
            }
            switch (choice) 
            {
                case 1: for (int i = 0; i < mountains.Items.Count; i++) 
                {
                        Console.WriteLine();
                    
                }
                    break;
                case 2: Start();
                    break;
                default: Console.WriteLine("Please choose 1 or 2");
                    mountain();
                    break;
            
            }
                

        }

        public void cave()
        {
            Console.WriteLine("A cave in the mountain! maybe there are better rocks to be found"); // look around/leave
            Console.WriteLine("1. Look around?\n2. Leave?\n");
            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number");
                cave();
                return;
            }
        }

        public void Hardestplace()
        {
            Console.WriteLine("Specliest rocks lie here"); // look around/leave
            Console.WriteLine("1. Look around?\n2. Leave?\n");
            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number");
                Hardestplace();
                return;
            }
        }

        public void pawnS()
        {
            Console.WriteLine("Remember that special rock?, Maybe they but rocks"); // look around/leave
            Console.WriteLine("1. Look around?\n2. Leave?\n");

            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number");
                pawnS();
                return;
            }
        }



        public void SetuP() 
        {

            //Mountains
            mountains.addItem("Pebbel", "rock but small");
            mountains.addItem("Rock", "pebbel but big");
            mountains.addItem("Sword", "Rock but sharp");
            mountains.addItem("Paper", "beats rock");
            mountains.addNPC("The rock");


            //Cave
            Cave.addItem("Bat", "rock buy flies");
            Cave.addItem("Crystal", "rock that glows");
            Cave.addItem("Boulder", "Its a rock");
            Cave.addItem("nome", "You just want to chuck it off a cliff");
            Cave.addNPC("Dwayne The Johnson");


            //AhardPlace
            AHardPlace.addItem("Stone", "Throwable rock");
            AHardPlace.addItem("MoonRock", "Sell for 10k dollars");
            AHardPlace.addItem("Paperweight", "A rock with a job");
            AHardPlace.addItem("Caveman", "a person that you keep");
            AHardPlace.addItem("Skipping stone", "skipable rock");
            AHardPlace.addNPC("Rocky");

            //Pawnshop
            PawnShop.addItem("Antique Computer", "Works like a rock");
            PawnShop.addItem("House", "Large and sturdy like a rock");
            PawnShop.addItem("Diamond", "Valuable rock");
            PawnShop.addItem("Gold", "Yellow rock");
            PawnShop.addItem("A bottle of water", "Has minerals from rocks");
            PawnShop.addNPC("Rick");


            Locations.Add(mountains);
            Locations.Add(Cave);
            Locations.Add(AHardPlace);
            Locations.Add(PawnShop);
        }



    }
}
