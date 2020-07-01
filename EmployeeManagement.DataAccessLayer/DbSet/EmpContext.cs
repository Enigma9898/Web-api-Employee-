using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccessLayer.DbSet
{
    public class EmpContext:DbContext
    {
        public EmpContext():base("EmployeeConnection") { }
        public DbSet<EmployeeModel> employeeModels { get; set; }
    }
}
