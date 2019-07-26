using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andre_Butler___12Ho___VS___Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
       
                                            // declare space for an array of 7 objects called planet 
        Firework[] firework = new Firework[7];
        Random xspeed = new Random();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 60);
                firework[i] = new Firework(y);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            {
                //get the graphics used to paint on the panel control
                g = e.Graphics;
                //call the Planet class's DrawPlanet method to draw the image planet1 
               

                for (int i = 0; i < 7; i++)
                {

                    // generate a random number from 5 to 20 and put it in rndmspeed
                    int rndmspeed = xspeed.Next(5, 20);
                    firework[i].x += rndmspeed;

                    //call the Planet class's drawPlanet method to draw the images
                    firework[i].drawfirework(g);
                }



            }

        }

        private void tmrFirework_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                firework[i].moveFirework();
            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
