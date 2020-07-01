using EmployeeManagement.BussinessAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BussinessAccessLayer.Factory
{
    public class BusinessLayerFactory
    {
        public static IEmployeeBusinessAccessLayer GetBusinessAccessLayerObj()
        {
            return new EmployeeBusinessAccessLayer();
        }
            

    }
}
