using System;
using System.Collections.Generic;
using Apttus.Assignment.DataAccess;
using Apttus.Assignment.FamilyMembers1;

namespace Apttus.Assignment.BookAndCalculate
{
    public class Book
    {
        public static float Cost = 1000.00F;
        public static float TotalCost = 0.00F;

        static void Main(string[] args)
        {
            AccessData ac = new AccessData();

            Console.WriteLine("Members in the family are");
            List<Members> displayMembers = ac.GetMembers();
            Dictionary<String, int> searchMembers = new Dictionary<String, int>();

            for (var i = 0; i < displayMembers.Count; i++)
            {
                Object ob = displayMembers[i];

                if (ob is Mother)
                {
                    Mother mother = (Mother)ob;
                    Console.WriteLine(string.Format("Name:{0}, Age:{1}, Genger:{2} ", mother.Name, mother.Age, mother.Gender));
                    searchMembers.Add(mother.Name, mother.Age);
                }
                else if (ob is Father)
                {
                    Father father = (Father)ob;
                    Console.WriteLine(string.Format("Name:{0}, Age:{1}, Genger:{2} ", father.Name, father.Age, father.Gender));
                    searchMembers.Add(father.Name, father.Age);
                }
                else if (ob is GrandFather)
                {
                    GrandFather grandfather = (GrandFather)ob;
                    Console.WriteLine(string.Format("Name:{0}, Age:{1}, Genger:{2} ", grandfather.Name, grandfather.Age, grandfather.Gender));
                    searchMembers.Add(grandfather.Name, grandfather.Age);
                }
                else if (ob is GrandMother)
                {
                    GrandMother grandmother = (GrandMother)ob;
                    Console.WriteLine(string.Format("Name:{0}, Age:{1}, Genger:{2} ", grandmother.Name, grandmother.Age, grandmother.Gender));
                    searchMembers.Add(grandmother.Name, grandmother.Age);
                }
                else if (ob is Son)
                {
                    Son son = (Son)ob;
                    Console.WriteLine(string.Format("Name:{0}, Age:{1}, Genger:{2} ", son.Name, son.Age, son.Gender));
                    searchMembers.Add(son.Name, son.Age);
                }


            }
            Console.WriteLine("Enter Names to book Tickets");
            String Sname = "";
            List<String> selectedMembers = new List<String>();
            String Done = "y";
            while (Done == "y")
            {
                Sname = Console.ReadLine();
                selectedMembers.Add(Sname);
                Console.WriteLine("Do you want to book for more people ? , Enter 'y' for yes and 'n' for no .");
                Done = Console.ReadLine();
            }
            TotalCostOfTickets(selectedMembers, searchMembers);
            Console.ReadLine();
        }




        private static void TotalCostOfTickets(List<string> lst, Dictionary<String, int> perso)
        {
            int CompareAge = 0;
            foreach (String s in lst)
            {
                if (perso.ContainsKey(s))
                {
                    foreach (KeyValuePair<string, int> p in perso)
                    {
                        if (p.Key== s)
                        {
                            CompareAge = p.Value;
                            if (CompareAge >= 60)
                            {
                                Cost = Cost - (Cost * (0.30F));
                            }
                            else
                            {
                                Cost = 1000;
                            }
                            TotalCost += Cost;
                        }
                    }
                    //var CompareAge = perso.Values;
                    //if (CompareAge >= 60)
                    //{
                    //    Cost = Cost - (Cost * (0.30F));
                    //}
                    //else
                    //{
                    //    Cost = 1000;
                    //}
                    //TotalCost += Cost;
                }
            }
            Console.WriteLine("Total Cost of Ticket = " + TotalCost);
            Console.ReadLine();
        }
    }
}
