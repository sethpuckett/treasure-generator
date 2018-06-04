using System.Collections.Generic;
using GmTools.TreasureGenerator.Domain.Model;

namespace GmTools.TreasureGenerator.Domain.Services.Data
{
  public class RollEvaluationCriteria
  {
    public RollEvaluationCriteria()
    {
      this.PotentialTreasures = new List<PotentialTreasure>();
    }

    public int DiceCount { get; set; }
    public int DiceSides { get; set; }

    public void AddPotentialTreasure(int min, int max, TreasureType treasureType, int treasureDiceCount, int treasureDiceSides, int multiplier = 1)
    {
      this.PotentialTreasures.Add(new PotentialTreasure(min, max, treasureType, treasureDiceCount, treasureDiceSides, multiplier));
    }

    public IList<PotentialTreasure> PotentialTreasures { get; private set; }
  }
}