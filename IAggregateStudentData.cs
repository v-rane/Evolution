using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoluation
{
    public interface IAggregateStudentData
    {
        /*
         * @className - IAggregateStudentData
         * @objective - declaring interfaces
         */
        List<AssignmentData> getAssignmentDetails(List<StudentData> studentsList);
         List<AssignmentCountData> getAssignmentCounts(List<StudentData> studentsList);
         List<AssignmentWithDaysAndStudents> getAssignmentBystatus(List<StudentData> studentsList); 
    }
}
