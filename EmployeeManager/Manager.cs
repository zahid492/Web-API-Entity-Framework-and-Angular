using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace EmployeeManager
{
   public class Manager
    {
       public ResponseModel Getall()
       {
           List<EmployeeBasic> employeelists;
           using (var db = new employeedbEntities())
           {
               employeelists = db.EmployeeBasics.ToList();
           }

           ResponseModel response = new ResponseModel() { Issucess = true, Message = "All Data", Data = employeelists };

           return response;
       }

       public ResponseModel Save(EmployeeBasic employee)
       {

           using (var db = new employeedbEntities())
           {
                db.EmployeeBasics.Add(employee);
               db.SaveChanges();
           }

           return new ResponseModel()
           {
               Issucess = true,
               Message = "All Data",
               Data = new List<EmployeeBasic> {employee}
              

           };
       }


    }
}
