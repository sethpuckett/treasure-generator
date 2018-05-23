namespace GmTools.TreasureGenerator.Domain.Services
{
  public interface IIndividualTreasureService
  {
    TreasureDomainResponse GenerateIndividualTreasure(int challengeRating);
  }
}