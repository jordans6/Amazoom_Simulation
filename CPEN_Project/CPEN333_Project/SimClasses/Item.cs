using System;
using System.Collections.Generic;
using System.Text;

namespace CPEN_Project
{
    public class Item
    {

        private string name;
        private int weight;
        private Tuple<int, int> location;
        private int itemNumber;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }
        public int ItemNumber
        {
            get => itemNumber;
        }


        // METHODS
        public void setLocation(Tuple<int, int> location)
        {
            this.location = location;
        }
        
        // CONSTRUCTORS
        public Item(string name, int weight, int itemNumber)
        {
            this.name = name;
            this.weight = weight;
            this.itemNumber = itemNumber;
        }
    }
}
