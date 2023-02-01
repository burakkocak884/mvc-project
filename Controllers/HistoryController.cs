using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;
using Microsoft.EntityFrameworkCore;

namespace mvc_project.Controllers
{
    public class HistoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MainDBContext _dbContext;

        


        public HistoryController(MainDBContext dbContext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public List<ServiceRecord> GetAllServiceRecords<ServiceRecord>() where ServiceRecord : class
        {     
            {
                return _dbContext.Set<ServiceRecord>().ToList();
            }
        }

        public IActionResult Index()
        {
            string carAndServiceRecordQuery = "SELECT service.\"Id\", service.\"Date\", car.\"Year\", car.\"Make\", car.\"Model\", service.\"Mileage\", service.\"Description\", service.\"EstimateCost\" FROM \"Cars\" car JOIN \"ServiceRecords\" service ON car.\"Id\" = service.\"VehicleId\"";
            //string carAndServiceRecordQuery = "SELECT * FROM 'Cars' cars WHERE 'Year' = 2014";
            ViewBag.ServiceRecordsHistory =  _dbContext.ServiceRecordsHistory.FromSqlRaw(carAndServiceRecordQuery).ToList();
            //ViewBag.CarList = _dbContext.Cars.ToList();
            //ViewBag.ServiceRecords = GetAllServiceRecords<ServiceRecord>();
            // List<ServiceRecordHistory> history = new List<ServiceRecordHistory>();

            // foreach(ServiceRecord record in ServiceRecords){
            //     history.Add(new ServiceRecordHistory{Date = record.Date, Car = "", Mileage = record.Mileage, Description = record.Description, EstimateCost = record.EstimateCost});

            // }
            //ViewBag.Cars = _dbContext.Cars;
            //ViewBag.NumberOfServiceRecords = _dbContext.ServiceRecords.Count();
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
