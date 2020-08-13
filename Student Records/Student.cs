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

        private string _name;
        private int _id;
        private bool _hasPaid;

        // Constructors ############################################################################

        /// <summary>
        /// This constructor method initialises the fields to a default value
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
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// This property gets the id of the student
        /// </summary>
        public int Id
        {
            get { return _id; }
        }



    }
}
