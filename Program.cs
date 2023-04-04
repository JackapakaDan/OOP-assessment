using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_Assessment_1_Jack_Wilson_26364588_Version_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = false;
            Console.WriteLine("You wish to test this program (true/false)?");
            bool test = false;
            try
            {
                test = Convert.ToBoolean(Console.ReadLine().ToLower());
            }
            catch (FormatException)//error handling (if the user enters a non numeric value)
            {
                Console.WriteLine("ERROR...You should have entered either true or false!");//error handling (if the user enters a non numeric value)
                error = true;//error handling (if the user enters a non numeric value)
            }
            catch (Exception exception)//error handling (if the user enters a non numeric value)
            {
                Console.WriteLine(
                    $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                error = true;//error handling (if the user enters a non numeric value)
            }
            while (error)
            {
                error = false;
                Console.WriteLine("You wish to test this program (true/false)?");
                try
                {
                    test = Convert.ToBoolean(Console.ReadLine().ToLower());
                }
                catch (FormatException)//error handling (if the user enters a non numeric value)
                {
                    Console.WriteLine("ERROR...You should have entered either true or false!");//error handling (if the user enters a non numeric value)
                    error = true;//error handling (if the user enters a non numeric value)
                }
                catch (Exception exception)//error handling (if the user enters a non numeric value)
                {
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                    error = true;//error handling (if the user enters a non numeric value)
                }
            }
            if (test)
            {
                Testing testing = new Testing();
            }
            else
            {
                Pack myCardPack = new Pack();
                int shuffleType = 3; //the type of shuffle, default is no shuffle.
                Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");//asks user to enter the shuffling method that they prefer
                try //error handling (if the user enters a non numeric value)
                {
                    shuffleType = Convert.ToInt32(Console.ReadLine()); //error handling (if the user enters a non numeric value)
                }
                catch (FormatException)//error handling (if the user enters a non numeric value)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                    error = true;//error handling (if the user enters a non numeric value)
                }
                catch (Exception exception)//error handling (if the user enters a non numeric value)
                {
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                    error = true;//error handling (if the user enters a non numeric value)
                }
                while (error)//error handling (if the user enters a non numeric value)
                {
                    error = false;//error handling (if the user enters a non numeric value)
                    Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");//error handling (if the user enters a non numeric value)
                    try
                    {
                        shuffleType = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
                    }
                    catch (FormatException)//error handling (if the user enters a non numeric value)
                    {
                        Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                        error = true;//error handling (if the user enters a non numeric value)
                    }
                    catch (Exception exception)//error handling (if the user enters a non numeric value)
                    {
                        Console.WriteLine(
                            $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                        error = true;//error handling (if the user enters a non numeric value)
                    }
                }
                bool shuffled = myCardPack.shuffleCardPack(shuffleType);

                while (shuffled == false)
                {
                    Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");//asks user to enter the shuffling method that they prefer
                    try //error handling (if the user enters a non numeric value)
                    {
                        shuffleType = Convert.ToInt32(Console.ReadLine()); //error handling (if the user enters a non numeric value)
                    }
                    catch (FormatException)//error handling (if the user enters a non numeric value)
                    {
                        Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                        error = true;//error handling (if the user enters a non numeric value)
                    }
                    catch (Exception exception)//error handling (if the user enters a non numeric value)
                    {
                        Console.WriteLine(
                            $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                        error = true;//error handling (if the user enters a non numeric value)
                    }
                    while (error)//error handling (if the user enters a non numeric value)
                    {
                        error = false;//error handling (if the user enters a non numeric value)
                        Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");//error handling (if the user enters a non numeric value)
                        try
                        {
                            shuffleType = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
                        }
                        catch (FormatException)//error handling (if the user enters a non numeric value)
                        {
                            Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                            error = true;//error handling (if the user enters a non numeric value)
                        }
                        catch (Exception exception)//error handling (if the user enters a non numeric value)
                        {
                            Console.WriteLine(
                                $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                            error = true;//error handling (if the user enters a non numeric value)
                        }
                    }
                    shuffled = myCardPack.shuffleCardPack(shuffleType);
                }
                int cards = 0;
                Console.WriteLine("How many cards are being dealt?");
                try
                {
                    cards = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
                    if (cards > 52 || cards < 1)
                    {
                        error = true;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                    error = true;//error handling (if the user enters a non numeric value)
                }
                catch (Exception exception)
                {
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                }
                while (error)//error handling (if the user enters a non numeric value)
                {
                    Console.WriteLine("How many cards are there per person?");//error handling (if the user enters a non numeric value)
                    error = false;//error handling (if the user enters a non numeric value)
                    try
                    {
                        cards = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
                        if (cards > 52 || cards < 1)
                        {
                            error = true;
                        }
                    }
                    catch (FormatException)//error handling (if the user enters a non numeric value)
                    {
                        Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                        error = true;//error handling (if the user enters a non numeric value)
                    }
                    catch (Exception exception)//error handling (if the user enters a non numeric value)
                    {
                        Console.WriteLine(
                            $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                        error = true;//error handling (if the user enters a non numeric value)
                    }
                }
                myCardPack.dealCard(cards);
            }




        }
    }
}
