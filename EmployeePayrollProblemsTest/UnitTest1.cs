using EmployeePayrollProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace EmployeePayrollProblemsTest
{
        [TestClass]
        public class UnitTest1
        {
            EmployeePayrollServices employeePayrollServices = new EmployeePayrollServices();
            [TestMethod]
            public void AbilityToAdd()
            {
            EmployeePayroll employee = new EmployeePayroll()
            {
                ID = 1,
                Name = "Amit",
                PhoneNumber = "123456789",
                Address = "Rampuri Colony",
                Gender = "M",
                Start = DateTime.Now
            };
            string result = employeePayrollServices.AddEmployeeInDB(employee);
            Assert.AreEqual("employee added successfully", result);
            }
        }
}