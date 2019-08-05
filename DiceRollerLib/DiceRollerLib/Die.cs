using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// we can use a sleep method
using System.Threading;

namespace DiceRollerLib
{
    public class Die
    {

        //public readonly int Value { get; set; }
        //private int Value;

        private int _value;

        public int Value
        {
            
            get { return  _value; }
            //set { myVar = value; }
        }


        public Die(int dieValue)
        {


            if (dieValue < 1 || dieValue > 6)
            {
                throw new ArgumentOutOfRangeException("Face value must be between 1 and 6");
            }
            else
            {
                //int dieSize = 223;
                _value = dieValue;
            }

        }


        public int Roll()
        {
            
            Random r1 = new Random();
            // we can use a sleep method
            //Thread.Sleep(100);

            //Random r2 = new Random();


             _value = r1.Next(1, 7);
            //int num2 = r2.Next(1, 7);   // between 1 and 10

            

             return _value;

        }



    }
}





