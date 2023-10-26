using Microsoft.AspNetCore.Mvc;
using WebApplication10.Data;
using WebApplication10.Models;

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
        public IActionResult Delete(int id) {
            User u = _dbContext.Users.Find(id);
            _dbContext.Users.Remove(u);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
                
                }
    }
}
