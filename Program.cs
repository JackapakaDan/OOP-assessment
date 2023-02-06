using System;
using System.Diagnostics.Metrics;

public class Card //Defines the card class
{

    public int Suit; //creates a suit for the card
    public int Value; //creates a value for the card
    public Card( int suit, int value)
    {

        Value = value; //assigns a value to the card
        Suit = suit; //assigns a suit to the card
    }
}
public class Deck //defines the suit class
{

    public static int[] deck = new int[52]; //creates an array to store the indexes of the cards
    public static Card[] cards = new Card[52]; // creates an array to store the cards themselves
    public Deck() //defines the deck
    {

        int value = 1; //defines a value that will be incremented - this is where the value on the cards is calculated.
        int suit = 1;  //defines a suit that will be incremented - this is where the suit of the cards is calculated.
        int counter = 1; //defines a counter for the while loop
        while (counter < 53) //makes sure that the index aren't out of range
        {
            deck[counter-1] = counter; //stores counter
            Card card = new Card(suit, value); //creates a card
            cards[counter-1] = card; // stores the card
            counter++; // increments counter
            value++; //increments the value of the card
            if (value == 14) //cards cannot have a value higher than a king
            {
                suit++; //increments suit
                value = 1; //resets value
                
            }
        }
    }



}
class Testing//defines that class that will run everything
{
    static void Main()
    {
        int shuffleType = 3;
        bool error = false;
        Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");
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
            error= false;//error handling (if the user enters a non numeric value)
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
        Deck deck = new Deck();
        ShuffleCardPack(shuffleType);

        Deal();
    }
    static void ShuffleCardPack(int typeOfShuffle)
    {
        var error = false;//error handling (if the user enters an invalid number)
        if (typeOfShuffle == 1)//error handling (if the user enters an invalid number)
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
            error= true;//error handling (if the user enters an invalid number)
        }
        while (error == true)//error handling (if the user enters an invalid number)
        {
            bool error1 = false;
            Console.WriteLine("There was an error...\nPlease enter a number between 1 and 3\nEnter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");
            try //error handling (if the user enters a non numeric value)
            {
                typeOfShuffle = Convert.ToInt32(Console.ReadLine()); //error handling (if the user enters a non numeric value)
            }
            catch (FormatException)//error handling (if the user enters a non numeric value)
            {
                Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                error1 = true;//error handling (if the user enters a non numeric value)
            }
            catch (Exception exception)//error handling (if the user enters a non numeric value)
            {
                Console.WriteLine(
                    $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                error1 = true;//error handling (if the user enters a non numeric value)
            }
            while (error1)//error handling (if the user enters a non numeric value)
            {
                error1 = false;//error handling (if the user enters a non numeric value)
                Console.WriteLine("Enter the type of shuffle: 1. Fisher Yates, 2. Riffle, 3. No shuffle:");//error handling (if the user enters a non numeric value)
                try
                {
                    typeOfShuffle = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
                }
                catch (FormatException)//error handling (if the user enters a non numeric value)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                    error1 = true;//error handling (if the user enters a non numeric value)
                }
                catch (Exception exception)//error handling (if the user enters a non numeric value)
                {
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                    error1 = true;//error handling (if the user enters a non numeric value)
                }
            }
            if (typeOfShuffle == 1)
            {
                error= false;
                Console.WriteLine("Fisher Yates shuffle selected...");
                FisherYatesShuffle();

            }
            else if (typeOfShuffle == 2)
            {
                error = false;
                Console.WriteLine("Riffle shuffle selected...");
                RiffleShuffle();
            }
            else if (typeOfShuffle == 3)
            {
                error = false;
            }
        }

    }
    static void FisherYatesShuffle()
    {

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


    }

    static void RiffleShuffle()
    {
        Random random= new Random();
        int amountOfRiffles = random.Next(10,20);
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


        }

    }
    static void Deal()
    {
        int people = 1;
        int personCounter = 1;
        Console.WriteLine("How many people are being dealt for?");
        bool error = false;//error handling (if the user enters a non numeric value)

        try//error handling (if the user enters a non numeric value)
        {
            people = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
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
            Console.WriteLine("How many people are being dealt for?");//error handling (if the user enters a non numeric value)
            error = false;//error handling (if the user enters a non numeric value)
            try
            {
                people = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
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

        while (people <= 0)
        {
            Console.WriteLine("There should be at least 1 person requiring shuffled cards");
            Console.WriteLine("How many people are being dealt for?");


            try
            {
                people = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
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
            while (error)
            {
                Console.WriteLine("How many people are being dealt for?");//error handling (if the user enters a non numeric value)
                error = false;//error handling (if the user enters a non numeric value)
                try
                {
                    people = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                    error = true;
                }
                catch (Exception exception)
                {

                
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                    error = true;
                }
            }
        }
        Console.WriteLine("How many cards are there per person?");
        int cards = 7;


        try
        {
            cards = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)

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
        while (people * cards > 52)//error handling (if the user asks for more cards than are in the deck)
        {
            Console.WriteLine("There are only 52 cards in this deck...");//error handling (if the user asks for more cards than are in the deck)
            Console.WriteLine("How many people are being dealt for?");//error handling (if the user asks for more cards than are in the deck)


            try
            {
                people = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR...You should have entered a number!");
                error = true;
            }
            catch (Exception exception)
            {
                error = true;
                Console.WriteLine(
                    $"Unexpected error:  {exception.Message}");
            }
            while (error)
            {
                Console.WriteLine("How many people are being dealt for?");
                error = false;
                try
                {
                    people = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");
                    error = true;
                }
                catch (Exception exception)
                {
                    error= true;
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");
                }
            }
            while (people <= 0)
            {
                Console.WriteLine("There should be at least 1 person requiring shuffled cards");
                Console.WriteLine("How many people are being dealt for?");

                try
                {
                    people = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");
                    error = true;
                }
                catch (Exception exception)
                {
                    error = true;
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");
                }
                while (error)
                {
                    Console.WriteLine("How many people are being dealt for?");
                    error = false;
                    try
                    {
                        people = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERROR...You should have entered a number!");
                        error = true;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(
                            $"Unexpected error:  {exception.Message}");
                    }
                }
            }
            Console.WriteLine("How many cards are there per person?");

            
            try
            {
                cards = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR...You should have entered a number!");
                error = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  {exception.Message}");
            }
            while (error)
            {
                Console.WriteLine("How many cards are there per person?");
                error = false;
                try
                {
                    cards = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");
                    error = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");
                    error = true;
                }
            }
        }

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