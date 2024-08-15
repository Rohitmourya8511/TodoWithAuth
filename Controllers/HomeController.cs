using TodoWithAuth.Models;
using TodoWithAuth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TodoWithAuth.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ITodoService _todoService;

        public HomeController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Todo()
        {
            var model = new TodoViewModel
            {
                Todos = _todoService.GetAll().ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(TodoItem newTodo)
        {
            if (ModelState.IsValid)
            {
                _todoService.Add(newTodo);
            }

            return RedirectToAction("Todo");
        }

        [HttpPost]
        public IActionResult Complete(int id)
        {
            _todoService.Complete(id);
            return RedirectToAction("Todo");
        }

        [HttpPost]
        public IActionResult Incomplete(int id)
        {
            _todoService.Incomplete(id);
            return RedirectToAction("Todo");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _todoService.Delete(id);
            return RedirectToAction("Todo");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
