using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPersonMainOop // SchoolPersonMainOop namespace
{
  internal class Person  // Person class within the SchoolPersonMainOop namespace
    {

        public string Name { get; set; }  // Property for the person's name
        public string Surname { get; set; }  // Property for the person's surname
        public DateTime BirthDate { get; set; }  // Property for the person's birth date
        public string Role { get; set; }  // Property for the person's role (e.g., Student, Teacher)
        public void SelfPromote()  // Method to introduce the person
        {
            Console.WriteLine($"{Name} {Surname}, {Role.ToLower()} and born on {BirthDate.ToShortDateString()}, is introducing themselves.");
        }

      
        }
    }
