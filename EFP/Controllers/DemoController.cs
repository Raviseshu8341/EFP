using EFP.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFP.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HomeLogin()
        {
            return View();
        }
        public IActionResult Insert(Class s)
        {
            using (var entity = new sampleContext())
            {
                EFPT t = new EFPT();
                t.Name = s.Name;
                t.Age = s.Age;
                t.Address = s.Address;
                t.City = s.City;
                t.Created_Time_Stamp = DateTime.Now;
                t.Update_Time_Stamp = DateTime.Now;
                entity.EFPT.Add(t);
                entity.SaveChanges();
            }
            return View("HomeLogin");
        }
    }
}
