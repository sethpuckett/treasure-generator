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
      var response = this.IndividualTreasureService.GenerateIndividualTreasure(cr);

      // TODO: error handling

      return Ok(response.TreasureHaul);
    }
  }
}