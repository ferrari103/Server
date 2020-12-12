using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
namespace Server.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventItemController : Controller
    {
        ApplicationContext db;
        public EventItemController(ApplicationContext context)
        {
            db = context;
            db.SaveChanges();
        }
        [HttpGet]
        public IEnumerable<EventItem> Get()
        {
            return db.Events.ToList();
        }
 
        [HttpGet("{id}")]
        public EventItem Get(int id)
        {
            EventItem product = db.Events.FirstOrDefault(x => x.Id == id);
            return product;
        }
 
        [HttpPost]
        public IActionResult Post(EventItem product)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(product);
                db.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }
 
        [HttpPut]
        public IActionResult Put(EventItem product)
        {
            if (ModelState.IsValid)
            {
                db.Update(product);
                db.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }
 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            EventItem product = db.Events.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                db.Events.Remove(product);
                db.SaveChanges();
            }
            return Ok(product);
        }
    }
}