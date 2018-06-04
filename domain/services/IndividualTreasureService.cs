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
      {
        haul = GenerateInvidiualTreasure0To4();
      }
      // TODO: other challenge ratings
      else
      {
        return TreasureDomainResponse.Invalid($"Invalid challenge rating: {challengeRating}");
      }

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
  }
}