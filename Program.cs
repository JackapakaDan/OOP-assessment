using System;
using System.Diagnostics.Metrics;

public class Card
{

    public int Suit;
    public int Value;
    public Card( int suit, int value)
    {

        Value = value;
        Suit = suit;
    }
}
public class Deck
{

    //Card[52]
    public static int[] deck = new int[52];
    public static Card[] cards = new Card[52];
    public Deck()
    {
        /*
        int counter = 0;
        for (int i = 1; i <= 5; ++i)
        {
            for (int j = 1; j <= 14; ++j)
            {
                //Card card = new Card(counter, i, j);
                Console.WriteLine(counter.ToString());
                deck[counter] = counter+1;
                counter++;

            }

        }
        */
        int value = 1;
        int suit = 1;
        Console.WriteLine(' ');
        int counter = 1;
        while (counter < 53)
        {

            //int temp = counter;
            deck[counter-1] = counter;
            //Console.WriteLine(deck[counter].ToString());
            Card card = new Card(suit, value);
            cards[counter-1] = card;
            counter++;
            value++;
            if (value == 14)
            {
                suit++;
                value = 1;
                
            }
        }
    }



}
class Testing
{
    //Deck[1]
    static void Main()
    {


        Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");
        int shuffleType= Convert.ToInt32(Console.ReadLine());
        Deck deck = new Deck();
        ShuffleCardPack(shuffleType);

        Deal();
    }
    static void ShuffleCardPack(int typeOfShuffle)
    {
        var error = false;
        if (typeOfShuffle == 1)
        {
            Console.WriteLine("Fisher Yates shuffle selected...");
            FisherYatesShuffle();
        }
        else if (typeOfShuffle == 2)
        {
            Console.WriteLine("Riffle shuffle selected...");
            RiffleShuffle();
        }
        else if (typeOfShuffle == 3)
        {
            Console.WriteLine("No shuffle selected...");
        }
        else
        {
            error= true;
        }
        while (error == true)
        {
            Console.WriteLine("There was an error...\nPlease enter a number between 1 and 3\nEnter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");
            if (typeOfShuffle == 1)
            {
                error= false;

            }
            else if (typeOfShuffle == 2)
            {
                error = false;
            }
            else if (typeOfShuffle == 3)
            {
                error = false;
            }
        }

    }
    static void FisherYatesShuffle()
    {
        //int count5 = 0;
        int count6 = 51;
        while (count6 > 0)
        {

            Random rand = new Random();
            int index = rand.Next(0, count6 - 1);
            int temp = Deck.deck[index];
            Deck.deck[index] = Deck.deck[count6];
            Deck.deck[count6] = temp;
            count6--;
        }
        /*
        while (count5 < Deck.deck.Length)
        {
            Console.WriteLine(count5.ToString() + " : " + Deck.deck[count5].ToString());
            count5++;
        }
        */

    }

    static void RiffleShuffle()
    {
        Random random= new Random();
        int amountOfRiffles = random.Next(2,10);
        while (amountOfRiffles > 0)
        {
            int[] arr1 = new int[26];
            int[] arr2 = new int[26];
            int[] arr3 = new int[52];
            int count = 0;
            int count1= 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            //int count5 = 0;
            while (count <= 25)
            {
                arr1[count] = Deck.deck[count];
                count++;
            }
            while(count<52 && count>=26)
            {

                arr2[count2] = Deck.deck[count];
                count++;
                count2++;
            }
            while (count4 < 26)
            {

                if (count1 % 2 == 0)
                {
                    arr3[count1] = arr2[count3];
                    count3++;
                }
                else
                {
                    arr3[count1] = arr1[count4];
                    count4++;
                }

                count1++;
            }
            Deck.deck = arr3;

            amountOfRiffles--;
            /*
            while (count5 < Deck.deck.Length)
            {
                Console.WriteLine(count5.ToString() + " : " + arr3[count5].ToString());
                count5++;
            }
            */

        }

    }
    static void Deal()
    {
        int personCounter = 1;
        Console.WriteLine("How many people are being dealt for?");
        int people = Convert.ToInt32(Console.ReadLine());
        while (people <= 0)
        {
            Console.WriteLine("There should be at least 1 person requiring shuffled cards");
            Console.WriteLine("How many people are being dealt for?");
            people = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("How many cards are there per person?");
        int cards = Convert.ToInt32(Console.ReadLine());
        while (people * cards > 52)
        {
            Console.WriteLine("There are only 52 cards in this deck...");
            Console.WriteLine("How many people are being dealt for?");
            people = Convert.ToInt32(Console.ReadLine());
            while (people <= 0)
            {
                Console.WriteLine("There should be at least 1 person requiring shuffled cards");
                Console.WriteLine("How many people are being dealt for?");
                people = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("How many cards are there per person?");
            cards = Convert.ToInt32(Console.ReadLine());
        }
        //int cardsToDraw = cards*people;
        int cardCounter = 0;
        int cardCount = cards;

        while (people > 0)//measures number of people
        {

            Console.WriteLine("Person " + personCounter.ToString() + " has the:");
            while (cards > 0)//measures cards drawn by 1 person
            {
                int index1 = Deck.deck[cardCounter];
                int suit = Deck.cards[index1-1].Suit;
                int value = Deck.cards[index1-1].Value;
                if (suit == 1)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Diamonds");
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Diamonds");
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Diamonds");
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Diamonds");
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Diamonds");
                    }
                }
                if (suit == 2)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Hearts");
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Hearts");
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Hearts");
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Hearts");
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Hearts");
                    }
                }
                if (suit == 3)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Clubs");
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Clubs");
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Clubs");
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Clubs");
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Clubs");
                    }
                }
                if (suit == 4)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Spades");
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Spades");
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Spades");
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Spades");
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Spades");
                    }
                }
                cardCounter++;
                cards--;

            }
            cards = cardCount;
            people--;
            personCounter++;

        }
    }
    

}