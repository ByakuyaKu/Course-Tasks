using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Game
{
    public class Player : IActions
    {
        private int pos_x;
        private int pos_y;
        private int health;
        private Bonus[] active_bonuses;

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

        private int Health
        {
            get => health;
            set => health = value;
        }

        public Player(int posx, int posy, int health, Bonus[] bonuses)
        {
            Position_x = posx;
            Position_y = posy;
            Health = Health;
            active_bonuses = bonuses;
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
