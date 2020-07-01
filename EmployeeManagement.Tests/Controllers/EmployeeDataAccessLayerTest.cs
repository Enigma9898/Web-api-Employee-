using System;
using System.Collections.Generic;
using EmployeeManagement.DataAccessLayer;
using EmployeeManagement.DataAccessLayer.Migrations;
using EmployeeManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagement.Tests.Controllers
{
    [TestClass]
    public class EmployeeDataAccessLayerTest
    {
        private EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
        [TestMethod]
        public void AddEmployeeifSuccess()
        {
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmpName = "Test Data Access Layer",
                Age = 24
            };
            bool result = employeeDataAccessLayer.AddEmployee(employeeModel);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GetEmployeeByIdIfSuccess()
        {
            int empId = 5;
            EmployeeModel employeeModel = employeeDataAccessLayer.GetEmployeeById(empId);
            Assert.IsNotNull(employeeModel);
        }
        [TestMethod]
        public void GetEmployeeByIdIfFails()
        {
            int empId = 1;
            EmployeeModel employeeModel = employeeDataAccessLayer.GetEmployeeById(empId);
            Assert.IsNull(employeeModel);
        }
        [TestMethod]
        public void GetAllEmployeeIfSuccess()
        {
            List<EmployeeModel> employees = employeeDataAccessLayer.GetAllEmployees();
            Assert.IsNotNull(employees);
        }
        [TestMethod]
        public void DeleteEmployeeByIdIfSuccess()
        {
            int empId = 16;
            bool result = employeeDataAccessLayer.DeleteEmployeeById(empId);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void DeleteemployeeByIdIfFails()
        {
            int empId = 1;
            bool result = employeeDataAccessLayer.DeleteEmployeeById(empId);
            Assert.IsFalse(result);
        }
       

    }
}
