using Repo_mvc.Abstract;
using Repo_mvc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_mvc.Functionality
{
    public class EmpFunction:iEmpFunction
    {  
        ContextEmp _Context = new ContextEmp();
        public List<Employee> GetAllProduct()
        {
          var emp=  _Context.EmployeeInfo.ToList();
            return emp;
        }

        public Employee Delails(int id)
        {
            try
            {
                var data = _Context.EmployeeInfo.FirstOrDefault(p => p.EmpId == id);
                return data;
            }
            catch(Exception ex)
            {
               
            }
            return null;
            

        }

        public  string  Delete(int id) 
        {   string msg = string.Empty;
            try
            {
                var data = _Context.EmployeeInfo.FirstOrDefault(p => p.EmpId == id);
                _Context.EmployeeInfo.Remove(data);
                _Context.SaveChanges();
                msg = "Done";
            } catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public String Create(Employee emp)
        {    string msg = String.Empty;
            try
            {
                _Context.EmployeeInfo.Add(emp);
                _Context.SaveChanges();
                msg = "Done";
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;

        }

        public string Update(Employee emp)
        {
            string msg = String.Empty;
            try
            {
                var oldData = _Context.EmployeeInfo.FirstOrDefault(p => p.EmpId == emp.EmpId);
                oldData.EmpName = emp.EmpName;
                oldData.Age = emp.Age;
                _Context.SaveChanges();
                msg = "Done";
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
              return msg;
        }
    }
}
