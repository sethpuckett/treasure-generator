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
      var haul = new TreasureHaul();
      var typeRoll = diceRoller.GetRoll(criteria.DiceCount, criteria.DiceSides);

      foreach (var potentialTreasure in criteria.PotentialTreasures)
      {
        evaluateIndividualPotentialTreasure(potentialTreasure, haul, typeRoll);
      }

      return haul;
    }

    private void evaluateIndividualPotentialTreasure(PotentialTreasure potentialTreasure, TreasureHaul haul, int roll)
    {
        if (roll >= potentialTreasure.Min && roll <= potentialTreasure.Max)
        {
          var amount = this.diceRoller.GetRoll(potentialTreasure.TreasureDiceCount, potentialTreasure.TreasureDiceSides);
          amount *= potentialTreasure.Multiplier;

          switch (potentialTreasure.treasureType)
          {
            case TreasureType.CP:
              haul.CP += amount;
              break;
            case TreasureType.SP:
              haul.SP += amount;
              break;
            case TreasureType.EP:
              haul.EP += amount;
              break;
            case TreasureType.GP:
              haul.GP += amount;
              break;
            case TreasureType.PP:
              haul.PP += amount;
              break;
          }
        }
    }
  }

}