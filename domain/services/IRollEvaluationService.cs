using GmTools.TreasureGenerator.Domain.Model;
using GmTools.TreasureGenerator.Domain.Services.Data;

namespace GmTools.TreasureGenerator.Domain.Services
{
  public interface IRollEvaluationService

  {
    TreasureHaul Evaluate(RollEvaluationCriteria criteria);
  }
}