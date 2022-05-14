using System;

namespace LearningC
{
    public class Learning
    {
        static void Main(string[] args)
        {

            // Verified Details Table
            string verifiedNames = "Guest";
            string verifiedPassword = "Guest";
            string verifiedWebsites = "Roblox";

            // Asking For Inputs
            Console.Title = "Nebula TokenAuthenticator for ROBLOX";
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("What website are you searching?");

            string webSite = Console.ReadLine();

            Console.WriteLine("Enter your username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Enter your password:");

            string passWord = Console.ReadLine();

            // Making Inputs Function
            if (userName == verifiedNames)
            {
                Console.WriteLine("Welcome " + userName);

            }
            else
            {
                Console.WriteLine("There is no such account with the name: " + userName);
            }

            if (passWord == verifiedPassword)
            {

                Console.WriteLine("Unable to fecth Account token");

            }
            else
            {
                Console.WriteLine("Your password is incorrect");
            }

            if (webSite == verifiedWebsites)
            {
                Console.WriteLine("The account is possible at Roblox.com");
            }
            else
            {
                Console.WriteLine("There is no such account in the website: " + webSite);
            }

        }



    }
}