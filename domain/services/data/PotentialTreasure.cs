using System.Collections.Generic;
using GmTools.TreasureGenerator.Domain.Model;

namespace GmTools.TreasureGenerator.Domain.Services.Data
{
  public class PotentialTreasure
  {
    public PotentialTreasure (uint min, uint max, TreasureType treasureType, uint treasureDiceCount, uint treasureDiceSides)
    {
      this.Min = min;
      this.Max = max;
      this.treasureType = treasureType;
      this.TreasureDiceCount = treasureDiceCount;
      this.TreasureDiceSides = treasureDiceSides;
    }

    public uint Min { get; private set; }
    public uint Max { get; private set; }
    public TreasureType treasureType { get; private set; }
    public uint TreasureDiceCount { get; private set; }
    public uint TreasureDiceSides { get; private set; }
  }
}
