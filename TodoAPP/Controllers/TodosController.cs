using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoAPP.Model;

namespace TodoAPP.Controllers
{
    public class TodosController : Controller
    {
        private readonly TodoContext _context;

        public TodosController(TodoContext context)
        {
            _context = context;
        }


        // GET: TodosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TodosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TodosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TodosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
