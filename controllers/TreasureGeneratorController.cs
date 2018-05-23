using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using GmTools.TreasureGenerator.Domain;
using GmTools.TreasureGenerator.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace GmTools.TreasureGenerator.Controllers
{
  [Route("/treasure")]
  public class TreasureGeneratorController : Controller
  {
    private readonly IIndividualTreasureService IndividualTreasureService;

    public TreasureGeneratorController(IIndividualTreasureService individualTreasureService)
    {
      this.IndividualTreasureService = individualTreasureService;
    }

    [HttpGet]
    public IActionResult GetIndividualTreasure(int cr)
    {
      return Ok(0);
    }
  }
}