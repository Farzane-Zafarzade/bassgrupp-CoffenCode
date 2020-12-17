using System;
using System.Collections.Generic;

namespace basgrupp_CoffenCode
{
    class Program
    {

        static void Main(string[] args)

        {   //Create a dictionary of the Member class and initialize with members of the base group
            Dictionary<string, Member> membersOfgroup = AddMembersTogroup();

            string codition = "y";
            do
            {
                // user enters name of base group to start the program
                string bgName = GetName();

                // check if the name of base group is correct
                if (CheckBasegroup(bgName))
                {
                    ShowMenu(membersOfgroup);// if the name is correct then a menu to select is displayed
                }

                else // if the entered name is incorrect the user can enter a new name or the program will end
                {
                    Console.WriteLine(" Namnet är otillgängligt, försok igen? y/n");
                    codition = (((Console.ReadLine()).ToLower()).Trim());
                }
            } while (codition == "y");

        }

  


        // a class that contains each member's 10 general details,greatest drive for programming and Constructors
        public class Member
        {  //fields
            private string name;
            private int age;
            private string accommodation;
            private string family;
            private string city;
            private string pets;
            private string job;
            private string hobby;
            private string favoriteFood;
            private string favoriteMusic;
            private string driv;

            public Member() //Constructors
            {

            }

            public Member(string name, int age, string accommodation, string family, string city, string pets, string job, string hobby, string favoriteFood, string favoriteMusic, string driv)
            {
                this.name = name;
                this.age = age;
                this.accommodation = accommodation;
                this.family = family;
                this.city = city;
                this.pets = pets;
                this.job = job;
                this.hobby = hobby;
                this.favoriteFood = favoriteFood;
                this.favoriteMusic = favoriteMusic;
                this.driv = driv;
            }

            public string Name  //properties
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public string Accommodation
            {
                get { return accommodation; }
                set { accommodation = value; }
            }

            public string Family
            {
                get { return family; }
                set { family = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public string Pets
            {
                get { return pets; }
                set { pets = value; }
            }
            public string Job
            {
                get { return job; }
                set { job = value; }
            }
            public string Hobby
            {
                get { return hobby; }
                set { hobby = value; }
            }
            public string FavoriteFood
            {
                get { return favoriteFood; }
                set { favoriteFood = value; }
            }
            public string FavoriteMusic
            {
                get { return favoriteMusic; }
                set { favoriteMusic = value; }
            }
            public string Driv
            {
                get { return driv; }
                set { driv = value; }
            }
        }


        static private string GetName()// get the name of base group from the user and return
        {
            Console.WriteLine("\n För att starta programmet skriv namnet på basgrupp: ");
            string name = Console.ReadLine().ToLower().Trim();
            return name;
        }

        // show menu to select an option
        static private void ShowMenu(Dictionary<string, Member> membersOfgroup)
        {
            Console.WriteLine("\n Välkommen till vår bassgrupp \"Coffen Code\". Ange önskat nummer för att visa varje alternativ: ");
            Console.WriteLine("\n 1 - Lista alla deltagare i gruppen separerat med 10 generella detaljer");
            Console.WriteLine(" 2 - visa varje persons största driv till programmering");
            Console.WriteLine(" 3 - ta bort en medlem av listen");
            Console.WriteLine(" 4 - Exit");
            int choice = GetChoice();//Get user's choice and return
            ShowOption(choice, membersOfgroup); // Display the selected option by the user
        }



        static private int GetChoice()//Get user's choice and return
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }


        static private Boolean CheckBasegroup(string bgName) // check if the name of base group is correct
        {
            string basegroupsName = "coffencode";

            if (bgName == basegroupsName)
                return true;
            else
                return false;
        }


        // Declare a class of Member for each member in the base group and put in a dictionary and return
        static private Dictionary<string, Member> AddMembersTogroup()
        {
            Dictionary<string, Member> memberOfGroup = new Dictionary<string, Member>();
            memberOfGroup["mikael"] = new Member("Mikael Alexander Larsson", 36, "Villa", "Fru, två döttrar och en tredje dotter på vägVilla.", "Vänersborg", "Två kaniner", "Restauranglärare", "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt. Allt mellan ambient och techno", "det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan.");
            memberOfGroup["madeleine"] = new Member("Karin Madeleine Karlsson", 35, "Villa", "Sambo och en dotter", "Stockholm", "Tre katter", "Har varit ekonomiassistent, testare och senast föräldraledig", "Bakning och spela Stardew Valley", "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv");
            memberOfGroup["sammy"] = new Member("Sammy On Tat Wong", 54, "Villa", "Fru och en son", "Åmål", "3 katter och en hund", "Personlig assistent", "Fotografering, matlagning", "Asiatisk,italiensk,svensk husmanskost", "Soul, RnB, House", "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem.");
            memberOfGroup["david"] = new Member("David Josef Frödin", 25, "Lägenhet", "Det vanliga", "Sundbyberg", "inga", "Verksamhetschef på en studentförening", "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch", "Allt! Inne i rockperiod som varvas med rysk folkmusik", "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix.");
            memberOfGroup["rauf"] = new Member("Rauf Karimli", 36, "Villa", "Fru, en son och en dotter", "Göteborg", "Inga", "Projektledare", "Spela piano, laga mat", "Grillat kött", "Gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas");
            memberOfGroup["erik"] = new Member("Erik Rindlert", 31, "Lägenhet", "Ogift", "Stockholm", "Inga", "IT-support", "Litteratur, datorspel", "Svensk-fransk fisksoppa", "Schubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga");
            memberOfGroup["daniel"] = new Member("Daniel Jacob Arlbring", 24, "lägenhet", "Sambo", "Alingsås", "Inga", "Väktare", "Motorsport/datorspel", "Italienskt", "House", "");
            memberOfGroup["svante"] = new Member("Svante Joelsson", 36, "Lägenhet", "Sambo och en son", "Strömstad", "Hund", "Fritidspedagog/Förskolelärare", "Illustrera Animera", "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av problemlösning och kreativitet,och att en dag landa ett jobb med mer frihet");
            memberOfGroup["sarah"] = new Member("Sarah Winroth", 31, "Lägenhet ", "Gift ", "Vara", "Inga", "Reseledare", "Motionerar gärna", "Älskar mat i alla former", "Lyssnar på det mesta", "Själva problemlösningen och tillfredsställelsen efteråt!");
            memberOfGroup["farzane"] = new Member("Farzane Zafarzade", 32, "Lägenhet", "Gift och inga barn", "Karlstad", "Inga", "IT-support", "Träning och bakning", "Alla typer av pasta", "Lugna och klassiker musik", "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ.");


            return memberOfGroup;
        }



        //If user wants to continue, he can return to the menu or he can exit the program
        static void GoBackToMenu(Dictionary<string,Member> membersOfgroup)
        {
            Console.WriteLine("\n\n\nTryck på M för att gå tillbaka till menyn eller tryck på E för att avsluta: ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "m")
            {
                Console.Clear();
                ShowMenu(membersOfgroup);
            }
           else 
              if (input == "e")
              {
                ExitProgram();
              }
        }


        // Exit the program
        static public void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine(" Exiting program...");
            Environment.Exit(-1);
        }



        //remove a member of the base group
        static private void RemoveMembers(string name, Dictionary<string, Member> membersOfgroup)
        {
            if (membersOfgroup.ContainsKey(name) == true)
            { 
            membersOfgroup.Remove(name);
            Console.WriteLine("Medlemmen har tagits bort från listan!"); 
            }
            else
            {
                Console.WriteLine(" Namnet är otillgängligt ");
            }
        }



        //display all members of the base group separated by 10 general details
        static void ShowGroupsMembers(Dictionary<string, Member> membersOfgroup)
        {
            Console.WriteLine("Members of groups");
            Console.WriteLine("============================================================");
            foreach (KeyValuePair<string, Member> enrty in membersOfgroup)
            {
               
                Console.WriteLine("Full Name:             {0}", enrty.Value.Name);
                Console.WriteLine("Age:                   {0}", enrty.Value.Age);
                Console.WriteLine("City of residence:     {0}", enrty.Value.City);
                Console.WriteLine("Family status:         {0}", enrty.Value.Family);
                Console.WriteLine("Type of accommodation: {0}", enrty.Value.Accommodation);
                Console.WriteLine("Pets:                  {0}", enrty.Value.Pets);
                Console.WriteLine("Previous profession:   {0}", enrty.Value.Job);
                Console.WriteLine("Hobby:                 {0}", enrty.Value.Hobby);
                Console.WriteLine("Favorite foods:        {0}", enrty.Value.FavoriteFood);
                Console.WriteLine("Favorite musiks:       {0}", enrty.Value.FavoriteMusic);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }



        // The option that user has selected is displayed
        static void ShowOption(int val, Dictionary<string, Member> membersOfgroup)
        {
            switch (val)
            {
                case 1:
                    ShowGroupsMembers(membersOfgroup);
                    GoBackToMenu(membersOfgroup);
                     break;

                case 2:
                    Console.WriteLine("Medlemmars största driv till programmering");
                    Console.WriteLine("=======================================================================================\n\n");
                    foreach (KeyValuePair<string, Member> enrty in membersOfgroup)
                    {
                        Console.WriteLine("{0}'s största driv till programmering : {1}", enrty.Key, enrty.Value.Driv);
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------");
                    }
                   GoBackToMenu(membersOfgroup);
                    break;

                case 3:
                    Console.WriteLine("Ange namnet på den medlem som du ska tas bort från listen:\n( Mikael , Madeleine , Sammy , David , Rauf , Erik , Daniel , Svante , Sarah , Farzane )");
                    Console.WriteLine("==========================================================");
                    string name = (((Console.ReadLine()).Trim()).ToLower());
                    RemoveMembers( name, membersOfgroup);
                    GoBackToMenu(membersOfgroup);
                    break;

                case 4:
                    ExitProgram();
                    break;

                default:
                    Console.WriteLine("Det angivna numret är felaktigt.");
                    GoBackToMenu(membersOfgroup);
                    break;
            }




        }


    }

}









