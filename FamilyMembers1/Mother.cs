﻿using Apttus.Assignment.FamilyMembers1.enums;

namespace Apttus.Assignment.FamilyMembers1
{
    public class Mother : Members
    {
        public Mother(string name, int age, string getroles)
        {
            Name = name;
            Age = age;
            GetRoles = getroles;
        }

        public override Gender Gender => Gender.Female;

       
    }
}