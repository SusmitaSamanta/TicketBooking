using Apttus.Assignment.FamilyMembers1.enums;
using Apttus.Assignment.Interfaces;

namespace Apttus.Assignment.FamilyMembers1
{
    public class GrandMother : IPerson
    {
        public GrandMother(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        Gender IPerson.GetGender()
        {
            return Gender.Female;
        }
    }
}
