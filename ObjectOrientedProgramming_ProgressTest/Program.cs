using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ProgressTest
{
    class Program
    {
        public class ObjectOriendtedProgrammingCourse
        {
            public string studentName;
            public string studentId;
            public string identificationCard;
            public string mark;

            public void SetStudentDetail(string StudentName, string StudentId, string IC, string Mark)
            {
                studentName = StudentName;
                studentId = StudentId;
                identificationCard = IC;
                mark = Mark;
            }
        }

        public class Student : ObjectOriendtedProgrammingCourse
        {
            List<string> StudentName = new List<string>() { "Ali","Abu","Lily","Siti","Ben"};
            List<string> StudentId = new List<string>() { "001","002","003","004","005"};
            List<string> IC = new List<string>() { "101", "102", "103", "104", "105" };
            List<string> Mark = new List<string>() { "2.0", "3.0", "4.0", "5.0", "6.0" };

            string StudentDetail = StudentName.OrderByAscending(n => n);
            string StudentRanking = Mark.OrderByDescending(n => n);
        }

        public class results
        {
            public static void Main(string[] args)
            {
                System.Console.WriteLine(StudentDetail);
                System.Console.WriteLine(StudentRanking);
            }
        }
    }
}



