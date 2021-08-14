using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTTESTSTSTST
{
    class Student
    {
        // fields
        private int idgenerator = 10000;
        private int studentid;
        private string firstName;
        private string lastName;
        private string major;
        private string phone;
        private double gpa;
        private int dayOfBirth;
        private int monthOfBirth;
        private int yearOfBirth;

        // properties
        public int IDGenerator { get => idgenerator; set => idgenerator = value; }
        public int StudentID { get => studentid; set => studentid = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Major { get => major; set => major = value; }
        public string Phone { get => phone; set => phone = value; }
        public double GPA { get => gpa; set => gpa = value; }
        public int DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public int MonthOfBirth { get => monthOfBirth; set => monthOfBirth = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }


        // constructors
        public Student(int studentID, string firstName, string lastName, string major, string phone, double gpa, int dayOfBirth, int monthOfBirth, int yearOfBirth)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Major = major;
            this.Phone = phone;
            this.GPA = gpa;
            this.DayOfBirth = dayOfBirth;
            this.MonthOfBirth = monthOfBirth;
            this.YearOfBirth = yearOfBirth;
        }

        // properties

        public int GetIDGenerator()
        {
            return idgenerator;
        }


        public int GetStudentID()
        {
            return studentid;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetFullName()
        {
            // Return first and last name of contact as a string
            return $"{firstName} {lastName}";
        }

        public string GetMajor()
        {
            return major;
        }

        public string GetPhone()
        {
            return phone;
        }


        public double GetGPA()
        {
            return gpa;
        }

        public string GetDateOfBirth()
        {
            return $"{dayOfBirth}-{monthOfBirth}-{yearOfBirth}";
        }

        // Displays Student information
        public string ToInfo()
        {
            return "*********** Student Information ***********" +
                    "\nIDGenerator: \t\t" + $"{idgenerator}" +
                    "\nStudentID: \t\t" + $"{studentid}" +
                    "\nFirst Name: \t\t" + $"{firstName}" +
                    "\nLast Name: \t\t" + $"{lastName}" +
                    "\nMajor \t\t\t" + $"{major}" +
                    "\nPhone: \t\t\t" + $"{phone}" +
                    "\nGPA: \t\t\t" + $"{gpa}" +
                    "\nDate of Birth: \t\t" + $"{dayOfBirth}-{monthOfBirth}-{yearOfBirth}" +
                    "\n";
        }
    }
}

