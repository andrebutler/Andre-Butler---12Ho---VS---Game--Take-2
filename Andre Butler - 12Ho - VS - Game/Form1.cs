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
       
                                            
        Firework[] firework = new Firework[7]; //loads 7 fireworks
        Random xspeed = new Random(); //sets the speed of the fireworks which are shooting across the screen
        Potato Potato = new Potato(); //load the potato character image name = potato
        bool up, down; //declares the variables
        int score, lives=5; //sets the score to 0 and the lives to 5
        string move; //this sets the variable move

        public Form1()
        {
            InitializeComponent(); //initializes the componenet
            for (int i = 0; i < 7; i++) //runs the firework code 7 times
            {
                int y = 10 + (i * 60); //determines a y co-ordinate for the firework
                firework[i] = new Firework(y); //creates a new firework
                firework[i].x = xspeed.Next(-200, 0); //this means the fireworks will start anywhere randomly between -200 = x and 0 = x
                score += firework[i].score;// get score from Firework class (in moveFirework method)
                lblScore.Text = score.ToString();// display score in the score label

            }

        }

        private void Form1_Load(object sender, EventArgs e) //adds no value to the code
        { //adds no value to the code

        } //adds no value to the code

        private void panel1_Paint(object sender, PaintEventArgs e) //loads the panel paint event
        {
            {
                //get the graphics used to paint on the panel control
                g = e.Graphics;
                //call the Planet class's DrawPlanet method to draw the image planet1 
               

                for (int i = 0; i < 7; i++) //draws 7 fireworks with loop event
                {

                    // generate a random number from 5 to 20 and put it in rndmspeed
                    float rndmspeed = xspeed.Next(5, 20);
                    rndmspeed *= 1f + score / 500f;//makes speed more different
                    firework[i].x += (int)rndmspeed;//makes the speed random

                    //call the Planet class's drawPlanet method to draw the images
                    firework[i].drawfirework(g); //draw firework of the game panel
                    Potato.drawPotato(g);//draws the potato on the game panel
                }//bracket



            }//bracket

        }//bracket

        private void Form1_KeyDown(object sender, KeyEventArgs e) //if the down key is pressed
        {
            if (e.KeyData == Keys.Up) { up = true; e.Handled = true; } //go up
            if (e.KeyData == Keys.Down) { down = true;e.Handled = true; }//go up


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) //if the down key is pressed
        {
            if (e.KeyData == Keys.Up) { up = false; e.Handled = true; }//go down
            if (e.KeyData == Keys.Down) { down = false; e.Handled = true; }//go down

        }//bracket

        private void label2_Click(object sender, EventArgs e)//adds no meaning to the code
        {

        }

        private void tmrPotato_Tick(object sender, EventArgs e) //if the potato timer is enabled
        {


            if (down) // if down arrow key pressed//
            {
                move = "right";//if down key pressed
                Potato.movePotato(move);//move down
            }
            if (up) // if up arrow key pressed
            {
                move = "left";//if up key pressed
                Potato.movePotato(move); //move up
            }

        }//bracket

        private void textBox1_TextChanged(object sender, EventArgs e)// adds no value to the code
        {

        }

        private void tmrFirework_Tick(object sender, EventArgs e) //if the firework timer is activited
        {
            for (int i = 0; i < 7; i++) // loads the 7 fireworks
            {
                score = 0; //start the game with a score 0
                firework[i].moveFirework(); //move the firework
                

                score += firework[i].score;// get score from Firework class (in moveFirework method)
                lblScore.Text = score.ToString();// display score

                if (firework[i].fireworkRec.IntersectsWith(Potato.potatoRec)) //if the firework intersects with the potato character
                {
                    //reset planet[i] back to top of panel
                    firework[i].x = 0; // set x value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    checkLives(); //check the lives
                }



            }//bracket
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }



        private void checkLives()// check the lives
        {
            if (lives == 0)//if lives = 0
            {
                tmrFirework.Enabled = false;//finish and close the game
                tmrPotato.Enabled = false;
                MessageBox.Show("Game Over");
                Close();// close the screen

            }//bracket
        }//bracket

        

    }//bracket
}//bracket
