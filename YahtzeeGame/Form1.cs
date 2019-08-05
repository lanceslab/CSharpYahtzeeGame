using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiceRollerLib;
// we can use a sleep method
using System.Threading;
using Chapter_11_InClass;

namespace YahtzeeGame
{
    public partial class Form1 : Form
    {
        //int rollCount = 0; // cant get RollDice() to work so I added this

        string titleMessage = "Lance'sLab - Yahtzee !!!     ";
        private Die[] Dice = new Die[5];
        YahtzeeRoller diceee = new YahtzeeRoller();

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = titleMessage;
            //for (int i = 0; i <= Dice.Length; i++)// changed to Length - 1
            for (int i = 0; i <= Dice.Length - 1; i++)
            {
                //Thread.Sleep(100);
                //try
                //{
                    Die dic = new Die(new Random().Next(1, 7));
                    //Die dic = new Die(new Random().Next(1, 17));// testing it works!
                    diceee.Dice[i] = dic;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message + "POOP");
                //}

                DieControl dicePiece = new DieControl();
                dicePiece.Width = 60;
                dicePiece.Height = 65;
                dicePiece.Parent = this;
                dicePiece.Top = 80;
                //dicePiece.Face = dic.Value;
                //dicePiece.Face = 1;

                switch (i)
                {
                    case 0:
                        dicePiece.Left = 30;
                        break;
                    case 1:
                        dicePiece.Left = 120;
                        break;
                    case 2:
                        dicePiece.Left = 210;
                        break;
                    case 3:
                        dicePiece.Left = 300;
                        break;
                    case 4:
                        dicePiece.Left = 390;
                        break;
                }
                dicePiece.Visible = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Set the values of Keep based on the checked values of the checkboxes
            if (checkBox1.Checked == true)
                diceee._keep[0] = 1;
            else
                diceee._keep[0] = 0;

            if (checkBox5.Checked == true)
                diceee._keep[1] = 1;
            else
                diceee._keep[1] = 0;

            if (checkBox4.Checked == true)
                diceee._keep[2] = 1;
            else
                diceee._keep[2] = 0;

            if (checkBox2.Checked == true)
                diceee._keep[3] = 1;
            else
                diceee._keep[3] = 0;

            if (checkBox3.Checked == true)
                diceee._keep[4] = 1;
            else
                diceee._keep[4] = 0;
            // Set the values of Keep based on the checked values of the checkboxes


            // Attempt to roll the dice
            try
            {
                diceee.RollDice();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Too many tries!");
            }


            int dIndex = 0;
            foreach (DieControl die in this.Controls.OfType<DieControl>())
            {
                die.Visible = true;
                die.Face = diceee.Dice[dIndex].Value;
                dIndex++;
            }

            // Display the values
            checkBox1.Text = "   " + diceee.Dice[0].Value.ToString();
            checkBox5.Text = "   " + diceee.Dice[1].Value.ToString();
            checkBox4.Text = "   " + diceee.Dice[2].Value.ToString();
            checkBox2.Text = "   " + diceee.Dice[3].Value.ToString();
            checkBox3.Text = "   " + diceee.Dice[4].Value.ToString();

            this.Text = titleMessage + ("Roll -  " + diceee.rollCount.ToString());

        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            diceee.NewTurn();
            //rollCount = 0;
            this.Text = titleMessage;
            checkBox1.Checked = false;
            checkBox5.Checked = false;
            checkBox4.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            checkBox1.Text = "";
            checkBox5.Text = "";
            checkBox4.Text = "";
            checkBox2.Text = "";
            checkBox3.Text = "";

            int dIndex = 0;
            foreach (DieControl die in this.Controls.OfType<DieControl>())
            {
                //die.Visible = true;
                die.Face = 1;
                dIndex++;
            }         
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}











//private void dieControl1_Load(object sender, EventArgs e)
//{
//    //dieControl1.Visible = false;
//}

//bool keep1;
//private void dieControl1_Click(object sender, EventArgs e)
//{
//    MessageBox.Show("");

//    if (keep1 == true)
//    {
//        diceee._keep[0] = 1;
//        keep1 = false;
//    }
//    else
//    {
//        diceee._keep[0] = 0;
//        keep1 = true;
//    }

//}

//bool keep2;
//private void dieControl2_Load(object sender, EventArgs e)
//{
//    if (keep2 == true)
//    {
//        diceee._keep[1] = 1;
//        keep2 = false;
//    }
//    else
//    {
//        diceee._keep[1] = 0;
//        keep2 = true;
//    }
//}

//bool keep3;
//private void dieControl3_Load(object sender, EventArgs e)
//{
//    if (keep3 == true)
//    {
//        diceee._keep[2] = 1;
//        keep3 = false;
//    }
//    else
//    {
//        diceee._keep[2] = 0;
//        keep3 = true;
//    }
//}

//bool keep4;
//private void dieControl4_Load(object sender, EventArgs e)
//{
//    if (keep4 == true)
//    {
//        diceee._keep[3] = 1;
//        keep4 = false;
//    }
//    else
//    {
//        diceee._keep[3] = 0;
//        keep4 = true;
//    }
//}

//bool keep5;
//private void dieControl5_Load(object sender, EventArgs e)
//{
//    if (keep5 == true)
//    {
//        diceee._keep[4] = 1;
//        keep5 = false;
//    }
//    else
//    {
//        diceee._keep[4] = 0;
//        keep5 = true;
//    }
//}



// Roll the dice
//try
//{
//    if (rollCount < 3)
//    {
//        for (int i = 0; i <= 5; i++)
//        {
//            if (diceee._keep[i] == 0)
//            {
//                diceee.Dice[i].Roll();                           
//            }
//        }
//    }
//    else
//    {
//        MessageBox.Show("You cant roll more than 3 times.");
//    }
//    rollCount++;
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    MessageBox.Show(ex.Message);
//}








//for (int i = 0; i <= 5; i++)
//{
//    diceee._keep[i] = 
//}

//try
//{
//    diceee.RollDice();

//}
//catch (ArgumentOutOfRangeException ex)
//{
//    MessageBox.Show(ex.Message);
//}

//try
//{
//    //die1.Face = new Random().Next(1, 9);
//    //die1.Value = new Random().Next(1, 7);
//    //die1 = new Die(new Random().Next(1, 7));
//foreach (Die d in diceee.Dice)
//{
//    //if (diceee._keep[d.Value] == 1)
//    if (diceee._keep[d.Value] == 1)
//    {
//        d.Roll();
//    }
//}
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    MessageBox.Show(ex.Message);
//}