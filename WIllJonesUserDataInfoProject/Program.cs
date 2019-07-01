using System;
using System.Collections.Generic;

namespace WIllJonesUserDataInfoProject
{
    class MainClass
    {
        public class UserDataInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int FavNumber { get; set; }
            public int NumOfPets { get; set; }


            public void GreetingWithUserInfo()
            {
                Console.WriteLine("It's nice to learn all these things about you " + FirstName + " " + LastName + "!");
               
            }
        }

        public static void Main()
        {
            UserDataInfo user = new UserDataInfo();
            Console.WriteLine("What is your first name?");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            user.LastName = Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            int FavNumber = int.Parse(Console.ReadLine());         
            Console.WriteLine("How many pets do you have, if you have any.");
            int NumOfPets = int.Parse(Console.ReadLine());         
            Console.WriteLine("Your favorite number is " + FavNumber + "." + " You have " + NumOfPets + " pets." + " Can you tell me your pets' names? If you don't have any, it's OK to say no!");
            string response = Console.ReadLine();          
            bool success = int.TryParse(response, out int numberOfPets);
            List<string> petNames = new List<string>();

            while (ShouldAskForPetName(response, success))
            {
                Console.WriteLine("What is one of your pets' names?");
                string petName = Console.ReadLine();
                petNames.Add(petName);

                Console.WriteLine("Do you have any more pets?");
                response = Console.ReadLine();
            }
            
            bool ShouldAskForPetName(string answer, bool parseSuccess)
            {
                bool result = (answer.ToLower() == "yes" || parseSuccess == true && answer.ToLower() != "no");
                return result;
            }

            Console.WriteLine("Your favorite number is " + FavNumber + "." + " You have " + NumOfPets + " pets in your household.");
            Console.WriteLine("If you said you had pets, their names are as follows:");
            foreach (object name in petNames)
            {
                Console.WriteLine(name);
            }
            user.GreetingWithUserInfo();

        }
        
    }
}
