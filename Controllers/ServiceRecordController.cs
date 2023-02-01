using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;
using mvc_project.Controllers;


namespace mvc_project.Controllers
{
    public class ServiceRecordController : Controller
    {
        private readonly ILogger<ServiceRecordController> _logger;
        private readonly MainDBContext _dbContext;
       

        public ServiceRecordController(MainDBContext dbContext, ILogger<ServiceRecordController> logger)
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

         public List<Car> GetAllCars<Car>() where Car : class
        {
            {
                return _dbContext.Set<Car>().ToList();
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult GetServiceRecords(int Id)
        { 
            ViewBag.Car = GetAllCars<Car>().Find(car => car.Id == Id);
            ViewBag.ServiceRecords = GetAllServiceRecords<ServiceRecord>().Where(i => i.VehicleId == Id);
            return View();
        }


        public IActionResult NewServiceRecord(ServiceRecord newRecord)
        { 
            _dbContext.ServiceRecords.Add(newRecord);
            _dbContext.SaveChanges();
            return RedirectToAction("GetServiceRecords", new { id = newRecord.VehicleId }); //Going back to service record grid.
        }
    }
}