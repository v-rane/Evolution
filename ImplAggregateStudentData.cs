using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoluation
{

    
    public class ImplAggregateStudentData : IAggregateStudentData
    {
        /*
         * @className - ImplAggregateStudentData
         * @objective - operations on assignment data 
         * @autherName - Varsha Rane
         * @date - 21-2-2022
         */
        public List<AssignmentWithDaysAndStudents> getAssignmentBystatus(List<StudentData> studentsList)
        {
            /*
             *@method name - getAssignmentBystatus 
             * @objective - to sort assignment data according to assignment done
             * @para - List<StudentData>
             * @return -List<AssignmentWithDaysAndStudents>
             */

            //dic with key taken as keyvalue and value as object of assignmentData
            Dictionary<KeyValuePair<string,string>, AssignmentWithDaysAndStudents> dic = new Dictionary<KeyValuePair<string,string>, AssignmentWithDaysAndStudents>();
            //list for storing result
            List<AssignmentWithDaysAndStudents> assignmentList = new List<AssignmentWithDaysAndStudents>();

            foreach (StudentData student in studentsList)
            {
                //keyValue created as we have key in dic for two entities, i.e.assignment and status
                var keyValue = new KeyValuePair<string,string>(student.Assignment,student.Status);
                if (dic.ContainsKey(keyValue))
                {
                    //if existing keyValue is there then increment in NumOfStudent and add existing student's days to dic days
                    dic[keyValue].NumOfStudent++;
                    dic[keyValue].TotalNumOfDays += student.days;                    
                }
                else
                {
                    //adding data in dic by creating object of AssignmentWithDaysAndStudents if keyValue is not there in dic
                    dic.Add(keyValue, new AssignmentWithDaysAndStudents());
                    dic[keyValue].Assignment = student.Assignment;
                    dic[keyValue].TotalNumOfDays = student.days;
                    dic[keyValue].NumOfStudent = 1;
                    dic[keyValue].Status = student.Status;
                }
            }
            foreach (AssignmentWithDaysAndStudents assignment in dic.Values)
            {
                assignmentList.Add(assignment);
            }
            return assignmentList;
        }


  //******************************************************************************************************************************************
        public List<AssignmentData> getAssignmentDetails(List<StudentData> studentsList)
        {
            /*
             *@method name - getAssignmentDetails 
             * @objective - to sort assignment data according to assignment done
             * @para - List<StudentData>
             * @return -List<AssignmentData> 
             */

            // dic is created with key as  assignment and value as AssignmentData
            Dictionary<string, AssignmentData> dic = new Dictionary<string, AssignmentData>();
           // List for storing objects
            List<AssignmentData> assignmentList = new List<AssignmentData>();

            foreach (StudentData student in studentsList)
            {
                //if dic has existing assignment of student then increment in  student num
                if (dic.ContainsKey(student.Assignment))
                {
                    dic[student.Assignment].NumberOfStudents++;
                    //AssignmentData assignmentData = dic[student.Assignment];
                    //assignmentData.NumberOfStudents++;
                }
                else
                {
                    //adding data in dic if dic does not contains assignment
                    dic.Add(student.Assignment, new AssignmentData());
                    dic[student.Assignment].NumberOfStudents = 1;
                    dic[student.Assignment].Assignment= student.Assignment;

                    //--can write like this too for adding in dic
                    //AssignmentData assignmentData = new AssignmentData();
                    //assignmentData.Assignment = student.Assignment;
                    //assignmentData.NumberOfStudents++;
                    //dic.Add(student.Assignment, assignmentData);
                }
            }
            //adding in list values of dic
            foreach (var element in dic.Values)
            {
                assignmentList.Add(element);
            }
            return assignmentList;
        }
//***************************************************************************************************************************************************
        public List<AssignmentCountData> getAssignmentCounts(List<StudentData> studentsList)
        {
            //list creating for storing result
            List<AssignmentCountData> reslist=new List<AssignmentCountData>();
            //dic with key as studentId and value as AssignmentCountData 
            Dictionary<int, AssignmentCountData> dic = new Dictionary<int, AssignmentCountData>();  
            foreach(StudentData student in studentsList)
            {
                if (dic.ContainsKey(student.StudentId))
                {
                    //if dic has student id then increment in StudentCount and  add existing days in dic 
                    AssignmentCountData assignmentCountData = dic[student.StudentId];
                    assignmentCountData.StudentCount++;
                    assignmentCountData.numOfDays += student.days;
                }
                else
                {
                    //adding data in dic if dic does not contains assignment
                    AssignmentCountData assignmentCountData =new AssignmentCountData();
                    assignmentCountData.StudentId = student.StudentId;
                    assignmentCountData.StudentName = student.StudentName;
                    assignmentCountData.StudentCount++;
                    assignmentCountData.numOfDays = student.days;
                    dic.Add(student.StudentId, assignmentCountData);
                }
            }
            //adding values in list from dic
            foreach(var element in dic.Values)
            {
                reslist.Add(element);
            }
            return reslist;
        }
        //*******************************************************************************************************************************************
       
    }
}
