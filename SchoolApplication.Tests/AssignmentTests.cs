using System;
using Xunit;
using SchoolApplication;

namespace SchoolApplication.Tests
{
    public class AssignmentTests
    {
        [Fact]
        public void TestAssignmentAverage()
        {
            Assignment assignment = new Assignment();
            assignment.AddGrades(new double[] { 50, 75, 100});
            double result = assignment.CalculateAverage();
            Assert.Equal(75, result);
        }

        [Fact]
        public void TestAssignmentHighest()
        {
            Assignment assignment = new Assignment();
            assignment.AddGrades(new double[] { 50, 75, 100 });
            double result = assignment.CalculateHighest();
            Assert.Equal(100, result);
        }

        [Fact]
        public void TestAssignmentLowest()
        {
            Assignment assignment = new Assignment();
            assignment.AddGrades(new double[] { 50, 75, 100 });
            double result = assignment.CalculateLowest();
            Assert.Equal(50, result);
        }
    }
}
