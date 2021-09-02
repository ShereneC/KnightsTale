using System;
using System.Collections.Generic;
using KnightsTale.Models;
using KnightsTale.Services;
using Microsoft.AspNetCore.Mvc;

namespace KnightsTale.Controllers
{
        [ApiController]
        [Route("/api/[controller]")]
    public class CastlesController : ControllerBase
    {
      private readonly CastlesService _cs;

      public CastlesController(CastlesService cs)
      {
          _cs = cs;
      }

      [HttpGet]
      public ActionResult<IEnumerable<Castle>> Get()
      {
          try
          {
            IEnumerable<Models.Castle> castles = _cs.GetAllCastles(); 
            return Ok(castles);
          }
          catch (Exception err)
          {
        return BadRequest(err.Message);
          }
      }

      [HttpGet("{id}")]

      public ActionResult<Castle> Get(int id)
      {
          try
          {
           Castle castle = _cs.GetCastleById(id);
           return Ok(castle);
          }
          catch (Exception err)
          {
        return BadRequest(err.Message);
          }
      }
      
      public ActionResult<Castle> Create([FromBody] Castle newCastle)
      {
          try
          {
               Castle castle = _cs.Create(newCastle);
               return Ok(castle);
          }
          catch (Exception err)
          {
          return BadRequest(err.Message);
          }
      }

[HttpDelete("{id}")]
public ActionResult<String> Delete(int id)
{
    try
    {
         _cs.DeleteCastle(id);
         return Ok("Successfully Deleted");
    }
    catch (Exception err)
    {
return BadRequest(err.Message);
    }
}

    }
}