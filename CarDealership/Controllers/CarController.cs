using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using CarDealership.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarDealership.Controllers
{
    public class CarController : Controller
    {

        private readonly CarDAL _car = new CarDAL();

        public IActionResult SearchIndex()
        {
            return View();
        }

        public async Task<IActionResult> SearchForCars(string Make, string Model, int Year, string Color)
        {
            List<Cars> carList = await _car.GetCars(Make, Model, Year, Color);
            return View(carList);
        }
       
    }
}
