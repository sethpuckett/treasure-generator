using System.Threading.Tasks;

namespace GmTools.TreasureGenerator.Gateways
{
  public interface IDiceRollerGateway
  {
    int GetRoll(int count, int sides);
  }
}