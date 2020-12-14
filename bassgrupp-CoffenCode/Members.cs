using System;
using System.Collections.Generic;
using System.Text;

namespace bassgrupp_CoffenCode
{
    class Members
    {
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
    }
}
