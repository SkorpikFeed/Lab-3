using System;
using System.Drawing;
using Lab_3_C_;
class Program
{ 
    public static void Main()
    {
        Rhombus First, Second,Third;
        start1:
        Console.WriteLine("Enter the coordinates of the first rhombus:");
        Console.WriteLine("Enter X1:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y1:");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X2:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y2:");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X3:");
        int x3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y3:");
        int y3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X4:");
        int x4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y4:");
        int y4 = Convert.ToInt32(Console.ReadLine());
        First = new Rhombus(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4));
        if (!First.IsRhombus())
        {
            goto start1;
        }
        Console.Clear();
        First.Print();
        start2:
        Console.WriteLine("Enter the coordinates of the second rhombus:");
        Console.WriteLine("Enter X1:");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y1:");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X2:");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y2:");
        y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X3:");
        x3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y3:");
        y3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X4:");
        x4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y4:");
        y4 = Convert.ToInt32(Console.ReadLine());
        Second = new Rhombus(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4));
        if (!First.IsRhombus())
        {
            goto start2;
        }
        Console.Clear();
        Console.Write("First ");
        First.Print();
        Console.Write("Second ");
        Second.Print();
        string answer;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("If you want to move the first rhombus(Rhombus + double or double + Rhombus), enter MOVE1, if the second, enter MOVE2");
        Console.WriteLine("If you want to compare the areas of the rhombuses(Rhombus > Rhombus or Rhombus < Rhombus), enter COMPARE");
        Console.WriteLine("If you want find the minimum value that is greater by 1, among all coordinate values ​​of the second rhombus, and add this value to all coordinates of the vertices of the first rhombus(Rhombus + Rhombus), enter ADD");
        Console.WriteLine("If you want to decrement the coordinates(Rhombus--), enter DECREMENT");
        Console.WriteLine("If you want to compare all coordinates with 0, enter COMPARE0");
        Console.WriteLine("If you want to exit, enter EXIT");
        Console.ForegroundColor = ConsoleColor.White;
        do
        {
            answer = Console.ReadLine();
            switch(answer) 
            { 
                case "MOVE1":
                    Console.WriteLine("Enter the value by which you want to move the first rhombus:");
                    double value = Convert.ToDouble(Console.ReadLine());
                    Third = First + value;
                    Third.Print();
                    break;
                case "MOVE2":
                    Console.WriteLine("Enter the value by which you want to move the second rhombus:");
                    value = Convert.ToDouble(Console.ReadLine());
                    Third = value + Second;
                    Third.Print();
                    break;
                case "COMPARE":
                    if (First > Second)
                        Console.WriteLine("The area of ​​the first rhombus is greater than the area of ​​the second");
                    else if (First < Second)
                        Console.WriteLine("The area of ​​the second rhombus is greater than the area of ​​the first");
                    else
                        Console.WriteLine("The areas of the rhombuses are equal");
                    break;
                case "ADD":
                    Third = First + Second;
                    Third.Print();
                    break;
                case "DECREMENT":
                    Third = First--;
                    Third.Print();
                    break;
                case "COMPARE0":
                    if (First & Second)
                        Console.WriteLine("There is no 0");
                    else
                        Console.WriteLine("All coordinates are 0");
                    break;
                case "EXIT":
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
        while (answer != "EXIT");
    }
}
