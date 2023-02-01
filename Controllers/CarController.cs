using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;

namespace mvc_project.Controllers
{
    public class CarController : Controller
    {
        private readonly MainDBContext  _dbContext;          
     
        private readonly ILogger<HomeController> _logger;
        

        public CarController(MainDBContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = context;
        }

        public List<Car> GetCars<Car>() where Car : class
        {  
            {
                return _dbContext.Set<Car>().ToList();
            }
        }

        public List<User> GetAllUsers<User>() where User : class
        {    
            {
                return _dbContext.Set<User>().ToList();
            }
        }

        public IActionResult Index(int userId)
        {
            // User tempUser = new User{EmailAddress = "firstylasty@test.com", FirstName = "JrFirsty", LastName = "Lasty", Password = "testPass123", SecretQuestionFirst = "First Pet", SecretQuestionSecond = "First School"};
            // _dbContext.Users.Add(tempUser);
            // _dbContext.SaveChanges();
            ViewBag.MyCars =  GetCars<Car>().FindAll(car => car.UserId == ((userId != 0) ? userId : 1)).OrderBy(car => car.Year);
            var users = GetAllUsers<User>();
            ViewBag.User = users.Find(user => user.Id == 1);
            return View();
        }

        public IActionResult NewCarView()
        {
            return View();
        }

        public IActionResult AddNewCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
            return RedirectToActionPermanent("Index", new{Id = 1});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
