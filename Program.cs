using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{  
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the choice assistant.");
            Console.WriteLine("\nThis will try to assist you in making a choice.");
            Console.WriteLine("\nFirst select what you are wondering about.\n" +
                              "Following or accepting the answer is up to you. This is just a suggestion.");

            FirstChoice();
        }
        private static void FirstChoice()
        {
            Console.WriteLine("\nNow choose area you want to start with.Press Backspace to return here.");
            Console.WriteLine(
                "\n1) I'm bored. What should I do?" + 
                "\n2) Will I pass my exam?" + 
                "\n3) My crazy ex wants to get back together." + 
                "\n4) Does he/she likes me?" + 
                "\n5) Magic 8-Ball simulator");

            String Message = "";

            ConsoleKey key = Console.ReadKey(true).Key;
            
                if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                {
                    Message = "\nIt's a wonder how we can still be bored when we have access to so much \ninformation today. Lets ee what can be done.\n";
                    Console.WriteLine(Message);
                    Bored();
                }

                else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                {
                    Message = "\nOne of the most common questions during session.\n";
                    Console.WriteLine(Message);
                    Exam();
                }

                else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
                {
                    Message = "\nReally? Your crazy ex called? That one you had so much trouble with?\nLets see...";
                    Console.WriteLine(Message);
                    CrazyEx();
                }
                else if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
                {
                    Message = "\n Want to say \"He loves me, He loves me not\" while tearing a flower's petals? \nDon't do that. Be a naturalist and save nature! Use this software instead.";
                    Console.WriteLine(Message);
                    Love();
                }
                else if (key == ConsoleKey.D5 || key == ConsoleKey.NumPad5)
                {
                    Message = "\nYou don't have a 8-ball? You want to use the good old classic?\nSearch no more.";
                    Console.WriteLine(Message);
                    EightBall();
                }
                else

                Message = "That's not one of the options yet. Press Enter to try again!";
                Console.WriteLine(Message);

                Console.ReadLine();
                FirstChoice();
            }
        private static void Bored()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Backspace)
            {
                FirstChoice();
            }

            Random MyRandom = new Random();
            MyRandom.Next(1, 11);
            int Action = MyRandom.Next(1, 11);
            string Message = "";

            if (Action == 1)
                Message = "How is the weather outside? If good then go for a walk.";
            else if (Action == 2)
                Message = "Read a book.";
            else if (Action == 3)
                Message = "Take an online course.";
            else if (Action == 4)
                Message = "Listen to some music.";
            else if (Action == 5)
                Message = "Go out and socialize. Yes, with PEOPLE.";
            else if (Action == 6)
                Message = "Try something new you haven't done before.";
            else if (Action == 7)
                Message = "Play some games. League of Legend, Age of Empires 2 or any you like.\nJust 2 hours. Don't go overboard.";
            else if (Action == 8)
                Message = "Remember that awesom TV series you wanted to watch? No?\nThen find one and watch a few episodes.";
            else if (Action == 9)
                Message = "Go online. Search for crazy things online or in wikipedia.";
            else if (Action == 10)
                Message = "Time for some exercises. Go running or to the gym. Better be in shape.";
            else if (Action == 11)
                Message = "Cook youself a nice meal. Junkfood isn't the answer.";

            Console.WriteLine("\n" + Message);
            Bored();
        }
        private static void Exam()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Backspace)
            {
                FirstChoice();
            }
            Random MyRandom = new Random();
            MyRandom.Next(1, 11);
            int Action = MyRandom.Next(1, 11);
            string Message = "";

            if (Action == 1)
                Message = "If you did not study you SHALL NOT PASS!";
            else if (Action == 2)
                Message = "Yeah, but don't expect miracles.";
            else if (Action == 3)
                Message = "So you studied non stop for the past 2 weeks and memorised half the textbook? \nWhy are you even asking?";
            else if (Action == 4)
                Message = "It' going to be pretty average.";
            else if (Action == 5)
                Message = "Yes. Now go drink a coffie.";
            else if (Action == 6)
                Message = "The night before does not count as studying. Your chances are 50/50.";
            else if (Action == 7)
                Message = "The difference between 2 and 3 is one year. \nYou will pass, but try harder next time.";
            else if (Action == 8)
                Message = "No worries. You got this.";
            else if (Action == 9)
                Message = "Should have prepared better. This is a hard subject. Better luck next time.";
            else if (Action == 10)
                Message = "You passed. All the coffie and google search helped.";
            else if (Action == 11)
                Message = "It depends how the professor feels today. Can't say.";


            Console.WriteLine("\n" + Message);
            Exam();
        }

        private static void CrazyEx()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Backspace)
            {
                FirstChoice();
            }
            Random MyRandom = new Random();
            MyRandom.Next(1, 11);
            int Action = MyRandom.Next(1, 11);
            string Message = "";

            if (Action == 1)
                Message = "Nope!";
            else if (Action == 2)
                Message = "NO!";
            else if (Action == 3)
                Message = "No... no... just no.";
            else if (Action == 4)
                Message = "Noooooo!";
            else if (Action == 5)
                Message = "Why are you considering this? Why is that number not blocked?";
            else if (Action == 6)
                Message = "Ring all you best friends and let them tell you \"no\" as well.";
            else if (Action == 7)
                Message = "Hahahaha.... No!";
            else if (Action == 8)
                Message = "Why would you do this to yourself?";
            else if (Action == 9)
                Message = "Find 5 reasons why you should do this?";
            else if (Action == 10)
                Message = "Remember what happened last time? Not a good idea.";
            else if (Action == 11)
                Message = "Time to get a new number.";


            Console.WriteLine("\n" + Message);
            CrazyEx();
        }
        private static void Love()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Backspace)
            {
                FirstChoice();
            }
            Random MyRandom = new Random();
            MyRandom.Next(1, 11);
            int Action = MyRandom.Next(1, 11);
            string Message = "";

            if (Action == 1)
                Message = "Yes.";
            else if (Action == 2)
                Message = "No.";
            else if (Action == 3)
                Message = "Stop picking flowers and just ask that person out.";
            else if (Action == 4)
                Message = "A chance for romance in the air.";
            else if (Action == 5)
                Message = "Stop stalking people.";
            else if (Action == 6)
                Message = "Do they speak with you? Laugh sincerely when they are around you? \nThere might be a chance.";
            else if (Action == 7)
                Message = "They appear interested.";
            else if (Action == 8)
                Message = "You are asking the wrong person(software). Go ask them out.";
            else if (Action == 9)
                Message = "Yes, but it's up to you to take the first step.";
            else if (Action == 10)
                Message = "I'd say 50/50 chance.";
            else if (Action == 11)
                Message = "Hard to tell. Try again later.";

            Console.WriteLine("\n" + Message);
            Love();

        }
        private static void EightBall()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Backspace)
            {
                FirstChoice();
            }
            Random MyRandom = new Random();
            MyRandom.Next(1, 20);
            int Action = MyRandom.Next(1, 20);
            string Message = "";

            if (Action == 1)
                Message = "It is certain";
            else if (Action == 2)
                Message = "It is decidedly so";
            else if (Action == 3)
                Message = "Without a doubt";
            else if (Action == 4)
                Message = "Yes definitely";
            else if (Action == 5)
                Message = "You may rely on it";
            else if (Action == 6)
                Message = " As I see it, yes";
            else if (Action == 7)
                Message = "Most likely";
            else if (Action == 8)
                Message = "Outlook good";
            else if (Action == 9)
                Message = "Yes";
            else if (Action == 10)
                Message = "Signs point to yes";
            else if (Action == 11)
                Message = "Reply hazy try again";
            else if (Action == 12)
                Message = "Ask again later";
            else if (Action == 13)
                Message = "Better not tell you now";
            else if (Action == 14)
                Message = "Cannot predict now";
            else if (Action == 15)
                Message = "Concentrate and ask again";
            else if (Action == 16)
                Message = "Don't count on it";
            else if (Action == 17)
                Message = "My reply is no";
            else if (Action == 18)
                Message = "My sources say no";
            else if (Action == 19)
                Message = "Outlook not so good";
            else if (Action == 20)
                Message = "Very doubtful";

            Console.WriteLine("\n" + Message);
            EightBall();
        }
    }
}
