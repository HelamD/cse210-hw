using System;

class Program
{
    static void Main(string[] args)
    {
            

                Console.Write("what is your grade in porcentage?: ");
                string userGrade = Console.ReadLine();
                int grade = int.Parse(userGrade);
                

                    string letter = "";


                    if (grade >= 90 )
                    {
                        letter = "A";
                    }

                    else if (grade >= 80)
                    {
                        letter = "B";
                    }
                    

                    else if(grade >=70 )
                    {
                        letter = "C";
                    }

                     else if (grade >= 60)
                    {
                        letter = "D";

                    }
                    

                    else if (grade < 60)
                    {
                        letter = "F";
                    }

                    Console.WriteLine($"your grade is {letter}");


                    if (grade > 70)
                    {
                        Console.WriteLine("You passed the course, YEAAAH!");
                    }

                     else if (grade < 60)
                    {
                        Console.WriteLine("sorry you did not passed the course");
                    }





    }
}