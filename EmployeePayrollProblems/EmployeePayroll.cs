using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollProblems
{
    //model class
    public class EmployeePayroll
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Start { get; set; }
    }
}