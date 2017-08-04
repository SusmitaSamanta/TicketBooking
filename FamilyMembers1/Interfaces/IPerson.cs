using System;
using Apttus.Assignment.FamilyMembers1.enums;

namespace Apttus.Assignment.Interfaces
{
    public interface IPerson
    {
         String Name { get; set; }
        int Age { get; set; }

        Gender GetGender();
    }
}
