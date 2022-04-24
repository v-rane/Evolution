using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoluation
{/*
  * @classname - StudentData
  * @objective - defining getter setter and constructors
  */
    public class StudentData
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public  string Assignment { get; set; }
        public string Status { get; set; }
        public int days { get; set; }

        public StudentData(int SId, string SName, string Assign,string StudentStatus,int completingdays)
        {
            StudentId = SId;
            StudentName = SName;
            Assignment = Assign;
            Status = StudentStatus;
            days = completingdays;
                
        }
    }
}
