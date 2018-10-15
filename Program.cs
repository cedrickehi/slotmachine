using System;

namespace SlotMachine
{
    /// <summary>
    /// Struggling to under the Coefficient part so made the slot machine without it
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("********Welcome to Bede Gaming Slot Machine*********");
            Console.WriteLine("");
            Console.WriteLine("*******Please Enter Your Deposit Amount**********");
            int winAmount = 10;

            int depositAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" You have entered " + depositAmount);
            Console.WriteLine("*********Please press the spaceBar to spin the machine***********");

            ConsoleKeyInfo spinKey = Console.ReadKey();



            if (spinKey.Key == ConsoleKey.Spacebar)
            {

                Console.WriteLine("Please enter the stake amount");

                int stakeAmount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Stake amount available " + stakeAmount);

                int result = depositAmount - stakeAmount + winAmount;
                Calculation(result, depositAmount);

            }

            else
            {
                Console.WriteLine("Incorrect key try it by pressing .... Spacebar");
                spinKey = Console.ReadKey();
            }

        }

        public static void Calculation(int check, int creditAmount)
        {
            Random randomAmount = new Random();
            

            //Declaring Slots

            string rowOne;
            string rowTwo;
            string rowThree;
            string rowFour;
            int randomOne = randomAmount.Next(10000, 20000);
            int randomTwo = randomAmount.Next(30000, 40000);
            int randomThree = randomAmount.Next(50000, 60000);
            int randomFour = randomAmount.Next(60000, 70000);


            int cellOne = randomOne % 45;
            int cellTwo = randomTwo % 35;
            int cellThree = randomThree % 15;
            int cellFour = randomFour % 5;

            string[] slots = new string[45];

            for (int i = 0; i < 8; i++)
                slots[i] = "A";
            for (int i = 8; i < 15; i++)
                slots[i] = "B";
            for (int i = 15; i < 21; i++)
                slots[i] = "P";
            for (int i = 21; i < 26; i++)
                slots[i] = "*";
          

            rowOne = slots[cellOne];
            rowTwo = slots[cellTwo];
            rowThree = slots[cellThree];
            rowFour = slots[cellFour];

            if (check == 0)
            {
                Console.WriteLine("You Lost");
                Console.WriteLine("Current Balance is " + check);
            }
            else if (check != 0)
            {
                int winAmount = check + creditAmount;
                Console.WriteLine("Row 1: " + rowOne);
                Console.WriteLine("Row  2: " + rowTwo);
                Console.WriteLine("Row  3: " + rowThree);
                Console.WriteLine("Row  4: " + rowFour);
                Console.WriteLine("You have Won");
                Console.WriteLine("");
                Console.WriteLine("Current Balance is: " + winAmount);
            }




         
        }
    }
}
