using CarsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsAPIController : ControllerBase
    {
        private readonly CarsDbContext _context;
        public CarsAPIController(CarsDbContext context)
        {
            _context = context;
        }

        //Get car list with endpoint api/cars
        [HttpGet]
        public async Task<ActionResult<List<Cars>>> GetCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return cars;
        }
        //Get one car with endpoint api/cars/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Cars>> GetCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            else
            {
                return car;
            }
        }

        //Get cars with endpoint api/carsapi/make/Make
        [HttpGet("make/{Make}")]
        public async Task<ActionResult<List<Cars>>> GetCarsbyMake(string make)
        {
            List<Cars> cars = await _context.Cars.Where(x => x.Make == make).ToListAsync();
            return cars;
        }

        //Get cars with endpoint api/carsapi/model/Model
        [HttpGet("model/{Model}")]
        public async Task<ActionResult<List<Cars>>> GetCarsbyModel(string model)
        {
            List<Cars> cars = await _context.Cars.Where(x => x.Model == model).ToListAsync();
            return cars;
        }

        //Get cars with endpoint api/carsapi/year/Year
        [HttpGet("year/{Year}")]
        public async Task<ActionResult<List<Cars>>> GetCarsbyYear(int year)
        {
            List<Cars> cars = await _context.Cars.Where(x => x.Year == year).ToListAsync();
            return cars;
        }

        //Get cars with endpoint api/carsapi/color/Color
        [HttpGet("color/{Color}")]
        public async Task<ActionResult<List<Cars>>> GetCarsbyColor(string color)
        {
            List<Cars> cars = await _context.Cars.Where(x => x.Color == color).ToListAsync();
            return cars;
        }

        [HttpGet("make/{make}/model/{model}/year/{year}/color/{color}")]
        public async Task<ActionResult<List<Cars>>> GetCarsbyCombination(string make, string model, int year, string color)
        {
            List<Cars> cars = await _context.Cars.ToListAsync();
            if (make != "any")
            {
                cars = cars.Where(x => x.Make.ToLower() == make.ToLower()).ToList();
            }
            if (model != "any")
            {
                cars = cars.Where(x => x.Model.ToLower() == model.ToLower()).ToList();
            }
            if (year != 0)
            {
                cars = cars.Where(x => x.Year == year).ToList();
            }
            if (color != "any")
            {
                cars = cars.Where(x => x.Color.ToLower() == color.ToLower()).ToList();
            }

            return cars;
        }

        //Post: api/carsapi
        [HttpPost]
        public async Task<ActionResult<Cars>> AddCar(Cars newCar)
        {
            if (ModelState.IsValid)
            {
                _context.Cars.Add(newCar);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCar), new { id = newCar.Id }, newCar);

            }
            else
            {
                return BadRequest();
            }

        }
        //Update api/cars/{id}
        [HttpPut]
        public async Task<ActionResult> UpdateCar(Cars updatedCar)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Entry(updatedCar).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
        //Delete api/car/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if(car == null)
            {
                return NotFound();
            }
            else
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
    }
    }
