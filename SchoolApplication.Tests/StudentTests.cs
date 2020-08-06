using System;
using Xunit;
using SchoolApplication;

namespace SchoolApplication.Tests
{
    public class StudentTests
    {
        [Fact]
        public void TestStudentAverage()
        {
            Student student = new Student();
            student.AddGrade(75);
            student.AddGrade(25);
            double average = student.CalculateAverage();
            Assert.Equal(50, average);
        }

        [Fact]
        public void TestStudentHighest()
        {
            Student student = new Student();
            student.AddGrade(75);
            student.AddGrade(25);
            double highest = student.CalculateHighest();
            Assert.Equal(75, highest);
        }

        [Fact]
        public void TestStudentLowest()
        {
            Student student = new Student();
            student.AddGrade(75);
            student.AddGrade(25);
            double lowest = student.CalculateLowest();
            Assert.Equal(25, lowest);
        }
    }
}
