using Apttus.Assignment.FamilyMembers1.enums;

namespace Apttus.Assignment.FamilyMembers1
{
    public class Son : Members
    {
        public Son(string name, int age, string getroles)
        {
            Name = name;
            Age = age;
            GetRoles = getroles;
        }

        public override Gender Gender => Gender.Male;

      
    }
}