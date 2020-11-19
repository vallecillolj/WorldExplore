using System;
using System.Collections.Generic;
using System.Text;

namespace GroupLineGameAssignment
{
    class Location
    {
        //List of locations
       public  List<Item> Items = new List<Item>();
        string name = "";

        public Location(string n)
        {
            name = n;



        }
        public void addItem(string n, string d) 
        {
            Items.Add(new Item(n, d));
            



        }
        public void addNPC(string p) 
        {
            Person person = new Person(p);



        }

        public string getname() 
        {
            return name;
        } 

    }
}
