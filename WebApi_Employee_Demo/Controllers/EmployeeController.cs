using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Employee_Demo.Data;

namespace WebApi_Employee_Demo.Controllers
{
    public class EmployeeController : ApiController
    {
        private int rowCount=5;
        private List<SampleEmployee> employees = new List<SampleEmployee>();
        public List<SampleEmployee>  GetAllEmployees(int pageNumber=0)
        {
            using (TutorialsEntities1 entities = new TutorialsEntities1())
            {
                int startIndex = (pageNumber * rowCount);
                int endIndex = startIndex + rowCount;
                if (employees != null)
                {
                    employees = entities.SampleEmployees.ToList();
                }
                    return employees.Skip(startIndex).Take(endIndex).ToList();
            }
        }

        
    }
}
