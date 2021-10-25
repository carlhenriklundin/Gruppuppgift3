using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment3
{
    interface IStudentList
    {
        const int MaxNrOfStudents = 50;

        /// <summary>
        /// The number of students to be divided into groups
        /// </summary>
        public int NrOfStudents { get; }

        /// <summary>
        /// Number of groups to be created using CreateGroups
        /// Number must be between 1 and Count/2
        /// if Number < 1 and > Count/2 an ArgumentOutOfRangeException() is thrown
        /// if Count  == 0 an ArgumentException("Empty list") is thrown
        /// </summary>
        public int NrOfGroups { get; set; }

        /// <summary>
        /// Number of Students to be placed in each group
        /// </summary>
        public int NrStudentsInGroup { get; }

        /// <summary>
        /// Number of students that remains to be placed in groups after groups are created
        /// </summary>
        public int NrStudentsNotInGroup { get; }

        /// <summary>
        /// Sort the Students alphabetically
        /// Implement sort on strings using either SelectionSort or BubbleSort from BOOP_05_07 
        /// </summary>
        public void Sort();

        /// <summary>
        /// Fills StudentList with the names of the students from of OOP1 .Net5 
        /// </summary>
        public void CreateOOP1dotNet5();
    }
}