using Cascading_Dropdown_List.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cascading_Dropdown_List.Controllers
{
    public class CascadeController : Controller
    {
        private readonly CascadeContext _context;
        public CascadeController(CascadeContext context) 
        {
            _context = context;

        }
       
        public IActionResult CascadeDropdown()
        {
            return View();
        }
        public JsonResult Country()
        {
            var cnt = _context.Counties.ToList();
            return new JsonResult(cnt);
        }
        public JsonResult State(int id)
        {
            var st = _context.States.Where(s => s.County.Id == id).ToList();
            return new JsonResult(st);
        }

        public JsonResult City(int id)
        {
            var ct = _context.Cities.Where(x => x.State.Id == id).ToList();
            return new JsonResult(ct);
        }


    }
}
