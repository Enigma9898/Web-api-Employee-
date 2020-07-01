using EmployeeManagement.DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccessLayer.Factory
{
   public class DataAccessLayerFactory
    {
        public static IEmployeeDataAccessLayer GetEmployeeDataAccessLayerObj()
        {
            return new EmployeeDataAccessLayer();
        }
    }
}
