using Apttus.Assignment.FamilyMembers1.enums;
using Apttus.Assignment.Interfaces;

namespace Apttus.Assignment.FamilyMembers1
{
    abstract public class Members : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string GetRoles { get; set; }

        abstract public Gender Gender { get; }
    }
}