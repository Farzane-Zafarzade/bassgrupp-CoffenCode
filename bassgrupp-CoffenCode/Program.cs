using System;
using System.Collections.Generic;

namespace basgrupp_CoffenCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string codition;
            do
            {
                // användare anger basgrupps namn för att uppstart programmet
                string bgName = getName();

                // detta kollar om namnet som har angett är rätt
                if (checkBasegroup(bgName))

                { // om namnet är rätt sen visas en meny för att välja
                     showMenu();
                  int choice = getChoice();

                    // detta visar koden till användarens val
                    showOption(choice);
                }
               
                else /* om namnet som har skrivit är fel användaren kan ange ett nytt namn eller
                    programmet avslutas*/

                    Console.WriteLine(" Namnet är otillgängligt, försok igen? y/n");
                    codition = (((Console.ReadLine()).ToLower()).Trim());

            } while (codition == "y");
                
                

        }

        static private string getName()
        {
            Console.WriteLine("Hej och välkommen. skriv namnet på basgrupp: ");
            string name = ((Console.ReadLine()).ToLower()).Trim();
           
            return name;
        }
        static private Boolean checkBasegroup(string bgName)
        {
            string basegroupsname = "coffencpde";

            if (bgName == basegroupsname)
                return true;
            else
                return false;
        }


        public class member
        {
            string name;
            string lastName;
            int age;
            string accommodation;
            string maritalStatus;
            int Children;
            string city;
            List<string> pets = new List<string>();
            List<string> favoriteFood = new List<string>();
            List<string> favoriteMusic = new List<string>();
            string driv;
        }


        static private void showMenu()
        {
            Console.WriteLine(" Ange önskat nummer för att visa varje alternativ: ");
            Console.WriteLine(" 1 - Lista alla deltagare i gruppen separerat med 10 generella detaljer");
            Console.WriteLine(" 2 - visa varje persons största driv till programmering");
            Console.WriteLine(" 3 - ta bort en medlem av listen");
        }

        static private int getChoice()
        { 
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        static void showOption(int val)
        {
            switch (val)
            {
                case 1:


                case 2:

                case 3:
            }

        }
            

        
        
        
    }
}
