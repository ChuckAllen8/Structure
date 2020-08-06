using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SchoolApplication
{
    public class Assignment
    {
        private string name;
        private double gradeAverage;
        private double gradeHigh;
        private double gradeLow;
        private List<double> grades;

        public string Name { get { return name; } }
        public double GradeAverage { get { return gradeAverage; } }
        public double GradeHigh { get { return gradeHigh; } }
        public double GradeLow { get { return gradeLow; } }

        public Assignment()
        {
            grades = new List<double>();
        }

        public void AddGrades(double[] studentGrades)
        {
            foreach(double grade in studentGrades)
            {
                grades.Add(grade);
            }
        }

        public double CalculateAverage()
        {
            if(grades.Count > 0)
            {
                double sum = 0;
                foreach(double grade in grades)
                {
                    sum += grade;
                }
                gradeAverage = sum / grades.Count;
            }
            return GradeAverage;
        }

        public double CalculateLowest()
        {
            if(grades.Count > 0)
            {
                double low = double.MaxValue;
                foreach(double grade in grades)
                {
                    if (grade < low)
                        low = grade;
                }
                gradeLow = low;
            }
            return GradeLow;
        }

        public double CalculateHighest()
        {
            if(grades.Count > 0)
            {
                double high = double.MinValue;
                foreach(double grade in grades)
                {
                    if (grade > high)
                        high = grade;
                }
                gradeHigh = high;
            }
            return GradeHigh;
        }
    }
}
