using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Microsoft.AspNetCore.Mvc;

namespace DiceRoller.Controllers
{
  [Route("/treasure")]
  public class DiceRollerController : Controller
  {
    [HttpGet]
    public IActionResult GetTreasure()
    {
      var baseUrl = "http://dice-roller/dice?sides=20&rolls=1&count=2";
      using (var client = new HttpClient())
      {
        var result = client.GetStringAsync(baseUrl).Result;
        return Ok(result);
      }
    }
  }
}