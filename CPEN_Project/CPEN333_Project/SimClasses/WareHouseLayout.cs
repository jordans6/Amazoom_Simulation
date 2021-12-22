using System;
using System.Collections.Generic;
using System.Text;

namespace CPEN_Project
{
    public class WareHouseLayout
    {
        // FIELDS
        private Dictionary<int, Shelf> shelves; // identifies each shelf by a particular number
        private int length;
        private int width;
        private char[,] grid;
        private Dock[] docks;
        private List<Robot> robots;

        // PROPERTIES
        public int Width
        {
            get => width;
        }
        
        public Dictionary<int, Shelf> Shelves
        {
            get => shelves;
        }

        public Dock[] Docks
        {
            get => docks;
        }

        public char[,] Grid
        {
            get => grid;
        }

        public List<Robot> Robots
        {
            get => robots;
        }

        // METHODS
        public void addRobot(Robot robot)
        {
            this.robots.Add(robot);
        }

        // CONSTRUCTORS

        // validates and assigns warehouse layout parameters
        // tuples are in x, y co-ordinates
        public WareHouseLayout(int length, int width, int numRobots, int numShelves, int shelfHeight)
        {
            if (length >= 5 && length <= 30) this.length = length;
            else this.length = 5;

            if (width >= 5 && width <= 30) this.width = width;
            else this.width = 5;

            this.grid = new char[this.length, this.width];

            if(numShelves > (this.width - 2) / 2) numShelves = (this.width - 2) / 2;

            Shelf temp;
            this.shelves = new Dictionary<int, Shelf>();
            
            for(int i = 0; i < numShelves; i++)
            {
                Tuple<int, int> location = new Tuple<int, int>(2 * i + 1, 1);
                temp = new Shelf(location, this.length - 3, shelfHeight, i);
                this.shelves.Add(i, temp);
            }

            this.docks = new Dock[2];
            Tuple<int, int> d1 = new Tuple<int, int>(1, this.length - 1); //docks in similar position as sketch
            Tuple<int, int> d2 = new Tuple<int, int>(2, this.length - 1);
            this.docks[0] = new Dock(d1);
            this.docks[1] = new Dock(d2);

            for(int y = 0; y < this.length; y++)
            {
                for(int x = 0; x < this.width; x++)
                {
                    this.grid[y, x] = '_';
                }
            }

            foreach (Shelf s in this.shelves.Values)
            {
                int xPos = s.Location.Item1;
                int yPos = s.Location.Item2;

                for (int i = 0; i < s.Length; i++)
                {
                    this.grid[yPos + i, xPos] = 's';
                }
            }

            this.grid[this.docks[0].Location.Item2, this.docks[0].Location.Item1] = 'd';
            this.grid[this.docks[1].Location.Item2, this.docks[1].Location.Item1] = 'd';

            this.robots = new List<Robot>();
        }
    }
}
