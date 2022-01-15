using System;
using System.Collections.Generic;

namespace ASM_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Members> members = new List<Members>(){
                new Members{
                    FirstName = "Dao",
                    LastName = "Vuong1",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2000,3,29),
                    BirthPlace = "Ha Noi",
                    IsGraduated = false,
                },
                new Members{
                    FirstName = "Dao",
                    LastName = "Vuong2",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1999,3,29),
                    BirthPlace = "Lao Cai",
                    IsGraduated = false,
                },
                new Members{
                    FirstName ="Dao",
                    LastName = "Vuong3",
                    Gender = "Male",
                    BirthPlace ="Lao Cai",
                    DateOfBirth = new DateTime(1998,2,12),
                },
                new Members{
                    FirstName = "Dao",
                    LastName = "Vuong4",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2001,3,29),
                    BirthPlace = "Ha Noi",
                    IsGraduated = false,
                },
            };
            //Ex1: Return a list of members who is Male
            foreach (Members member in members)
            {
                if (member.Gender == "Male")
                {
                    Console.WriteLine(member.FirstName + " " + member.LastName + " is male");
                }
            }
            //Ex2: Return the oldest one based on “Age” (if return more than one record then select first record)
            int max_age = 0;
            foreach (Members member in members)
            {
                if (member.Age > max_age)
                {
                    max_age = member.Age;
                }
            }
            Console.WriteLine("max age is: " + max_age);
            foreach (Members member in members)
            {
                if(member.Age == max_age)
                {
                    Console.WriteLine("The first oldest is: " + member.FirstName + " " +member.LastName);
                }
            }
            //Ex3: Return a new list that contains Full Name only ( Full Name = Last Name + First Name)
            foreach (Members member in members)
            {
                Console.WriteLine(member.LastName + " " + member.FirstName);
            }
            //Ex4: Return 3 lists
            List<Members> lessThan2000 = new List<Members>();
            List<Members> greaterThan2000 = new List<Members>();
            List<Members> equal2000 = new List<Members>();
            foreach (var member in members)
            {
                switch (member.DateOfBirth.Year)
                {
                    case int n when n < 2000:
                        lessThan2000.Add(member);
                        break;
                    case int n when n > 2000:
                        greaterThan2000.Add(member);
                        break;
                    default:
                        equal2000.Add(member);
                        break;
                }
            }
            foreach (Members member in lessThan2000)
            {
                Console.WriteLine("Less than 2000: " + member.FirstName + " " + member.LastName);
            }
            foreach (Members member in greaterThan2000)
            {
                Console.WriteLine("greater than 2000: " + member.FirstName + " " + member.LastName);
            }
            foreach (Members member in equal2000)
            {
                Console.WriteLine("equal 2000: " + member.FirstName + " " + member.LastName);
            }
            //Ex5: return first person who was born in Hanoi
            int i = 0;
            while (true)
            {
                if (members[i].BirthPlace == "Ha Noi")
                {
                    Console.WriteLine("First person in Hanoi is: " + members[i].FirstName + " " + members[i].LastName);
                    break;
                }
                i++;
            }
        }
    }
}
