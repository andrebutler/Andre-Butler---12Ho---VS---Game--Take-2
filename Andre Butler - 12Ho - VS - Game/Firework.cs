using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Andre_Butler___12Ho___VS___Game
{
    class Firework
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image fireworkImage;//variable for the planet's image
        public Rectangle fireworkRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Firework(int spacing)
        {

            y = spacing;
            x = 10; //the fireworks start at x =10
            width = 33; //the width of the firework sprite is set to 33 pixels
            height = 17; // the height of the firework sprite is set to 17 pixels.
            fireworkImage = Image.FromFile("chargamevsfw.png"); //get the firework image from file explorer it is called chargamevsfw.png
            fireworkRec = new Rectangle(x, y, width, height); // put the firework sprite in a new rectangle






        }



        // Methods for the Planet class
        public void drawfirework(Graphics g) //draw the firework image
        {
            fireworkRec = new Rectangle(x, y, width, height);
            g.DrawImage(fireworkImage, fireworkRec);


        }

        public void moveFirework()
        {

            score += 1;// add 1 to score when planet reaches bottom of panel

            fireworkRec.Location = new Point(x, y);
            score += 1;// add 1 to score when planet reaches bottom of panel

            if (fireworkRec.Location.X > 400)
            {
                x = 20;
                fireworkRec.Location = new Point(x, y);//

            }

             

        }


    }
}
