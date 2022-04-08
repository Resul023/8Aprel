using System;
using System.Collections.Generic;
using ClassLibrary;
namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string answerTool;

            List<Student> newStudent = new List<Student>();

            

             bool check = true;
            

            do
            {
                Console.WriteLine("1-Add Student");
                Console.WriteLine("2-Add Student's exam");
                Console.WriteLine("3-Show student's exam");
                Console.WriteLine("4-Show stundent's all exams");
                Console.WriteLine("5-Show student's the results of all exams");
                Console.WriteLine("6-Delete student's exam");
                Console.WriteLine("0-End of process");

                do
                {
                    Console.WriteLine("Select:");
                    answerTool = Console.ReadLine();

                } while (!int.TryParse(answerTool, out answer));
                switch (answer)
                {
                    case 1:
                        string studentSetFullName;


                        do
                        {
                            Console.WriteLine("Write student name:");
                            studentSetFullName = Console.ReadLine();


                        } while (String.IsNullOrWhiteSpace(studentSetFullName));
                        Student student = new Student();
                        student.FullName = studentSetFullName;

                        newStudent.Add(student);

                        break;

                    case 2:
                        string examName;
                        do
                        {
                            Console.WriteLine("Write exam name");
                            examName = Console.ReadLine();

                        } while (String.IsNullOrWhiteSpace(examName));


                        int examPoint;
                        string examPointSetTool;
                        do
                        {
                            Console.WriteLine("Write exam point:");
                            examPointSetTool = Console.ReadLine();

                        } while (!int.TryParse(examPointSetTool, out examPoint));

                        int studentSetNo;
                        string studentSetNoTool;

                        do
                        {
                            Console.WriteLine("Write student no:");
                            studentSetNoTool = Console.ReadLine();
                        } while (!int.TryParse(studentSetNoTool, out studentSetNo));

                        foreach (var item in newStudent)
                        {
                            item.AddExam(examName, examPoint);
                        }
                        break;
                    case 3:

                        int examNoForSearching;
                        string examNoForSearchingTool;
                        do
                        {
                            Console.WriteLine("Write student No  for searching");
                            examNoForSearchingTool = Console.ReadLine();

                        } while (!int.TryParse(examNoForSearchingTool, out examNoForSearching));


                        string examNameForSearching;
                        do
                        {
                            Console.WriteLine("Write exam Name value for searching");
                            examNameForSearching = Console.ReadLine();

                        } while (String.IsNullOrWhiteSpace(examNameForSearching));


                        foreach (var item in newStudent)
                        {

                            if (item.No == examNoForSearching)
                            {

                                Console.WriteLine($"result-{ item.ExamResult(examNameForSearching)}");

                            }

                        }
                        break;
                    case 4:


                        do
                        {
                            Console.WriteLine("Write student no:");
                            studentSetNoTool = Console.ReadLine();
                        } while (!int.TryParse(studentSetNoTool, out studentSetNo));
                        foreach (var item in newStudent)
                        {
                            if (item.No == studentSetNo)
                            {
                                foreach (var exam in item.Exams)
                                {
                                    Console.WriteLine(exam.Key + "-" + exam.Value);
                                }
                            }
                        }
                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine("Write student no:");
                            studentSetNoTool = Console.ReadLine();
                        } while (!int.TryParse(studentSetNoTool, out studentSetNo));
                        foreach (var item in newStudent)
                        {
                            if (item.No == studentSetNo)
                            {
                                foreach (var exam in item.Exams)
                                {
                                    Console.WriteLine(item.GetExamAvg());
                                }
                            }
                        }
                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine("Write student no:");
                            studentSetNoTool = Console.ReadLine();
                        } while (!int.TryParse(studentSetNoTool, out studentSetNo));


                        do
                        {
                            Console.WriteLine("Which one do you want to delete:");
                            examName = Console.ReadLine();

                        } while (String.IsNullOrWhiteSpace(examName));

                        foreach (var item in newStudent)
                        {
                            if (item.No == studentSetNo)
                            {
                                item.Exams.Remove(examName);
                            }
                        }
                        break;

                    case 0:
                        check = false;
                        
                        break;
                }   
            } while (check);
        }
    }
}
