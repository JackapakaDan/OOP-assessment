using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Jack_Wilson_26364588_Version_3
{
    internal class Pack
    {
        public enum Suit
        {
            diamonds,
            hearts,
            clubs,
            spades
        }
        public enum Value
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
        List<Card> pack = new List<Card>();

        public Pack()
        {
             
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in (Value[])Enum.GetValues(typeof(Value)))
                {
                    Card card = new Card();
                    card.suit = suit;
                    card.value = value;
                    pack.Add(card);
                }
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                //fisher yates shuffle
                Console.WriteLine("\n\nFisher Yates shuffle selected...\n\n");//informs the user that their choice was accepted
                for (int i = 51; i > 0; i--)
                {
                    Random rand = new Random();
                    int index = rand.Next(0, i - 1);//generates a random index in order to swap numbers
                    Card temp = pack[index]; //stores random number from the deck array
                    pack[index] = pack[i];//overwrites random number with the last element in the array
                    pack[i] = temp;//overwrites the last element of the array with random number

                }
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                
                Console.WriteLine("\n\nRiffle shuffle selected...\n\n");//informs the user that their choice was accepted
                //riffle shuffle
                bool error = false;
                int amountOfRiffles = 3; //the type of shuffle, default is no shuffle.
                Console.WriteLine("Enter the number of riffles that you wish to perform:");//asks user to enter the shuffling method that they prefer
                try //error handling (if the user enters a non numeric value)
                {
                    amountOfRiffles = Convert.ToInt32(Console.ReadLine()); //error handling (if the user enters a non numeric value)
                    if (amountOfRiffles < 1)
                    {
                        Console.WriteLine("There is an error: there are too few riffles!");
                        error = true;
                    }
                    else if (amountOfRiffles > 15)
                    {
                        Console.WriteLine("There is an error: there are too many riffles!");
                        error = true;
                    }
                    else
                    {
                        Console.WriteLine("Number of riffles accepted!");
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
                while (error)//error handling (if the user enters a non numeric value)
                {
                    error = false;//error handling (if the user enters a non numeric value)
                    Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");//error handling (if the user enters a non numeric value)
                    try
                    {
                        amountOfRiffles = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
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
                while (amountOfRiffles > 0)
                {
                    List<Card> list1 = new List<Card>();//this stores the first half of the array
                    List<Card> list2 = new List<Card>();//this stores the second half of the array
                    List<Card> list3 = new List<Card>();//this stores the shuffled array


                    int count = 0;//this is used for adding elements in arr2 to arr3
                    int count1 = 0;//this is used for adding elements in arr1 to arr3
                    for (int i = 0; i < 52; i++)//adds elements to arr1
                    {
                        if (i < 26)
                        {
                            list1.Add(pack[i]);

                        }
                        else
                        {
                            list2.Add(pack[i]);
                        }
                    }
                    for (int k = 0; k < 52; k++)
                    {
                        if (k % 2 == 0)
                        {
                            list3.Add(list2[count]);
                            count++;
                        }
                        else
                        {
                            list3.Add(list1[count1]);
                            count1++;
                        }
                    }
                    pack = list3; //stores the new array in the array deck
                    amountOfRiffles--;//decrements the amount of riffles
                }
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                //no shuffle
                Console.WriteLine("\n\nNo shuffle selected...\n\n");//informs the user that their choice was accepted
                return true;
            }
            else
            {
                return false;
            }
        }

        public Card deal()
        {
            //Deals one card
            Card cardToDeal = pack.Last();
            pack.Remove(cardToDeal);
            return cardToDeal;
        }
        public List<Card> dealCard(int amount)
        {

            //Deals the number of cards specified by 'amount'
            Console.WriteLine("You have dealt the:");
            for (int i = 0; i < amount; i++)
            {
                if (pack.Count>0)
                {
                    Card dealtCard = deal();
                    Console.WriteLine(dealtCard.value.ToString() + " of " + dealtCard.suit.ToString());
                }

            }
            return pack;
        }
    }
}
