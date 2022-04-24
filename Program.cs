using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoluation
{
    /*
     * @className - Program
     * @objective - for orcastation of program by calling several methods
     * @autherName - Varsha Rane
     * @date - 21-2-2022
     */
    public class Program
    {
        static void Main(string[] args)
        {
            //passing values in object
            StudentData studentData1 = new StudentData(101,"Bhanu","java","complete",5);
            StudentData studentData2 = new StudentData(102,"Bhawna","java","progress",3);
            StudentData studentData3 = new StudentData(103,"sajal","c#","complete",5);
            StudentData studentData4 = new StudentData(101,"bhanu","unit test","not done",0);
            StudentData studentData5 = new StudentData(105,"ritika","web","progress",3);
            StudentData studentData6 = new StudentData(106,"utkarsh","web","progress",4);
            StudentData studentData7 = new StudentData(105,"ritika","web","complete",6);
            StudentData studentData8 = new StudentData(106,"utkarsh","web","progress",8);
            StudentData studentData9 = new StudentData(101,"bhanu","c#","complete",12);
            StudentData studentData10 = new StudentData(102,"bhawna","unit test","complete",6);

           // passing all objects in list
           List<StudentData> studentList = new List<StudentData>();
            studentList.Add(studentData1);
            studentList.Add(studentData2);
            studentList.Add(studentData3);
            studentList.Add(studentData4);
            studentList.Add(studentData5);
            studentList.Add(studentData6);
            studentList.Add(studentData7);
            studentList.Add(studentData8);
            studentList.Add(studentData9);
            studentList.Add(studentData10);
            //studentList.Add((StudentData)studentList[0]);
            
            //display data of the list
            foreach(StudentData studentData in studentList)
            {
                Console.WriteLine("student id:" +studentData.StudentId +" , "+ "student name:" + studentData.StudentName+ " , "+ " student assignment:" +studentData.Assignment + "  ,  " + "student status:" +studentData.Status + "  ,  " + " required days" + studentData.days);
            }

            //calling method of implementedStudentData - aggregateStudentData
            ImplAggregateStudentData aggregateStudentData = new ImplAggregateStudentData();
            List<AssignmentData> assignmentDatas = aggregateStudentData.getAssignmentDetails(studentList);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            //problem 1:-
            List<AssignmentWithDaysAndStudents> list = aggregateStudentData.getAssignmentBystatus(studentList);
            foreach(AssignmentWithDaysAndStudents element in list)
            {
                Console.WriteLine(element.Assignment +" ,"+ element.NumOfStudent + " ," + element.TotalNumOfDays +" ,"+ element.Status);
            }
            Console.WriteLine("**********************************************************************************************");

            //problem 2:-
            Console.WriteLine("assignment completed by number of students are:-");
            List<AssignmentData> result = aggregateStudentData.getAssignmentDetails(studentList);
            foreach(AssignmentData key in result)
            {
                Console.WriteLine(key.Assignment + "  , " + key.NumberOfStudents);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

           //problem 3:-
            Console.WriteLine("assignment completed by students with count of days");
            List<AssignmentCountData> resultlist = aggregateStudentData.getAssignmentCounts(studentList);
            foreach(AssignmentCountData data in resultlist)
            {
                Console.WriteLine(data.StudentId + " , " + data.StudentName + " , " + data.StudentCount + " , " + data.numOfDays);
            }

        }
    }
}
