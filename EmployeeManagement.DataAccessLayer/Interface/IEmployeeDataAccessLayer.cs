using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccessLayer.Interface
{
    public interface IEmployeeDataAccessLayer
    {
        bool AddEmployee(EmployeeModel addEmployee);
        EmployeeModel GetEmployeeById(int empId);
        List<EmployeeModel> GetAllEmployees();
         bool DeleteEmployeeById(int empId);

    }
}
