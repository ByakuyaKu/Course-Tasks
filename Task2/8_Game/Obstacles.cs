using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Game
{
    public class Obstacles
    {
        protected string name_of_obstacles;
        protected int pos_x;
        protected int pos_y;

        private string Name
        {
            get => name_of_obstacles;
            set => name_of_obstacles = value;
        }

        private int Position_x
        {
            get => pos_x;
            set => pos_x = value;
        }

        private int Position_y
        {
            get => pos_y;
            set => pos_y = value;
        }

        public Obstacles(string name, int posx, int posy)
        {
            Name = name;
            Position_x = posx;
            Position_y = posy;
        }
    }
}
