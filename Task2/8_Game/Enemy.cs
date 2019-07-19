using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Game
{
    public class Enemy : IActions
    {
        private int pos_x;
        private int pos_y;

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

        public Enemy(int posx, int posy)
        {
            Position_x = posx;
            Position_y = posy;
        }

        public void Move_Up()
        {

        }

        public void Move_Down()
        {

        }

        public void Move_Right()
        {

        }

        public void Move_Left()
        {

        }
    }
}
