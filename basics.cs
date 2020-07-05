using System;


namespace Basics
{
    class Program
    {
        static public void Basics()
        {
            // Strings
            Console.WriteLine("Hello World!");
            Console.WriteLine("New World!");
            string aFriend = "Bill Gates ";
            string bFriend = "Melinda Gates";
            Console.WriteLine(aFriend + "\n" + bFriend.Length);
            Console.WriteLine($"{aFriend} and {bFriend} are family");
            Console.WriteLine($"[{aFriend.Trim()}]");
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            // Numbers
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(c*2);

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double ad = 5;
            double bd = 4;
            double cd = 2;
            double dd = (ad + bd) / cd;
            Console.WriteLine(dd);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

            string filePath = @"C:\Users\scoleridge\Documents\";
            //Output: C:\Users\scoleridge\Documents\

            string text = @"My pensive SARA ! thy soft cheek reclined
                            Thus on mine arm, most soothing sweet it is
                            To sit beside our Cot,...";
            /* Output:
            My pensive SARA ! thy soft cheek reclined
               Thus on mine arm, most soothing sweet it is
               To sit beside our Cot,...
            */

            string quote = @"Her name was ""Sara.""";
            //Output: Her name was "Sara."

        }
    }
}
