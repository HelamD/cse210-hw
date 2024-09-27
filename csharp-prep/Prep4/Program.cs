using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter a list of numbers, type 0 when finished");

       
       List<int> numbers = new List<int>();

        int number = -1;

       while (number != 0)
       
        {

            Console.Write("Enter a number ");
            string answer = Console.ReadLine();
            int newAnswer = int.Parse(answer);

            
            if (newAnswer != 0)
            {
                numbers.Add(newAnswer);
            }

            else
            {
                break;
            }

        }
        Console.WriteLine("The numberes you entered:");
        foreach (int num in numbers)
        {
                Console.WriteLine(num);
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
         Console.WriteLine($"The sum of the numbers is: {sum}");

         double average = (double)sum / numbers.Count;
          Console.WriteLine($"The average of the numbers is: {average}");

        if (numbers.Count > 0)
        {
                int largest = numbers[0];
                foreach (int num in numbers)
                {
                        if (num > largest)
                        {
                            largest = num;
                        }
                 }  

                Console.WriteLine($"The largest number is: {largest}");
     }
    }           

}