using System;
namespace _24_Object_Methods
{
    public class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            return gpa >= 2.5 ? true : false;
        }
    }
}
