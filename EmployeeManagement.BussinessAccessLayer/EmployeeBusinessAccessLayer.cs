using EmployeeManagement.BussinessAccessLayer.Interface;
using EmployeeManagement.DataAccessLayer.Factory;
using EmployeeManagement.DataAccessLayer.Interface;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BussinessAccessLayer
{
    public class EmployeeBusinessAccessLayer: IEmployeeBusinessAccessLayer
    {
        private IEmployeeDataAccessLayer employeeDataAccessLayer = DataAccessLayerFactory.GetEmployeeDataAccessLayerObj();

        public bool AddEmployee(EmployeeModel addEmployee)
        {
            try 
            {
                if (addEmployee.EmpName == "" || addEmployee.Age == 0)
                {
                    return false;
                }
                else
                {
                    return employeeDataAccessLayer.AddEmployee(addEmployee);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
        public EmployeeModel GetEmployeeById(string id)
        {
            int empId;
            try
            {
                empId = Convert.ToInt32(id); 

                if (empId == 0)
                {
                    EmployeeModel employeeModel = null;
                    return employeeModel;
                }
                return employeeDataAccessLayer.GetEmployeeById(empId);
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
        public List<EmployeeModel> GetAllEmployees()
        {
            return (employeeDataAccessLayer.GetAllEmployees());
        }
        
        public bool DeleteEmployeeById(string id)
        {
            int empId;
            try
            {
                empId = Convert.ToInt32(id);
                if (empId == 0)
                {
                    return false;
                }
                return employeeDataAccessLayer.DeleteEmployeeById(empId);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
