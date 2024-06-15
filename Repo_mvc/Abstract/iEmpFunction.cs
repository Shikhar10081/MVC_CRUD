using Repo_mvc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_mvc.Abstract
{
     public interface iEmpFunction
    {
        List<Employee> GetAllProduct();
        Employee Delails(int id);
        string Delete(int id);
        String Create(Employee emp);
        string Update(Employee emp);
    }
}
