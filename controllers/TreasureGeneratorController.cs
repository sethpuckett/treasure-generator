using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DiceRoller.Controllers
{
  [Route("/treasure")]
  public class DiceRollerController : Controller
  {
    [HttpGet]
    public IActionResult GetTreasure()
    {
      return Ok(50);
    }
  }
}