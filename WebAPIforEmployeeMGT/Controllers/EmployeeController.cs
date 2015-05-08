using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeManager;
using Models;

namespace WebAPIforEmployeeMGT.Controllers
{
    public class EmployeeController : ApiController
    {
        Manager manager;
        public EmployeeController()
        {
            manager = new Manager();
        }
        
        public ResponseModel Get()
        {
           

            return manager.Getall();
        }

        public ResponseModel Post(EmployeeBasic employeeBasic)
        {
            

           return manager.Save(employeeBasic);
        }

    }
}
