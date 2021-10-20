using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
  
        [HttpGet]
        public IEnumerable<Models.Publisher> Get()
        {
            //CRUD
            using (var _context = new BookStoresDBContext())
            {
                //Models.Publisher publisher = new Models.Publisher();
                //publisher.PublisherName = "Egmont Book";

                //_context.Publishers.Add(publisher);

                //_context.SaveChanges();
                Models.Publisher publisher = _context.Publishers.FirstOrDefault();
                publisher.PublisherName = "Egmond Books";

                _context.SaveChanges();


                return _context.Publishers.ToList();
            }




        }
    }
}
