using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using EmployeeManagement.Controllers;
using EmployeeManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagement.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        EmployeeController employeeController = new EmployeeController();
       
        [TestMethod]
        public void AddEmployeeIfSuccess()
        {
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmpName = "Test Controller",
                Age = 24,
            };
            String expected = "Success";

            CreatedNegotiatedContentResult<String> result = (CreatedNegotiatedContentResult<String>)employeeController.AddEmployee(employeeModel);

            Assert.AreEqual(expected, result.Content);
        }
        [TestMethod]
        public void AddEmployeeIfFails()
        {
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmpName = "",
                Age = 24,
            };
            string expected = "Wrong Input";

            BadRequestErrorMessageResult result = (BadRequestErrorMessageResult)employeeController.AddEmployee(employeeModel);

           // CreatedAtRouteNegotiatedContentResult<string> result = (CreatedAtRouteNegotiatedContentResult<string>)employeeController.AddEmployee(employeeModel);

            Assert.AreEqual(expected, result.Message);
        }
        [TestMethod]
        public void GetEmployeeByIdIfSucess()
        {
            string empId = "6";

            OkNegotiatedContentResult<EmployeeModel> result = (OkNegotiatedContentResult<EmployeeModel>)employeeController.GetEmployeeById(empId);

            Assert.IsNotNull(result.Content);
        }
        [TestMethod]
        public void GetEmployeeById_BadRequest()
        {
            string empId = "sai";

            string expected = "Wrong Input";

            BadRequestErrorMessageResult result = (BadRequestErrorMessageResult)employeeController.GetEmployeeById(empId);

            Assert.AreEqual(expected, result.Message);
        }
        [TestMethod]
        public void GetEmployeeById_NotFound()
        {
            string empId = "1";

            string expected = "Employee Id Not Found";

            NegotiatedContentResult<string> result = (NegotiatedContentResult<string>)employeeController.GetEmployeeById(empId);

            Assert.AreEqual(expected, result.Content);
        }
        [TestMethod]
        public void GetAllEmployeeIfSuccess()
        {
            OkNegotiatedContentResult<List<EmployeeModel>> result = (OkNegotiatedContentResult<List<EmployeeModel>>)employeeController.GetAllEmployees();

            Assert.IsNotNull(result.Content.Count);
            Assert.IsTrue(result.Content.Count != 0);
        }
        [TestMethod]
        public void DeleteEmployeeIfSuccess()
        {
            string empId = "6";

            NegotiatedContentResult<string> actionresult = (NegotiatedContentResult<string>)employeeController.DeleteEmployeeById(empId);

            Assert.AreEqual<HttpStatusCode>(HttpStatusCode.NoContent, actionresult.StatusCode);
            Assert.AreEqual("", actionresult.Content);
        }
        [TestMethod]
        public void DeleteEmployee_NotFound()
        {
            string empId = "1";

            string expected = "Employee Id does not Exist";

            NegotiatedContentResult<string> actionresult = (NegotiatedContentResult<string>)employeeController.DeleteEmployeeById(empId);

            Assert.AreEqual(expected, actionresult.Content);

        }
        [TestMethod]
        public void DeleteEmployee_BadRequest()
        {
            string empId = "sai";

            string expected = "Wrong Input";

            BadRequestErrorMessageResult result = (BadRequestErrorMessageResult)employeeController.GetEmployeeById(empId);

            Assert.AreEqual(expected, result.Message);
        }
    }
}
