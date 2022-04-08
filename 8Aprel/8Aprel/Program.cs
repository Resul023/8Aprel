using System;
using System.Collections.Generic;
using ClassLibrary;
namespace _8Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            bool check = true;
            Console.WriteLine("1-Add Student");
            Console.WriteLine("2-Add Student's exam");
            Console.WriteLine("3-Show student's exam");
            Console.WriteLine("4-Show stundent's all exams");
            Console.WriteLine("5-Show student's the results of all exams");
            Console.WriteLine("6-Delete student's exam");
            Console.WriteLine("0-End of process");
            do 
            {
   
                int answer;
                string answerTool;
                
                List<Student> newStudent = new List<Student>();
                
                
                do
                {
                    Console.WriteLine("Select:");
                    answerTool = Console.ReadLine();

                } while (!int.TryParse(answerTool, out answer));

                
                if (answer == 1)
                {
                    
                    string studentSetFullName ;
                    

                    do
                    {
                        Console.WriteLine("Write student name:");
                        studentSetFullName = Console.ReadLine();


                    } while (String.IsNullOrWhiteSpace(studentSetFullName));
                    Student student = new Student();
                    student.FullName = studentSetFullName;
                    
                    newStudent.Add(student);

                }

               else if (answer == 2)
                {
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
                        item.AddExam(examName, studentSetNo);
                    }
                    


                }
                else if (answer == 3)
                {
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

                            Console.WriteLine(item.ExamResult(examNameForSearching));

                        }

                    }

                }
                else if (answer == 4)
                {
                    int studentSetNo;
                    string studentSetNoTool;

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
                                Console.WriteLine(exam.Key +"-"+ exam.Value);
                            }
                        }
                    }

                }
                else if (answer == 5)
                {
                    int studentSetNo;
                    string studentSetNoTool;

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

                }
                else if (answer == 6)
                {
                    int studentSetNo;
                    string studentSetNoTool;

                    do
                    {
                        Console.WriteLine("Write student no:");
                        studentSetNoTool = Console.ReadLine();
                    } while (!int.TryParse(studentSetNoTool, out studentSetNo));

                    string examName;
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


                }
                else if (answer == 0)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("This choice is not exist ");
                }

               
            }while (check) ;
        }
    }
}
