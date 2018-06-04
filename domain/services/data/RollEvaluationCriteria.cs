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

    public void AddPotentialTreasure(uint min, uint max, TreasureType treasureType, uint treasureDiceCount, uint treasureDiceSides)
    {
      this.PotentialTreasures.Add(new PotentialTreasure(min, max, treasureType, treasureDiceCount, treasureDiceSides));
    }

    public IList<PotentialTreasure> PotentialTreasures { get; private set; }
  }
}