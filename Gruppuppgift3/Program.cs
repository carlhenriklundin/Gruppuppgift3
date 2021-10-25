using System;

namespace GroupAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main program is using IStudentList as the type. 
            //Compilation works fine. 
            StudentList myStudents = new StudentList();

            //Before execution myStudents needs to be assign an instance of StudentList
            //myStudents = new StudentList();

            Console.WriteLine("Empty student list");
            Console.WriteLine(myStudents);

            Console.WriteLine("\nStudent list");
            myStudents.CreateOOP1dotNet5();
            Console.WriteLine(myStudents);

            Console.WriteLine("\nSorted student list");
            myStudents.SortStudentList();
            Console.WriteLine(myStudents);
            Console.WriteLine();


            //Using the General UserInput we made in one of the code exercises
            int NrOfGroups = 0;
            bool Continue = UserInput.TryReadInt32("How many groups do you want", 1, myStudents.NrOfStudents / 2, out NrOfGroups);
            if (!Continue) return;

            myStudents.NrOfGroups = NrOfGroups;
            Console.WriteLine($"If you make {NrOfGroups} group(s), each group will have {myStudents.NrStudentsInGroup} student(s) with {myStudents.NrStudentsNotInGroup} student(s) remaining to be placed in the groups.");


            string[,] studentGroups = myStudents.CreateGroups();
            myStudents.GetGroup(studentGroups);
            Console.WriteLine();
            myStudents.RemainToGroup(studentGroups);
        }
    }
}
