using System.Collections.Generic;

namespace GmTools.TreasureGenerator.Domain.Model
{
  public class TreasureHaul
  {
    public TreasureHaul()
    {
      this.TreasureObjects = new List<TreasureObject>();
      this.MagicItems = new List<MagicItem>();
    }

    public int CP { get; set; }
    public int SP { get; set; }
    public int EP { get; set; }
    public int GP { get; set; }
    public int PP { get; set; }

    public IEnumerable<TreasureObject> TreasureObjects { get; set; }

    public IEnumerable<MagicItem> MagicItems { get; set; }
  }
}