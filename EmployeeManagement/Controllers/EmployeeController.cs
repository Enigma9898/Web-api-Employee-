using EmployeeManagement.BussinessAccessLayer.Factory;
using EmployeeManagement.BussinessAccessLayer.Interface;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private IEmployeeBusinessAccessLayer employeeBusinessAccessLayer = BusinessLayerFactory.GetBusinessAccessLayerObj();

        [HttpPost,Route("add")]
        public IHttpActionResult AddEmployee(EmployeeModel addEmployee)
        {
            try
            {
                if (employeeBusinessAccessLayer.AddEmployee(addEmployee) == true)
                {
                    return this.Created("", "Success");
                }
                else
                {
                    return BadRequest("Wrong Input");
                }

            }
            catch (Exception)
            {
                return BadRequest("Wrong Input");
            }
        }

        [HttpGet,Route("getById")]        
        public IHttpActionResult GetEmployeeById(string empId)
        {
            try
            {
                if(employeeBusinessAccessLayer.GetEmployeeById(empId) == null)
                {
                    return Content(HttpStatusCode.NotFound, "Employee Id Not Found");
                }
                else
                {
                    return Ok(employeeBusinessAccessLayer.GetEmployeeById(empId));
                }
            }
            catch (Exception)
            {
                return BadRequest("Wrong Input");
            }

        }
       
        [HttpGet,Route("getAll")]
        public IHttpActionResult GetAllEmployees()
        {
            
          return Ok(employeeBusinessAccessLayer.GetAllEmployees());
           
        }
        [HttpDelete,Route("deleteById")]
        public IHttpActionResult DeleteEmployeeById(string empId)
        {
            try
            {
                if(employeeBusinessAccessLayer.DeleteEmployeeById(empId) == false)
                {
                    return Content(HttpStatusCode.NotFound, "Employee Id does not Exist");
                }
                else
                {
                    employeeBusinessAccessLayer.DeleteEmployeeById(empId);
                    return Content(HttpStatusCode.NoContent, "");
                }
            }
            catch(Exception)
            {
                return BadRequest("Wrong Input");
            }
        }

    }
}
