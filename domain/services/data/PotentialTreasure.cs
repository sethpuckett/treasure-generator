using System.Collections.Generic;
using GmTools.TreasureGenerator.Domain.Model;

namespace GmTools.TreasureGenerator.Domain.Services.Data
{
  public class PotentialTreasure
  {
    public PotentialTreasure (int min, int max, TreasureType treasureType, int treasureDiceCount, int treasureDiceSides)
    {
      this.Min = min;
      this.Max = max;
      this.treasureType = treasureType;
      this.TreasureDiceCount = treasureDiceCount;
      this.TreasureDiceSides = treasureDiceSides;
    }

    public int Min { get; private set; }
    public int Max { get; private set; }
    public TreasureType treasureType { get; private set; }
    public int TreasureDiceCount { get; private set; }
    public int TreasureDiceSides { get; private set; }
  }
}
