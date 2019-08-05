using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DiceRollerLib
{
    public class YahtzeeRoller
    {
        private string diceScore;
        private Die[] Dice = new Die[5];
        public int[] _keep = new int[5];
        private int rollCount = 0;


        public void Keep(int dieKeeper) // this is the index of the array
        {
            _keep[dieKeeper] = dieKeeper;
        }


        public void NewTurn()
        {
            rollCount = 0;
            
        }

        public Die[] ShowDice()
        {
            return Dice;
        }

        public void RollDice()
        {

            if (rollCount < 3)
            {
                rollCount++;

                int newRoll = 0;
               // int index = 0;
                //foreach (Die d in Dice)
                //{
                //    if (_keep[index] == 0)
                //    {
                        
                //        newRoll = d.Roll();
                //        //Dice[index] = new Die(newRoll);
                //        //d = new Die(newRoll);
                //       // d.Value = newRoll;
                //        index++;
                //    }
                //}


                for (int i = 0; i < 5; i++)
                {
                    //Die tempDie = new Die(Dice[i].Value);
                    if (_keep[i] == 0)
                    {
                        //Thread.Sleep(100);
                        newRoll = Dice[i].Roll();
                        
                        Dice[i] = new Die(newRoll);


                        //Die tempDie = new Die(Dice[i].Roll());
                        //Dice[i].Roll(); 
                        //Dice[i].Value = Dice[i].Roll();
                        //tempDie.Roll();
                        //Dice[i] = tempDie;
                        //tempDie = null;
                    }
                    //Thread.Sleep(100);
                }

            }
            else
            {
                string errorMessage = "You have already rolled 3 times.\n\n" + Score();
                //throw new ArgumentOutOfRangeException("You have already rolled 3 times.");
                throw new ArgumentOutOfRangeException(errorMessage);
            }

        }

        private string Score()
        {
            
            int ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0;
            int[] i = new int[6];

            //foreach (Die d in Dice)
            for (int diceIndex = 0; diceIndex <= Dice.Length; diceIndex++)
            {
                int thisDieValue = Dice[diceIndex].Value;
                switch (thisDieValue)
                {
                    case 1:
                        ones += 1;
                        i[0] += 1;
                        break;
                    case 2:
                        twos += 1;;
                        i[1] += 1;
                        break;
                    case 3:
                        threes += 1;;
                        i[2] += 1;
                        break;
                    case 4:
                        fours += 1;;
                        i[3] += 1;
                        break;
                    case 5:
                        fives += 1;;
                        i[4] += 1;
                        break;
                    case 6:
                        sixes += 1;;
                        i[5] += 1;
                        break;
                }
                
            }

            bool fullHouse3 = false, fullHouse2 = false;
            int zeros = 0;
            foreach (int o in i)
            {

                switch (o)
                {
                    case 0:
                        zeros += 1;
                        break;
                    case 4:
                        diceScore = "Four of a kind !";
                        break;
                    case 2:
                        fullHouse2 = true;
                        break;
                    case 3:
                        fullHouse3 = true;
                        break;
                }

                //if (o == 0)
                //{
                //    zeros += 1;
                //}

                //if (o == 4)
                //{
                //    diceScore = "Four of a kind !";
                //}

                //if (o == 3)
                //{
                //    fullHouse3 = true;
                //}

                //if (o == 2)
                //{
                //    fullHouse2 = true;
                //}
            }

            if (fullHouse3 = true && fullHouse2 == true)
                diceScore = "Full House !";

            if (zeros <= 1)
            {
                diceScore = "Large Strait !";
            }
            else if (zeros == 2)
            {
                diceScore = "Small Strait !";
            }



            if (diceScore == null)
                //diceScore = "I can't figure out your score ??";
                diceScore = "    You Lose :(    ";
                 
            return diceScore;
        }



    }
}
