using System;

namespace GroupAssignment3
{

    class StudentList : IStudentList
    {
        const int MaxNrOfStudents = 50;
        string[] students;

        private int _NrOfStudents = 0;
        public int NrOfStudents => _NrOfStudents;

        public int NrOfGroups { get; set; }

        public int NrStudentsInGroup => NrOfStudents / NrOfGroups;

        public int NrStudentsNotInGroup => NrOfStudents % NrOfGroups;

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _NrOfStudents; i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public void CreateOOP1dotNet5()
        {
            students = new string[MaxNrOfStudents];
            students[0] = "Sahar";
            students[1] = "Jennifer";
            students[2] = "Shohruh";
            students[3] = "Jonathan";
            students[4] = "Leo";
            students[5] = "Jenny";
            students[6] = "Mohamed";
            students[7] = "Ferri";
            students[8] = "Alexandra F";
            students[9] = "Vidar";
            students[10] = "Kamran";
            students[11] = "Pontus";
            students[12] = "Kaveh";
            students[13] = "Maria";
            students[14] = "Adam";
            students[15] = "Sophie";
            students[16] = "Louise";
            students[17] = "Fredric";
            students[18] = "Carl-Henrik";
            students[19] = "Frans";
            students[20] = "Sam";
            students[21] = "Alexandra S";
            students[22] = "Alperen";
            students[23] = "Josefine";
            students[24] = "Ghasem";
            students[25] = "Hanna";
            students[26] = "Finan";
            students[27] = "Niklas";
            students[28] = "Hector";
            students[29] = "Fredrik";
            students[30] = "Adrian";
            students[31] = "Teodor";

            _NrOfStudents = 32;
        }

        public string[,] CreateGroups()
        {
            string[,] groupArray = new string[NrOfGroups + 1, NrStudentsInGroup];
            ShuffleStudents();
            int studentsIndex = 0;

            for (int group = 0; group < groupArray.GetLength(0); group++)
            {
                for (int student = 0; student < groupArray.GetLength(1); student++)
                {
                    groupArray[group, student] = students[studentsIndex++];
                }
            }

            return groupArray;
        }

        public void GetGroup(string[,] groupArray)
        {
            UserInput.TryReadInt32("Vilken grupp vill du skriva ut?", 1, NrOfGroups, out int groupNumber);
            Console.WriteLine($"Grupp {groupNumber} har följande medlemmar:");

            for (int student = 0; student < groupArray.GetLength(1); student++)
            {
                Console.WriteLine(groupArray[groupNumber - 1, student]);
            }
        }

        public void RemainToGroup(string[,] groupArray)
        {
            Console.WriteLine($"Följande studenter finns inte med i en grupp:");

            for (int student = 0; student < groupArray.GetLength(1); student++)
            {
                Console.WriteLine(groupArray[groupArray.GetLength(0)-1, student]);
            }
        }

        public void Sort()
        {
            for (int unsortedStart = 0; unsortedStart < students.Length - 1; unsortedStart++)
            {
                int minIndex = unsortedStart;

                for (int i = unsortedStart + 1; i < students.Length; i++)
                {
                    if (students[i] != null && students[i].CompareTo(students[minIndex]) < 0) minIndex = i;
                }

                (students[unsortedStart], students[minIndex]) = (students[minIndex], students[unsortedStart]);
            }
        }
        
        public void ShuffleStudents()
        {
            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int randomStudent1 = rnd.Next(0, 32);
                int randomStudent2 = rnd.Next(0, 32);
                (students[randomStudent1], students[randomStudent2]) = (students[randomStudent2], students[randomStudent1]);
            }
        }
    }

}