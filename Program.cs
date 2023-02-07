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
        int shuffleType = 3; //the type of shuffle, default is no shuffle.
        bool error = false;//there should be no errors to begin with
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
        Deck deck = new Deck();//creates an object that inherits from the class Deck
        ShuffleCardPack(shuffleType);//calls the procedure ShuffleCardPack with the parameter shuffleType

        Deal();//Calls the function deal, which deals the cards out evenly
    }
    static void ShuffleCardPack(int typeOfShuffle)
    {
        var error = false;//error handling (if the user enters an invalid number)
        if (typeOfShuffle == 1)//error handling (if the user enters an invalid number)
        {
            Console.WriteLine("Fisher Yates shuffle selected...");//informs the user that their choice was accepted
            FisherYatesShuffle();//calls the FisherYatesShuffle procedure
        }
        else if (typeOfShuffle == 2)
        {
            Console.WriteLine("Riffle shuffle selected...");//informs the user that their choice was accepted
            RiffleShuffle();//calls the RiffleShuffle procedure
        }
        else if (typeOfShuffle == 3)
        {
            Console.WriteLine("No shuffle selected...");//informs the user that their choice was accepted
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
                error= false;//prevents errors
                Console.WriteLine("Fisher Yates shuffle selected...");//informs the user that their choice was accepted
                FisherYatesShuffle();//calls the FisherYatesShuffle procedure

            }
            else if (typeOfShuffle == 2)
            {
                error = false;//prevents errors
                Console.WriteLine("Riffle shuffle selected...");//informs the user that their choice was accepted
                RiffleShuffle();//calls the RiffleShuffle procedure
            }
            else if (typeOfShuffle == 3)
            {
                error = false;//prevents errors
                Console.WriteLine("No shuffle selected...");//informs the user that their choice was accepted
            }
        }

    }
    static void FisherYatesShuffle()
    {

        int count6 = 51;
        while (count6 > 0)//counts down from 51 to 0
        {

            Random rand = new Random();
            int index = rand.Next(0, count6 - 1);//generates a random index in order to swap numbers
            int temp = Deck.deck[index]; //stores random number from the deck array
            Deck.deck[index] = Deck.deck[count6];//overwrites random number with the last element in the array
            Deck.deck[count6] = temp;//overwrites the last element of the array with random number
            count6--;//decrements count6
        }


    }

    static void RiffleShuffle()
    {
        Random random= new Random();
        int amountOfRiffles = random.Next(10,20);//generates a random amount of riffles
        while (amountOfRiffles > 0)
        {
            int[] arr1 = new int[26];//this stores the first half of the array
            int[] arr2 = new int[26];//this stores the second half of the array
            int[] arr3 = new int[52];//this stores the shuffled array
            int count = 0;//this counts each element going into aar1 and arr2
            int count1= 0;// this is used to add values to arr3
            int count2 = 0;//this is used for indexing in arr2
            int count3 = 0;//this is used for adding elements in arr2 to arr3
            int count4 = 0;//this is used for adding elements in arr1 to arr3
            while (count <= 25)//adds elements to arr1
            {
                arr1[count] = Deck.deck[count];
                count++;
            }
            while(count<52 && count>=26)//adds elements to arr2
            {

                arr2[count2] = Deck.deck[count];
                count++;
                count2++;
            }
            while (count4 < 26)//puts the shuffled array together in arr3
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
            Deck.deck = arr3; //stores the new array in the array deck

            amountOfRiffles--;//decrements the amount of riffles


        }

    }
    static void Deal()
    {
        int people = 1; //default number of people set to 1
        int personCounter = 1;//used to count the number of people
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
        int cards = 7;//default number of cards set to 7


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
        while (people * cards > 52 || cards <= 0)//error handling (if the user asks for more cards than are in the deck)
        {
            Console.WriteLine("There are 52 cards in this deck and each person should get at least 1 card...");//error handling (if the user asks for more cards than are in the deck)
            Console.WriteLine("How many people are being dealt for?");//error handling (if the user asks for more cards than are in the deck)


            try
            {
                people = Convert.ToInt32(Console.ReadLine());//reads number user has inputted
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                error = true;//error handling (if the user enters a non numeric value)
            }
            catch (Exception exception)//error handling (if the user enters a non numeric value)
            {
                error = true;//error handling (if the user enters a non numeric value)
                Console.WriteLine(
                    $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
            }
            while (error)
            {
                Console.WriteLine("How many people are being dealt for?");//error handling (if the user enters a non numeric value)
                error = false;
                try
                {
                    people = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)
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
                        $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                }
            }
            while (people <= 0)
            {
                Console.WriteLine("There should be at least 1 person requiring shuffled cards");//error handling (if there are no or negative people)
                Console.WriteLine("How many people are being dealt for?");

                try
                {
                    people = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                    error = true;//error handling (if the user enters a non numeric value)
                }
                catch (Exception exception)
                {
                    error = true;
                    Console.WriteLine(
                        $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
                }
                while (error)
                {
                    Console.WriteLine("How many people are being dealt for?");//error handling (if the user enters a non numeric value)
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
                            $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
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
                Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
                error = true;//error handling (if the user enters a non numeric value)
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  {exception.Message}");
            }
            while (error)
            {
                Console.WriteLine("How many cards are there per person?");//error handling (if the user enters a non numeric value)
                error = false;
                try
                {
                    cards = Convert.ToInt32(Console.ReadLine());//error handling (if the user enters a non numeric value)

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

        int cardCounter = 0; // counts the number of cards dealt
        int cardCount = cards;//stores how may cards per person because the variable cards is needed to be changed

        while (people > 0)//measures number of people
        {

            Console.WriteLine("Person " + personCounter.ToString() + " has the:");//informs user about which player is drawing
            while (cards > 0)//measures cards drawn by 1 person
            {
                int index1 = Deck.deck[cardCounter];//finds index
                int suit = Deck.cards[index1-1].Suit;//gets suit
                int value = Deck.cards[index1-1].Value;//gets value
                if (suit == 1)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Diamonds");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Diamonds");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Diamonds");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Diamonds");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Diamonds");//outputs any remaining numbers allong with the suit
                    }
                }
                if (suit == 2)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Hearts");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Hearts");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Hearts");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Hearts");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Hearts");//outputs any remaining numbers allong with the suit
                    }
                }
                if (suit == 3)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Clubs");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Clubs");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Clubs");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Clubs");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Clubs");//outputs any remaining numbers allong with the suit
                    }
                }
                if (suit == 4)
                {
                    if (value == 13)
                    {
                        Console.WriteLine("King of Spades");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 12)
                    {
                        Console.WriteLine("Queen of Spades");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 11)
                    {
                        Console.WriteLine("Jack of Spades");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("Ace of Spades");//allows for kings, queens, jacks and aces to be outputted as text, rather than numbers
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " of Spades");//outputs any remaining numbers allong with the suit
                    }
                }
                cardCounter++;//increments cardCounter
                cards--;//decrements number of cards for user to draw

            }
            cards = cardCount;//changes the value of cards due to new people
            people--;//decrements number of people
            personCounter++;//adds a new person

        }
    }
    

}