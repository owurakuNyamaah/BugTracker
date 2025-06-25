using BugTrackerMvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace BugTrackerMvc.Controllers
{
    public class BugController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BugController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bugs = _context.Bugs.ToList();

            return View(bugs);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult create(Bug bug)
        {
            if(!ModelState.IsValid) return View();

            _context.Bugs.Add(bug);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
