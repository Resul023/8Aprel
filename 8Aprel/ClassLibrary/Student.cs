using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }

        public int No { get; set; }
        static int _totalCount;
        public string FullName { get; set; }
        public Dictionary<string, int> Exams = new Dictionary<string, int>();

        public void AddExam(string ExamName, int Point) 
        {
            Exams.Add(ExamName, Point);
        }

        
        public int ExamResult(string ExamName ) 
        {
            foreach (var item in Exams)
            { 

                if (item.Key == ExamName)
                {
                    return item.Value;
                }
            }return -1;
        
        }

        public double GetExamAvg() 
        {
            int sum = 0;
            int count = 0;
            foreach (var item in Exams)
            {
                count++;
                sum += item.Value;
            }return sum / count;
        
        }
      

    }
}
