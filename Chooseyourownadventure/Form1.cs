using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chooseyourownadventure
{
    public partial class Form1 : Form
    {
        
        Random randGen = new Random();
        int smash;
        int scene = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 9;
                }
                else if (scene == 5)
                {
                    scene = 5;
                }
                else if (scene == 6)
                {
                    scene = 5;
                }
                else if (scene == 7)
                {
                    scene = 1; 
                }
                else if (scene == 8)
                {
                    scene = 10;
                }
                else if (scene == 9)
                {
                    scene = 14;
                }
                else if (scene == 10)
                {
                    scene = 18;
                }
                else if (scene == 11)
                {
                    scene = 18;
                }
                else if (scene == 12)
                {
                    scene = 9;
                }
                else if (scene == 13)
                {
                    int smash = randGen.Next(1, 101);

                    if (smash > 20)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 21;
                    }
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 15)
                {
                    scene = 9;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
                else if (scene == 18)
                {
                    scene = 0;                  
                } 
                else if (scene ==19)
                {
                    scene = 0;
                }
                else if (scene == 20)
                {
                    scene = 0;
                }
                else if (scene == 21)
                {
                    scene = 9;
                }


            }

            if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 6;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 8;
                }
                else if (scene == 5)
                {
                    scene = 18;
                }
                else if (scene == 6)
                {
                    scene = 1;
                }
                else if (scene == 7)
                {
                    scene = 5;
                }
                else if (scene == 8)
                {
                    scene = 11;
                }
                else if (scene == 9)
                {
                    scene = 13;
                }
                else if (scene == 10)
                {
                    scene = 18;
                }
                else if (scene == 11)
                {
                    scene = 18;
                }
                else if (scene == 9)
                {
                    scene = 4;
                }
                else if (scene == 13)
                {
                    scene = 9;
                }
                else if (scene == 14)
                {
                    scene = 17;
                }
                else if (scene == 15)
                {
                    int smash = randGen.Next(1, 101);

                    if (smash>20)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 21;
                    }
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
            }

            if (e.KeyCode == Keys.N)
            {
                if (scene == 9)
                {
                    scene = 12;
                }
               
            }

            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You're on your way to visit your mum when you realize that you're lost, you come\n to an intersection in the middle of nowhere, you see a convenience store and a house.";
                    choice1.Text = "Do you go to the house?";
                    choice2.Text = "Do you go to the store?";
                    choice2.Visible = true;
                    labelB.Visible = true;
                    
                    break;
                case 1:
                    outputLabel.Text = "You go to the house and knock on the door, doing so you slightly push it open.";
                    choice1.Text = "Enter the house";
                    choice2.Text = "Knock again";
                    break;
                case 2:
                    outputLabel.Text = "You go to the convince store and open the door, the clerk looks at you and smiles \n as the bell rings";
                    choice1.Text = "Ask for directions";
                    choice2.Text = "Leave without buying anything";
                    break;
                case 3:
                    outputLabel.Text = "You knock 3 more times and there is no answer.";
                    choice1.Text = "Go in";
                    choice2.Text = "Give up and try to find your way";
                    break;
                case 4:
                    labelN.Visible = false;
                    choice3.Visible = false;
                    outputLabel.Text = "You enter the house quietly yelling hello stepping further into the house, there's \n no answer, you see a dark hallway and a staircase leading to the second floor.";
                    choice1.Text = "Upstairs";
                    choice2.Text = "Down the hallway";

                    break;
                case 5:
                    outputLabel.Text = "You get in your car, you drive for about 5 minutes and get even more lsot, you hit/n a tree that's fallen on the road, you fly through the windshield and die a slow and painful death";
                    choice1.Text = " ";
                    choice2.Text = " ";
                    break;
                case 6:
                    outputLabel.Text = "You buy something and leave with without asking for directions.";
                    choice1.Text = "Get in your car ";
                    choice2.Text = "Go to the house ";
                    break;
                case 7:
                    outputLabel.Text = "You ask for directions and the clerk says he doesn't know, but the person in the/n house might.";
                    choice1.Text = "Enter the house";
                    choice2.Text = "Try and find your own way";
                    break;
                case 8:
                    outputLabel.Text = "You move down the hallway, the floor squeaking with every step, you come to a\n kitchen and there is a woman at the table.";
                    choice1.Text = "Speak to the woman";
                    choice2.Text = "Back away";
                    break;
                case 9:
                    choice3.Visible = true;
                    labelN.Visible = true;
                    choice2.Visible = true;                                      
                    labelB.Visible = true;
                    outputLabel.Text = "You go up the stairs and see three doors.";
                    choice1.Text = "Open the far door";
                    choice2.Text = "Open the door on the left ";
                    choice3.Text = "Open the door on the Right";
                    break;
                case 10:
                    outputLabel.Text = "You ask the woman for directions and she says there is a map by the front door,\n when you tun around she shoot you in the back of the head.";
                    choice1.Text = "You Dun Fucked Up";
                    choice2.Text = "You still dead";
                    break;
                case 11:
                    outputLabel.Text = "you make a noise when backing up, the woman sees you and shoots you";
                    choice1.Text = "You dead";
                    choice2.Text = "You still dead";
                    break;
                case 12:
                    outputLabel.Text = "The door is locked try another";
                    choice1.Text = "Return to the hall";
                    choice2.Visible = false;
                    choice3.Visible = false;
                    labelB.Visible = false;
                    labelN.Visible = false;

                    break;
                case 13:
                    outputLabel.Text = "The door on the left is an empty office, with nothing but a desk and overturned\n chair";
                    choice1.Text = "Enter the room ";
                    choice2.Text = "Return to the hall";
                    choice3.Visible = false;
                    labelN.Visible = false;
                    break;
                case 14:
                    labelN.Visible = false;
                    choice3.Visible = false;
                    outputLabel.Text = "The door at the end of the hall opens to what looks like a child's bedroom, Theres\n blood everywhere, on the wall is a map";
                    choice1.Text = "Run";
                    choice2.Text = "Take the map ";
                    break;
                case 15:
                    outputLabel.Text = " You trip over the chair, and have 20% chance you catch your self and 80% chance\n you smash your head on the desk and Die";
                   
                    break;
                case 16:
                    outputLabel.Text = " You try and run, slipping on the blood and falling on a conveniently placed knife.\n you die.";
                    choice1.Text = "You dead";
                    choice2.Text = "You still dead";
                    break;
                case 17:
                    outputLabel.Text = "You take the map and leave the house, get in your car and find your way to your/n mum's house";
                    choice1.Text = "Congrats you made it";
                    choice2.Visible = false;
                    labelB.Visible = false;
                    break;
                case 18:
                    outputLabel.Text = "You are dead";
                    choice1.Text = "Restart";
                    choice2.Visible = false;
                    labelB.Visible = false;

                    break;
                case 19:
                    outputLabel.Text = "YOU WON!!!!";
                    choice1.Text = "Restart";
                    choice2.Visible = false;
                    labelB.Visible = false;
                    break;
                case 20:
                    outputLabel.Text = "You trip and smash your smashed your head on the table...... You are dead";
                    choice1.Text = "Restart";
                    choice2.Visible = false;
                    choice3.Visible = false;
                    labelN.Visible = false;
                    labelB.Visible = false;
                    break;
                case 21:
                    outputLabel.Text = "You trip over the chair but you catch your self";
                    choice1.Text = "Return to the hall";
                    choice2.Visible = false;
                    choice3.Visible = false;
                    labelN.Visible = false;
                    labelB.Visible = false;


                    break;


                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scene = 0;
            labelN.Visible = false;
            choice3.Visible = false;

        }
    }
}
