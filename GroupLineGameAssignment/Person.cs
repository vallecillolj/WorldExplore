using System;
using System.Collections.Generic;
using System.Text;

namespace GroupLineGameAssignment
{
    class Person
    {

        public string Name = "Name";
       public List<Item> Inventory = new List<Item>();


        public Person(string n)
        {
            Name = n;
            

        }


        public void addItem(string I, string d)
        {
            Inventory.Add(new Item( I, d));




        }

        public void giveItem(Person p, int i) 
        {
            p.addItem(Inventory[i].name, Inventory[i].definition);

            Inventory.RemoveAt(i);        
        }

        public void talk() 
        {
            //To Do
            Console.WriteLine("Hello there");
        
        }
        public void changeName(string n) 
        {

            Name = n;
        
        
        
        
        }
    }
}
