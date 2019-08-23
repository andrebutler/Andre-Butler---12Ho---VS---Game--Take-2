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
            x = 400; //potato character starts at x = 400
            y = 200; //potato character starts at y = 200;
            width = 40; //the width of the character = 40 pixels
            height = 40; //the height of the potato character = 40 pixels
            potato = Image.FromFile("potato.png"); //pull the potato image from file explorer it is called potato.png
            potatoRec = new Rectangle(x, y, width, height); //put the image potatoRec in a new rectangle

        }

        //methods
        public void drawPotato(Graphics g) //draw the potato image
        {

            g.DrawImage(potato, potatoRec); //draw the potato image
        }

        public void movePotato(string move) //move the potato character
        {
            potatoRec.Location = new Point(x, y); // potatoRec location

            if (move == "right") //when the spaceship moves right
            {
                if (potatoRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    y = 450; //y will equal 450
                    potatoRec.Location = new Point(x, y); 
                }
                else
                {
                    y += 5;
                    potatoRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (potatoRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    y = 10;
                    potatoRec.Location = new Point(x, y);
                }
                else
                {
                    
                    y-= 5;
                    potatoRec.Location = new Point(x, y);
                }

            }

            


        }


    }
}
