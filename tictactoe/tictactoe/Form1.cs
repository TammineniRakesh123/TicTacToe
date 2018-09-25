using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public int counter;
        public static  int count=0;
        public static char[] var=new char[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter == 2 || counter==4)
            {
                MessageBox.Show("let other person play");
            }
            else
            {
                counter = 2;//o
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter == 1 || counter == 3)
            {
                MessageBox.Show("let other person play");
            }
            else
            {
                counter = 1;//x
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (counter == 3||counter==4||counter==0)
            { }
            else
            {
                if (counter == 1)
                {
                    button3.Text = "x";
                    var[0] = 'x';
                    counter = 3;

                }
                else if (counter == 2)
                {
                    button3.Text = "o";
                    var[0] = 'o';
                    counter = 4;
                }
                button3.Enabled = false;
                logic();
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0) { }
            else
            {
                if (counter == 1)
                {
                    button4.Text = "x";
                    var[1] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button4.Text = "o";
                    var[1] = 'o';
                    counter = 4;
                }
                button4.Enabled = false;
                logic();
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0)
            { }
            else
            {
                if (counter == 1)
                {
                    button5.Text = "x";
                    var[2] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button5.Text = "o";
                    var[2] = 'o';
                    counter = 4;
                }
                button5.Enabled = false;
                logic();
               
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0)
            { }
            else
            {
                if (counter == 1)
                {
                    button6.Text = "x";
                    var[3] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button6.Text = "o";
                    var[3] = 'o';
                    counter = 4;
                }
                button6.Enabled = false;
                logic();
               
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0)
            { }
            else
            {
                if (counter == 1)
                {
                    button7.Text = "x";
                    var[4] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button7.Text = "o";
                    var[4] = 'o';
                    counter = 4;
                }
                button7.Enabled = false;
                logic();
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0)
            { }
            else
            {
                if (counter == 1)
                {
                    button8.Text = "x";
                    var[5] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button8.Text = "o";
                    var[5] = 'o';
                    counter = 4;
                }
                button8.Enabled = false;
                logic();
               
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0)
            { }
            else
            {
                if (counter == 1)
                {
                    button9.Text = "x";
                    var[6] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button9.Text = "o";
                    var[6] = 'o';
                    counter = 4;
                }
                button9.Enabled = false;
                logic();
               
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0)
            { }
            else
            {
                if (counter == 1)
                {
                    button10.Text = "x";
                    var[7] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button10.Text = "o";
                    var[7] = 'o';
                    counter = 4;
                }
                button10.Enabled = false;
                logic();
               
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (counter == 3 || counter == 4 || counter == 0)
            { }
            else
            {
                if (counter == 1)
                {
                    button11.Text = "x";
                    var[8] = 'x';
                    counter = 3;
                }
                else if (counter == 2)
                {
                    button11.Text = "o";
                    var[8] = 'o';
                    counter = 4;
                }
                button11.Enabled = false;
                logic();
                
            }
        }
        static void logic()
        {
            if (var[0]=='\0'||var[1]=='\0'||var[2]=='\0')
            { }
            else
            {
                if ((var[0] == var[1]) && (var[0] == var[2]))
                {
                    MessageBox.Show("the winner is " + var[0]);
                    var[0] = var[1] = var[2] = var[3] = var[4] = var[5] = var[5] = var[6] = var[7] = var[8] = '\0';
                    
                }

            }
              if (var[0]=='\0'||var[3]=='\0'||var[6]=='\0')
                { }
                else
                {
                     if ((var[0] == var[3]) && (var[0] == var[6]))
                        {
                            MessageBox.Show("the winner is " + var[0]);
                            var[0] = var[1] = var[2] = var[3] = var[4] = var[5] = var[5] = var[6] = var[7] = var[8] = '\0';
                        }
                }
                if (var[2]=='\0'||var[5]=='\0'||var[8]=='\0')
                { }
                else
                {
                         if ((var[2] == var[5]) && (var[8] == var[2]))
                        {
                            MessageBox.Show("the winner is " + var[2]);
                            var[0] = var[1] = var[2] = var[3] = var[4] = var[5] = var[5] = var[6] = var[7] = var[8] = '\0';
                        }
                }
                 if (var[6]=='\0'||var[7]=='\0'||var[8]=='\0')
                 { }
                 else
                 {
                     if ((var[6] == var[7]) && (var[6] == var[8]))
                    {
                        MessageBox.Show("the winner is " + var[6]);
                        var[0] = var[1] = var[2] = var[3] = var[4] = var[5] = var[5] = var[6] = var[7] = var[8] = '\0';
                    }
                 }
                if (var[3]=='\0'||var[4]=='\0'||var[5]=='\0')
                { }
                else
                {
                     if ((var[3] == var[4]) && (var[3] == var[5]))
                    {
                        MessageBox.Show("the winner is " + var[3]);
                        var[0] = var[1] = var[2] = var[3] = var[4] = var[5] = var[5] = var[6] = var[7] = var[8] = '\0';
                    }
               }
                if (var[0]=='\0'||var[4]=='\0'||var[8]=='\0')
                {
               }else{
                         if ((var[0] == var[4]) && (var[0] == var[8]))
                    {
                        MessageBox.Show("the winner is " + var[0]);
                        var[0] = var[1] = var[2] = var[3] = var[4] = var[5] = var[5] = var[6] = var[7] = var[8] = '\0';
                    }
                }
                 if (var[2]=='\0'||var[4]=='\0'||var[6]=='\0')
                 { }
                 else
                 {
                     if ((var[2] == var[4]) && (var[6] == var[2]))
                    {
                        MessageBox.Show("the winner is " + var[2]);
                        var[0] = var[1] = var[2] = var[3] = var[4] = var[5] = var[5] = var[6] = var[7] = var[8] = '\0';
                    }
                 }
              if (var[4]=='\0'||var[1]=='\0'||var[7]=='\0')
              { }
              else
              {
                    if ((var[4] == var[1]) && (var[1] == var[7]))
                    {
                        MessageBox.Show("the winner is " + var[1]);
                        var[0] = var[1] = var[2] = var[3]=var[4]=var[5]=var[5]=var[6]=var[7]=var[8]='\0';

                    }
              }
              if (var[0] != '\0' && var[1] != '\0' && var[2] != '\0' && var[3] != '\0' && var[4] != '\0' && var[5] != '\0' && var[6] != '\0' && var[7] != '\0' && var[8] != '\0')
              {
                  MessageBox.Show("DRAW");
              }

            }
        }
    }

