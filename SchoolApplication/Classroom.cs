using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApplication
{
    public class Classroom
    {
        private List<Student> students;
        private List<Assignment> assignments;
        public Classroom()
        {
            students = new List<Student>();
            assignments = new List<Assignment>();
        }

    }
}
