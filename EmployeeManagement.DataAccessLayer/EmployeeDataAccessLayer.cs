using EmployeeManagement.DataAccessLayer.DbSet;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccessLayer
{
    public class EmployeeDataAccessLayer:Interface.IEmployeeDataAccessLayer
    {
        private EmpContext emp = new EmpContext();

        public bool AddEmployee(EmployeeModel addEmployee)
        {
            try
            {
                emp.employeeModels.Add(addEmployee);
                emp.SaveChanges();
                return true;
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }
        public EmployeeModel GetEmployeeById(int empId)
        {
            try
            {
                EmployeeModel employeeModel = emp.employeeModels.Where<EmployeeModel>(x => x.EmpId == empId).FirstOrDefault();
                return employeeModel;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public List<EmployeeModel> GetAllEmployees()
        {

            return emp.employeeModels.ToList();
        }
        public bool DeleteEmployeeById(int empId)
        {
            try
            {
                EmployeeModel employeeModel = emp.employeeModels.FirstOrDefault<EmployeeModel>(x => x.EmpId == empId);
                if(employeeModel == null)
                {
                    return false;
                }
                emp.employeeModels.Remove(employeeModel);
                emp.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
