using GmTools.TreasureGenerator.Domain.Model;
using GmTools.TreasureGenerator.Domain.Services.Data;
using GmTools.TreasureGenerator.Gateways;

namespace GmTools.TreasureGenerator.Domain.Services
{
  public class IndividualTreasureService : IIndividualTreasureService
  {
    IDiceRollerGateway diceRoller;

    IRollEvaluationService rollEvaluationService;

    public IndividualTreasureService(IDiceRollerGateway diceRoller, IRollEvaluationService rollEvaluationService)
    {
      this.diceRoller = diceRoller;
      this.rollEvaluationService = rollEvaluationService;
    }

    public TreasureDomainResponse GenerateIndividualTreasure(int challengeRating)
    {
      TreasureHaul haul;

      if (challengeRating >= 0 & challengeRating <= 4)
        haul = GenerateInvidiualTreasure0To4();
      else if (challengeRating >= 5 & challengeRating <= 10)
        haul = GenerateInvidiualTreasure5To10();
      else if (challengeRating >= 11 & challengeRating <= 16)
        haul = GenerateInvidiualTreasure11To16();
      else if (challengeRating >= 17)
        haul = GenerateInvidiualTreasure17Plus();
      else
        return TreasureDomainResponse.Invalid($"Invalid challenge rating: {challengeRating}");

      return new TreasureDomainResponse(haul);
    }

    private TreasureHaul GenerateInvidiualTreasure0To4()
    {
      var criteria = new RollEvaluationCriteria();
      criteria.DiceCount = 1;
      criteria.DiceSides = 100;
      criteria.AddPotentialTreasure(1, 30, TreasureType.CP, 5, 6);
      criteria.AddPotentialTreasure(31, 60, TreasureType.SP, 4, 6);
      criteria.AddPotentialTreasure(61, 70, TreasureType.EP, 3, 6);
      criteria.AddPotentialTreasure(71, 95, TreasureType.GP, 3, 6);
      criteria.AddPotentialTreasure(96, 100, TreasureType.PP, 1, 6);

      return this.rollEvaluationService.Evaluate(criteria);
    }

    private TreasureHaul GenerateInvidiualTreasure5To10()
    {
      var criteria = new RollEvaluationCriteria();
      criteria.DiceCount = 1;
      criteria.DiceSides = 100;
      criteria.AddPotentialTreasure(1, 30, TreasureType.CP, 4, 6, 100);
      criteria.AddPotentialTreasure(1, 30, TreasureType.EP, 1, 6, 10);
      criteria.AddPotentialTreasure(31, 60, TreasureType.SP, 6, 6, 10);
      criteria.AddPotentialTreasure(31, 60, TreasureType.SP, 2, 6, 10);
      criteria.AddPotentialTreasure(61, 70, TreasureType.EP, 3, 6, 10);
      criteria.AddPotentialTreasure(61, 70, TreasureType.GP, 2, 6, 10);
      criteria.AddPotentialTreasure(71, 95, TreasureType.GP, 4, 6, 10);
      criteria.AddPotentialTreasure(96, 100, TreasureType.GP, 2, 6, 10);
      criteria.AddPotentialTreasure(96, 100, TreasureType.PP, 3, 6);

      return this.rollEvaluationService.Evaluate(criteria);
    }

    private TreasureHaul GenerateInvidiualTreasure11To16()
    {
      var criteria = new RollEvaluationCriteria();
      criteria.DiceCount = 1;
      criteria.DiceSides = 100;
      criteria.AddPotentialTreasure(1, 20, TreasureType.SP, 4, 6, 100);
      criteria.AddPotentialTreasure(1, 20, TreasureType.GP, 1, 6, 100);
      criteria.AddPotentialTreasure(21, 35, TreasureType.EP, 1, 6, 100);
      criteria.AddPotentialTreasure(21, 35, TreasureType.GP, 1, 6, 100);
      criteria.AddPotentialTreasure(36, 75, TreasureType.GP, 2, 6, 100);
      criteria.AddPotentialTreasure(36, 75, TreasureType.PP, 1, 6, 10);
      criteria.AddPotentialTreasure(76, 100, TreasureType.GP, 2, 6, 100);
      criteria.AddPotentialTreasure(76, 100, TreasureType.PP, 2, 6, 10);

      return this.rollEvaluationService.Evaluate(criteria);
    }

    private TreasureHaul GenerateInvidiualTreasure17Plus()
    {
      var criteria = new RollEvaluationCriteria();
      criteria.DiceCount = 1;
      criteria.DiceSides = 100;
      criteria.AddPotentialTreasure(1, 15, TreasureType.EP, 2, 6, 1000);
      criteria.AddPotentialTreasure(1, 15, TreasureType.GP, 8, 6, 100);
      criteria.AddPotentialTreasure(16, 55, TreasureType.GP, 1, 6, 1000);
      criteria.AddPotentialTreasure(16, 55, TreasureType.PP, 1, 6, 100);
      criteria.AddPotentialTreasure(56, 100, TreasureType.GP, 1, 6, 1000);
      criteria.AddPotentialTreasure(56, 100, TreasureType.PP, 2, 6, 100);

      return this.rollEvaluationService.Evaluate(criteria);
    }
  }
}