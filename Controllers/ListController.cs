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
    public class ListController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public List<Car> ListofCars {get; set;}

        public ListController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Test Data
            ListofCars = new List<Car>
            {
                new Car {Id= 1, Year = 2006, Make = "Honda", Model = "Civic", Color = "White", DriveTrain = "Auto FWD", EngineSize = "1.8L", BodyStyle = "Sedan", ServiceHistory = null},
                new Car {Id= 2, Year = 2005, Make = "Pontiac", Model = "Sunfire", Color = "Black", DriveTrain = "Auto FWD", EngineSize = "2.4L", BodyStyle = "Coupe",ServiceHistory = null},
                new Car {Id= 3, Year = 1998, Make = "Nissan", Model = "Altima", Color = "Brown", DriveTrain = "Manual FWD", EngineSize = "2.4L", BodyStyle = "Sedan",ServiceHistory = null},
                new Car {Id= 4, Year = 1998, Make = "Ford", Model = "Escort ZX2", Color = "Red", DriveTrain = "Manual FWD", EngineSize = "2.0L", BodyStyle = "Coupe",ServiceHistory = null},
                new Car {Id= 5, Year = 2011, Make = "Honda", Model = "Civic", Color = "White", DriveTrain = "Auto FWD", EngineSize = "1.8L", BodyStyle = "Sedan",ServiceHistory = null},
                new Car {Id= 6, Year = 2011, Make = "Infiniti", Model = "G25", Color = "Gray", DriveTrain = "Auto RWD", EngineSize = "2.5L", BodyStyle = "Sedan",ServiceHistory = null},
                new Car {Id= 7, Year = 2022, Make = "Nissan", Model = "Pathfinder", Color = "Gray", DriveTrain = "Auto FWD", EngineSize = "3.5L", BodyStyle = "SUV",ServiceHistory = null},
                new Car {Id= 8, Year = 2013, Make = "Infiniti", Model = "G37", Color = "White", DriveTrain = "Auto RWD", EngineSize = "3.7L", BodyStyle = "Sedan",ServiceHistory = null},
                new Car {Id= 9, Year = 1998, Make = "Honda", Model = "Accord", Color = "Tan", DriveTrain = "Auto FWD", EngineSize = "2.3L", BodyStyle = "Sedan",ServiceHistory = null},
                new Car {Id= 10, Year = 1997, Make = "Nissan", Model = "Quest", Color = "Green", DriveTrain = "Auto FWD", EngineSize = "3.0L", BodyStyle = "Mini Van",ServiceHistory = null},
                new Car {Id= 11, Year = 1998, Make = "Kia", Model = "SepHia", Color = "Red", DriveTrain = "Manual FWD", EngineSize = "1.8L", BodyStyle = "Sedan",ServiceHistory = null},
                new Car {Id= 12, Year = 2011, Make = "Kia", Model = "Optima", Color = "Tan", DriveTrain = "Auto FWD", EngineSize = "2.7L", BodyStyle = "Sedan",ServiceHistory = null}
            };

            ListofCars[0].ServiceHistory = new List<ServiceRecords>
            {
                new ServiceRecords { Id = 1, Date = "02/03/2022", Mileage = 123543, Description = "Front Brake Pad Service has been done."},
                new ServiceRecords { Id = 2, Date = "01/04/2021", Mileage = 94343, Description = "Oil/OilFilter Changed."}

            };
            
            ViewBag.MyCars = ListofCars;
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
