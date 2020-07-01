using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BussinessAccessLayer.Interface
{
    public interface IEmployeeBusinessAccessLayer
    {
        bool AddEmployee(EmployeeModel addEmployee);
        EmployeeModel GetEmployeeById(string empId);
        List<EmployeeModel> GetAllEmployees();
        bool DeleteEmployeeById(string empId);
    }
}
