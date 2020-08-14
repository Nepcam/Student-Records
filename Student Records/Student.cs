using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Records
{
    class Student
    {
        // Student class - to hold information about a student
        // Create rerad and write properties for - Name, Student ID, Fees (paid or not)
        // Write a ToString Method that returns a string containing information in the Student object

        // Fields that will store data about a student #############################################

        private string _name;
        private int _id;
        private bool _hasPaid;

        // Constructors ############################################################################

        /// <summary>
        /// A constructor method that  initialises the fields to default values
        /// </summary>
        public Student()
        {
            _name = "";
            _id = 0;
            _hasPaid = false;
        }

        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="name">The name of the student</param>
        /// <param name="id">The identification number of hte student</param>
        public Student(string name, int id)
        {
            _name = name;
            _id = id;
        }

        // Properties ############################################################################

        /// <summary>
        /// This property gets and sets the name of the student
        /// </summary>
        public string Name
        {
            // (Read) get the value of the name and return back the value of our name field to our button_click method in Form1.cs 
            get { return _name; }
            // (Write) set the value of the name field to the value that is passed to the property 
            set { _name = value; } 
        }

        /// <summary>
        /// This property gets the id of the student
        /// </summary>
        public int Id
        {
            // (Read only) 
            get { return _id; }
        }

        /// <summary>
        /// Gets if the student has paid their fees
        /// </summary>
        public bool Haspaid
        {
            // (Read only) 
            get { return _hasPaid; }
        }

        /// <summary>
        /// Method sets the has paid to true to show the student has paid their fees
        /// </summary>
        public void Pay()
        {
            _hasPaid = true;
        }

        /// <summary>
        /// Method sets the paid to false to show the student has not paid their fees
        /// </summary>
        public void NotPay()
        {
            _hasPaid = false;
        }

        /// <summary>
        /// Returns back all the information about the student
        /// </summary>
        /// <returns>Back all of the student information padded out</returns>
        public override string ToString()
        {
            return Name.ToString().PadRight(15) + Id.ToString().PadRight(15) + Haspaid;
        }

    }
}
