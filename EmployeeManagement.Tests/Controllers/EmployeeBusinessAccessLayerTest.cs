using System;
using System.Collections.Generic;
using EmployeeManagement.BussinessAccessLayer;
using EmployeeManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagement.Tests.Controllers
{
    [TestClass]
    public class EmployeeBusinessAccessLayerTest
    {
        private EmployeeBusinessAccessLayer employeeBusinessAccessLayer = new EmployeeBusinessAccessLayer();
        [TestMethod]
        public void AddEmployeeIfSucccess()
        {
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmpName = "sai",
                Age = 24
            };
            bool data = employeeBusinessAccessLayer.AddEmployee(employeeModel);

            Assert.IsTrue(data);
        }
        [TestMethod]
        public void AddEmployeeIfFails()
        {
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmpName = "",
                Age = 24
            };
            bool data = employeeBusinessAccessLayer.AddEmployee(employeeModel);

            Assert.IsFalse(data);
        }
        [TestMethod]
        public void GetEmployeeByIdIfSuccess()
        {
            string empId = "5";

            EmployeeModel employeeModel = employeeBusinessAccessLayer.GetEmployeeById(empId);

            Assert.IsNotNull(employeeModel);
        }
        [TestMethod]
        public void GetEmployeeByIdIfFails()
        {
            string empId = "1";

            EmployeeModel employeeModel = employeeBusinessAccessLayer.GetEmployeeById(empId);

            Assert.IsNull(employeeModel);
        }
        [TestMethod]
        public void GetEmployeeByIdIf_WrongInput()
        {
            string empId = "sai";

            string expectedErrorMessage = "Input string was not in a correct format.",result = "";

            try
            {
                employeeBusinessAccessLayer.GetEmployeeById(empId);
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            Assert.AreEqual(expectedErrorMessage, result);
        }
        [TestMethod]
        public void GetAllEmployeeIfSuccess()
        {
            List<EmployeeModel> employee = employeeBusinessAccessLayer.GetAllEmployees();

            Assert.IsNotNull(employee);
        }
        [TestMethod]
        public void DeleteEmployeeByIdIfSuccess()
        {
            string empId = "12";

            bool result = employeeBusinessAccessLayer.DeleteEmployeeById(empId);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void DeleteEmployeeByIdIfFails()
        {
            string empId = "1";

            bool result = employeeBusinessAccessLayer.DeleteEmployeeById(empId);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void DeleteEmployeeByIdIf_WrongInput()
        {
            string empId = "sai";

            string expectedErrorMessage = "Input string was not in a correct format.",result = "";
            try
            {
                employeeBusinessAccessLayer.DeleteEmployeeById(empId);
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            Assert.AreEqual(expectedErrorMessage, result);
        }
        
           


    }
}
