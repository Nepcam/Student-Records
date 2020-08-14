using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Records
{
    public partial class Form1 : Form
    {
        string student_name = "";
        int student_id = 0;
        string has_paid = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNewStudent_Click(object sender, EventArgs e)
        {
            // information from the textboxes
            student_name = textBoxName.Text;
            student_id = int.Parse(textBoxID.Text);
            has_paid = checkBoxYes.Checked.ToString();

            // get Student class and set it as an object 
            Student student = new Student(student_name, student_id); // pass into the student object what the constructor instructs you to pass in.
            // student fee condition
            if (checkBoxYes.Checked)
            {
                student.Pay();
            }
            else if (checkBoxNo.Checked)
            {
                student.NotPay();
            }

            // display student object onto the listBox object
            listBoxStudentUi.Items.Add(student.ToString());
        }
    }
}
