using System;
using GmTools.TreasureGenerator.Domain.Model;
using GmTools.TreasureGenerator.Domain.Services.Data;
using GmTools.TreasureGenerator.Gateways;

namespace GmTools.TreasureGenerator.Domain.Services
{
  public class RollEvaluationService : IRollEvaluationService
  {
    IDiceRollerGateway diceRoller;

    public RollEvaluationService(IDiceRollerGateway diceRoller)
    {
      this.diceRoller = diceRoller;
    }

    public TreasureHaul Evaluate(RollEvaluationCriteria criteria)
    {
      var typeRoll = diceRoller.GetRoll(criteria.DiceCount, criteria.DiceSides);

      // TODO: loop through potential treasureas and apply to haul

      throw new NotImplementedException();
    }
  }

}