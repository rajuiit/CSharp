using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfo
{
    class student
    {

        public string name;
        public string roll;
        public string cgpa;
        public string sex;
        public string dob;


        public enum  sexE
        { 
        Male,
        Female,
        Other
        }

        public string Name {

            get { return name;}
            set { name=value;}
                           }

        public string Roll
        {

            get { return roll; }
            set { roll = value; }
        }

        public string Cgpa
        {

            get { return cgpa; }
            set { cgpa = value; }
        }

        public string Sex
        {

            get { return sex;}
            set { sex=value; }
        }

        public string Dob
        {

            get { return dob; }
            set { dob = value; }
        }

        public string welcomeNote()
        {
            string note = "Welcome To Our Student Information System";
            return note;
        }
        public string presentNote()
        {
            string note = "Student Information:";
            return note;
        }

        }
    }
