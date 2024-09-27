using System;

class Program
{
    static void Main(string[] args)

       
    {
        Console.Write("What is the magic number?: ");
        string magic = Console.ReadLine();
        int numberMagic = int.Parse(magic);

        int numberGuess = -1;


        while (numberGuess != numberMagic)
     {
            Console.Write("What is your guess?: "); 
            string guess = Console.ReadLine();
            numberGuess = int.Parse(guess);

            
    
            if (numberGuess > numberMagic)
            {
                Console.WriteLine("Too high");
            }   


            else if  (numberGuess < numberMagic)
            {
                Console.WriteLine("Too low");
            } 


            else if  (numberGuess == numberMagic)
            {
                Console.WriteLine("You got it");
            } 

        }
    }             
}