using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTestForFinal
{
    class Student
    {

        //Properties
        public string studNumber { get; set; }
        public string studName { get; set; }
        public int courses { get; set; } // Courses refers to the number of courses the studet is taking
        public string studType { get; set; }

        private double totalCourses;

        public Student(string studNumber, string studName, int courses, string studType)
        {
            this.studNumber = studNumber;
            this.studName = studName;
            this.courses = courses;
            this.studType = studType;
        }

        public virtual double compute()
        {
            return totalCourses = courses * 3;
        }

    }

    class International : Student
    {
        int adminFee = 0;
        double tuitionFee = 0;
        public International(string studNumber, string studName, int courses, string studType) : base(studNumber, studName, courses, studType)
        {
            this.adminFee = 3000;
        }

        public override double compute()
        {
            return tuitionFee = (base.compute() * 150) + adminFee;
        }
    }

    class Domestic : Student
    {
        int adminFee = 0;
        double tuitionFee = 0;
        public Domestic(string studNumber, string studName, int courses, string studType) : base(studNumber, studName, courses, studType)
        {
            this.adminFee = 1000;
        }

        public override double compute()
        {
            return tuitionFee = (base.compute() * 100) + adminFee;
        }
    }
}
