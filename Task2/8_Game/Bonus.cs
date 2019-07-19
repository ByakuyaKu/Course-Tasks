using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Game
{
    public class Bonus
    {
        protected string name_of_bonus;
        protected int pos_x;
        protected int pos_y;

        private string Name
        {
            get => name_of_bonus;
            set => name_of_bonus = value;
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

        public Bonus(string name, int posx, int posy)
        {
            Name = name;
            Position_x = posx;
            Position_y = posy;
        }

        public void Bonus_Effect()
        {

        }
    }
}
