using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProfileWinFormApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        //public Person(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}


        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetReverseName()
        {
            string reverseName = "";
            string name = GetFullName();

            for(int index = name.Length - 1;index >= 0; index--)
            {
                reverseName += name[index];
            }

            return reverseName;
        }
    }
}
