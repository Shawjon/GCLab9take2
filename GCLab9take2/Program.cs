using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab9take2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesNo = true;

            List<int> numberinlist = new List<int>();
            numberinlist.Add(1);            numberinlist.Add(2);            numberinlist.Add(3);            numberinlist.Add(4);            numberinlist.Add(5);            numberinlist.Add(6);            numberinlist.Add(7);
            numberinlist.Add(8);            numberinlist.Add(9);            numberinlist.Add(10);            numberinlist.Add(11);            numberinlist.Add(12);            numberinlist.Add(13);            numberinlist.Add(14);
            numberinlist.Add(15);
            List<string> firstName = new List<string>();
            firstName.Add("Michael");            firstName.Add("Taylor");            firstName.Add("Joshua");            firstName.Add("Lin-Z");            firstName.Add("Madelyn");            firstName.Add("Nana");            firstName.Add("Rochelle");
            firstName.Add("Shah");            firstName.Add("Tim");            firstName.Add("Abby");            firstName.Add("Blake");            firstName.Add("Bob");            firstName.Add("Jordan");            firstName.Add("Jay");
            firstName.Add("Jon");
            List<string> hometown = new List<string>();
            hometown.Add("Canton, MI");            hometown.Add("Caro, MI");            hometown.Add("Taylor, MI");            hometown.Add("Toledo, OH");            hometown.Add("Oxford, MI");            hometown.Add("Guana");            hometown.Add("Mars");
            hometown.Add("Newark, NJ");            hometown.Add("Detroit, MI");            hometown.Add("Traverse City, MI");            hometown.Add("Los Angeles, CA");            hometown.Add("St. Clair Shores, MI");            hometown.Add("Warren, MI");            hometown.Add("Macomb, MI");
            hometown.Add("Huntington Woods, MI");
            List<string> FavFood = new List<string>();
            FavFood.Add("Chicken Wings");            FavFood.Add("Cordon Bleu");            FavFood.Add("Turkey");            FavFood.Add("Ice Cream");            FavFood.Add("Croissent");            FavFood.Add("Empanadas");            FavFood.Add("Space Cheese");
            FavFood.Add("Chicken Wings");            FavFood.Add("Chicken Parm");            FavFood.Add("Soup");            FavFood.Add("Cannolis");            FavFood.Add("Pizza");            FavFood.Add("Burgers");            FavFood.Add("Pickles");
            FavFood.Add("Ribs");
            List<string> lastName = new List<string>();
            lastName.Add("Hern");            lastName.Add("Everts");            lastName.Add("Zimmerman");            lastName.Add("Chang");            lastName.Add("Hilty");            lastName.Add("Banahene");            lastName.Add("Toles");
            lastName.Add("Shahid");            lastName.Add("Broughton");            lastName.Add("Wessels");            lastName.Add("Shaw");            lastName.Add("Valentic");            lastName.Add("Owiesny");            lastName.Add("Stiles");
            lastName.Add("Shaw");
            List<string> FavColor = new List<string>();
            FavColor.Add("Red");  FavColor.Add("Bleu");  FavColor.Add("Yellow");  FavColor.Add("Purple");  FavColor.Add("Brown");  FavColor.Add("Green"); FavColor.Add("Lime Green");
            FavColor.Add("Orange"); FavColor.Add("Blue"); FavColor.Add("Black"); FavColor.Add("Pink"); FavColor.Add("Light Blue");FavColor.Add("Red"); FavColor.Add("White");
            FavColor.Add("Grey");

            while (yesNo == true)
            {
                try
                {
                    Console.WriteLine("Welcome to our C# class. \nWhich student would you like to learn more about? ");
                    
                    bool learnMore = true;
                    while (learnMore == true)
                    {
                        Console.Write("(enter a number 1-" + numberinlist.Count + "): ");
                        int y = int.Parse(Console.ReadLine());
                        int x = y - 1;
                        Console.WriteLine("Student " + y + " is " + (firstName[x] + " " + lastName[x]));                
                        Console.Write("What do you want to know about " + (firstName[x] + " " + lastName[x]) + "?  ");
                        Console.Write("(enter \"Hometown\" or \"Favorite Food\" or \"Favorite Color\" or type\"add new student\" to add a new student): ");
                        string entry = (Console.ReadLine());
                        while (entry.ToLower() != "favorite food" || entry.ToLower() != "hometown" || entry.ToLower() != "favorite color" || entry.ToLower() != "add new student" || entry.ToLower() != "quit")
                        {

                            if (entry.ToLower() == "favorite food")
                            {
                                Console.WriteLine("The Favorite Food of " + (firstName[x] + " " + lastName[x]) + " is " + FavFood[x] + ".");
                                break; 
                            }
                            else if (entry.ToLower() == "hometown")
                            {
                                Console.WriteLine("The Hometown of " + (firstName[x] + " " + lastName[x]) + " is " + hometown[x] + ".");
                                break;
                            }
                            else if (entry.ToLower() == "favorite color")
                            {
                                Console.WriteLine("The Favorite color of " + (firstName[x] + " " + lastName[x]) + " is " + FavColor[x] + ".");
                                break;
                            }
                            else if (entry.ToLower() == "add new student")
                            {

                                addStudent(firstName, lastName, hometown, FavFood, FavColor, numberinlist);
                                yesNo = false;
                                break;
                            }
                            else if (entry.ToLower() == "quit")
                            {
                                yesNo = false;
                                return;
                            }
                            else
                            {
                                Console.Write("That is not a valid answer. Please enter \"Hometown\" or \"Favorite Food\" or \"Favorite Color\" or \"Add new Student\": ");
                                entry = Console.ReadLine();

                            }



                        }
                        Console.Write("Would you like to know learn more or add a student? (y/n): ");
                        string end1 = Console.ReadLine();
                        while (end1.ToLower() != "n" || end1.ToLower() != "y" || end1.ToLower() != "no" || end1.ToLower() != "yes")
                        {
                            if (end1.ToLower() == "n" || end1.ToLower() == "no")
                            {
                                learnMore = false;
                                break;
                            }
                            else if (end1.ToLower() == "y" || end1.ToLower() == "yes")
                            {
                                learnMore = true;
                                break;
                            }
                            else
                            {
                                Console.Write("That is not a valid answer, Would you like to know about another student? (y/n):  ");
                                end1 = Console.ReadLine();
                            }
                        }
                    }
                    

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That is not a vaild number in the student range");
                }


                Console.Write("Would you like to know about another student? (y/n): ");
                string end = Console.ReadLine();
                while (end.ToLower() != "n" || end.ToLower() != "y" || end.ToLower() != "no" || end.ToLower() != "yes")
                {
                    if (end.ToLower() == "n" || end.ToLower() == "no")
                    {
                        yesNo = false;
                        Console.WriteLine("Thank you, have a good day!");
                        break;
                    }
                    else if (end.ToLower() == "y" || end.ToLower() == "yes")
                    {
                        yesNo = true;
                        break;
                    }
                    else
                    {
                        Console.Write("That is not a valid answer, Would you like to know about another student? (y/n):  ");
                        end = Console.ReadLine();
                    }
                }
            }
            
        
        }
        static List<string> createList()
        {
            Console.WriteLine();
            List<string> list = new List<string>();
            return list;

        }
        static void addstringItem(List<string> list, string message)
        {
            string a;
            Console.WriteLine(message);
            a = Console.ReadLine();
            while (String.IsNullOrEmpty(a) ==true)
            {
                Console.Write("That is not an answer, try again:  ");
                a = Console.ReadLine();
            }
            list.Add(a);    

        }
        static void addintItem(List<int> list)
        {
            list.Add((list.Count+1));
        }
        static void addStudent(List<string> firstName, List<string> lastName, List<string> hometown, List<string> FavFood, List<string> FavColor, List<int> numberinlist)
        {
            addstringItem(firstName, "What is the student's first name?: ");
            addstringItem(lastName, "What is the student's last name?: ");
            addstringItem(hometown, "What is their hometown?: ");
            addstringItem(FavFood, "What is their favorite food?: ");
            addstringItem(FavColor, "What is their favorite color?: ");
            int x = numberinlist.Count;
            addintItem(numberinlist);
        }

    }

    }

