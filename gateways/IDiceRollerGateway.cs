using System.Threading.Tasks;

namespace GmTools.TreasureGenerator.Gateways
{
  public interface IDiceRollerGateway
  {
    Task<int> GetRoll(int count, int sides);
  }
}