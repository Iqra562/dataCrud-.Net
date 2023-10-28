using Microsoft.AspNetCore.Mvc;
using WebApplication10.Data;
using WebApplication10.Models;
using WebApplication10.Models.FormModels;

namespace WebApplication10.Controllers
{
    public class UserController: Controller 
    {
        private readonly MyDbContext _dbContext;
        public UserController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.Users);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserRegisterRequest request) {

            if (ModelState.IsValid)
            {
                User user = new User();
                user.Email = request.Email;
                user.Password = request.Password;
                user.Role = request.Role;
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));


            }
            return View(request);

        }
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete(int id) {
            User u = _dbContext.Users.Find(id);
            _dbContext.Users.Remove(u);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
                
                }
    }
}
