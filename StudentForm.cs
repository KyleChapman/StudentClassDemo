// Author:  Kyle Chapman
// Date:    February 17, 2021
// Description:
//  This is a form code file for a basic demo related to object-oriented
//  programming principles in C# and with WindowsForms.
//  This form collects student names and displays these and some other
//  values back to the user. You can also reset and exit the form.
//  Based loosely/partly on an older, non-C# demo by Paul Massardo.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentClassDemo
{
    public partial class formStudentForm : Form
    {
        public formStudentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets student names based on whatever is entered, then displays properties from the student class back to the user.
        /// </summary>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare AND instantiate a Student object with the default constructor.
            Student studentOne = new Student();
            // Declare a Student variable, but do not instantiate the object.
            Student studentTwo;

            // Instantiate a student object with the parametrized constructor and assign it to studentTwo.
            studentTwo = new Student(2);

            // Set the Name of studentOne equal to whatever is in the first Textbox.
            studentOne.Name = textBoxStudentOneNameInput.Text;
            // Set the Name of studentTwo equal to whatever is in the second Textbox.
            studentTwo.Name = textBoxStudentTwoNameInput.Text;

            // Set the Text of the output for student one equal to whatever is in the object's Name property.
            textBoxStudentOneNameOutput.Text = studentOne.Name;
            // Set the Text of the output for student one equal to whatever is in the object's Count property.
            textBoxStudentOneCountOutput.Text = studentOne.Count.ToString();
            // Set the Text of the output for student one equal to whatever is returned by the object's GetStudentData() function.
            textBoxStudentOneDataOutput.Text = studentOne.GetStudentData();

            // Now same thing but for studentTwo. :)
            textBoxStudentTwoNameOutput.Text = studentTwo.Name;
            textBoxStudentTwoCountOutput.Text = studentTwo.Count.ToString();
            textBoxStudentTwoDataOutput.Text = studentTwo.GetStudentData();
        }

        /// <summary>
        /// Resets the form to its default state.
        /// </summary>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear the input textboxes.
            textBoxStudentOneNameInput.Clear();
            textBoxStudentTwoNameInput.Clear();

            // Clear the output textboxes for student one.
            textBoxStudentOneNameOutput.Clear();
            textBoxStudentOneCountOutput.Clear();
            textBoxStudentOneDataOutput.Clear();

            // Clear the output textboxes for student two.
            textBoxStudentTwoNameOutput.Clear();
            textBoxStudentTwoCountOutput.Clear();
            textBoxStudentTwoDataOutput.Clear();

            // Set focus for easy data entry.
            textBoxStudentOneNameInput.Focus();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
