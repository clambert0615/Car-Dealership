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
        public IActionResult AddCarInfo()
        {
            return View();
        }
        public async Task<IActionResult> AddNewCar(Cars newCar)
        {
            await _car.AddCar(newCar);
            return RedirectToAction("SearchIndex");
        }

        public async Task<IActionResult> DeleteCar(int id)
        {
           _car.DeleteCar(id);
             return RedirectToAction("SearchIndex");
        }
       [HttpGet]
        public async Task<IActionResult> UpdateCar(int id)
        {
            Cars foundcar = await _car.GetCar(id);
            return View(foundcar);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCar( Cars updatedcar)
        {
            Cars oldcar = await _car.GetCar(updatedcar.Id);
            oldcar.Model = updatedcar.Model;
            oldcar.Make = updatedcar.Make;
            oldcar.Year = updatedcar.Year;
            oldcar.Color = updatedcar.Color;
            _car.UpdateCar(oldcar);
            return RedirectToAction("SearchIndex");
        }
    }
}
