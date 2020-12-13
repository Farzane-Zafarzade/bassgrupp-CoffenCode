using System;
using System.Collections.Generic;

namespace basgrupp_CoffenCode
{
    class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, Member> membersOfgroup = AddMembersTogroup();

            string codition = "y";

            do
            {
                // användare anger basgrupps namn för att uppstart programmet
                string bgName = getName();

                // detta kollar om namnet som har angett är rätt
                if (checkBasegroup(bgName))
                {
                    showMenu(membersOfgroup);// om namnet är rätt sen visas en meny för att välja
                   // int choice = getChoice();//användaren kan välja ett alternativ
                   // showOption(choice); // detta visar koden till användarens val
                }

                else // om namnet som har skrivit är fel användaren kan ange ett nytt namn eller programmet avslutas

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

        static private void showMenu(Dictionary<string,Member> membersOfgroup)
        {
            Console.WriteLine(" Ange önskat nummer för att visa varje alternativ: ");
            Console.WriteLine(" 1 - Lista alla deltagare i gruppen separerat med 10 generella detaljer");
            Console.WriteLine(" 2 - visa varje persons största driv till programmering");
            Console.WriteLine(" 3 - ta bort en medlem av listen");
            Console.WriteLine(" 4 - Exit");
            int choice = getChoice();//användaren kan välja ett alternativ
            showOption(choice, membersOfgroup); // detta visar koden till användarens val
        }



        static private int getChoice()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }


        static private Boolean checkBasegroup(string bgName)
        {
            string basegroupsname = "coffencode";

            if (bgName == basegroupsname)
                return true;
            else
                return false;
        }




        public class Member
        {
            public string name;
            public int age;
            public string accommodation;
            public string family;
            public string city;
            public string pets;
            public string job;
            public string hobby;
            public string favoriteFood;
            public string favoriteMusic;
            public string driv;

            public Member() //Konstruktorer
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

            public string Name
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

        static private Dictionary<string, Member> AddMembersTogroup()
        {
            Dictionary<string, Member> memberOfGroup = new Dictionary<string, Member>();
            memberOfGroup["mikaelalexanderlarsson"] = new Member("Mikael Alexander Larsson", 36, "Villa", "Fru, två döttrar och en tredje dotter på vägVilla.", "Vänersborg", "Två kaniner", "Restauranglärare", "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt. Allt mellan ambient och techno", "Hans största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan.");
            memberOfGroup["arinadeleinearlsson"] = new Member("Karin Madeleine Karlsson", 35, "Villa", "Sambo och en dotter", "Stockholm", "Tre katter", "Har varit ekonomiassistent, testare och senast föräldraledig", "Bakning och spela Stardew Valley", "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor", "Hennes största driv är att Ha alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv");
            memberOfGroup["sammyontatwong"] = new Member("Sammy On Tat Wong", 54, "Villa", "Fru och en son", "Åmål", "3 katter och en hund", "Personlig assistent", "Fotografering, matlagning", "Asiatisk,italiensk,svensk husmanskost", "Soul, RnB, House", "Hans största driv till programmering: Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem.");
            memberOfGroup["davidjoseffrödin"] = new Member("David Josef Frödin", 25, "Lägenhet", "Det vanliga", "Sundbyberg", "inga", "Verksamhetschef på en studentförening", "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch", "Allt! Inne i rockperiod som varvas med rysk folkmusik", "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix.");
            memberOfGroup["raufkarimli"] = new Member("Rauf Karimli", 36, "Villa", "Fru, en son och en dotter", "Göteborg", "Inga", "Projektledare", "Spela piano, laga mat", "Grillat kött", "Gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas");
            memberOfGroup["erikrindlert"] = new Member("Erik Rindlert", 31, "Lägenhet", "Ogift", "Stockholm", "Inga", "IT-support", "Litteratur, datorspel", "Svensk-fransk fisksoppa", "Schubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga");
            memberOfGroup["danieljacobarlbring"] = new Member("Daniel Jacob Arlbring", 24, "lägenhet", "Sambo", "Alingsås", "Inga", "Väktare", "Motorsport/datorspel", "Italienskt", "House", "");
            memberOfGroup["svantejoelsson"] = new Member("Svante Joelsson", 36, "Lägenhet", "Sambo och en son", "Strömstad", "Hund", "Fritidspedagog/Förskolelärare", "Illustrera Animera", "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av problemlösning och kreativitet,och att en dag landa ett jobb med mer frihet");
            memberOfGroup["sarahwinroth"] = new Member("Sarah Winroth", 31, "Lägenhet ", "Gift ", "Vara", "Inga", "Reseledare", "Motionerar gärna", "Älskar mat i alla former", "Lyssnar på det mesta", "Själva problemlösningen och tillfredsställelsen efteråt!");
            memberOfGroup["farzane"] = new Member("Farzane Zafarzade", 32, "Lägenhet", "Gift", "Karlstad", "Inga", "IT-support", "Träning och bakning", "Alla typer av pastar", "Lyssnar på det mesta", "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ.");


            return memberOfGroup;
        }

        static void GoBackToMenu(Dictionary<string,Member> membersOfgroup)
        {
            Console.WriteLine("Press M to back to menu or press E to exit ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "m")
                Console.Clear();
                showMenu(membersOfgroup);
            if (input == "e")

                Console.ReadKey();
        }




        static private void RemoveMembers(string name, Dictionary<string, Member> membersOfgroup)
        {
            if (membersOfgroup.ContainsKey(name) == true) { 

            membersOfgroup.Remove(name);

            Console.WriteLine("Medlemmen har tagits bort från listan!"); 
        }

            
            
         }

        static void ShowGroupsMembers(Dictionary<string, Member> membersOfgroup)
        {
            foreach (KeyValuePair<string, Member> enrty in membersOfgroup)
            {

                Console.WriteLine("Full Name:             {0}", enrty.Value.Name);
                Console.WriteLine("Age:                   {0}", enrty.Value.Age);
                Console.WriteLine("City of residence:     {0}", enrty.Value.City);
                Console.WriteLine("Family status:         {0}", enrty.Value.family);
                Console.WriteLine("Type of accommodation: {0}", enrty.Value.Accommodation);
                Console.WriteLine("Pets:                  {0}", enrty.Value.Pets);
                Console.WriteLine("Previous profession:   {0}", enrty.Value.Job);
                Console.WriteLine("Hobby:                 {0}", enrty.Value.Hobby);
                Console.WriteLine("Favorite foods:        {0}", enrty.Value.FavoriteFood);
                Console.WriteLine("Favorite musiks:       {0}", enrty.Value.FavoriteMusic);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }

        static void showOption(int val, Dictionary<string, Member> membersOfgroup)
        {
            


            switch (val)
            {
                case 1:
                    Console.WriteLine("Members of groups");
                    Console.WriteLine("============================================================");
                    foreach (KeyValuePair<string, Member> enrty in membersOfgroup)
                    {

                        Console.WriteLine("Full Name:             {0}", enrty.Value.Name);
                        Console.WriteLine("Age:                   {0}", enrty.Value.Age);
                        Console.WriteLine("City of residence:     {0}", enrty.Value.City);
                        Console.WriteLine("Family status:         {0}", enrty.Value.family);
                        Console.WriteLine("Type of accommodation: {0}", enrty.Value.Accommodation);
                        Console.WriteLine("Pets:                  {0}", enrty.Value.Pets);
                        Console.WriteLine("Previous profession:   {0}", enrty.Value.Job);
                        Console.WriteLine("Hobby:                 {0}", enrty.Value.Hobby);
                        Console.WriteLine("Favorite foods:        {0}", enrty.Value.FavoriteFood);
                        Console.WriteLine("Favorite musiks:       {0}", enrty.Value.FavoriteMusic);
                        Console.WriteLine("-----------------------------------------------------------");
                    }

                    GoBackToMenu(membersOfgroup);
                    
                    break;

                case 2:
                    Console.WriteLine("greatest drive of groups members");
                    Console.WriteLine("============================================================");

                    foreach (KeyValuePair<string, Member> enrty in membersOfgroup)
                    {
                        Console.WriteLine("{0}'s greatest drive for programming is: {1}", enrty.Key, enrty.Value.Driv);
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                  
                    GoBackToMenu(membersOfgroup);
                    break;

                case 3:
                    Console.WriteLine("Ange namnet på den medlem som du ska tas bort från listen:");
                    Console.WriteLine("==========================================================");
                    string name = (((Console.ReadLine()).Trim()).ToLower());
                    
                 
                    RemoveMembers( name, membersOfgroup);
                    GoBackToMenu(membersOfgroup);
                    break;

                default:
                    Console.WriteLine("Det angivna numret är felaktigt.");
                    GoBackToMenu(membersOfgroup);
                    break;
            }




        }


    }

}









