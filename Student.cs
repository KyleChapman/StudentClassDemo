// Author:  Kyle Chapman
// Date:    February 17, 2021
// Description:
//  This is a class file for a basic demo related to object-oriented
//  programming principles in C# and with WindowsForms.
//  Includes a definition for a student class with two properties.
//  Based partly on an older, non-C# demo by Paul Massardo.

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {

        // Static variable to hold the number of students.
        private static int studentCount = 0;

        // Instance variables to hold the students name and years to graduate.
        private string studentName = String.Empty;
        private int yearsToGraduation = 0;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Student()
        {
            // During instantiation, add a student to the count.
            studentCount += 1;
            // If the default constructor is called, set yearsToCompletion to 3.
            yearsToGraduation = 3;
        }

        /// <summary>
        /// Parametrized constructor.
        /// </summary>
        /// <param name="years">the student's years to completion</param>
        public Student(int years)
        {
            // During instantiation, add a student to the count.
            studentCount += 1;
            // If the parametrized constructor is called, 
            yearsToGraduation = years;
        }

        /// <summary>
        /// The student's full name
        /// </summary>
        public string Name
        {
            get
            {
                // Return the value that is in the private studentName field.
                return studentName;
            }
            set
            {
                // Set the studentName field to the value that is passed in.
                // This value is always called "value" by default.
                studentName = value;
            }
        }

        /// <summary>
        /// The number of students created
        /// This property COULD be static, and maybe should be, but isn't for demonstration purposes.
        /// </summary>
        public int Count
        {
            get
            {
                // Return the value that is in the private studentCount field.
                return studentCount;
            }
        }

        /// <summary>
        /// Return a string that describes this student.
        /// </summary>
        /// <returns>a string describing the student</returns>
        public string GetStudentData()
        {
            return "Student " + studentName + " will graduate in " + yearsToGraduation.ToString() + " years.";
        }
    }
}
