using System;
using System.Diagnostics.Metrics;

public class Card
{
    public int Id;
    public int Suit;
    public int Value;
    public Card(int id, int suit, int value)
    {
        Id = id;
        Value = value;
        Suit = suit;
    }
}
public class Deck
{

    //Card[52]
    public static int[] deck = new int[53];

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
        while (counter < 52)
        {

            int temp = counter;

            deck[counter-1] = temp;
            //Console.WriteLine(deck[counter].ToString());
            Card card = new Card(temp, suit, value);
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

        //Deal();
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

    }
    static void RiffleShuffle()
    {
        Random random= new Random();
        int amountOfRiffles = random.Next(2,10);
        while (amountOfRiffles > 0)
        {
            int[] arr1 = new int[27];
            int[] arr2 = new int[27];
            int[] arr3 = new int[53];
            int count = 0;
            int count1= 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            while (count < 26)
            {
                arr1[count] = Deck.deck[count];
                count++;
            }
            while(count2<26)
            {

                arr2[count2] = Deck.deck[count];
                count++;
                count2++;
            }
            while (count3 < 26)
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
            Console.WriteLine(Deck.deck.ToString());
            amountOfRiffles--;
            

        }

    }
    static void Deal()
    {

    }
    

}