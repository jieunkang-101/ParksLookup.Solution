using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksLookupApiContext _db;

    public ParksController(ParksLookupApiContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string parkName, string statesCode)
    {
      var query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      }

      if (statesCode != null)
      {
        query = query.Where(entry => entry.StatesCode == statesCode);
      }

      return query.ToList();
    }

    // GET api/parks/3
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    // POST api/parks
    [Authorize]
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    // PUT api/parks/3
    [Authorize]
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/parks/3
    [Authorize]
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }

    // GET api/parks/random
    [HttpGet("random")]
    public ActionResult<Park> Random ()
    {
      List<Park> parks = _db.Parks.ToList();
      var rnd = new Random();
      int rndIdx = rnd.Next(0, parks.Count);
      return parks[rndIdx];
    }
  }
}
