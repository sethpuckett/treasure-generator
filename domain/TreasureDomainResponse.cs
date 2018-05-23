using GmTools.TreasureGenerator.Domain.Model;

namespace GmTools.TreasureGenerator.Domain
{
  public class TreasureDomainResponse
  {
    public readonly bool Valid;
    public readonly string Message;
    public readonly TreasureHaul TreasureHaul;

    public TreasureDomainResponse(TreasureHaul treasureHaul, bool valid = true, string message = null)
    {
      this.TreasureHaul = treasureHaul;
      this.Valid = valid;
      this.Message = message;
    }

    public static TreasureDomainResponse Invalid(string message)
    {
      return new TreasureDomainResponse(null, false, message);
    }
  }
}