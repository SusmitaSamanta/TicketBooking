using System;
using System.Collections.Generic;
using Apttus.Assignment.FamilyMembers1;
using Apttus.Assignment.Interfaces;


namespace Apttus.Assignment.BookAndCalculate
{
    class Book
    {
        public static float Cost = 1000.00F;
        public static float TotalCost = 0.00F;
        static void Main(string[] args)
        {
            Dictionary<String, IPerson> person = new Dictionary<String, IPerson>();
            person.Add("Nupur", new Mother("Nupur", 50));
            person.Add("Amit", new Father("Amit", 60));
            person.Add("Anup", new GrandFather("Anup", 87));
            person.Add("Neetu", new GrandMother("Neetu", 79));
            person.Add("Rohan", new Child("Rohan", 7));
            Console.WriteLine("Members in the family are");
            foreach (KeyValuePair<String, IPerson> KVP in person)
            {
                Console.WriteLine("Name : " + KVP.Key + ", Age :" + KVP.Value.Age + ", Gender :" + KVP.Value.GetGender());

            }
            Console.WriteLine("Enter Names to book Tickets");
            // Console.ReadLine()
            List<String> listP = new List<String>();
            String Done = "y";
            while (Done == "y")
            {
                String Sname = Console.ReadLine();
                listP.Add(Sname);
                Console.WriteLine("Do you want to book for more people ? , Enter 'y' for yes and 'n' for no .");
                Done = Console.ReadLine();
            }
            TotalCostOfTickets(listP, person);
            Console.ReadLine();

        }
        static void TotalCostOfTickets(List<string> o, Dictionary<String, IPerson> perso)
        {
            foreach (String s in o)
            {
                if (perso.ContainsKey(s))
                {
                    IPerson CompareAge = perso[s];
                    if (CompareAge.Age >= 60) { Cost = Cost - (Cost * (0.30F)); }
                    else { Cost = 1000; }
                    TotalCost += Cost;
                }
            }
            Console.WriteLine("Total Cost of Ticket = " + TotalCost);
            Console.ReadLine();
        }
    }
}
