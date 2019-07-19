using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Game
{
    public class Map
    {
        private int height;
        private int width;

        private Player player;
        private Enemy enemies;
        private Bonus[] bonuses;
        private Obstacles[] obstacles;

        private int Height
        {
            get => height;
            set => height = value;
        }

        private int Width
        {
            get => width;
            set => width = value;
        }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Load_Player()
        {

        }

        public void Load_Enemis()
        {

        }

        public void Load_Obstacles()
        {

        }

        public void Load_Bonuses()
        {

        }
    }
}
