using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace Andre_Butler___12Ho___VS___Game
{
    class Potato
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image potato;//variable for the planet's image

        public Rectangle potatoRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Potato()
        {
            x = 400;
            y = 200;
            width = 40;
            height = 40;
            potato = Image.FromFile("potato.png");
            potatoRec = new Rectangle(x, y, width, height);

        }

        //methods
        public void drawPotato(Graphics g)
        {

            g.DrawImage(potato, potatoRec);
        }

        public void movePotato(string move)
        {
            potatoRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (potatoRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    x = 450;
                    potatoRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    potatoRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (potatoRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 10;
                    potatoRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    potatoRec.Location = new Point(x, y);
                }

            }

            


        }


    }
}
