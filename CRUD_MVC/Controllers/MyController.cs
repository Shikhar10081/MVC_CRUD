using Microsoft.AspNetCore.Mvc;
using Repo_mvc.Abstract;
using Repo_mvc.Functionality;
using Repo_mvc.Model;


namespace CRUD_MVC.Controllers
{
    public class MyController : Controller
    {
        iEmpFunction _repo = new  EmpFunction();
        public IActionResult Index()
        {
          List<Employee> lst=  _repo.GetAllProduct();
            return View(lst);
        }
        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            String msg=  _repo.Create(emp);
            if (msg.Equals("Done"))
                {
                  return RedirectToAction("Index");
                }
            return View();
        }
        [HttpGet]
        public IActionResult Details(String id)
        {
            var data = _repo.Delails(Convert.ToInt32(id));
            return View(data);
        }
        public IActionResult Delete(String id) 
        {
           var msg=    _repo.Delete(Convert.ToInt32(id));
            if (msg.Equals("Done"))
            {
                return RedirectToAction("Index");
            }
               
            return View();
        }

        [HttpGet]
        public IActionResult Edit(String id)
        {
            var data = _repo.Delails(Convert.ToInt32(id));
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit( Employee emp)
        {

         var msg=   _repo.Update(emp);
            if (msg.Equals("Done"))
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
