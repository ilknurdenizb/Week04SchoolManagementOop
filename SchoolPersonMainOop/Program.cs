using System;

class Program // Main class for the program
{
    static void Main(string[] args) // Main method to run the program
    {
        SchoolPersonMainOop.Person student1 = new SchoolPersonMainOop.Person  // Create a new student object
        {
            Name = "Johnny", // Set the student's name
            Surname = "Depp",  // Set the student's surname
            BirthDate = new DateTime(1963, 6, 9),  // Set the student's birth date
            Role = "Student"  //Set the student's role
        };

        SchoolPersonMainOop.Person student2 = new SchoolPersonMainOop.Person  // Create another student object
        {
            Name = "Emma",
            Surname = "Watson",
            BirthDate = new DateTime(1990, 4, 15),
            Role = "Student"
        };

        SchoolPersonMainOop.Person teacher1 = new SchoolPersonMainOop.Person
        {
            Name = "John",
            Surname = "Smith",
            BirthDate = new DateTime(1989, 3, 25),
            Role = "Teacher"
        };

        SchoolPersonMainOop.Person teacher2 = new SchoolPersonMainOop.Person
        {
            Name = "Jane",
            Surname = "Doe",
            BirthDate = new DateTime(1985, 11, 30),
            Role = "Teacher"
        };

        student1.SelfPromote(); // Call the SelfPromote method for student1
        student2.SelfPromote(); // Call the SelfPromote method for student2
        teacher1.SelfPromote(); // Call the SelfPromote method for teacher1
        teacher2.SelfPromote(); // Call the SelfPromote method for teacher2
    }
}