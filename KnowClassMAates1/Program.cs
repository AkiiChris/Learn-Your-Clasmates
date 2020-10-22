using System;

namespace KnowClassMAates1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Kyle", "Anthony", "Kobe", "Jada" };
            string[] HomeTown = { "Battle Creek", "Detroit", "Los Angeles", "Chicago" };
            string[] FavoriteFood = { "Hamburgers", "Cheese Fries", "Lamb Chops", "Salad" };

            for(int i = 1; i <= 1; i--)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-4:) ");
                string userInput1 = Console.ReadLine();
                int studentNumber = Convert.ToInt32(userInput1);

                if(studentNumber == 1)
                {
                    bool isValid = false;
                    while (isValid == false)
                    {
                        Console.WriteLine($"Student {studentNumber} is {Names[0]}. What would you like to know about {Names[0]} ? (enter “hometown” or “favorite food”)");
                        string information = Console.ReadLine();

                        if (information == "hometown" || information == "Hometown" || information == "HOMETOWN")
                        {
                            isValid = true;
                            Console.WriteLine($"{Names[0]} is from {HomeTown[0]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            
                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else if (information == "favorite food" || information == "FAVORITE FOOD" || information == "Favorite Food")
                        {
                            isValid = true;
                            Console.WriteLine($"{Names[0]} favorite food is {FavoriteFood[0]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”):");
                        }
                    }
                }
                else if(studentNumber == 2)
                {
                    bool isValid = false;
                    while (isValid == false)
                    {
                        Console.WriteLine($"Student {studentNumber} is {Names[1]}. What would you like to know about {Names[1]} ? (enter “hometown” or “favorite food”)");
                        string information = Console.ReadLine();

                        if (information == "hometown" || information == "Hometown" || information == "HOMETOWN")
                        {
                            Console.WriteLine($"{Names[1]} is from {HomeTown[1]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else if (information == "favorite food" || information == "FAVORITE FOOD" || information == "Favorite Food")
                        {
                            Console.WriteLine($"{Names[1]} favorite food is {FavoriteFood[1]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”):");

                        }
                    }
                }
                else if(studentNumber == 3)
                {
                    bool isValid = false;
                    while (isValid == false)
                    {
                        Console.WriteLine($"Student {studentNumber} is {Names[2]}. What would you like to know about {Names[2]} ? (enter “hometown” or “favorite food”)");
                        string information = Console.ReadLine();

                        if (information == "hometown" || information == "Hometown" || information == "HOMETOWN")
                        {
                            Console.WriteLine($"{Names[2]} is from {HomeTown[2]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else if (information == "favorite food" || information == "FAVORITE FOOD" || information == "Favorite Food")
                        {
                            Console.WriteLine($"{Names[2]} favorite food is {FavoriteFood[2]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”):");

                        }
                    }
                }
                else if(studentNumber == 4)
                {
                    bool isValid = false;
                    while (isValid == false)
                    {
                        Console.WriteLine($"Student {studentNumber} is {Names[3]}. What would you like to know about {Names[3]} ? (enter “hometown” or “favorite food”)");
                        string information = Console.ReadLine();

                        if (information == "hometown" || information == "Hometown" || information == "HOMETOWN")
                        {
                            Console.WriteLine($"{Names[3]} is from {HomeTown[3]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else if (information == "favorite food" || information == "FAVORITE FOOD" || information == "Favorite Food")
                        {
                            Console.WriteLine($"{Names[3]} favorite food is {FavoriteFood[3]}. Would you like to know more? (enter “yes” or “no”):");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "yes")
                            {
                                break;
                            }
                            else if (yesOrNo == "no")
                            {
                                Console.WriteLine("Thanks.");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”):");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-4)");
                    continue;
                }
            }
        }
    }
}
