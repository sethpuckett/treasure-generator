using GmTools.TreasureGenerator.Domain.Model;
using GmTools.TreasureGenerator.Gateways;

namespace GmTools.TreasureGenerator.Domain.Services
{
  public class IndividualTreasureService : IIndividualTreasureService
  {
    IDiceRollerGateway diceRoller;

    public IndividualTreasureService(IDiceRollerGateway diceRoller)
    {
      this.diceRoller = diceRoller;
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
      var haul = new TreasureHaul();
      var typeRoll = this.diceRoller.GetRoll(1, 100);

      if (typeRoll >= 1 && typeRoll <= 30)
      {
        haul.CP = this.diceRoller.GetRoll(5, 6);
      }
      else if (typeRoll >= 31 && typeRoll <= 60)
      {
        haul.SP = this.diceRoller.GetRoll(4, 6);
      }
      else if (typeRoll >= 61 && typeRoll <= 70)
      {
        haul.EP = this.diceRoller.GetRoll(3, 6);
      }
      else if (typeRoll >= 71 && typeRoll <= 95)
      {
        haul.GP = this.diceRoller.GetRoll(3, 6);
      }
      else if (typeRoll >= 96 && typeRoll <= 100)
      {
        haul.PP = this.diceRoller.GetRoll(1, 6);
      }
      else
      {
        // TODO: error
      }

      return haul;
    }
  }
}