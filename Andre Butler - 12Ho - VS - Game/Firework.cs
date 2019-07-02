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
        public Firework()
        {
            x = 10;
            y = 10;
            width = 33;
            height = 17;
            fireworkImage = Image.FromFile("chargamevsfw.png");
            fireworkRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            g.DrawImage(fireworkImage, fireworkRec);
        }

    }
}
