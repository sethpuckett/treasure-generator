using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GmTools.TreasureGenerator.Gateways
{
  public class DiceRollerGateway : IDiceRollerGateway
  {
    public int GetRoll(int count, int sides)
    {
      var url = $"http://dice-roller/dice?count={count}&sides={sides}"; // TODO: Store this in config
      using (var client = new HttpClient())
      {
        var response = client.GetStringAsync(url).Result;
        var retVal = 0;
        if (!Int32.TryParse(response, out retVal))
        {
          // TODO: Log invalid return type
        }
        return retVal;
      }
    }
  }
}